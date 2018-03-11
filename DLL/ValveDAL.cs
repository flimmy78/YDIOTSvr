/**  版本信息模板在安装目录下，可自行修改。
* Valve.cs
*
* 功 能： N/A
* 类 名： Valve
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:49   N/A    初版
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
    /// 数据访问类:ValveDAL
	/// </summary>
	public partial class ValveDAL
	{
		public ValveDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ValveEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Valve(");
			strSql.Append("Valve_Name,Valve_longitude,Valve_dimensionality,Valve_Description,Msc_ID,Valve_Brand,Valve_Specification,Valve_Diameter,Valve_Manufacturer)");
			strSql.Append(" values (");
			strSql.Append("@Valve_Name,@Valve_longitude,@Valve_dimensionality,@Valve_Description,@Msc_ID,@Valve_Brand,@Valve_Specification,@Valve_Diameter,@Valve_Manufacturer)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Valve_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Valve_longitude", SqlDbType.Float,8),
					new SqlParameter("@Valve_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@Valve_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Valve_Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@Valve_Specification", SqlDbType.NVarChar,150),
					new SqlParameter("@Valve_Diameter", SqlDbType.NChar,10),
					new SqlParameter("@Valve_Manufacturer", SqlDbType.NChar,10)};
			parameters[0].Value = model.Valve_Name;
			parameters[1].Value = model.Valve_longitude;
			parameters[2].Value = model.Valve_dimensionality;
			parameters[3].Value = model.Valve_Description;
			parameters[4].Value = model.Msc_ID;
			parameters[5].Value = model.Valve_Brand;
			parameters[6].Value = model.Valve_Specification;
			parameters[7].Value = model.Valve_Diameter;
			parameters[8].Value = model.Valve_Manufacturer;

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
		public bool Update(ValveEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Valve set ");
			strSql.Append("Valve_Name=@Valve_Name,");
			strSql.Append("Valve_longitude=@Valve_longitude,");
			strSql.Append("Valve_dimensionality=@Valve_dimensionality,");
			strSql.Append("Valve_Description=@Valve_Description,");
			strSql.Append("Msc_ID=@Msc_ID,");
			strSql.Append("Valve_Brand=@Valve_Brand,");
			strSql.Append("Valve_Specification=@Valve_Specification,");
			strSql.Append("Valve_Diameter=@Valve_Diameter,");
			strSql.Append("Valve_Manufacturer=@Valve_Manufacturer");
			strSql.Append(" where Valve_ID=@Valve_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Valve_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Valve_longitude", SqlDbType.Float,8),
					new SqlParameter("@Valve_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@Valve_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Valve_Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@Valve_Specification", SqlDbType.NVarChar,150),
					new SqlParameter("@Valve_Diameter", SqlDbType.NChar,10),
					new SqlParameter("@Valve_Manufacturer", SqlDbType.NChar,10),
					new SqlParameter("@Valve_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Valve_Name;
			parameters[1].Value = model.Valve_longitude;
			parameters[2].Value = model.Valve_dimensionality;
			parameters[3].Value = model.Valve_Description;
			parameters[4].Value = model.Msc_ID;
			parameters[5].Value = model.Valve_Brand;
			parameters[6].Value = model.Valve_Specification;
			parameters[7].Value = model.Valve_Diameter;
			parameters[8].Value = model.Valve_Manufacturer;
			parameters[9].Value = model.Valve_ID;

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
		public bool Delete(int Valve_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Valve ");
			strSql.Append(" where Valve_ID=@Valve_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Valve_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Valve_ID;

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
		public bool DeleteList(string Valve_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Valve ");
			strSql.Append(" where Valve_ID in ("+Valve_IDlist + ")  ");
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
		public ValveEntity GetModel(int Valve_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Valve_ID,Valve_Name,Valve_longitude,Valve_dimensionality,Valve_Description,Msc_ID,Valve_Brand,Valve_Specification,Valve_Diameter,Valve_Manufacturer from Valve ");
			strSql.Append(" where Valve_ID=@Valve_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Valve_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Valve_ID;

			ValveEntity model=new ValveEntity();
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
		public ValveEntity DataRowToModel(DataRow row)
		{
			ValveEntity model=new ValveEntity();
			if (row != null)
			{
				if(row["Valve_ID"]!=null && row["Valve_ID"].ToString()!="")
				{
					model.Valve_ID=int.Parse(row["Valve_ID"].ToString());
				}
				if(row["Valve_Name"]!=null)
				{
					model.Valve_Name=row["Valve_Name"].ToString();
				}
				if(row["Valve_longitude"]!=null && row["Valve_longitude"].ToString()!="")
				{
					model.Valve_longitude=decimal.Parse(row["Valve_longitude"].ToString());
				}
				if(row["Valve_dimensionality"]!=null && row["Valve_dimensionality"].ToString()!="")
				{
					model.Valve_dimensionality=decimal.Parse(row["Valve_dimensionality"].ToString());
				}
				if(row["Valve_Description"]!=null)
				{
					model.Valve_Description=row["Valve_Description"].ToString();
				}
				if(row["Msc_ID"]!=null && row["Msc_ID"].ToString()!="")
				{
					model.Msc_ID=int.Parse(row["Msc_ID"].ToString());
				}
				if(row["Valve_Brand"]!=null)
				{
					model.Valve_Brand=row["Valve_Brand"].ToString();
				}
				if(row["Valve_Specification"]!=null)
				{
					model.Valve_Specification=row["Valve_Specification"].ToString();
				}
				if(row["Valve_Diameter"]!=null)
				{
					model.Valve_Diameter=row["Valve_Diameter"].ToString();
				}
				if(row["Valve_Manufacturer"]!=null)
				{
					model.Valve_Manufacturer=row["Valve_Manufacturer"].ToString();
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
			strSql.Append("select Valve_ID,Valve_Name,Valve_longitude,Valve_dimensionality,Valve_Description,Msc_ID,Valve_Brand,Valve_Specification,Valve_Diameter,Valve_Manufacturer ");
			strSql.Append(" FROM Valve ");
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
			strSql.Append(" Valve_ID,Valve_Name,Valve_longitude,Valve_dimensionality,Valve_Description,Msc_ID,Valve_Brand,Valve_Specification,Valve_Diameter,Valve_Manufacturer ");
			strSql.Append(" FROM Valve ");
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
			strSql.Append("select count(1) FROM Valve ");
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
				strSql.Append("order by T.Valve_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Valve T ");
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
			parameters[0].Value = "Valve";
			parameters[1].Value = "Valve_ID";
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

