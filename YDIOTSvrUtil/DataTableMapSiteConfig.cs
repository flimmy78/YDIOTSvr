using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YDIOTSvr.DataLayer.BLL;

namespace YDIOTSvrYDIOTSvrUtil
{
    public class DataTableMapSiteConfig
    {

        private volatile static DataTableMapSiteConfig _instance = null;
        private DataTable mapSiteConfig;
        private static readonly object lockHelper = new object();
        private DataTableMapSiteConfig()
        {
            if (mapSiteConfig == null)
            {
                mapSiteConfig = new DataTable();
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("Msc_ID") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("DTU_ID") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("Md_ID") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("St_ID") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("At_ID") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("Md_port") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("ValueTypeID") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("ValueName") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("MSC_Is_Display") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("CorrectedValue") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("PL_Time") });
                mapSiteConfig.Columns.AddRange(new DataColumn[] { new DataColumn("PL_Value") });


            }
            if (mapSiteConfig.Rows.Count == 0)
            {
                //度数据库中的mapsiteConfig表
                MapSiteConfigBLL mscb = new MapSiteConfigBLL();
                DataSet ds = mscb.GetAllList();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                {
                    mapSiteConfig = ds.Tables[0];
                }
            }



        }
        public static DataTableMapSiteConfig CreateInstance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                        _instance = new DataTableMapSiteConfig();
                }
            }
            return _instance;
        }

        public bool Update(string md_port, string md_id, string dtu_id, decimal pl_value)
        {
            DataRow[] selectRow = mapSiteConfig.Select("md_port='" + md_port + "' and md_id='" + md_id + "' and dtu_id = '" + dtu_id + "'");
            if (selectRow.Length == 1)
            {
                selectRow[0]["PL_Value"] = pl_value;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
