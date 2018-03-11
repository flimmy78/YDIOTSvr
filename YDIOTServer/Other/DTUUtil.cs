using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YDIOTSvr.DataLayer.Entity;
using YDIOTSvr.BusinessLayer.BaseObject;
using DerivedObject;
using YDIOTSvrYDIOTSvrUtil;
using System.Configuration;

namespace TcpServer.Other
{
    /// <summary>
    /// DTU对应的工具类
    /// 根据登录id区分dtu
    /// </summary>
    public class DTUUtil
    {
        private static DTUUtil du;
        static int dicNumber = int.Parse(ConfigurationManager.AppSettings["DtuDicNumber"].ToString());
        static int polling_delay_time = int.Parse(ConfigurationManager.AppSettings["polling_delay_time"].ToString());
        static int polling_time = int.Parse(ConfigurationManager.AppSettings["polling_time"].ToString());

        private DTUUtil()
        {

        }

        public static DTUUtil getInstance()
        {
            if (du != null)
            {
                return du;
            }
            else
            {
                du = new DTUUtil();
                return du;
            }
        }
        //dtuDic是所有的dtu的字典集合，刚开始初始化的时候，把数据库中的所有dtu读取出来并且初始化
        private Dictionary<String, BaseDTU> dtuDic = new Dictionary<string, BaseDTU>();
        public Dictionary<String, BaseDTU> getDTUDic()
        {
            
            if (dtuDic.Count <= 0)
            {
                //读数据库 初始化dtudic
                for (int i = 0; i < dicNumber; i++)
                {
                    DTUEntity dtuEntity = new DTUEntity();
                    dtuEntity.Address = i + "";
                    dtuEntity.polling_delay_time = polling_delay_time;
                    dtuEntity.polling_time = polling_time;
                 
                    Dictionary<string, BaseStation> stationDic = new Dictionary<string, BaseStation>();

                    ////////////模块1、////////
                    StationEntity se1 = new StationEntity();
                    se1.Address = "1";
                    se1.Md_ID = i + "md1";
                    StationEDA9017 s1 = new StationEDA9017(se1);
                    s1.initCmd();
                    stationDic.Add(se1.Address, s1);
                    ////////////模块1完成////////

                    ////////////模块2、////////
                    StationEntity se2 = new StationEntity();
                    se2.Address = "2";
                    se2.Md_ID = i + "md2";
                    StationEDA9017 s2 = new StationEDA9017(se2);
                    s2.initCmd();
                    stationDic.Add(se2.Address, s2);
                    //////////////模块2完成、////////
                    BaseDTU basedtu = new BaseDTU(dtuEntity, stationDic);
                    dtuDic.Add((100000 + i) + "", basedtu);
                }
                return dtuDic;
            }
            else
            {
                return dtuDic;
            }
        }

    }
}
