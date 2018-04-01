using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HPSocketCS;
using System.Threading;
using System.Collections;
using ServiceStack.Redis;
using ServiceStack.Redis.Support;
using TcpServer.Other;
using System.Configuration;
using YDIOTSvr.DataLayer.SQLHelper;
using YDIOTSvr.BusinessLayer.BaseObject;
using System.Collections.Concurrent;
using YDIOTSvrYDIOTSvrUtil;
using TcpServer;

namespace SSLServerNS
{
    public enum AppState
    {
        Starting, Started, Stoping, Stoped, Error
    }

    public partial class frmServer : Form
    {
        //配置参数，含义详见app.config
        static int timerMgrNumber = int.Parse(ConfigurationManager.AppSettings["TimerMgrNumber"].ToString());
        static int timerMgrInterval = int.Parse(ConfigurationManager.AppSettings["TimerMgrInterval"].ToString());
        static int subThreadNunber = int.Parse(ConfigurationManager.AppSettings["SubThreadNunber"].ToString());
        static int showTaskNumber = int.Parse(ConfigurationManager.AppSettings["ShowTaskNumber"].ToString());
        static int exceedNewThread = int.Parse(ConfigurationManager.AppSettings["ExceedNewThread"].ToString());
        static int IfShowLog = int.Parse(ConfigurationManager.AppSettings["IfShowLog"].ToString());
        static int showFilterNumber = int.Parse(ConfigurationManager.AppSettings["ShowFilterNumber"].ToString());



        bool isShutDown = false;
        Thread dealThread;
        System.Threading.Timer threadTimer;
        //定义心跳包
        byte[] heartbeat = new byte[] { 0, 0, 0 };
        //开启timerMgrNumber个BaseTimer 其时间间隔是timerMgrInterval
        BaseTimerMgr basetimermgr = new BaseTimerMgr(timerMgrNumber, timerMgrInterval);
        private AppState appState = AppState.Stoped;

        private delegate void ShowMsg(string msg);
        private ShowMsg AddMsgDelegate;
        //表示虚拟化10个服务器
        TcpServerManager s1, s2, s3, s4, s5, s6, s7, s8, s9, s10;
        private string title = "YDIOTServer [ 'C' - clear list box ]";

        public frmServer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //增加任务和服务器消息显示委托函数
                TaskQueue.AddMsgDelegate += new TcpServer.ShowMsg(TaskQueue_AddMsgDelegate);
                TcpServerManager.OnMessage += new TcpServer.ShowMsg(TcpServerManager_OnMessage);

                this.Text = title;
                this.txtIpAddress.ReadOnly = true;
                AddMsgDelegate = new ShowMsg(AddMsg);
                // 设置服务器事件
                SetAppState(AppState.Stoped);
            }
            catch (Exception ex)
            {
                SetAppState(AppState.Error);
                AddMsg(ex.Message);
            }
        }

        void TcpServerManager_OnMessage(string msg)
        {
            AddMsg(msg);
        }

        void TaskQueue_AddMsgDelegate(string msg)
        {
            AddMsg(msg);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //实例化10个服务器
                s1 = new TcpServerManager("0.0.0.0", 5555, "s1服务器");
                s2 = new TcpServerManager("0.0.0.0", 5556, "s2服务器");
                s3 = new TcpServerManager("0.0.0.0", 5557, "s3服务器");
                s4 = new TcpServerManager("0.0.0.0", 5558, "s4服务器");
                s5 = new TcpServerManager("0.0.0.0", 5559, "s5服务器");

                s6 = new TcpServerManager("0.0.0.0", 5560, "s6服务器");
                s7 = new TcpServerManager("0.0.0.0", 5561, "s7服务器");
                s8 = new TcpServerManager("0.0.0.0", 5562, "s8服务器");
                s9 = new TcpServerManager("0.0.0.0", 5563, "s9服务器");
                s10 = new TcpServerManager("0.0.0.0", 5564, "s10服务器");

                SetAppState(AppState.Started);
                // dtuDic = DTUUtil.getInstance().getDTUDic();
                dealThread = new Thread(new ThreadStart(MainThreadPool));
                dealThread.Start();
                //
                threadTimer = new System.Threading.Timer(new System.Threading.TimerCallback(MonitorTaskQueue), 0, 1000, 20);


            }
            catch (Exception ex)
            {
                AddMsg(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SetAppState(AppState.Stoping);

            //// 停止服务
            //AddMsg("$Server Stop");
            //if (server.Stop())
            //{
            //    this.Text = title;
            //    SetAppState(AppState.Stoped);
            //}
            //else
            //{
            //    AddMsg(string.Format("$Stop Error -> {0}({1})", server.ErrorMessage, server.ErrorCode));
            //}
        }

        private void btnDisconn_Click(object sender, EventArgs e)
        {
            try
            {
                //IntPtr connId = (IntPtr)Convert.ToInt32(this.txtDisConn.Text.Trim());
                ////  断开指定客户
                //if (server.Disconnect(connId, true))
                //{
                //    AddMsg(string.Format("$({0}) Disconnect OK", connId));
                //    BaseDTU basedtu = dtuDic.Values.Where(item => item.connId == connId).FirstOrDefault();
                //    if (basedtu != null)
                //    {

                //        basetimermgr.RemoveDTU(basedtu);
                //        basedtu.connId = IntPtr.Zero;
                //    }

                //}
                //else
                //{
                //    throw new Exception(string.Format("Disconnect({0}) Error", connId));
                //}
            }
            catch (Exception ex)
            {
                AddMsg(ex.Message);
            }
        }

        /// <summary>
        /// 处理单个数据
        /// 这个数据可以使任何的，比如登陆的，心跳的 ，还是正常的数据包都行
        /// </summary>
        /// <param name="data">要求为 ClientInfo</param>
        public void ProcessSingleData(object data)
        {

            ClientInfo clientInfo = data as ClientInfo;

            if (clientInfo != null)
            {
                HPSocketCS.TcpServer server = clientInfo.server;
                byte[] bytes = clientInfo.Data;
                IntPtr connId = clientInfo.ConnId;
                if (bytes.Length == 14 && bytes[0] == 170)
                {
                    //14位长，并且第一位是170，表示是登陆指令，解析登陆id
                    String logid = BaseDTU.ParseLogin(bytes);
                    if (logid != "")
                    {
                        try
                        {
                            //合法的id，首先发送心跳包
                            if (server.Send(clientInfo.ConnId, heartbeat, heartbeat.Length))
                            {
                                //发送心跳包成功，根据过滤的设置显示发送成功的消息
                                if (clientInfo.ConnId.ToInt32() % showFilterNumber == 0)
                                {
                                    AddMsg(string.Format(" 发送了心跳包  {0}", clientInfo.ConnId));
                                }
                                //判断此server的dtu字典中是否存在这个logid
                                if (clientInfo.serverManager.dtuDic.ContainsKey(logid))
                                {
                                    //已存在key,说明已经初始化了
                                    try
                                    {
                                        //心跳完成，准备轮训
                                        clientInfo.serverManager.dtuDic[logid].server = server;
                                        clientInfo.serverManager.dtuDic[logid].connId = connId;
                                        basetimermgr.AddDTU(clientInfo.serverManager.dtuDic[logid]);
                                        if (clientInfo.ConnId.ToInt32() % showFilterNumber == 0)
                                        {
                                            AddMsg(string.Format(clientInfo.serverManager.desc + "    > [客户端] -> {0}开始轮询", (int)connId));
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        MessageBox.Show(e.Message);
                                    }
                                }
                                else
                                {
                                    //不存在key 未被初始化
                                    if (server.Disconnect(connId, true))
                                    {
                                        //正常断开非法登录客户端
                                    }
                                    AddMsg(string.Format(" > [客户端] -> {0}断开 id : {1}", (int)connId, logid));
                                }
                            }
                        }
                        catch (Exception e)
                        {

                            MessageBox.Show("发送出错" + e.Message);
                        }
                    }
                    else
                    {
                        //非法id,断开
                        if (server.Disconnect(connId, true))
                        {
                            //正常断开非法登录客户端
                        }
                    }
                }
                else
                {
                    //不是登录包
                    if (bytes == heartbeat)
                    {
                        //收到的是心跳包
                    }
                    else
                    {
                        try
                        {
                            //收到的是正常任务包
                            BaseDTU basedtu = clientInfo.serverManager.dtuDic.Values.Where(item => item.connId == connId).FirstOrDefault();
                            if (basedtu != null)
                            {
                                //把正常数据包丢给dtu处理
                                basedtu.ReceivedCmd(bytes);
                            }
                        }
                        catch (Exception e)
                        {
                            server.Disconnect(connId);
                        }
                    }

                }

            }
            else
            {
                AddMsg(string.Format(" > [OnReceive] -> ({0} bytes)", "recieve data == null"));
            }
        }


        //处理队列的线程
        //除非关掉程序，否则循环检测TaskQueue中是否有数据
        //如果有数据就处理，否则休息1s钟
        private void MainThreadPool()
        {
            ClientInfo dequeueData;
            while (true)
            {
               // DateTime now = DateTime.Now;
                dequeueData = TaskQueue.getNext();
                if (dequeueData != null)
                {
                    ProcessSingleData(dequeueData);
                }
                else
                {
                    Thread.Sleep(1000);
                }
                if (isShutDown)
                {
                    break;
                }
            }
        }


        private void SubThreadPool()
        {
            ClientInfo dequeueData;
            while (true)
            {
                dequeueData = TaskQueue.getNext();
                if (dequeueData != null)
                {
                    ProcessSingleData(dequeueData);
                }
                else { break; }
                if (isShutDown)
                {
                    break;
                }
            }
        }

        //监视任务队列
        //如果任务队列数目>设置的数目的生活，开启子线程处理
        public void MonitorTaskQueue(object data)
        {
            if (DateTime.Now.Second % showTaskNumber == 0)
            {
                AddMsg(DateTime.Now.ToString() + "  任务队列个数" + TaskQueue.getQueueNumber());
            }

            for (int i = 0; i < subThreadNunber; i++)
            {
                if (TaskQueue.getQueueNumber() > exceedNewThread)
                {
                    Thread.Sleep(10);
                    Thread thread = new Thread(new ThreadStart(SubThreadPool));
                    thread.Start();
                }

            }
        }

        /// <summary>
        /// 设置程序状态
        /// </summary>
        /// <param name="state"></param>
        void SetAppState(AppState state)
        {
            appState = state;
            this.btnStart.Enabled = (appState == AppState.Stoped);
            this.btnStop.Enabled = (appState == AppState.Started);
            this.txtIpAddress.Enabled = (appState == AppState.Stoped);
            this.txtPort.Enabled = (appState == AppState.Stoped);
            this.txtDisConn.Enabled = (appState == AppState.Started);
            this.btnDisconn.Enabled = (appState == AppState.Started && this.txtDisConn.Text.Length > 0);
        }


        /// <summary>
        /// 往listbox加一条项目
        /// </summary>
        /// <param name="msg"></param>
        public void AddMsg(string msg)
        {
            if (IfShowLog == 1)
            {
                if (this.lbxMsg.InvokeRequired)
                {
                    // 很帅的调自己
                    this.lbxMsg.Invoke(AddMsgDelegate, msg);
                }
                else
                {
                    if (this.lbxMsg.Items.Count > 100)
                    {
                        this.lbxMsg.Items.RemoveAt(0);
                    }
                    this.lbxMsg.Items.Add(msg);
                    this.lbxMsg.TopIndex = this.lbxMsg.Items.Count - (int)(this.lbxMsg.Height / this.lbxMsg.ItemHeight);
                }
            }
        }

        private void txtDisConn_TextChanged(object sender, EventArgs e)
        {
            // CONNID框被改变事件
            this.btnDisconn.Enabled = (appState == AppState.Started && this.txtDisConn.Text.Length > 0);
        }

        private void lbxMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 清理listbox
            if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                this.lbxMsg.Items.Clear();
            }
        }

        private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //server.Destroy();
        }






        private static DataTable GetSocketInfoSchema()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("Id") });
            dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("connId") });
            dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("ip") });
            dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("port") });
            dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("content") });
            dataTable.Columns.AddRange(new DataColumn[] { new DataColumn("gettime") });
            return dataTable;
        }


    }


}
