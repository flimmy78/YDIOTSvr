using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YDIOTSvr.BusinessLayer.BaseObject;
using YDIOTSvr.DataLayer.Entity;
using HPSocketCS;

namespace DerivedObject
{
    public class DTULQ8110E : BaseDTU
    {
        public DTULQ8110E(DTUEntity dtu, IntPtr connId, TcpServer server)
        :base(dtu,connId,server){
      
       }
        public DTULQ8110E() { }
    }
}
