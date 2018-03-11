using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YDIOTSvr.BusinessLayer.BaseObject;
using YDIOTSvr.DataLayer.Entity;

namespace DerivedObject
{
    public class StationEDA9060:BaseStation
    {
          public StationEDA9060(StationEntity stationEntity): base(stationEntity)
        {
            this.stationEntity = stationEntity;
        }

          public StationEDA9060() { }
    }
}
