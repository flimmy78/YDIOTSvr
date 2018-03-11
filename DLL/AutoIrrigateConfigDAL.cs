/**  版本信息模板在安装目录下，可自行修改。
* Auto_Irrigate_Config.cs
*
* 功 能： N/A
* 类 名： Auto_Irrigate_Config
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
	/// 数据访问类:Auto_Irrigate_Config
	/// </summary>
	public partial class AutoIrrigateConfigDAL
	{
		public AutoIrrigateConfigDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Auto_Irrigate_Facility_ID", "Auto_Irrigate_Config"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Auto_Irrigate_Facility_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Auto_Irrigate_Config");
			strSql.Append(" where Auto_Irrigate_Facility_ID=@Auto_Irrigate_Facility_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Auto_Irrigate_Facility_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Auto_Irrigate_Facility_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AutoIrrigateConfigEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Auto_Irrigate_Config(");
			strSql.Append("Trigger_Facility_ID,Auto_Irrigate_Facility_ID,StartOrStop_MSC_ID,State_MSC_ID,Irrigate_Duration,Auto_Irrigate_Enabled)");
			strSql.Append(" values (");
			strSql.Append("@Trigger_Facility_ID,@Auto_Irrigate_Facility_ID,@StartOrStop_MSC_ID,@State_MSC_ID,@Irrigate_Duration,@Auto_Irrigate_Enabled)");
			SqlParameter[] parameters = {
					new SqlParameter("@Trigger_Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Auto_Irrigate_Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@StartOrStop_MSC_ID", SqlDbType.Int,4),
					new SqlParameter("@State_MSC_ID", SqlDbType.Int,4),
					new SqlParameter("@Irrigate_Duration", SqlDbType.Int,4),
					new SqlParameter("@Auto_Irrigate_Enabled", SqlDbType.Bit,1)};
			parameters[0].Value = model.Trigger_Facility_ID;
			parameters[1].Value = model.Auto_Irrigate_Facility_ID;
			parameters[2].Value = model.StartOrStop_MSC_ID;
			parameters[3].Value = model.State_MSC_ID;
			parameters[4].Value = model.Irrigate_Duration;
			parameters[5].Value = model.Auto_Irrigate_Enabled;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(AutoIrrigateConfigEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Auto_Irrigate_Config set ");
			strSql.Append("Trigger_Facility_ID=@Trigger_Facility_ID,");
			strSql.Append("StartOrStop_MSC_ID=@StartOrStop_MSC_ID,");
			strSql.Append("State_MSC_ID=@State_MSC_ID,");
			strSql.Append("Irrigate_Duration=@Irrigate_Duration,");
			strSql.Append("Auto_Irrigate_Enabled=@Auto_Irrigate_Enabled");
			strSql.Append(" where Auto_Irrigate_Facility_ID=@Auto_Irrigate_Facility_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Trigger_Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@StartOrStop_MSC_ID", SqlDbType.Int,4),
					new SqlParameter("@State_MSC_ID", SqlDbType.Int,4),
					new SqlParameter("@Irrigate_Duration", SqlDbType.Int,4),
					new SqlParameter("@Auto_Irrigate_Enabled", SqlDbType.Bit,1),
					new SqlParameter("@Auto_Irrigate_Facility_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Trigger_Facility_ID;
			parameters[1].Value = model.StartOrStop_MSC_ID;
			parameters[2].Value = model.State_MSC_ID;
			parameters[3].Value = model.Irrigate_Duration;
			parameters[4].Value = model.Auto_Irrigate_Enabled;
			parameters[5].Value = model.Auto_Irrigate_Facility_ID;

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
		public bool Delete(int Auto_Irrigate_Facility_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Auto_Irrigate_Config ");
			strSql.Append(" where Auto_Irrigate_Facility_ID=@Auto_Irrigate_Facility_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Auto_Irrigate_Facility_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Auto_Irrigate_Facility_ID;

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
		public bool DeleteList(string Auto_Irrigate_Facility_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Auto_Irrigate_Config ");
			strSql.Append(" where Auto_Irrigate_Facility_ID in ("+Auto_Irrigate_Facility_IDlist + ")  ");
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
		public AutoIrrigateConfigEntity GetModel(int Auto_Irrigate_Facility_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Trigger_Facility_ID,Auto_Irrigate_Facility_ID,StartOrStop_MSC_ID,State_MSC_ID,Irrigate_Duration,Auto_Irrigate_Enabled from Auto_Irrigate_Config ");
			strSql.Append(" where Auto_Irrigate_Facility_ID=@Auto_Irrigate_Facility_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Auto_Irrigate_Facility_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Auto_Irrigate_Facility_ID;

			AutoIrrigateConfigEntity model=new AutoIrrigateConfigEntity();
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
		public AutoIrrigateConfigEntity DataRowToModel(DataRow row)
		{
			AutoIrrigateConfigEntity model=new AutoIrrigateConfigEntity();
			if (row != null)
			{
				if(row["Trigger_Facility_ID"]!=null && row["Trigger_Facility_ID"].ToString()!="")
				{
					model.Trigger_Facility_ID=int.Parse(row["Trigger_Facility_ID"].ToString());
				}
				if(row["Auto_Irrigate_Facility_ID"]!=null && row["Auto_Irrigate_Facility_ID"].ToString()!="")
				{
					model.Auto_Irrigate_Facility_ID=int.Parse(row["Auto_Irrigate_Facility_ID"].ToString());
				}
				if(row["StartOrStop_MSC_ID"]!=null && row["StartOrStop_MSC_ID"].ToString()!="")
				{
					model.StartOrStop_MSC_ID=int.Parse(row["StartOrStop_MSC_ID"].ToString());
				}
				if(row["State_MSC_ID"]!=null && row["State_MSC_ID"].ToString()!="")
				{
					model.State_MSC_ID=int.Parse(row["State_MSC_ID"].ToString());
				}
				if(row["Irrigate_Duration"]!=null && row["Irrigate_Duration"].ToString()!="")
				{
					model.Irrigate_Duration=int.Parse(row["Irrigate_Duration"].ToString());
				}
				if(row["Auto_Irrigate_Enabled"]!=null && row["Auto_Irrigate_Enabled"].ToString()!="")
				{
					if((row["Auto_Irrigate_Enabled"].ToString()=="1")||(row["Auto_Irrigate_Enabled"].ToString().ToLower()=="true"))
					{
						model.Auto_Irrigate_Enabled=true;
					}
					else
					{
						model.Auto_Irrigate_Enabled=false;
					}
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
			strSql.Append("select Trigger_Facility_ID,Auto_Irrigate_Facility_ID,StartOrStop_MSC_ID,State_MSC_ID,Irrigate_Duration,Auto_Irrigate_Enabled ");
			strSql.Append(" FROM Auto_Irrigate_Config ");
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
			strSql.Append(" Trigger_Facility_ID,Auto_Irrigate_Facility_ID,StartOrStop_MSC_ID,State_MSC_ID,Irrigate_Duration,Auto_Irrigate_Enabled ");
			strSql.Append(" FROM Auto_Irrigate_Config ");
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
			strSql.Append("select count(1) FROM Auto_Irrigate_Config ");
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
				strSql.Append("order by T.Auto_Irrigate_Facility_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Auto_Irrigate_Config T ");
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
			parameters[0].Value = "Auto_Irrigate_Config";
			parameters[1].Value = "Auto_Irrigate_Facility_ID";
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

