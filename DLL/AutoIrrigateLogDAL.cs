/**  版本信息模板在安装目录下，可自行修改。
* Auto_Irrigate_Log.cs
*
* 功 能： N/A
* 类 名： Auto_Irrigate_Log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:27   N/A    初版
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
    /// 数据访问类:AutoIrrigateLogDAL
	/// </summary>
	public partial class AutoIrrigateLogDAL
	{
		public AutoIrrigateLogDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AIL_ID", "Auto_Irrigate_Log"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AIL_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Auto_Irrigate_Log");
			strSql.Append(" where AIL_ID=@AIL_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIL_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = AIL_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AutoIrrigateLogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Auto_Irrigate_Log(");
			strSql.Append("Auto_Irrigate_Facility_ID,Auto_Irrigate_StartTime,Auto_Irrigate_EndTime,Auto_Irrigate_State)");
			strSql.Append(" values (");
			strSql.Append("@Auto_Irrigate_Facility_ID,@Auto_Irrigate_StartTime,@Auto_Irrigate_EndTime,@Auto_Irrigate_State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Auto_Irrigate_Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Auto_Irrigate_StartTime", SqlDbType.DateTime),
					new SqlParameter("@Auto_Irrigate_EndTime", SqlDbType.DateTime),
					new SqlParameter("@Auto_Irrigate_State", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.Auto_Irrigate_Facility_ID;
			parameters[1].Value = model.Auto_Irrigate_StartTime;
			parameters[2].Value = model.Auto_Irrigate_EndTime;
			parameters[3].Value = model.Auto_Irrigate_State;

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
		public bool Update(AutoIrrigateLogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Auto_Irrigate_Log set ");
			strSql.Append("Auto_Irrigate_Facility_ID=@Auto_Irrigate_Facility_ID,");
			strSql.Append("Auto_Irrigate_StartTime=@Auto_Irrigate_StartTime,");
			strSql.Append("Auto_Irrigate_EndTime=@Auto_Irrigate_EndTime,");
			strSql.Append("Auto_Irrigate_State=@Auto_Irrigate_State");
			strSql.Append(" where AIL_ID=@AIL_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Auto_Irrigate_Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Auto_Irrigate_StartTime", SqlDbType.DateTime),
					new SqlParameter("@Auto_Irrigate_EndTime", SqlDbType.DateTime),
					new SqlParameter("@Auto_Irrigate_State", SqlDbType.NVarChar,20),
					new SqlParameter("@AIL_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Auto_Irrigate_Facility_ID;
			parameters[1].Value = model.Auto_Irrigate_StartTime;
			parameters[2].Value = model.Auto_Irrigate_EndTime;
			parameters[3].Value = model.Auto_Irrigate_State;
			parameters[4].Value = model.AIL_ID;

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
		public bool Delete(int AIL_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Auto_Irrigate_Log ");
			strSql.Append(" where AIL_ID=@AIL_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIL_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = AIL_ID;

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
		public bool DeleteList(string AIL_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Auto_Irrigate_Log ");
			strSql.Append(" where AIL_ID in ("+AIL_IDlist + ")  ");
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
		public AutoIrrigateLogEntity GetModel(int AIL_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AIL_ID,Auto_Irrigate_Facility_ID,Auto_Irrigate_StartTime,Auto_Irrigate_EndTime,Auto_Irrigate_State from Auto_Irrigate_Log ");
			strSql.Append(" where AIL_ID=@AIL_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIL_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = AIL_ID;

			AutoIrrigateLogEntity model=new AutoIrrigateLogEntity();
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
		public AutoIrrigateLogEntity DataRowToModel(DataRow row)
		{
			AutoIrrigateLogEntity model=new AutoIrrigateLogEntity();
			if (row != null)
			{
				if(row["AIL_ID"]!=null && row["AIL_ID"].ToString()!="")
				{
					model.AIL_ID=int.Parse(row["AIL_ID"].ToString());
				}
				if(row["Auto_Irrigate_Facility_ID"]!=null && row["Auto_Irrigate_Facility_ID"].ToString()!="")
				{
					model.Auto_Irrigate_Facility_ID=int.Parse(row["Auto_Irrigate_Facility_ID"].ToString());
				}
				if(row["Auto_Irrigate_StartTime"]!=null && row["Auto_Irrigate_StartTime"].ToString()!="")
				{
					model.Auto_Irrigate_StartTime=DateTime.Parse(row["Auto_Irrigate_StartTime"].ToString());
				}
				if(row["Auto_Irrigate_EndTime"]!=null && row["Auto_Irrigate_EndTime"].ToString()!="")
				{
					model.Auto_Irrigate_EndTime=DateTime.Parse(row["Auto_Irrigate_EndTime"].ToString());
				}
				if(row["Auto_Irrigate_State"]!=null)
				{
					model.Auto_Irrigate_State=row["Auto_Irrigate_State"].ToString();
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
			strSql.Append("select AIL_ID,Auto_Irrigate_Facility_ID,Auto_Irrigate_StartTime,Auto_Irrigate_EndTime,Auto_Irrigate_State ");
			strSql.Append(" FROM Auto_Irrigate_Log ");
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
			strSql.Append(" AIL_ID,Auto_Irrigate_Facility_ID,Auto_Irrigate_StartTime,Auto_Irrigate_EndTime,Auto_Irrigate_State ");
			strSql.Append(" FROM Auto_Irrigate_Log ");
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
			strSql.Append("select count(1) FROM Auto_Irrigate_Log ");
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
				strSql.Append("order by T.AIL_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Auto_Irrigate_Log T ");
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
			parameters[0].Value = "Auto_Irrigate_Log";
			parameters[1].Value = "AIL_ID";
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

