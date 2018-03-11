using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    //指令类型 轮询 初始化 运行时
    public enum BaseCmdType
    {
        Polling, Init, Runtime,End
    }
}
