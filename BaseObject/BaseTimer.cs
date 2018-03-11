using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    /// <summary>
    /// 单个Timer，管理一些Dtu
    /// 表示 由这一个timer可以用来带动一些的dtu 
    /// 这些dtu存放于baseDTUList 中
    /// </summary>
    public class BaseTimer
    {
        //定义一个系统的timer 定期的执行一个任务，此处是定期执行CallAllBeat函数
        public System.Threading.Timer timer;
        private List<BaseDTU> baseDTUList = new List<BaseDTU>();
        //将dtu加入到dtu列表中 要求线程安全的
        public void AddTaskItem(BaseDTU item)
        {
            lock (baseDTUList)
            {
                baseDTUList.Add(item);
            }
        }
        public void RemoveTaskItem(BaseDTU item)
        {
            baseDTUList.Remove(item);
        }

        public BaseTimer(long interval, long starttime)
        {
            timer = new System.Threading.Timer(new System.Threading.TimerCallback(CallAllBeat), 0, starttime, interval);

        }
        //定期执行的函数 这里做的事是 针对每一个dtu in baseDTUList
        //执行dtu的beat函数
        private void CallAllBeat(object obj)
        {
            lock (baseDTUList)
            {
                foreach (BaseDTU dtu in baseDTUList)
                {
                    dtu.beat(obj);
                }
            }

        }

    }
}

