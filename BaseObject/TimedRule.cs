using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    public enum TimedType
    {
        YEAR,
        MONTH,
        DAY,
        HOUR,
        MINUTE
    }
    /// <summary>
    /// 时间规则类，定义时间规则类，使用run()方法判断是否满足执行条件
    /// </summary>
    public class TimedRule
    {
        public TimedType timeType = TimedType.MINUTE;//1 按年 2 月 3 日 4时5分 
        public DateTime startTime = new DateTime(2013, 1, 1);
        public int count = 0;
        public int interval = 1;
        //  int oldCount = 0;
        bool isRunRightNow = true;
        public int excuteNumber = -1;//表示执行次数
        public List<BaseCmd> cmdList = new List<BaseCmd>();
        public DateTime nextTime;//表示下次执行时间
        private  DateTime firsttime = DateTime.MinValue;
        public TimedRule(TimedType timeType, DateTime startTime, int interval, bool isRunRightNow)
        {

            this.timeType = timeType;
            this.startTime = startTime;
            this.interval = interval;
            this.isRunRightNow = isRunRightNow;
          
            if (isRunRightNow)
            {

                firsttime = startTime;
            }
            else
            {
                switch (timeType)
                {
                    case TimedType.YEAR:
                        firsttime = startTime.AddYears(interval);
                        break;
                    case TimedType.MONTH:
                        firsttime = startTime.AddMonths(interval);
                        break;
                    case TimedType.DAY:
                        firsttime = startTime.AddDays(interval);
                        break;
                    case TimedType.HOUR:
                        firsttime = startTime.AddHours(interval);
                        break;
                    case TimedType.MINUTE:
                        firsttime = startTime.AddMinutes(interval);
                        break;
                }

                if (DateTime.Now <= firsttime)
                {
                    nextTime = firsttime;
                }
                else
                {
                    getCount();
                    if (excuteNumber >= 0)
                    {
                        if (count >= excuteNumber)
                        {
                            nextTime = DateTime.MaxValue;
                        }
                    }
                    else
                    {
                        switch (timeType)
                        {
                            case TimedType.YEAR:
                                nextTime = firsttime.AddYears(interval * (count + 1));
                                break;
                            case TimedType.MONTH:
                                nextTime = firsttime.AddMonths(interval * (count + 1));
                                break;
                            case TimedType.DAY:
                                nextTime = firsttime.AddDays(interval * (count + 1));
                                break;
                            case TimedType.HOUR:
                                nextTime = firsttime.AddHours(interval * (count + 1));
                                break;
                            case TimedType.MINUTE:
                                nextTime = firsttime.AddMinutes(interval * (count + 1));
                                break;
                        }
                    }
                }
            }

        }

        public void getCount()
        {
            DateTime now = DateTime.Now;
            switch (timeType)
            {
                case TimedType.YEAR:
                    while (firsttime.AddYears(interval * count) < now)
                    {
                        if (firsttime.AddYears(interval * (count + 1)) > now)
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }

                    }

                    break;
                case TimedType.MONTH:
                    while (firsttime.AddMonths(interval * count) < now)
                    {
                        if (firsttime.AddMonths(interval * (count + 1)) > now)
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }

                    }

                    break;
                case TimedType.DAY:
                    count = (int)Math.Floor(((now - firsttime).TotalDays) / interval);
                    break;
                case TimedType.HOUR:
                    count = (int)Math.Floor(((now - firsttime).TotalHours) / interval);
                    break;
                case TimedType.MINUTE:
                    count = (int)Math.Floor(((now - firsttime).TotalMinutes) / interval);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 更新NextTime
        /// </summary>
        public void SetNextTime()
        {
            switch (timeType)
            {
                case TimedType.YEAR:
                    nextTime = nextTime.AddYears(interval);
                    break;
                case TimedType.MONTH:
                    nextTime = nextTime.AddMonths(interval);
                    break;
                case TimedType.DAY:
                    nextTime = nextTime.AddDays(interval);
                    break;
                case TimedType.HOUR:
                    nextTime = nextTime.AddHours(interval);
                    break;
                case TimedType.MINUTE:
                    nextTime = nextTime.AddMinutes(interval);
                    break;
            }
        }

    }
}
