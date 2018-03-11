using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;

namespace YDIOTSvr.DataLayer.SQLHelper
{
    public class SQLBulkCopy
    {
        public static long SqlBulkCopy(DataTable dataTable, String tableName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(SQLHelperEX.connectionString);
            sqlBulkCopy.DestinationTableName = tableName;
            sqlBulkCopy.BatchSize = dataTable.Rows.Count;
            SqlConnection sqlConnection = new SqlConnection(SQLHelperEX.connectionString);
            sqlConnection.Open();
            if (dataTable != null && dataTable.Rows.Count != 0)
            {
                try
                {
                    sqlBulkCopy.WriteToServer(dataTable);
                }
                catch (Exception)
                {

                    // throw;
                }

            }
            sqlBulkCopy.Close();
            sqlConnection.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }






    }
}
