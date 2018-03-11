using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YDIOTSvr.DataLayer.BLL;

namespace YDIOTSvrYDIOTSvrUtil
{
    public class DataTablePollingLog
    {
        private volatile static DataTablePollingLog _instance = null;
        private DataTable pollingLog;
        private static readonly object lockHelper = new object();
        private DataTablePollingLog()
        {
            if (pollingLog == null)
            {
                pollingLog = new DataTable();
                pollingLog.Columns.AddRange(new DataColumn[] { new DataColumn("Pl_ID") });
                pollingLog.Columns.AddRange(new DataColumn[] { new DataColumn("PL_Time") });
                pollingLog.Columns.AddRange(new DataColumn[] { new DataColumn("Msc_ID") });
                pollingLog.Columns.AddRange(new DataColumn[] { new DataColumn("Value") });
            }
        }
        public static DataTablePollingLog CreateInstance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                        _instance = new DataTablePollingLog();
                }
            }
            return _instance;
        }

        public void Add( int msc_id, decimal value)
        {
            DataRow newRow = pollingLog.NewRow();
            newRow["Pl_ID"] = Guid.NewGuid();
            newRow["PL_Time"] = DateTime.Now;
            newRow["Msc_ID"] = msc_id;
            newRow["Value"] = value;
            pollingLog.Rows.Add(newRow);
        }
    }
}
