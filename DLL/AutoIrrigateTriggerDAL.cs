/**  版本信息模板在安装目录下，可自行修改。
* Auto_Irrigate_Trigger.cs
*
* 功 能： N/A
* 类 名： Auto_Irrigate_Trigger
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
	/// 数据访问类:Auto_Irrigate_Trigger
	/// </summary>
	public partial class AutoIrrigateTriggerDAL
	{
		public AutoIrrigateTriggerDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Trigger_Facility_ID", "Auto_Irrigate_Trigger"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Trigger_Facility_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Auto_Irrigate_Trigger");
			strSql.Append(" where Trigger_Facility_ID=@Trigger_Facility_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Trigger_Facility_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Trigger_Facility_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AutoIrrigateTriggerEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Auto_Irrigate_Trigger(");
			strSql.Append("Trigger_Facility_ID,Trigger_MSC_ID_1,Trigger_MSC_ID_2,Trigger_MSC_ID_3,Trigger_Threshold_LowLimit,Trigger_Threshold_UpperLimit)");
			strSql.Append(" values (");
			strSql.Append("@Trigger_Facility_ID,@Trigger_MSC_ID_1,@Trigger_MSC_ID_2,@Trigger_MSC_ID_3,@Trigger_Threshold_LowLimit,@Trigger_Threshold_UpperLimit)");
			SqlParameter[] parameters = {
					new SqlParameter("@Trigger_Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Trigger_MSC_ID_1", SqlDbType.Int,4),
					new SqlParameter("@Trigger_MSC_ID_2", SqlDbType.Int,4),
					new SqlParameter("@Trigger_MSC_ID_3", SqlDbType.Int,4),
					new SqlParameter("@Trigger_Threshold_LowLimit", SqlDbType.Float,8),
					new SqlParameter("@Trigger_Threshold_UpperLimit", SqlDbType.Float,8)};
			parameters[0].Value = model.Trigger_Facility_ID;
			parameters[1].Value = model.Trigger_MSC_ID_1;
			parameters[2].Value = model.Trigger_MSC_ID_2;
			parameters[3].Value = model.Trigger_MSC_ID_3;
			parameters[4].Value = model.Trigger_Threshold_LowLimit;
			parameters[5].Value = model.Trigger_Threshold_UpperLimit;

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
		public bool Update(AutoIrrigateTriggerEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Auto_Irrigate_Trigger set ");
			strSql.Append("Trigger_MSC_ID_1=@Trigger_MSC_ID_1,");
			strSql.Append("Trigger_MSC_ID_2=@Trigger_MSC_ID_2,");
			strSql.Append("Trigger_MSC_ID_3=@Trigger_MSC_ID_3,");
			strSql.Append("Trigger_Threshold_LowLimit=@Trigger_Threshold_LowLimit,");
			strSql.Append("Trigger_Threshold_UpperLimit=@Trigger_Threshold_UpperLimit");
			strSql.Append(" where Trigger_Facility_ID=@Trigger_Facility_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Trigger_MSC_ID_1", SqlDbType.Int,4),
					new SqlParameter("@Trigger_MSC_ID_2", SqlDbType.Int,4),
					new SqlParameter("@Trigger_MSC_ID_3", SqlDbType.Int,4),
					new SqlParameter("@Trigger_Threshold_LowLimit", SqlDbType.Float,8),
					new SqlParameter("@Trigger_Threshold_UpperLimit", SqlDbType.Float,8),
					new SqlParameter("@Trigger_Facility_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Trigger_MSC_ID_1;
			parameters[1].Value = model.Trigger_MSC_ID_2;
			parameters[2].Value = model.Trigger_MSC_ID_3;
			parameters[3].Value = model.Trigger_Threshold_LowLimit;
			parameters[4].Value = model.Trigger_Threshold_UpperLimit;
			parameters[5].Value = model.Trigger_Facility_ID;

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
		public bool Delete(int Trigger_Facility_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Auto_Irrigate_Trigger ");
			strSql.Append(" where Trigger_Facility_ID=@Trigger_Facility_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Trigger_Facility_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Trigger_Facility_ID;

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
		public bool DeleteList(string Trigger_Facility_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Auto_Irrigate_Trigger ");
			strSql.Append(" where Trigger_Facility_ID in ("+Trigger_Facility_IDlist + ")  ");
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
		public AutoIrrigateTriggerEntity GetModel(int Trigger_Facility_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Trigger_Facility_ID,Trigger_MSC_ID_1,Trigger_MSC_ID_2,Trigger_MSC_ID_3,Trigger_Threshold_LowLimit,Trigger_Threshold_UpperLimit from Auto_Irrigate_Trigger ");
			strSql.Append(" where Trigger_Facility_ID=@Trigger_Facility_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Trigger_Facility_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Trigger_Facility_ID;

			AutoIrrigateTriggerEntity model=new AutoIrrigateTriggerEntity();
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
		public AutoIrrigateTriggerEntity DataRowToModel(DataRow row)
		{
			AutoIrrigateTriggerEntity model=new AutoIrrigateTriggerEntity();
			if (row != null)
			{
				if(row["Trigger_Facility_ID"]!=null && row["Trigger_Facility_ID"].ToString()!="")
				{
					model.Trigger_Facility_ID=int.Parse(row["Trigger_Facility_ID"].ToString());
				}
				if(row["Trigger_MSC_ID_1"]!=null && row["Trigger_MSC_ID_1"].ToString()!="")
				{
					model.Trigger_MSC_ID_1=int.Parse(row["Trigger_MSC_ID_1"].ToString());
				}
				if(row["Trigger_MSC_ID_2"]!=null && row["Trigger_MSC_ID_2"].ToString()!="")
				{
					model.Trigger_MSC_ID_2=int.Parse(row["Trigger_MSC_ID_2"].ToString());
				}
				if(row["Trigger_MSC_ID_3"]!=null && row["Trigger_MSC_ID_3"].ToString()!="")
				{
					model.Trigger_MSC_ID_3=int.Parse(row["Trigger_MSC_ID_3"].ToString());
				}
				if(row["Trigger_Threshold_LowLimit"]!=null && row["Trigger_Threshold_LowLimit"].ToString()!="")
				{
					model.Trigger_Threshold_LowLimit=decimal.Parse(row["Trigger_Threshold_LowLimit"].ToString());
				}
				if(row["Trigger_Threshold_UpperLimit"]!=null && row["Trigger_Threshold_UpperLimit"].ToString()!="")
				{
					model.Trigger_Threshold_UpperLimit=decimal.Parse(row["Trigger_Threshold_UpperLimit"].ToString());
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
			strSql.Append("select Trigger_Facility_ID,Trigger_MSC_ID_1,Trigger_MSC_ID_2,Trigger_MSC_ID_3,Trigger_Threshold_LowLimit,Trigger_Threshold_UpperLimit ");
			strSql.Append(" FROM Auto_Irrigate_Trigger ");
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
			strSql.Append(" Trigger_Facility_ID,Trigger_MSC_ID_1,Trigger_MSC_ID_2,Trigger_MSC_ID_3,Trigger_Threshold_LowLimit,Trigger_Threshold_UpperLimit ");
			strSql.Append(" FROM Auto_Irrigate_Trigger ");
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
			strSql.Append("select count(1) FROM Auto_Irrigate_Trigger ");
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
				strSql.Append("order by T.Trigger_Facility_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Auto_Irrigate_Trigger T ");
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
			parameters[0].Value = "Auto_Irrigate_Trigger";
			parameters[1].Value = "Trigger_Facility_ID";
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

