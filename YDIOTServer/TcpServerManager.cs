using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using HPSocketCS;
using YDIOTSvr.BusinessLayer.BaseObject;
using TcpServer.Other;

namespace TcpServer
{
    
    public delegate void ShowMsg(string msg);
    /// <summary>
    /// 定义一个服务器，这个服务器可以通过参数实例化
    /// </summary>
    public class TcpServerManager
    {
        private HPSocketCS.TcpServer server;
        HPSocketCS.Extra<ClientInfo> extra;
        public Dictionary<String, BaseDTU> dtuDic;
        public bool isShutDown = true;
        private string ip = "";
        private ushort port = 0;
        public string desc = "";
        
        public static event ShowMsg OnMessage;//消息来了的委托事件
        /// <summary>
        /// 构造函数，要求有参数
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port">端口号</param>
        /// <param name="desc">服务器描述</param>
        public TcpServerManager(string ip,ushort port,string desc)
        {
            this.ip = ip;
            this.port = port;
            this.desc = desc;
            server = new HPSocketCS.TcpServer();
            extra = new HPSocketCS.Extra<ClientInfo>();
            server.OnAccept += new HPSocketCS.TcpServerEvent.OnAcceptEventHandler(server_OnAccept);
            server.OnSend += new TcpServerEvent.OnSendEventHandler(server_OnSend);
            server.OnReceive += new HPSocketCS.TcpServerEvent.OnReceiveEventHandler(server_OnReceive);
            server.OnClose += new TcpServerEvent.OnCloseEventHandler(server_OnClose);
            server.OnShutdown += new TcpServerEvent.OnShutdownEventHandler(server_OnShutdown);
            StartServer();
        }

        private void StartServer()
        {
            server.IpAddress = ip;
            server.Port = port;
            server.SocketBufferSize = 102400;
            //初始化这个服务器的所有dtu
            dtuDic = DTUUtil.getInstance().getDTUDic();
            // 启动服务
            if (server.Start())
            {
                string text = string.Format("{2} - ({0}:{1})", ip, port, desc);
                if (OnMessage != null)
                {
                    OnMessage(text);
                }
                isShutDown = false;
            }
            else
            {
                throw new Exception(string.Format("$Server Start Error -> {0}({1})", server.ErrorMessage, server.ErrorCode));
            }

        }

        HandleResult server_OnShutdown()
        {
            // 服务关闭了
            OnMessage(" > [OnShutdown],端口号为 "+server.Port);
            isShutDown = true;
            return HandleResult.Ok;
        }

        HandleResult server_OnClose(IntPtr connId, SocketOperation enOperation, int errorCode)
        {
            if (OnMessage != null)
            {
                if (errorCode == 0)
                    OnMessage(string.Format(" > [{0},OnClose {1}------port:{2}]", connId, enOperation.ToString(),server.Port));
                else
                    OnMessage(string.Format(" > [{0},OnError] -> OP:{1},CODE:{2} ------port:{3}", connId, enOperation, errorCode, server.Port));

                if (extra.Remove(connId) == false)
                {
                    OnMessage(string.Format(" > [{0},OnClose] -> SetConnectionExtra({0}, null) fail ------port:{1}", connId,server.Port));
                }
                return HandleResult.Ok;
            }
            throw new Exception("端口为"+server.Port+"的服务器close失败");
        }

        HandleResult server_OnSend(IntPtr connId, byte[] bytes)
        {
            ClientInfo clientInfo = extra.Get(connId);
            return HandleResult.Ok;
        }
        
        HandleResult server_OnReceive(IntPtr connId, byte[] bytes)
        {
            try
            {
                // 获取附加数据
                ClientInfo clientInfo = extra.Get(connId);
                clientInfo.Data = bytes;
                //服务器只要来了数据，不用处理，直接交给任务队列即可
                TaskQueue.AddMessage(clientInfo);
                if (OnMessage != null&&((int)connId%1000==0))
                {
               //   OnMessage(string.Format(" > [{0}------port:{1}]", connId,  server.Port));
                }
                return HandleResult.Ok;
            }
            catch (Exception e)
            {
                return HandleResult.Ignore;
            }

        }
       
        HandleResult server_OnAccept(IntPtr connId, IntPtr pClient)
        {
            
            // 获取客户端ip和端口
            string ip = string.Empty;
            ushort port = 0;
            // 设置附加数据
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.ConnId = connId;
            clientInfo.IpAddress = ip;
            clientInfo.Port = port;
            clientInfo.server = server;
            clientInfo.serverManager = this;
            if (extra.Set(connId, clientInfo) == false)
            {
                if (OnMessage != null)
                {
                    OnMessage(string.Format(" > [{0},OnAccept] -> SetConnectionExtra fail", connId));
                }
            }
            return HandleResult.Ok;
        }
    }
}
