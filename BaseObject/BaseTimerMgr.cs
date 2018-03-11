using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    /// <summary>
    /// 时间管理类
    /// 此类管理多个基本的timer 
    /// 主要功能是针对已经设置的好的时间参数 如timernumber 和timerInterval
    /// 循环起来多个timer
    /// 然后开放一个add函数接口
    /// 增加一个dtu进来，函数会根据所有开启的tiner中的dtuList的长度计算这个新的dtu要放置在哪一个里面
    /// 目的是 尽可能的保持各个timer中的dtuList尽可能等长
    /// </summary>
    public class BaseTimerMgr
    {
      
        private int index = 0;//实际到来的dtu数量
        private int _timerNumber;
        private int _timerInterval;
        List<BaseTimer> baseTimerList = new List<BaseTimer>();
        public BaseTimerMgr(int timerNumber, int timerInterval)
        {
            _timerInterval = timerInterval;
            _timerNumber = timerNumber;
            for (int i = 0; i < timerNumber; i++)
            {
                //循环开启timerNumber个BaseTimer 时间间隔都是一样的，但是开始时间要一个比一个晚，目的是分批次起来
                BaseTimer baseTimer = new BaseTimer(timerInterval, (int)((timerInterval * i / timerNumber)));
                baseTimerList.Add(baseTimer);
            }
        }
        /// <summary>
        /// 把到来的实际dtu下分到具体的BaseTimer中
        /// </summary>
        /// <param name="baseDTU"></param>
        public void AddDTU(BaseDTU baseDTU) {
            object o = new object();
            lock (o)
            {
                //计算新的baseDTU应该被放置在哪一个BaseTimer中
                int tempIndex = (int)(index++) % baseTimerList.Count;
                baseTimerList.ElementAt(tempIndex).AddTaskItem(baseDTU);
            }
        }

        public void RemoveDTU(BaseDTU baseDTU)
        {
            object o = new object();
            lock (o)
            {
                foreach (BaseTimer basetimer in baseTimerList)
                {
                    basetimer.RemoveTaskItem(baseDTU);
                }
            }

        }


    }
}
