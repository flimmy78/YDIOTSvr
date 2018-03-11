using System;

using System.Configuration;

using System.Data;

using System.Data.SqlClient;

using System.Collections;



namespace YDIOTSvr.DataLayer.SQLHelper
{
    /// <summary>

    /// SqlHelper类提供很高的数据访问性能, 

    /// 使用SqlClient类的通用定义.

    /// </summary>

    public abstract class SQLHelperEX
    {



        //定义数据库连接串

        private static string _connectionString;

        // 存贮Cache缓存的Hashtable集合

        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());

        public static string connectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        /// <summary>

        /// 使用连接字符串，执行一个SqlCommand命令（没有记录返回）

        /// 使用提供的参数集.

        /// </summary>

        /// <remarks>

        /// 示例:  

        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));

        /// </remarks>

        /// <param name="connectionString">一个有效的SqlConnection连接串</param>

        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>

        /// <param name="commandText">存贮过程名称或是一个T-SQL语句串</param>

        /// <param name="commandParameters">执行命令的参数集</param>

        /// <returns>受此命令影响的行数</returns>

        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);

                int val = cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                return val;
            }

        }



        /// <summary>

        /// 在一个存在的连接上执行数据库的命令操作

        /// 使用提供的参数集.

        /// </summary>

        /// <remarks>

        /// e.g.:  

        ///  int result = ExecuteNonQuery(connection, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));

        /// </remarks>

        /// <param name="conn">一个存在的数据库连接对象</param>

        /// <param name="commandType">命令类型CommandType (stored procedure, text, etc.)</param>

        /// <param name="commandText">存贮过程名称或是一个T-SQL语句串</param>

        /// <param name="commandParameters">执行命令的参数集</param>

        /// <returns>受此命令影响的行数</returns>

        public static int ExecuteNonQuery(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {



            SqlCommand cmd = new SqlCommand();



            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);

            int val = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            return val;

        }



        /// <summary>

        /// 在一个事务的连接上执行数据库的命令操作

        /// 使用提供的参数集.

        /// </summary>

        /// <remarks>

        /// e.g.:  

        ///  int result = ExecuteNonQuery(trans, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));

        /// </remarks>

        /// <param name="trans">一个存在的事务</param>

        /// <param name="commandType">命令类型CommandType (stored procedure, text, etc.)</param>

        /// <param name="commandText">存贮过程名称或是一个T-SQL语句串</param>

        /// <param name="commandParameters">执行命令的参数集</param>

        /// <returns>受此命令影响的行数</returns>

        public static int ExecuteNonQuery(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();

            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);

            int val = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            return val;

        }



        /// <summary>

        /// 在一个连接串上执行一个命令，返回一个SqlDataReader对象

        /// 使用提供的参数.

        /// </summary>

        /// <remarks>

        /// e.g.:  

        ///  SqlDataReader r = ExecuteReader(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));

        /// </remarks>

        /// <param name="connectionString">一个有效的SqlConnection连接串</param>

        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>

        /// <param name="commandText">存贮过程名称或是一个T-SQL语句串</param>

        /// <param name="commandParameters">执行命令的参数集</param>

        /// <returns>一个结果集对象SqlDataReader</returns>

        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();

            SqlConnection conn = new SqlConnection(connectionString);



            // 如果不存在要查询的对象，则发生异常

            // 连接要关闭

            // CommandBehavior.CloseConnection在异常时不发生作用

            try
            {

                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);

                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                cmd.Parameters.Clear();

                return rdr;

            }

            catch
            {

                conn.Close();

                throw;

            }

        }



        /// <summary>

        /// 在一个连接串上执行一个命令，返回表中第一行，第一列的值

        /// 使用提供的参数.

        /// </summary>

        /// <remarks>

        /// e.g.:  

        ///  Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));

        /// </remarks>

        /// <param name="connectionString">一个有效的SqlConnection连接串</param>

        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>

        /// <param name="commandText">存贮过程名称或是一个T-SQL语句串</param>

        /// <param name="commandParameters">执行命令的参数集</param>        /// <returns>返回的对象，在使用时记得类型转换</returns>

        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();



            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);

                object val = cmd.ExecuteScalar();

                cmd.Parameters.Clear();

                return val;

            }

        }



        /// <summary>

        /// 在一个连接上执行一个命令，返回表中第一行，第一列的值

        /// 使用提供的参数.

        /// </summary>

        /// <remarks>

        /// e.g.:  

        ///  Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));

        /// </remarks>

        /// <param name="connectionString">一个有效的SqlConnection连接</param>

        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>

        /// <param name="commandText">存贮过程名称或是一个T-SQL语句串</param>

        /// <param name="commandParameters">执行命令的参数集</param>        /// <returns>返回的对象，在使用时记得类型转换</returns>

        public static object ExecuteScalar(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {



            SqlCommand cmd = new SqlCommand();



            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);

            object val = cmd.ExecuteScalar();

            cmd.Parameters.Clear();

            return val;

        }



        /// <summary>

        /// 在缓存中添加参数数组

        /// </summary>

        /// <param name="cacheKey">参数的Key</param>

        /// <param name="cmdParms">参数数组</param>

        public static void CacheParameters(string cacheKey, params SqlParameter[] commandParameters)
        {

            parmCache[cacheKey] = commandParameters;

        }



        /// <summary>

        /// 提取缓存的参数数组

        /// </summary>

        /// <param name="cacheKey">查找缓存的key</param>

        /// <returns>返回被缓存的参数数组</returns>

        public static SqlParameter[] GetCachedParameters(string cacheKey)
        {

            SqlParameter[] cachedParms = (SqlParameter[])parmCache[cacheKey];



            if (cachedParms == null)

                return null;



            SqlParameter[] clonedParms = new SqlParameter[cachedParms.Length];



            for (int i = 0, j = cachedParms.Length; i < j; i++)

                clonedParms[i] = (SqlParameter)((ICloneable)cachedParms[i]).Clone();



            return clonedParms;

        }



        /// <summary>

        /// 提供一个SqlCommand对象的设置

        /// </summary>

        /// <param name="cmd">SqlCommand对象</param>

        /// <param name="conn">SqlConnection 对象</param>

        /// <param name="trans">SqlTransaction 对象</param>

        /// <param name="cmdType">CommandType 如存贮过程，T-SQL</param>

        /// <param name="cmdText">存贮过程名或查询串</param>

        /// <param name="cmdParms">命令中用到的参数集</param>

        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {



            if (conn.State != ConnectionState.Open)

                conn.Open();



            cmd.Connection = conn;

            cmd.CommandText = cmdText;



            if (trans != null)

                cmd.Transaction = trans;



            cmd.CommandType = cmdType;



            if (cmdParms != null)
            {

                foreach (SqlParameter parm in cmdParms)

                    cmd.Parameters.Add(parm);

            }

        }

    }

}

