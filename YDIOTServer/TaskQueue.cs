using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using HPSocketCS;
using System.Collections.Concurrent;

namespace TcpServer
{
    [StructLayout(LayoutKind.Sequential)]
    public class ClientInfo
    {
        public IntPtr ConnId { get; set; }
        public string IpAddress { get; set; }
        public ushort Port { get; set; }
        public byte[] Data { get; set; }
        public HPSocketCS.TcpServer server { get; set; }
        public TcpServerManager serverManager { get; set; }
    }

    /// <summary>
    /// 定义任务队列
    /// 这个任务队列定义了一个线程安全的队列，封装了显示函数和增加函数，获取函数
    /// 增加函数要求的是一个客户端信息 类型为ClientInfo
    /// </summary>
    public static class TaskQueue
    {
        static ConcurrentQueue<ClientInfo> dataQueue = new ConcurrentQueue<ClientInfo>();
        public static event ShowMsg AddMsgDelegate;
        public static void AddMessage(ClientInfo info)
        {
            dataQueue.Enqueue(info);
            //if (AddMsgDelegate != null)
            //{
            //    AddMsgDelegate(info.ConnId.ToString());
            //}
        }
        public static ClientInfo getNext()
        {
            ClientInfo dequeueData = null;

            if (dataQueue.TryDequeue(out dequeueData))
            {
                if (dequeueData != null)
                {
                    return dequeueData;
                }
            }
            return null;
        }

        public static long getQueueNumber() {
            return dataQueue.Count;
        }
    }
}
