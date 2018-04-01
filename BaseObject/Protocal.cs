using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
   public class Protocal
    {

       public virtual byte[] wrap(ServerCMD serverCMD) { return null; }

       public virtual ServerCMD unWrap(byte[] cmd) { return null; }

       public static  Protocal getInstance(BaseDTU baseDTU) {

           if (baseDTU.dtu.protocal == 0) {

               return new ModbusProtocal();
           }
           return null;
       
       }

       public virtual bool isToThisDtu(byte[] inData, byte[] compareData) {
           return false;
       }

       public virtual bool valid(byte[] inData) {

           return false;
       }

    }
}
