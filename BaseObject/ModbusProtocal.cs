using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YDIOTSvr.YDIOTSvrUtil;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    public class ModbusProtocal : Protocal
    {
        public override ServerCMD unWrap(byte[] bytes)
        {
            if (valid(bytes))
            {
                ServerCMD serverCMD = new ServerCMD();
                Array.Copy(bytes, serverCMD.adress, 1);
                Array.Copy(bytes, 1, serverCMD.funcCode, 0, 1);
                Array.Copy(bytes, bytes.Length - 2, serverCMD.validCode, 0, 2);
                serverCMD.funcCode = bytes;
                return serverCMD;
            }
            return null;

        }

        public override bool isToThisDtu(byte[] inData, byte[] compareData)
        {
            ServerCMD inCMD = unWrap(inData);
            ServerCMD compareCMD = unWrap(compareData);
            if (null != inCMD && null != compareCMD)
            {
                return (inCMD.adress == compareCMD.adress && inCMD.funcCode == compareCMD.funcCode);
            }
            return false;
        }

        public override bool valid(byte[] inData)
        {

            byte[] rawBytes = new byte[inData.Length - 2];
            for (int i = 0; i < rawBytes.Length; i++)
            {
                rawBytes[i] = inData[i];
            }
            CRCData crcData = CRCDataCaculate.CRCCaculate(rawBytes);
            if (crcData.CRCLow == inData[inData.Length - 2] && crcData.CRCHigh == inData[inData.Length - 1])
            {
                return true;
            }
            return base.valid(inData);
        }


    }
}
