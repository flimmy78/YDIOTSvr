using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDIOTSvr.BusinessLayer.BaseObject
{
    public class Port
    {
        public int id { get; set; }
        public string name { get; set; }

        public Port(int id,string name) {
            this.id = id;
            this.name = name;
        }
    }
}
