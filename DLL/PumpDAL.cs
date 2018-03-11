/**  版本信息模板在安装目录下，可自行修改。
* Pump.cs
*
* 功 能： N/A
* 类 名： Pump
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
	/// 数据访问类:PumpDAL
	/// </summary>
	public partial class PumpDAL
	{
        public PumpDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(PumpEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Pump(");
			strSql.Append("Pump_Name,Pump_longitude,Pump_dimensionality,Pump_Description,Pump_area,Msc_ID,Pump_Brand,Pump_Specification,Pump_Power,Pump_Flow,Pump_Diameter,Pump_Manufacturer)");
			strSql.Append(" values (");
			strSql.Append("@Pump_Name,@Pump_longitude,@Pump_dimensionality,@Pump_Description,@Pump_area,@Msc_ID,@Pump_Brand,@Pump_Specification,@Pump_Power,@Pump_Flow,@Pump_Diameter,@Pump_Manufacturer)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Pump_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_longitude", SqlDbType.Float,8),
					new SqlParameter("@Pump_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@Pump_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_area", SqlDbType.NVarChar,50),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Pump_Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_Specification", SqlDbType.NVarChar,150),
					new SqlParameter("@Pump_Power", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_Flow", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_Diameter", SqlDbType.NChar,10),
					new SqlParameter("@Pump_Manufacturer", SqlDbType.NChar,10)};
			parameters[0].Value = model.Pump_Name;
			parameters[1].Value = model.Pump_longitude;
			parameters[2].Value = model.Pump_dimensionality;
			parameters[3].Value = model.Pump_Description;
			parameters[4].Value = model.Pump_area;
			parameters[5].Value = model.Msc_ID;
			parameters[6].Value = model.Pump_Brand;
			parameters[7].Value = model.Pump_Specification;
			parameters[8].Value = model.Pump_Power;
			parameters[9].Value = model.Pump_Flow;
			parameters[10].Value = model.Pump_Diameter;
			parameters[11].Value = model.Pump_Manufacturer;

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
		public bool Update(PumpEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Pump set ");
			strSql.Append("Pump_Name=@Pump_Name,");
			strSql.Append("Pump_longitude=@Pump_longitude,");
			strSql.Append("Pump_dimensionality=@Pump_dimensionality,");
			strSql.Append("Pump_Description=@Pump_Description,");
			strSql.Append("Pump_area=@Pump_area,");
			strSql.Append("Msc_ID=@Msc_ID,");
			strSql.Append("Pump_Brand=@Pump_Brand,");
			strSql.Append("Pump_Specification=@Pump_Specification,");
			strSql.Append("Pump_Power=@Pump_Power,");
			strSql.Append("Pump_Flow=@Pump_Flow,");
			strSql.Append("Pump_Diameter=@Pump_Diameter,");
			strSql.Append("Pump_Manufacturer=@Pump_Manufacturer");
			strSql.Append(" where Pump_ID=@Pump_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Pump_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_longitude", SqlDbType.Float,8),
					new SqlParameter("@Pump_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@Pump_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_area", SqlDbType.NVarChar,50),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Pump_Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_Specification", SqlDbType.NVarChar,150),
					new SqlParameter("@Pump_Power", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_Flow", SqlDbType.NVarChar,50),
					new SqlParameter("@Pump_Diameter", SqlDbType.NChar,10),
					new SqlParameter("@Pump_Manufacturer", SqlDbType.NChar,10),
					new SqlParameter("@Pump_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Pump_Name;
			parameters[1].Value = model.Pump_longitude;
			parameters[2].Value = model.Pump_dimensionality;
			parameters[3].Value = model.Pump_Description;
			parameters[4].Value = model.Pump_area;
			parameters[5].Value = model.Msc_ID;
			parameters[6].Value = model.Pump_Brand;
			parameters[7].Value = model.Pump_Specification;
			parameters[8].Value = model.Pump_Power;
			parameters[9].Value = model.Pump_Flow;
			parameters[10].Value = model.Pump_Diameter;
			parameters[11].Value = model.Pump_Manufacturer;
			parameters[12].Value = model.Pump_ID;

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
		public bool Delete(int Pump_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Pump ");
			strSql.Append(" where Pump_ID=@Pump_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Pump_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Pump_ID;

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
		public bool DeleteList(string Pump_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Pump ");
			strSql.Append(" where Pump_ID in ("+Pump_IDlist + ")  ");
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
		public PumpEntity GetModel(int Pump_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Pump_ID,Pump_Name,Pump_longitude,Pump_dimensionality,Pump_Description,Pump_area,Msc_ID,Pump_Brand,Pump_Specification,Pump_Power,Pump_Flow,Pump_Diameter,Pump_Manufacturer from Pump ");
			strSql.Append(" where Pump_ID=@Pump_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Pump_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Pump_ID;

			PumpEntity model=new PumpEntity();
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
		public PumpEntity DataRowToModel(DataRow row)
		{
			PumpEntity model=new PumpEntity();
			if (row != null)
			{
				if(row["Pump_ID"]!=null && row["Pump_ID"].ToString()!="")
				{
					model.Pump_ID=int.Parse(row["Pump_ID"].ToString());
				}
				if(row["Pump_Name"]!=null)
				{
					model.Pump_Name=row["Pump_Name"].ToString();
				}
				if(row["Pump_longitude"]!=null && row["Pump_longitude"].ToString()!="")
				{
					model.Pump_longitude=decimal.Parse(row["Pump_longitude"].ToString());
				}
				if(row["Pump_dimensionality"]!=null && row["Pump_dimensionality"].ToString()!="")
				{
					model.Pump_dimensionality=decimal.Parse(row["Pump_dimensionality"].ToString());
				}
				if(row["Pump_Description"]!=null)
				{
					model.Pump_Description=row["Pump_Description"].ToString();
				}
				if(row["Pump_area"]!=null)
				{
					model.Pump_area=row["Pump_area"].ToString();
				}
				if(row["Msc_ID"]!=null && row["Msc_ID"].ToString()!="")
				{
					model.Msc_ID=int.Parse(row["Msc_ID"].ToString());
				}
				if(row["Pump_Brand"]!=null)
				{
					model.Pump_Brand=row["Pump_Brand"].ToString();
				}
				if(row["Pump_Specification"]!=null)
				{
					model.Pump_Specification=row["Pump_Specification"].ToString();
				}
				if(row["Pump_Power"]!=null)
				{
					model.Pump_Power=row["Pump_Power"].ToString();
				}
				if(row["Pump_Flow"]!=null)
				{
					model.Pump_Flow=row["Pump_Flow"].ToString();
				}
				if(row["Pump_Diameter"]!=null)
				{
					model.Pump_Diameter=row["Pump_Diameter"].ToString();
				}
				if(row["Pump_Manufacturer"]!=null)
				{
					model.Pump_Manufacturer=row["Pump_Manufacturer"].ToString();
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
			strSql.Append("select Pump_ID,Pump_Name,Pump_longitude,Pump_dimensionality,Pump_Description,Pump_area,Msc_ID,Pump_Brand,Pump_Specification,Pump_Power,Pump_Flow,Pump_Diameter,Pump_Manufacturer ");
			strSql.Append(" FROM Pump ");
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
			strSql.Append(" Pump_ID,Pump_Name,Pump_longitude,Pump_dimensionality,Pump_Description,Pump_area,Msc_ID,Pump_Brand,Pump_Specification,Pump_Power,Pump_Flow,Pump_Diameter,Pump_Manufacturer ");
			strSql.Append(" FROM Pump ");
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
			strSql.Append("select count(1) FROM Pump ");
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
				strSql.Append("order by T.Pump_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Pump T ");
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
			parameters[0].Value = "Pump";
			parameters[1].Value = "Pump_ID";
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

