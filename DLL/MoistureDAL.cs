/**  版本信息模板在安装目录下，可自行修改。
* moisture.cs
*
* 功 能： N/A
* 类 名： moisture
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:39   N/A    初版
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
	/// 数据访问类:moisture
	/// </summary>
	public partial class MoistureDAL
	{
		public MoistureDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MoistureEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into moisture(");
			strSql.Append("Moisture_Name,Moisture_longitude,Moisture_dimensionality,Moisture_Description,Msc_ID_Low,Msc_ID_Low_is_valid,Msc_ID_Mid,Msc_ID_Mid_is_valid,Msc_ID_Deep,Msc_ID_Deep_is_valid,Moisture_Brand,Moisture_Specification,Moisture_Unit,Moisture_Range,Moisture_Probe_Length)");
			strSql.Append(" values (");
			strSql.Append("@Moisture_Name,@Moisture_longitude,@Moisture_dimensionality,@Moisture_Description,@Msc_ID_Low,@Msc_ID_Low_is_valid,@Msc_ID_Mid,@Msc_ID_Mid_is_valid,@Msc_ID_Deep,@Msc_ID_Deep_is_valid,@Moisture_Brand,@Moisture_Specification,@Moisture_Unit,@Moisture_Range,@Moisture_Probe_Length)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Moisture_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_longitude", SqlDbType.Float,8),
					new SqlParameter("@Moisture_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@Moisture_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Msc_ID_Low", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID_Low_is_valid", SqlDbType.Bit,1),
					new SqlParameter("@Msc_ID_Mid", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID_Mid_is_valid", SqlDbType.Bit,1),
					new SqlParameter("@Msc_ID_Deep", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID_Deep_is_valid", SqlDbType.Bit,1),
					new SqlParameter("@Moisture_Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_Specification", SqlDbType.NVarChar,150),
					new SqlParameter("@Moisture_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_Range", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_Probe_Length", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Moisture_Name;
			parameters[1].Value = model.Moisture_longitude;
			parameters[2].Value = model.Moisture_dimensionality;
			parameters[3].Value = model.Moisture_Description;
			parameters[4].Value = model.Msc_ID_Low;
			parameters[5].Value = model.Msc_ID_Low_is_valid;
			parameters[6].Value = model.Msc_ID_Mid;
			parameters[7].Value = model.Msc_ID_Mid_is_valid;
			parameters[8].Value = model.Msc_ID_Deep;
			parameters[9].Value = model.Msc_ID_Deep_is_valid;
			parameters[10].Value = model.Moisture_Brand;
			parameters[11].Value = model.Moisture_Specification;
			parameters[12].Value = model.Moisture_Unit;
			parameters[13].Value = model.Moisture_Range;
			parameters[14].Value = model.Moisture_Probe_Length;

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
        public bool Update(MoistureEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update moisture set ");
			strSql.Append("Moisture_Name=@Moisture_Name,");
			strSql.Append("Moisture_longitude=@Moisture_longitude,");
			strSql.Append("Moisture_dimensionality=@Moisture_dimensionality,");
			strSql.Append("Moisture_Description=@Moisture_Description,");
			strSql.Append("Msc_ID_Low=@Msc_ID_Low,");
			strSql.Append("Msc_ID_Low_is_valid=@Msc_ID_Low_is_valid,");
			strSql.Append("Msc_ID_Mid=@Msc_ID_Mid,");
			strSql.Append("Msc_ID_Mid_is_valid=@Msc_ID_Mid_is_valid,");
			strSql.Append("Msc_ID_Deep=@Msc_ID_Deep,");
			strSql.Append("Msc_ID_Deep_is_valid=@Msc_ID_Deep_is_valid,");
			strSql.Append("Moisture_Brand=@Moisture_Brand,");
			strSql.Append("Moisture_Specification=@Moisture_Specification,");
			strSql.Append("Moisture_Unit=@Moisture_Unit,");
			strSql.Append("Moisture_Range=@Moisture_Range,");
			strSql.Append("Moisture_Probe_Length=@Moisture_Probe_Length");
			strSql.Append(" where Moisture_ID=@Moisture_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Moisture_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_longitude", SqlDbType.Float,8),
					new SqlParameter("@Moisture_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@Moisture_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Msc_ID_Low", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID_Low_is_valid", SqlDbType.Bit,1),
					new SqlParameter("@Msc_ID_Mid", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID_Mid_is_valid", SqlDbType.Bit,1),
					new SqlParameter("@Msc_ID_Deep", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID_Deep_is_valid", SqlDbType.Bit,1),
					new SqlParameter("@Moisture_Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_Specification", SqlDbType.NVarChar,150),
					new SqlParameter("@Moisture_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_Range", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_Probe_Length", SqlDbType.NVarChar,50),
					new SqlParameter("@Moisture_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Moisture_Name;
			parameters[1].Value = model.Moisture_longitude;
			parameters[2].Value = model.Moisture_dimensionality;
			parameters[3].Value = model.Moisture_Description;
			parameters[4].Value = model.Msc_ID_Low;
			parameters[5].Value = model.Msc_ID_Low_is_valid;
			parameters[6].Value = model.Msc_ID_Mid;
			parameters[7].Value = model.Msc_ID_Mid_is_valid;
			parameters[8].Value = model.Msc_ID_Deep;
			parameters[9].Value = model.Msc_ID_Deep_is_valid;
			parameters[10].Value = model.Moisture_Brand;
			parameters[11].Value = model.Moisture_Specification;
			parameters[12].Value = model.Moisture_Unit;
			parameters[13].Value = model.Moisture_Range;
			parameters[14].Value = model.Moisture_Probe_Length;
			parameters[15].Value = model.Moisture_ID;

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
		public bool Delete(int Moisture_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from moisture ");
			strSql.Append(" where Moisture_ID=@Moisture_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Moisture_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Moisture_ID;

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
		public bool DeleteList(string Moisture_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from moisture ");
			strSql.Append(" where Moisture_ID in ("+Moisture_IDlist + ")  ");
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
        public MoistureEntity GetModel(int Moisture_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Moisture_ID,Moisture_Name,Moisture_longitude,Moisture_dimensionality,Moisture_Description,Msc_ID_Low,Msc_ID_Low_is_valid,Msc_ID_Mid,Msc_ID_Mid_is_valid,Msc_ID_Deep,Msc_ID_Deep_is_valid,Moisture_Brand,Moisture_Specification,Moisture_Unit,Moisture_Range,Moisture_Probe_Length from moisture ");
			strSql.Append(" where Moisture_ID=@Moisture_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Moisture_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Moisture_ID;

            MoistureEntity model = new MoistureEntity();
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
        public MoistureEntity DataRowToModel(DataRow row)
		{
            MoistureEntity model = new MoistureEntity();
			if (row != null)
			{
				if(row["Moisture_ID"]!=null && row["Moisture_ID"].ToString()!="")
				{
					model.Moisture_ID=int.Parse(row["Moisture_ID"].ToString());
				}
				if(row["Moisture_Name"]!=null)
				{
					model.Moisture_Name=row["Moisture_Name"].ToString();
				}
				if(row["Moisture_longitude"]!=null && row["Moisture_longitude"].ToString()!="")
				{
					model.Moisture_longitude=decimal.Parse(row["Moisture_longitude"].ToString());
				}
				if(row["Moisture_dimensionality"]!=null && row["Moisture_dimensionality"].ToString()!="")
				{
					model.Moisture_dimensionality=decimal.Parse(row["Moisture_dimensionality"].ToString());
				}
				if(row["Moisture_Description"]!=null)
				{
					model.Moisture_Description=row["Moisture_Description"].ToString();
				}
				if(row["Msc_ID_Low"]!=null && row["Msc_ID_Low"].ToString()!="")
				{
					model.Msc_ID_Low=int.Parse(row["Msc_ID_Low"].ToString());
				}
				if(row["Msc_ID_Low_is_valid"]!=null && row["Msc_ID_Low_is_valid"].ToString()!="")
				{
					if((row["Msc_ID_Low_is_valid"].ToString()=="1")||(row["Msc_ID_Low_is_valid"].ToString().ToLower()=="true"))
					{
						model.Msc_ID_Low_is_valid=true;
					}
					else
					{
						model.Msc_ID_Low_is_valid=false;
					}
				}
				if(row["Msc_ID_Mid"]!=null && row["Msc_ID_Mid"].ToString()!="")
				{
					model.Msc_ID_Mid=int.Parse(row["Msc_ID_Mid"].ToString());
				}
				if(row["Msc_ID_Mid_is_valid"]!=null && row["Msc_ID_Mid_is_valid"].ToString()!="")
				{
					if((row["Msc_ID_Mid_is_valid"].ToString()=="1")||(row["Msc_ID_Mid_is_valid"].ToString().ToLower()=="true"))
					{
						model.Msc_ID_Mid_is_valid=true;
					}
					else
					{
						model.Msc_ID_Mid_is_valid=false;
					}
				}
				if(row["Msc_ID_Deep"]!=null && row["Msc_ID_Deep"].ToString()!="")
				{
					model.Msc_ID_Deep=int.Parse(row["Msc_ID_Deep"].ToString());
				}
				if(row["Msc_ID_Deep_is_valid"]!=null && row["Msc_ID_Deep_is_valid"].ToString()!="")
				{
					if((row["Msc_ID_Deep_is_valid"].ToString()=="1")||(row["Msc_ID_Deep_is_valid"].ToString().ToLower()=="true"))
					{
						model.Msc_ID_Deep_is_valid=true;
					}
					else
					{
						model.Msc_ID_Deep_is_valid=false;
					}
				}
				if(row["Moisture_Brand"]!=null)
				{
					model.Moisture_Brand=row["Moisture_Brand"].ToString();
				}
				if(row["Moisture_Specification"]!=null)
				{
					model.Moisture_Specification=row["Moisture_Specification"].ToString();
				}
				if(row["Moisture_Unit"]!=null)
				{
					model.Moisture_Unit=row["Moisture_Unit"].ToString();
				}
				if(row["Moisture_Range"]!=null)
				{
					model.Moisture_Range=row["Moisture_Range"].ToString();
				}
				if(row["Moisture_Probe_Length"]!=null)
				{
					model.Moisture_Probe_Length=row["Moisture_Probe_Length"].ToString();
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
			strSql.Append("select Moisture_ID,Moisture_Name,Moisture_longitude,Moisture_dimensionality,Moisture_Description,Msc_ID_Low,Msc_ID_Low_is_valid,Msc_ID_Mid,Msc_ID_Mid_is_valid,Msc_ID_Deep,Msc_ID_Deep_is_valid,Moisture_Brand,Moisture_Specification,Moisture_Unit,Moisture_Range,Moisture_Probe_Length ");
			strSql.Append(" FROM moisture ");
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
			strSql.Append(" Moisture_ID,Moisture_Name,Moisture_longitude,Moisture_dimensionality,Moisture_Description,Msc_ID_Low,Msc_ID_Low_is_valid,Msc_ID_Mid,Msc_ID_Mid_is_valid,Msc_ID_Deep,Msc_ID_Deep_is_valid,Moisture_Brand,Moisture_Specification,Moisture_Unit,Moisture_Range,Moisture_Probe_Length ");
			strSql.Append(" FROM moisture ");
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
			strSql.Append("select count(1) FROM moisture ");
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
				strSql.Append("order by T.Moisture_ID desc");
			}
			strSql.Append(")AS Row, T.*  from moisture T ");
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
			parameters[0].Value = "moisture";
			parameters[1].Value = "Moisture_ID";
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

