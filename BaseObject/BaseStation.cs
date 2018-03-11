using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YDIOTSvr.DataLayer.Entity;
using YDIOTSvr.YDIOTSvrUtil;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    public class BaseStation
    {
        //端口链表
        public List<Port> portList = new List<Port>();
        public StationEntity stationEntity;
        //下属的传感器字典 其key应该是BaseSensor 下面的MapSiteConfigEntity中 Md_port字段
        public Dictionary<string, BaseSensor> sensorDic = new Dictionary<string, BaseSensor>();
        public List<BaseCmd> initComand = new List<BaseCmd>();
        public List<BaseCmd> pollingComand = new List<BaseCmd>();
        public Queue<BaseCmd> runtimeComand = new Queue<BaseCmd>();
        public Boolean isInitSccess = false;
        public List<TimedRule> trList = new List<TimedRule>();
        public StationProtocol protocol = StationProtocol.MODBUS;




        public BaseStation(StationEntity stationEntity)
        {
            this.stationEntity = stationEntity;
        }

        public BaseStation() { }

        /// <summary>
        /// 初始化所有指令
        /// </summary>
        public virtual void initCmd()
        {
            initInitCmd();
            initPollingCmd();
            initRuntimeCmd();
            initTimedCmd();
            //给所有指令的stationid赋值 来源于当前的 this.stationEntity.Md_ID
            for (int i = 0; i < initComand.Count; i++)
            {
                initComand[i].stationId = this.stationEntity.Md_ID;
            }
            for (int i = 0; i < pollingComand.Count; i++)
            {
                pollingComand[i].stationId = this.stationEntity.Md_ID;
            }
            for (int i = 0; i < runtimeComand.Count; i++)
            {
                runtimeComand.ElementAt(i).stationId = this.stationEntity.Md_ID;
            }
            for (int i = 0; i < trList.Count; i++)
            {
                for (int j = 0; j < trList[i].cmdList.Count; j++)
                {
                    trList[i].cmdList[j].stationId = this.stationEntity.Md_ID;
                }

            }

        }

        public virtual void initTimedCmd() { }
        public virtual void initInitCmd() { }

        public virtual void initPollingCmd() { }

        public virtual void initRuntimeCmd() { }

        /// <summary>
        /// 针对这个模块的所有初始化指令，
        /// 有一个匹配上，就返回true ，具体规则自己写
        /// 初始化时候，服务器每收到一个数据，都要调用下这个函数
        /// 判断下是否初始化完成
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public virtual bool isInit(byte[] bytes)
        {
            //处理这个isInitSccess
            for (int i = 0; i < initComand.Count; i++)
            {
                BaseCmd ce = initComand[i];
                if (ce.canUse)
                {
                    if (ce.GetLastCommand() == null) {
                        break;
                    }
                    if (ByteUtils.ByteArrayEquals2(ce.GetLastCommand(), bytes))
                    {
                        //如果相等，那就是在这个初始化指令的对应回复值
                        ce.canUse = false;
                        var query = initComand.Where(item => item.canUse == true && item.stationId == ce.stationId);
                        if (!query.Any())
                        {
                            var pollingQuery = pollingComand.Where(item => item.stationId == ce.stationId);
                            foreach (var bas in pollingQuery)
                            {
                                bas.canUse = true;
                            }
                        }
                        break;
                    }
                }
            }
            var queryAll = initComand.Where(item => item.canUse == true);
            if (!queryAll.Any())
            {
                isInitSccess = true;
            }
            return false;
        }

        /// <summary>
        /// 把临时运行时指令加入队列
        /// </summary>
        /// <param name="baseCmd"></param>
        public virtual void PushRuntimeCmd(BaseCmd baseCmd)
        {
            baseCmd.commandType = BaseCmdType.Runtime;
            runtimeComand.Enqueue(baseCmd);
        }

        /// <summary>
        /// 解析到达的数据
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public virtual byte[] Parse(byte[] bytes)
        {
            byte[] rawBytes = new byte[bytes.Length - 2];
            for (int i = 0; i < rawBytes.Length; i++)
            {
                rawBytes[i] = bytes[i];
            }
            CRCData crcData = CRCDataCaculate.CRCCaculate(rawBytes);
            if (crcData.CRCLow == bytes[bytes.Length - 2] && crcData.CRCHigh == bytes[bytes.Length - 1])
            {
                if (!isInitSccess)
                {
                    isInit(bytes);
                }
                return bytes;
            }
            return null;
        }

        /// <summary>
        /// 获取可以发送的第一条指令
        /// 规则 如果这个工作站已经初始化成功 首先考虑runtime指令
        /// 否则 返回初始化的第一条指令
        /// </summary>
        /// <returns></returns>
        public virtual BaseCmd ReadRunTimeCmd()
        {
            if (runtimeComand.Count > 0)
            {
                return runtimeComand.Dequeue();
            }
            return null;

        }

        public virtual void ReStart()
        {
            isInitSccess = false;
            for (int i = 0; i < pollingComand.Count; i++)
            {
                pollingComand.ElementAt(i).canUse = false;
            }
            for (int i = 0; i < initComand.Count; i++)
            {
                pollingComand.ElementAt(i).canUse = true;
            }
            runtimeComand.Clear();

        }
    }
}
