using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    public class BaseCmd
    {
        private byte[] indata;//传进来的指令数据
        protected byte[] sendCommand;
        private byte[] lastCommand;
        public BaseCmdType commandType = BaseCmdType.Init;
        public Boolean canUse = true;
        public string stationId;

        public static BaseCmd getInitCmd()
        {
            BaseCmd baseCmd = new BaseCmd();
            baseCmd.canUse = true;
            baseCmd.commandType = BaseCmdType.Init;
            return baseCmd;

        }
        public static BaseCmd getPollingCmd()
        {
            BaseCmd baseCmd = new BaseCmd();
            baseCmd.canUse = false;
            baseCmd.commandType = BaseCmdType.Polling;
            return baseCmd;

        }
        public static BaseCmd getRuntimeCmd()
        {
            BaseCmd baseCmd = new BaseCmd();
            baseCmd.canUse = true;
            baseCmd.commandType = BaseCmdType.Runtime;
            return baseCmd;

        }
        public static BaseCmd getEndCmd()
        {
            BaseCmd baseCmd = new BaseCmd();
            baseCmd.canUse = false;
            baseCmd.commandType = BaseCmdType.End;
            return baseCmd;

        }
        public void SetData(byte[] indata)
        {
            this.indata = indata;
        }
        //public virtual String[] Parse()
        //{
        //    return null;
        //}
        public byte[] GetLastCommand()
        {
            return lastCommand;
        }
        public virtual byte[] GetSendCommand()
        {
            MakeCmd();
            lastCommand = sendCommand;
            return sendCommand;
        }
        /// <summary>
        /// 产生指令（包含校验码）.指令的具体内容由具体的派生类生成
        /// 此处默认为静态指令
        /// </summary>
        protected virtual void MakeCmd()
        {
            sendCommand = indata;
        }

        /// <summary>
        /// 校验指令是否合法.
        /// 1、使用CRC或者其他算法 校验该指令是否符合协议CRC
        /// 2、判断该指令是否是发送出去的指令的返回。
        /// </summary>
        /// <returns></returns>
        protected virtual bool CheckCmd()
        {
            return false;
        }

        protected virtual byte[] Parse() {
            return null;
        }




    }
}
