using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YDIOTSvr.DataLayer.Entity;
using YDIOTSvr.YDIOTSvrUtil;
using HPSocketCS;
using YDIOTSvrYDIOTSvrUtil;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    /// <summary>
    /// dtu实体
    /// </summary>
    public class BaseDTU
    {
        public HPSocketCS.TcpServer server; //服务器，用于发送指令
        public IntPtr connId;  //连接号
        private DateTime sendTime = DateTime.MinValue;//本次指令发送的精确时间
        private DateTime pollingStartTime = DateTime.MinValue;//本轮指令发送的确切时间
        private BaseCmd currentCmd;//当前发送指令
        private int beatCounter = 0;//心跳计数器
        private Queue<BaseCmd> sendCmd = new Queue<BaseCmd>();
        public DTUEntity dtu;//dtu实体，对应数据库

        public List<TimedRule> trList = new List<TimedRule>();//定义的时间规则

        public long hearttingTime//心跳包断线时间 单位是毫秒 定义多久收不到信息就表示断线了
        {
            get;
            set;
        }
        //是否掉线
        public bool offline = false;
        public BaseStation selfStation;
        //这个dtu下属的工作站字典 这里的key 应该是BaseStation里面 StationEntity 下面的 _Address字段
        public Dictionary<string, BaseStation> baseStationDic = new Dictionary<string, BaseStation>();
        public static String ParseLogin(byte[] bytes)
        {
            String id = "";
            if (bytes.Length != 14)
            {
                return "";
            }

            if (bytes[0] != 170 || bytes[1] != 1)
            {
                return "";
            }
            if (bytes[2] == 250)
            {
                return "test";
            }

            int i = 2;
            while (bytes[i] != 250)
            {
                id = id + (bytes[i] - 48) + "";
                i++;
            }
            return id;
        }
        public BaseDTU(DTUEntity dtu, IntPtr connId, TcpServer server)
        {
            this.dtu = dtu;
            this.connId = connId;
            this.server = server;
        }

        public BaseDTU(DTUEntity dtu, Dictionary<string, BaseStation> baseStationDic)
            : this(dtu, IntPtr.Zero, null)
        {
            this.baseStationDic = baseStationDic;
            /// this.trList = trList;
            StationEntity se = new StationEntity();
            se.DTU_ID = dtu.DTU_ID;
            se.Address = dtu.Address;
            selfStation = new BaseStation(se);
            InitTimedRule();
            InitBaseStationDic();
            InitSendCmd();

        }


        public BaseDTU() { }
        /// <summary>
        /// 初始化发送指令
        /// </summary>
        private void InitSendCmd()
        {
            InitSendCmd(selfStation);
            foreach (String key in baseStationDic.Keys)
            {
                InitSendCmd(baseStationDic[key]);
            }
            BaseCmd endCMD = new BaseCmd();
            endCMD.commandType = BaseCmdType.End;
            endCMD.canUse = false;//endCMD一定不能发
            sendCmd.Enqueue(endCMD);

        }

        private void InitSendCmd(BaseStation baseStation)
        {
            //先考虑初始化指令
            for (int i = 0; i < baseStation.initComand.Count; i++)
            {
                sendCmd.Enqueue(baseStation.initComand[i]);
            }
            //再考虑轮询指令
            for (int i = 0; i < baseStation.pollingComand.Count; i++)
            {
                sendCmd.Enqueue(baseStation.pollingComand[i]);
            }
        }

        //初始化baseStationDic
        public virtual void InitBaseStationDic()
        {

        }

        public virtual void InitTimedRule()
        {
            foreach (BaseStation item in baseStationDic.Values)
            {
                trList.AddRange(item.trList);
            }

        }
        /// <summary>
        /// 弹出一个要发送的指令,必然是可用的指令
        /// </summary>
        /// <returns></returns>
        public BaseCmd ReadCmd()
        {
            lock (sendCmd)
            {
                //首先考虑DTU自己的运行时指令
                if (selfStation.runtimeComand.Count > 0)
                {
                    return selfStation.runtimeComand.Dequeue();
                }
                //在考虑其下属的模块的运行时指令
                foreach (string key in baseStationDic.Keys)
                {
                    if (baseStationDic[key].runtimeComand.Count > 0)
                    {
                        return baseStationDic[key].runtimeComand.Dequeue();
                    }
                }
                //最后考虑大队列
                if (sendCmd.Count > 0)
                {
                    //开头是End类型了，说明已经轮询一遍了
                    if (sendCmd.ElementAt(0).commandType == BaseCmdType.End)
                    {
                        TimeSpan pollingtime = DateTime.Now - pollingStartTime;
                        if (pollingtime.TotalMilliseconds < dtu.polling_time)
                        {
                            return null;
                        }
                        else
                        {
                            pollingStartTime = DateTime.Now;
                        }
                    }

                    BaseCmd baseCmd = sendCmd.Dequeue();
                    sendCmd.Enqueue(baseCmd);
                    while (!baseCmd.canUse)
                    {
                        if (baseCmd.commandType == BaseCmdType.End)
                        {
                            TimeSpan pollingtime = DateTime.Now - pollingStartTime;
                            if (pollingtime.TotalMilliseconds < dtu.polling_time)
                            {
                                return null;
                            }
                            else
                            {
                                pollingStartTime = DateTime.Now;
                            }
                        }
                        baseCmd = sendCmd.Dequeue();
                        sendCmd.Enqueue(baseCmd);
                    }
                    return baseCmd;
                }
                return null;
            }
        }

        public void ReceivedCmd(byte[] bytes)
        {
            if (ByteUtils.ByteArrayEquals2(currentCmd.GetLastCommand(), bytes))
            {
                string addr = "";
                //表示 发送指令已经收到了，可以丢给对应的模块Station处理了
                addr = bytes[0] + "";
                baseStationDic[addr].Parse(bytes);
                sendPollingCMD();
            }

        }
        /// <summary>
        /// 发送指令
        /// 此处得到的发送指令，一定是可用的且不为End类型的
        /// </summary>
        private void sendPollingCMD()
        {
            BaseCmd baseCmd = ReadCmd();
            if (baseCmd != null)
            {
                currentCmd = baseCmd;
                byte[] tempCmd = baseCmd.GetSendCommand();
                if (server.Send(connId, tempCmd, tempCmd.Length))
                {
                    sendTime = DateTime.Now;

                }
            }
        }


        public void beat(Object obj)
        {
            trList.RemoveAll((item)=>item.nextTime==DateTime.MaxValue);
           // trList.Sort((a, b) => a.nextTime.CompareTo(b.nextTime));
            trList.OrderBy(a => a.nextTime);
            for (int i = 0; i < trList.Count; i++)
            {
                TimedRule t1 = trList[i];
                if (DateTime.Now >= t1.nextTime)
                {
                    //符合定时条件
                    for (int j = 0; j < t1.cmdList.Count; j++)
                    {
                        BaseCmd bcm = t1.cmdList[j];
                        BaseStation bastation = baseStationDic.Values.Where(item => item.stationEntity.Md_ID == bcm.stationId).FirstOrDefault();
                        if (bastation != null)
                        {
                            bastation.runtimeComand.Enqueue(bcm);
                        }
                    }

                    t1.SetNextTime();
                }
                else { break; }
            }

            bool istosend = false;
            //第一次发送的时候
            if (sendTime == DateTime.MinValue)
            {
                istosend = true;
                pollingStartTime = DateTime.Now;
            }
            else
            {
                TimeSpan interval = DateTime.Now - sendTime;
                //单个指令延迟
                if (interval.TotalMilliseconds > dtu.polling_delay_time)
                {
                    istosend = true;
                }
            }
            if (istosend)
            {
                istosend = false;
                sendPollingCMD();
            }
        }


    }
}
