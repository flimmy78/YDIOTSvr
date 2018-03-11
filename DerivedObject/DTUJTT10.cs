using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YDIOTSvr.BusinessLayer.BaseObject;
using YDIOTSvr.DataLayer.Entity;
using HPSocketCS;

namespace DerivedObject
{
   public class DTUJTT10:BaseDTU
    {
       public DTUJTT10(DTUEntity dtu, IntPtr connId, TcpServer server)
        :base(dtu,connId,server){
      
       }
       public DTUJTT10()
       {

       }
    }
}
