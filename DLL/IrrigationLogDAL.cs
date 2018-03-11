/**  版本信息模板在安装目录下，可自行修改。
* IrrigationLog.cs
*
* 功 能： N/A
* 类 名： IrrigationLog
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:33   N/A    初版
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
	/// 数据访问类:IrrigationLogDAL
	/// </summary>
	public partial class IrrigationLogDAL
	{
        public IrrigationLogDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AIL_ID", "IrrigationLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AIL_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from IrrigationLog");
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
		public int Add(IrrigationLogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into IrrigationLog(");
			strSql.Append("AIL_Start_Time,AIL_End_Time,AIC_ID,Soil_Moisture_Low,Soil_Moisture_Mid,Soil_Moisture_High,Soil_Moisture_Unit,AIL_Flow_Gauge_Start_Reading,AIL_Flow_Gauge_End_Reading1,Manual_Irrigation_User)");
			strSql.Append(" values (");
			strSql.Append("@AIL_Start_Time,@AIL_End_Time,@AIC_ID,@Soil_Moisture_Low,@Soil_Moisture_Mid,@Soil_Moisture_High,@Soil_Moisture_Unit,@AIL_Flow_Gauge_Start_Reading,@AIL_Flow_Gauge_End_Reading1,@Manual_Irrigation_User)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AIL_Start_Time", SqlDbType.DateTime),
					new SqlParameter("@AIL_End_Time", SqlDbType.DateTime),
					new SqlParameter("@AIC_ID", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Low", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Mid", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_High", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Unit", SqlDbType.NChar,10),
					new SqlParameter("@AIL_Flow_Gauge_Start_Reading", SqlDbType.Float,8),
					new SqlParameter("@AIL_Flow_Gauge_End_Reading1", SqlDbType.Float,8),
					new SqlParameter("@Manual_Irrigation_User", SqlDbType.Int,4)};
			parameters[0].Value = model.AIL_Start_Time;
			parameters[1].Value = model.AIL_End_Time;
			parameters[2].Value = model.AIC_ID;
			parameters[3].Value = model.Soil_Moisture_Low;
			parameters[4].Value = model.Soil_Moisture_Mid;
			parameters[5].Value = model.Soil_Moisture_High;
			parameters[6].Value = model.Soil_Moisture_Unit;
			parameters[7].Value = model.AIL_Flow_Gauge_Start_Reading;
			parameters[8].Value = model.AIL_Flow_Gauge_End_Reading1;
			parameters[9].Value = model.Manual_Irrigation_User;

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
		public bool Update(IrrigationLogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update IrrigationLog set ");
			strSql.Append("AIL_Start_Time=@AIL_Start_Time,");
			strSql.Append("AIL_End_Time=@AIL_End_Time,");
			strSql.Append("AIC_ID=@AIC_ID,");
			strSql.Append("Soil_Moisture_Low=@Soil_Moisture_Low,");
			strSql.Append("Soil_Moisture_Mid=@Soil_Moisture_Mid,");
			strSql.Append("Soil_Moisture_High=@Soil_Moisture_High,");
			strSql.Append("Soil_Moisture_Unit=@Soil_Moisture_Unit,");
			strSql.Append("AIL_Flow_Gauge_Start_Reading=@AIL_Flow_Gauge_Start_Reading,");
			strSql.Append("AIL_Flow_Gauge_End_Reading1=@AIL_Flow_Gauge_End_Reading1,");
			strSql.Append("Manual_Irrigation_User=@Manual_Irrigation_User");
			strSql.Append(" where AIL_ID=@AIL_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIL_Start_Time", SqlDbType.DateTime),
					new SqlParameter("@AIL_End_Time", SqlDbType.DateTime),
					new SqlParameter("@AIC_ID", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Low", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Mid", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_High", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Unit", SqlDbType.NChar,10),
					new SqlParameter("@AIL_Flow_Gauge_Start_Reading", SqlDbType.Float,8),
					new SqlParameter("@AIL_Flow_Gauge_End_Reading1", SqlDbType.Float,8),
					new SqlParameter("@Manual_Irrigation_User", SqlDbType.Int,4),
					new SqlParameter("@AIL_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.AIL_Start_Time;
			parameters[1].Value = model.AIL_End_Time;
			parameters[2].Value = model.AIC_ID;
			parameters[3].Value = model.Soil_Moisture_Low;
			parameters[4].Value = model.Soil_Moisture_Mid;
			parameters[5].Value = model.Soil_Moisture_High;
			parameters[6].Value = model.Soil_Moisture_Unit;
			parameters[7].Value = model.AIL_Flow_Gauge_Start_Reading;
			parameters[8].Value = model.AIL_Flow_Gauge_End_Reading1;
			parameters[9].Value = model.Manual_Irrigation_User;
			parameters[10].Value = model.AIL_ID;

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
			strSql.Append("delete from IrrigationLog ");
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
			strSql.Append("delete from IrrigationLog ");
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
		public IrrigationLogEntity GetModel(int AIL_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AIL_ID,AIL_Start_Time,AIL_End_Time,AIC_ID,Soil_Moisture_Low,Soil_Moisture_Mid,Soil_Moisture_High,Soil_Moisture_Unit,AIL_Flow_Gauge_Start_Reading,AIL_Flow_Gauge_End_Reading1,Manual_Irrigation_User from IrrigationLog ");
			strSql.Append(" where AIL_ID=@AIL_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIL_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = AIL_ID;

			IrrigationLogEntity model=new IrrigationLogEntity();
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
		public IrrigationLogEntity DataRowToModel(DataRow row)
		{
			IrrigationLogEntity model=new IrrigationLogEntity();
			if (row != null)
			{
				if(row["AIL_ID"]!=null && row["AIL_ID"].ToString()!="")
				{
					model.AIL_ID=int.Parse(row["AIL_ID"].ToString());
				}
				if(row["AIL_Start_Time"]!=null && row["AIL_Start_Time"].ToString()!="")
				{
					model.AIL_Start_Time=DateTime.Parse(row["AIL_Start_Time"].ToString());
				}
				if(row["AIL_End_Time"]!=null && row["AIL_End_Time"].ToString()!="")
				{
					model.AIL_End_Time=DateTime.Parse(row["AIL_End_Time"].ToString());
				}
				if(row["AIC_ID"]!=null && row["AIC_ID"].ToString()!="")
				{
					model.AIC_ID=int.Parse(row["AIC_ID"].ToString());
				}
				if(row["Soil_Moisture_Low"]!=null && row["Soil_Moisture_Low"].ToString()!="")
				{
					model.Soil_Moisture_Low=int.Parse(row["Soil_Moisture_Low"].ToString());
				}
				if(row["Soil_Moisture_Mid"]!=null && row["Soil_Moisture_Mid"].ToString()!="")
				{
					model.Soil_Moisture_Mid=int.Parse(row["Soil_Moisture_Mid"].ToString());
				}
				if(row["Soil_Moisture_High"]!=null && row["Soil_Moisture_High"].ToString()!="")
				{
					model.Soil_Moisture_High=int.Parse(row["Soil_Moisture_High"].ToString());
				}
				if(row["Soil_Moisture_Unit"]!=null)
				{
					model.Soil_Moisture_Unit=row["Soil_Moisture_Unit"].ToString();
				}
				if(row["AIL_Flow_Gauge_Start_Reading"]!=null && row["AIL_Flow_Gauge_Start_Reading"].ToString()!="")
				{
					model.AIL_Flow_Gauge_Start_Reading=decimal.Parse(row["AIL_Flow_Gauge_Start_Reading"].ToString());
				}
				if(row["AIL_Flow_Gauge_End_Reading1"]!=null && row["AIL_Flow_Gauge_End_Reading1"].ToString()!="")
				{
					model.AIL_Flow_Gauge_End_Reading1=decimal.Parse(row["AIL_Flow_Gauge_End_Reading1"].ToString());
				}
				if(row["Manual_Irrigation_User"]!=null && row["Manual_Irrigation_User"].ToString()!="")
				{
					model.Manual_Irrigation_User=int.Parse(row["Manual_Irrigation_User"].ToString());
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
			strSql.Append("select AIL_ID,AIL_Start_Time,AIL_End_Time,AIC_ID,Soil_Moisture_Low,Soil_Moisture_Mid,Soil_Moisture_High,Soil_Moisture_Unit,AIL_Flow_Gauge_Start_Reading,AIL_Flow_Gauge_End_Reading1,Manual_Irrigation_User ");
			strSql.Append(" FROM IrrigationLog ");
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
			strSql.Append(" AIL_ID,AIL_Start_Time,AIL_End_Time,AIC_ID,Soil_Moisture_Low,Soil_Moisture_Mid,Soil_Moisture_High,Soil_Moisture_Unit,AIL_Flow_Gauge_Start_Reading,AIL_Flow_Gauge_End_Reading1,Manual_Irrigation_User ");
			strSql.Append(" FROM IrrigationLog ");
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
			strSql.Append("select count(1) FROM IrrigationLog ");
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
			strSql.Append(")AS Row, T.*  from IrrigationLog T ");
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
			parameters[0].Value = "IrrigationLog";
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

