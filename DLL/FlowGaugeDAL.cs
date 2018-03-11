/**  版本信息模板在安装目录下，可自行修改。
* FlowGauge.cs
*
* 功 能： N/A
* 类 名： FlowGauge
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:30   N/A    初版
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
	/// 数据访问类:FlowGauge
	/// </summary>
	public partial class FlowGaugeDAL
	{
		public FlowGaugeDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FlowGauge_ID", "FlowGauge"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FlowGauge_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FlowGauge");
			strSql.Append(" where FlowGauge_ID=@FlowGauge_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FlowGauge_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = FlowGauge_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(FlowGaugeEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FlowGauge(");
			strSql.Append("FG_Name,FG_longitude,FG_dimensionality,FG_Description,Msc_ID,FG_Brand,FG_Specification,FG_Manufacturer)");
			strSql.Append(" values (");
			strSql.Append("@FG_Name,@FG_longitude,@FG_dimensionality,@FG_Description,@Msc_ID,@FG_Brand,@FG_Specification,@FG_Manufacturer)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FG_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FG_longitude", SqlDbType.Float,8),
					new SqlParameter("@FG_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@FG_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@FG_Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@FG_Specification", SqlDbType.NVarChar,150),
					new SqlParameter("@FG_Manufacturer", SqlDbType.NChar,10)};
			parameters[0].Value = model.FG_Name;
			parameters[1].Value = model.FG_longitude;
			parameters[2].Value = model.FG_dimensionality;
			parameters[3].Value = model.FG_Description;
			parameters[4].Value = model.Msc_ID;
			parameters[5].Value = model.FG_Brand;
			parameters[6].Value = model.FG_Specification;
			parameters[7].Value = model.FG_Manufacturer;

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
		public bool Update(FlowGaugeEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FlowGauge set ");
			strSql.Append("FG_Name=@FG_Name,");
			strSql.Append("FG_longitude=@FG_longitude,");
			strSql.Append("FG_dimensionality=@FG_dimensionality,");
			strSql.Append("FG_Description=@FG_Description,");
			strSql.Append("Msc_ID=@Msc_ID,");
			strSql.Append("FG_Brand=@FG_Brand,");
			strSql.Append("FG_Specification=@FG_Specification,");
			strSql.Append("FG_Manufacturer=@FG_Manufacturer");
			strSql.Append(" where FlowGauge_ID=@FlowGauge_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FG_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FG_longitude", SqlDbType.Float,8),
					new SqlParameter("@FG_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@FG_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@FG_Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@FG_Specification", SqlDbType.NVarChar,150),
					new SqlParameter("@FG_Manufacturer", SqlDbType.NChar,10),
					new SqlParameter("@FlowGauge_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.FG_Name;
			parameters[1].Value = model.FG_longitude;
			parameters[2].Value = model.FG_dimensionality;
			parameters[3].Value = model.FG_Description;
			parameters[4].Value = model.Msc_ID;
			parameters[5].Value = model.FG_Brand;
			parameters[6].Value = model.FG_Specification;
			parameters[7].Value = model.FG_Manufacturer;
			parameters[8].Value = model.FlowGauge_ID;

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
		public bool Delete(int FlowGauge_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FlowGauge ");
			strSql.Append(" where FlowGauge_ID=@FlowGauge_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FlowGauge_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = FlowGauge_ID;

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
		public bool DeleteList(string FlowGauge_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FlowGauge ");
			strSql.Append(" where FlowGauge_ID in ("+FlowGauge_IDlist + ")  ");
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
		public FlowGaugeEntity GetModel(int FlowGauge_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FlowGauge_ID,FG_Name,FG_longitude,FG_dimensionality,FG_Description,Msc_ID,FG_Brand,FG_Specification,FG_Manufacturer from FlowGauge ");
			strSql.Append(" where FlowGauge_ID=@FlowGauge_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FlowGauge_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = FlowGauge_ID;

			FlowGaugeEntity model=new FlowGaugeEntity();
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
		public FlowGaugeEntity DataRowToModel(DataRow row)
		{
			FlowGaugeEntity model=new FlowGaugeEntity();
			if (row != null)
			{
				if(row["FlowGauge_ID"]!=null && row["FlowGauge_ID"].ToString()!="")
				{
					model.FlowGauge_ID=int.Parse(row["FlowGauge_ID"].ToString());
				}
				if(row["FG_Name"]!=null)
				{
					model.FG_Name=row["FG_Name"].ToString();
				}
				if(row["FG_longitude"]!=null && row["FG_longitude"].ToString()!="")
				{
					model.FG_longitude=decimal.Parse(row["FG_longitude"].ToString());
				}
				if(row["FG_dimensionality"]!=null && row["FG_dimensionality"].ToString()!="")
				{
					model.FG_dimensionality=decimal.Parse(row["FG_dimensionality"].ToString());
				}
				if(row["FG_Description"]!=null)
				{
					model.FG_Description=row["FG_Description"].ToString();
				}
				if(row["Msc_ID"]!=null && row["Msc_ID"].ToString()!="")
				{
					model.Msc_ID=int.Parse(row["Msc_ID"].ToString());
				}
				if(row["FG_Brand"]!=null)
				{
					model.FG_Brand=row["FG_Brand"].ToString();
				}
				if(row["FG_Specification"]!=null)
				{
					model.FG_Specification=row["FG_Specification"].ToString();
				}
				if(row["FG_Manufacturer"]!=null)
				{
					model.FG_Manufacturer=row["FG_Manufacturer"].ToString();
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
			strSql.Append("select FlowGauge_ID,FG_Name,FG_longitude,FG_dimensionality,FG_Description,Msc_ID,FG_Brand,FG_Specification,FG_Manufacturer ");
			strSql.Append(" FROM FlowGauge ");
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
			strSql.Append(" FlowGauge_ID,FG_Name,FG_longitude,FG_dimensionality,FG_Description,Msc_ID,FG_Brand,FG_Specification,FG_Manufacturer ");
			strSql.Append(" FROM FlowGauge ");
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
			strSql.Append("select count(1) FROM FlowGauge ");
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
				strSql.Append("order by T.FlowGauge_ID desc");
			}
			strSql.Append(")AS Row, T.*  from FlowGauge T ");
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
			parameters[0].Value = "FlowGauge";
			parameters[1].Value = "FlowGauge_ID";
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

