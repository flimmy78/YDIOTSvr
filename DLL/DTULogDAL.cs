/**  版本信息模板在安装目录下，可自行修改。
* DTU_log.cs
*
* 功 能： N/A
* 类 名： DTU_log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:28   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：元大信息科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YDIOTSvr.DataLayer.Entity;using YDIOTSvr.DataLayer.DAL;//Please add references
using YDIOTSvr.DataLayer.SQLHelper;
namespace YDIOTSvr.DataLayer.DAL
{
	/// <summary>
    /// 数据访问类:DTULogDAL
	/// </summary>
	public partial class DTULogDAL
	{
		public DTULogDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Dl_ID", "DTU_log"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Dl_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DTU_log");
			strSql.Append(" where Dl_ID=@Dl_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Dl_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Dl_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DTULogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DTU_log(");
			strSql.Append("DTU_ID,DTU_IP,DTU_port,DTU_login_time,DTU_logout_time,DTU_Logout_Value)");
			strSql.Append(" values (");
			strSql.Append("@DTU_ID,@DTU_IP,@DTU_port,@DTU_login_time,@DTU_logout_time,@DTU_Logout_Value)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_IP", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_port", SqlDbType.Int,4),
					new SqlParameter("@DTU_login_time", SqlDbType.DateTime),
					new SqlParameter("@DTU_logout_time", SqlDbType.DateTime),
					new SqlParameter("@DTU_Logout_Value", SqlDbType.Float,8)};
			parameters[0].Value = model.DTU_ID;
			parameters[1].Value = model.DTU_IP;
			parameters[2].Value = model.DTU_port;
			parameters[3].Value = model.DTU_login_time;
			parameters[4].Value = model.DTU_logout_time;
			parameters[5].Value = model.DTU_Logout_Value;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(DTULogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DTU_log set ");
			strSql.Append("DTU_ID=@DTU_ID,");
			strSql.Append("DTU_IP=@DTU_IP,");
			strSql.Append("DTU_port=@DTU_port,");
			strSql.Append("DTU_login_time=@DTU_login_time,");
			strSql.Append("DTU_logout_time=@DTU_logout_time,");
			strSql.Append("DTU_Logout_Value=@DTU_Logout_Value");
			strSql.Append(" where Dl_ID=@Dl_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_IP", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_port", SqlDbType.Int,4),
					new SqlParameter("@DTU_login_time", SqlDbType.DateTime),
					new SqlParameter("@DTU_logout_time", SqlDbType.DateTime),
					new SqlParameter("@DTU_Logout_Value", SqlDbType.Float,8),
					new SqlParameter("@Dl_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.DTU_ID;
			parameters[1].Value = model.DTU_IP;
			parameters[2].Value = model.DTU_port;
			parameters[3].Value = model.DTU_login_time;
			parameters[4].Value = model.DTU_logout_time;
			parameters[5].Value = model.DTU_Logout_Value;
			parameters[6].Value = model.Dl_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Dl_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DTU_log ");
			strSql.Append(" where Dl_ID=@Dl_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Dl_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Dl_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Dl_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DTU_log ");
			strSql.Append(" where Dl_ID in ("+Dl_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public DTULogEntity GetModel(int Dl_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Dl_ID,DTU_ID,DTU_IP,DTU_port,DTU_login_time,DTU_logout_time,DTU_Logout_Value from DTU_log ");
			strSql.Append(" where Dl_ID=@Dl_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Dl_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Dl_ID;

            DTULogEntity model = new DTULogEntity();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public DTULogEntity DataRowToModel(DataRow row)
		{
            DTULogEntity model = new DTULogEntity();
			if (row != null)
			{
				if(row["Dl_ID"]!=null && row["Dl_ID"].ToString()!="")
				{
					model.Dl_ID=int.Parse(row["Dl_ID"].ToString());
				}
				if(row["DTU_ID"]!=null)
				{
					model.DTU_ID=row["DTU_ID"].ToString();
				}
				if(row["DTU_IP"]!=null)
				{
					model.DTU_IP=row["DTU_IP"].ToString();
				}
				if(row["DTU_port"]!=null && row["DTU_port"].ToString()!="")
				{
					model.DTU_port=int.Parse(row["DTU_port"].ToString());
				}
				if(row["DTU_login_time"]!=null && row["DTU_login_time"].ToString()!="")
				{
					model.DTU_login_time=DateTime.Parse(row["DTU_login_time"].ToString());
				}
				if(row["DTU_logout_time"]!=null && row["DTU_logout_time"].ToString()!="")
				{
					model.DTU_logout_time=DateTime.Parse(row["DTU_logout_time"].ToString());
				}
				if(row["DTU_Logout_Value"]!=null && row["DTU_Logout_Value"].ToString()!="")
				{
					model.DTU_Logout_Value=decimal.Parse(row["DTU_Logout_Value"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Dl_ID,DTU_ID,DTU_IP,DTU_port,DTU_login_time,DTU_logout_time,DTU_Logout_Value ");
			strSql.Append(" FROM DTU_log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Dl_ID,DTU_ID,DTU_IP,DTU_port,DTU_login_time,DTU_logout_time,DTU_Logout_Value ");
			strSql.Append(" FROM DTU_log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DTU_log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Dl_ID desc");
			}
			strSql.Append(")AS Row, T.*  from DTU_log T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DTU_log";
			parameters[1].Value = "Dl_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

