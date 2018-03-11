using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using YDIOTSvr.BusinessLayer.BaseObject;
using YDIOTSvr.DataLayer.Entity;
using YDIOTSvr.YDIOTSvrUtil;
using YDIOTSvrYDIOTSvrUtil;


namespace DerivedObject
{
    public class StationEDA9017 : BaseStation
    {
        public StationEDA9017(StationEntity stationEntity)
            : base(stationEntity)
        {
            portList.Add(new Port(0, "IIN0"));
            portList.Add(new Port(1, "IIN1"));
            portList.Add(new Port(2, "IIN2"));
            portList.Add(new Port(3, "IIN3"));
            portList.Add(new Port(4, "IIN4"));
            portList.Add(new Port(5, "IIN5"));
            portList.Add(new Port(6, "IIN6"));
            portList.Add(new Port(7, "IIN7"));
            portList.Add(new Port(8, "IIN8"));
            portList.Add(new Port(9, "IIN9"));
            portList.Add(new Port(10, "IIN10"));
            portList.Add(new Port(11, "IIN11"));

        }
        public override void initCmd()
        {
            base.initCmd();

        }
        /// <summary>
        /// 初始化Init指令   110 和120
        /// </summary>
        public override void initInitCmd()
        {
            ///////////////////////i1//////////////////////
            BaseCmd i1 = BaseCmd.getInitCmd();
            byte[] send1 = new byte[6];
            send1[0] = Convert.ToByte(stationEntity.Address);
            send1[1] = 1;
            send1[2] = 0;
            send1[3] = 0;
            send1[4] = 0;
            send1[5] = 4;
            CRCData crcdata = CRCDataCaculate.CRCCaculate(send1);
            byte[] s1 = new byte[8];

            for (int i = 0; i < 6; i++)
            {
                s1[i] = send1[i];
            }

            s1[6] = crcdata.CRCHigh;
            s1[7] = crcdata.CRCLow;
            i1.SetData(s1);
            initComand.Add(i1);
            ///////////////////////i2//////////////////////
            BaseCmd i2 = BaseCmd.getInitCmd();
            byte[] send2 = new byte[6];
            send2[0] = Convert.ToByte(stationEntity.Address);
            send2[1] = 2;
            send2[2] = 0;
            send2[3] = 0;
            send2[4] = 0;
            send2[5] = 4;
            crcdata = CRCDataCaculate.CRCCaculate(send2);
            byte[] s2 = new byte[8];

            for (int i = 0; i < 6; i++)
            {
                s2[i] = send2[i];
            }

            s2[6] = crcdata.CRCHigh;
            s2[7] = crcdata.CRCLow;
            i2.SetData(s2);
            initComand.Add(i2);
           


        }
        /// <summary>
        /// 初始化Polling指令   130 和140 150
        /// </summary>
        public override void initPollingCmd()
        {
            /////////////////////////////p1///////
            BaseCmd p1 = BaseCmd.getPollingCmd();
            byte[] send1 = new byte[] { Convert.ToByte(stationEntity.Address), 3, 0, 3, 0, 12 };
            CRCData crcdata = CRCDataCaculate.CRCCaculate(send1);
            byte[] s1 = new byte[8];
            for (int i = 0; i < 6; i++)
            {
                s1[i] = send1[i];
            }
            s1[6] = crcdata.CRCLow;
            s1[7] = crcdata.CRCHigh;
            p1.SetData(s1);
            pollingComand.Add(p1);
            /////////////////////////////p2///////
            BaseCmd p2 = BaseCmd.getPollingCmd();
            byte[] send2 = new byte[] { Convert.ToByte(stationEntity.Address), 4, 0, 3, 0, 12 };
            crcdata = CRCDataCaculate.CRCCaculate(send2);
            byte[] s2 = new byte[8];
            for (int i = 0; i < 6; i++)
            {
                s2[i] = send2[i];
            }
            s2[6] = crcdata.CRCLow;
            s2[7] = crcdata.CRCHigh;
            p2.SetData(s2);
            pollingComand.Add(p2);
            /////////////////////////////p3///////
            BaseCmd p3 = BaseCmd.getPollingCmd();
            byte[] send3 = new byte[] { Convert.ToByte(stationEntity.Address), 5, 0, 3, 0, 12 };
            crcdata = CRCDataCaculate.CRCCaculate(send3);
            byte[] s3 = new byte[8];
            for (int i = 0; i < 6; i++)
            {
                s3[i] = send3[i];
            }
            s3[6] = crcdata.CRCLow;
            s3[7] = crcdata.CRCHigh;
            p3.SetData(s3);
            pollingComand.Add(p3);
        }
        /// <summary>
        /// 运行时指令 160
        /// </summary>
        public override void initRuntimeCmd()
        {
            base.initRuntimeCmd();
            ///////////////r2////////////////////
            BaseCmd r1 = BaseCmd.getRuntimeCmd();
            byte[] send2 = new byte[6];
            send2[0] = Convert.ToByte(stationEntity.Address);
            send2[1] = 6;
            send2[2] = 0;
            send2[3] = 0;
            send2[4] = 0;
            send2[5] = 4;
            CRCData crcdata = CRCDataCaculate.CRCCaculate(send2);
            byte[] s2 = new byte[8];

            for (int i = 0; i < 6; i++)
            {
                s2[i] = send2[i];
            }

            s2[6] = crcdata.CRCHigh;
            s2[7] = crcdata.CRCLow;
            r1.SetData(s2);
            runtimeComand.Enqueue(r1);
        }
        /// <summary>
        /// 定时指令 170 180 190 
        /// </summary>
        public override void initTimedCmd()
        {
            //170每2分钟执行一次
            TimedRule tr2 = new TimedRule(TimedType.MINUTE, new DateTime(2017, 8, 6, 15, 53, 12), 2, false);
            ///////////////////////////////p2///////
            BaseCmd p2 = BaseCmd.getRuntimeCmd();
            byte[] send2 = new byte[] { Convert.ToByte(stationEntity.Address), 7, 0, 0, 0, 4 };
            CRCData crcdata = CRCDataCaculate.CRCCaculate(send2);
            byte[] s2 = new byte[8];
            for (int i = 0; i < 6; i++)
            {
                s2[i] = send2[i];
            }
            s2[6] = crcdata.CRCHigh;
            s2[7] = crcdata.CRCLow;
            p2.SetData(s2);
            tr2.cmdList.Add(p2);
            trList.Add(tr2);
            //180每1小时执行一次
            TimedRule tr3 = new TimedRule(TimedType.MINUTE, new DateTime(2017, 8, 6, 15, 10, 6), 1, false);
            /////////////////////////////p3///////
            BaseCmd p3 = BaseCmd.getRuntimeCmd();
            byte[] send3 = new byte[] { Convert.ToByte(stationEntity.Address), 8, 0, 0, 0, 4 };
            crcdata = CRCDataCaculate.CRCCaculate(send3);
            byte[] s3 = new byte[8];
            for (int i = 0; i < 6; i++)
            {
                s3[i] = send3[i];
            }
            s3[6] = crcdata.CRCHigh;
            s3[7] = crcdata.CRCLow;
            p3.SetData(s3);
            tr3.cmdList.Add(p3);
            trList.Add(tr3);

            //190每1天执行一次，上午10点
            TimedRule tr1 = new TimedRule(TimedType.MINUTE, new DateTime(2017, 8, 6, 10, 0, 0), 4, false);
            /////////////////////////////p1///////
            BaseCmd p1 = BaseCmd.getRuntimeCmd();
            byte[] send1 = new byte[] { Convert.ToByte(stationEntity.Address), 9, 0, 0, 0, 4 };
            crcdata = CRCDataCaculate.CRCCaculate(send1);
            byte[] s1 = new byte[8];
            for (int i = 0; i < 6; i++)
            {
                s1[i] = send1[i];
            }
            s1[6] = crcdata.CRCHigh;
            s1[7] = crcdata.CRCLow;
            p1.SetData(s1);
            tr1.cmdList.Add(p1);
            trList.Add(tr1);
        }

        public override byte[] Parse(byte[] bytes)
        {

          return  base.Parse(bytes);

            //bytes = base.Parse(bytes);
            ////取出数据长度
            //int Length = Convert.ToInt32(bytes[2]);
            //int index = (int)Math.Round((double)Length / 2.0);
            //if (index != 12) return null;
            //double[] ValueArray = new double[index];
            //for (int i = 0; i < index; i++)
            //{
            //    ValueArray[i] = Conversion.Val("&H" + Strings.Right("0" + Conversion.Hex(bytes[2 * i + 3]), 2) + Strings.Right("0" + Conversion.Hex(bytes[2 * i + 4]), 2));
            //}

            //foreach (string key in sensorDic.Keys)
            //{
            //    Port port = portList.Where(t => t.name == key).FirstOrDefault();
            //    int TmpIndex = port.id;
            //    BaseSensor Sensor = sensorDic[key];
            //    decimal value = (decimal)ValueArray[TmpIndex] / 1000;
            //    //- Sen)or.sensorEntity.Sensor_type.St_analog_min_value) * (Sensor.Sensor_type.St_analog_max_range - Sensor.Sensor_type.St_analog_min_range) / (Sensor.Sensor_type.St_analog_max_value - Sensor.Sensor_type.St_analog_min_value));
            //    value = value + Sensor.sensorEntity.CorrectedValue;
            //    value = Math.Round(value, 2);
            //    DataTablePollingLog.CreateInstance().Add(Sensor.sensorEntity.Msc_ID, value);
            //    DataTableMapSiteConfig.CreateInstance().Update(Sensor.sensorEntity.Md_port, Sensor.sensorEntity.Md_ID, Sensor.sensorEntity.DTU_ID, value);
            //}
           // return bytes;
        }
    }
}
