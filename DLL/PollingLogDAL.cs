/**  版本信息模板在安装目录下，可自行修改。
* Polling_Log.cs
*
* 功 能： N/A
* 类 名： Polling_Log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:40   N/A    初版
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
    /// 数据访问类:PollingLogDAL
	/// </summary>
	public partial class PollingLogDAL
	{
        public PollingLogDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Pl_ID", "Polling_Log"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Pl_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Polling_Log");
			strSql.Append(" where Pl_ID=@Pl_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Pl_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Pl_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(PollingLogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Polling_Log(");
			strSql.Append("PL_Time,Msc_ID,Value)");
			strSql.Append(" values (");
			strSql.Append("@PL_Time,@Msc_ID,@Value)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PL_Time", SqlDbType.DateTime),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Value", SqlDbType.Float,8)};
			parameters[0].Value = model.PL_Time;
			parameters[1].Value = model.Msc_ID;
			parameters[2].Value = model.Value;

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
        public bool Update(PollingLogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Polling_Log set ");
			strSql.Append("PL_Time=@PL_Time,");
			strSql.Append("Msc_ID=@Msc_ID,");
			strSql.Append("Value=@Value");
			strSql.Append(" where Pl_ID=@Pl_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@PL_Time", SqlDbType.DateTime),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Value", SqlDbType.Float,8),
					new SqlParameter("@Pl_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.PL_Time;
			parameters[1].Value = model.Msc_ID;
			parameters[2].Value = model.Value;
			parameters[3].Value = model.Pl_ID;

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
		public bool Delete(int Pl_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Polling_Log ");
			strSql.Append(" where Pl_ID=@Pl_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Pl_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Pl_ID;

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
		public bool DeleteList(string Pl_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Polling_Log ");
			strSql.Append(" where Pl_ID in ("+Pl_IDlist + ")  ");
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
        public PollingLogEntity GetModel(int Pl_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Pl_ID,PL_Time,Msc_ID,Value from Polling_Log ");
			strSql.Append(" where Pl_ID=@Pl_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Pl_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Pl_ID;

            PollingLogEntity model = new PollingLogEntity();
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
        public PollingLogEntity DataRowToModel(DataRow row)
		{
            PollingLogEntity model = new PollingLogEntity();
			if (row != null)
			{
				if(row["Pl_ID"]!=null && row["Pl_ID"].ToString()!="")
				{
					model.Pl_ID=int.Parse(row["Pl_ID"].ToString());
				}
				if(row["PL_Time"]!=null && row["PL_Time"].ToString()!="")
				{
					model.PL_Time=DateTime.Parse(row["PL_Time"].ToString());
				}
				if(row["Msc_ID"]!=null && row["Msc_ID"].ToString()!="")
				{
					model.Msc_ID=int.Parse(row["Msc_ID"].ToString());
				}
				if(row["Value"]!=null && row["Value"].ToString()!="")
				{
					model.Value=decimal.Parse(row["Value"].ToString());
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
			strSql.Append("select Pl_ID,PL_Time,Msc_ID,Value ");
			strSql.Append(" FROM Polling_Log ");
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
			strSql.Append(" Pl_ID,PL_Time,Msc_ID,Value ");
			strSql.Append(" FROM Polling_Log ");
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
			strSql.Append("select count(1) FROM Polling_Log ");
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
				strSql.Append("order by T.Pl_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Polling_Log T ");
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
			parameters[0].Value = "Polling_Log";
			parameters[1].Value = "Pl_ID";
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

