using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
   public class ServerCMD
    {
       public byte[] data { set; get; }
       public byte[] funcCode { set; get; }
       public byte[] address { set; get; } 
    }
}
