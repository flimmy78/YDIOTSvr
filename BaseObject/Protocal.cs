using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
   public class Protocal
    {

       public virtual string wrap(ServerCMD serverCMD) { return null; }

       public virtual ServerCMD unWrap(string cmd) { return null; } 

    }
}
