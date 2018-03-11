/**  版本信息模板在安装目录下，可自行修改。
* FacilityType.cs
*
* 功 能： N/A
* 类 名： FacilityType
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
	/// 数据访问类:FacilityType
	/// </summary>
	public partial class FacilityTypeDAL
	{
        public FacilityTypeDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Facility_Type_ID", "FacilityType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Facility_Type_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FacilityType");
			strSql.Append(" where Facility_Type_ID=@Facility_Type_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_Type_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Facility_Type_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(FacilityTypeEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FacilityType(");
			strSql.Append("Facility_Type_Name,Facility_Type_Description,Facility_Type_Image,Facility_Type_Map_Image,Facility_Type_Function_Url,Facility_Type_Function_img)");
			strSql.Append(" values (");
			strSql.Append("@Facility_Type_Name,@Facility_Type_Description,@Facility_Type_Image,@Facility_Type_Map_Image,@Facility_Type_Function_Url,@Facility_Type_Function_img)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_Type_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Facility_Type_Description", SqlDbType.NVarChar,500),
					new SqlParameter("@Facility_Type_Image", SqlDbType.NVarChar,100),
					new SqlParameter("@Facility_Type_Map_Image", SqlDbType.NVarChar,50),
					new SqlParameter("@Facility_Type_Function_Url", SqlDbType.NVarChar,100),
					new SqlParameter("@Facility_Type_Function_img", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Facility_Type_Name;
			parameters[1].Value = model.Facility_Type_Description;
			parameters[2].Value = model.Facility_Type_Image;
			parameters[3].Value = model.Facility_Type_Map_Image;
			parameters[4].Value = model.Facility_Type_Function_Url;
			parameters[5].Value = model.Facility_Type_Function_img;

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
		public bool Update(FacilityTypeEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FacilityType set ");
			strSql.Append("Facility_Type_Name=@Facility_Type_Name,");
			strSql.Append("Facility_Type_Description=@Facility_Type_Description,");
			strSql.Append("Facility_Type_Image=@Facility_Type_Image,");
			strSql.Append("Facility_Type_Map_Image=@Facility_Type_Map_Image,");
			strSql.Append("Facility_Type_Function_Url=@Facility_Type_Function_Url,");
			strSql.Append("Facility_Type_Function_img=@Facility_Type_Function_img");
			strSql.Append(" where Facility_Type_ID=@Facility_Type_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_Type_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Facility_Type_Description", SqlDbType.NVarChar,500),
					new SqlParameter("@Facility_Type_Image", SqlDbType.NVarChar,100),
					new SqlParameter("@Facility_Type_Map_Image", SqlDbType.NVarChar,50),
					new SqlParameter("@Facility_Type_Function_Url", SqlDbType.NVarChar,100),
					new SqlParameter("@Facility_Type_Function_img", SqlDbType.NVarChar,50),
					new SqlParameter("@Facility_Type_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Facility_Type_Name;
			parameters[1].Value = model.Facility_Type_Description;
			parameters[2].Value = model.Facility_Type_Image;
			parameters[3].Value = model.Facility_Type_Map_Image;
			parameters[4].Value = model.Facility_Type_Function_Url;
			parameters[5].Value = model.Facility_Type_Function_img;
			parameters[6].Value = model.Facility_Type_ID;

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
		public bool Delete(int Facility_Type_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FacilityType ");
			strSql.Append(" where Facility_Type_ID=@Facility_Type_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_Type_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Facility_Type_ID;

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
		public bool DeleteList(string Facility_Type_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FacilityType ");
			strSql.Append(" where Facility_Type_ID in ("+Facility_Type_IDlist + ")  ");
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
		public FacilityTypeEntity GetModel(int Facility_Type_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Facility_Type_ID,Facility_Type_Name,Facility_Type_Description,Facility_Type_Image,Facility_Type_Map_Image,Facility_Type_Function_Url,Facility_Type_Function_img from FacilityType ");
			strSql.Append(" where Facility_Type_ID=@Facility_Type_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_Type_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Facility_Type_ID;

			FacilityTypeEntity model=new FacilityTypeEntity();
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
		public FacilityTypeEntity DataRowToModel(DataRow row)
		{
			FacilityTypeEntity model=new FacilityTypeEntity();
			if (row != null)
			{
				if(row["Facility_Type_ID"]!=null && row["Facility_Type_ID"].ToString()!="")
				{
					model.Facility_Type_ID=int.Parse(row["Facility_Type_ID"].ToString());
				}
				if(row["Facility_Type_Name"]!=null)
				{
					model.Facility_Type_Name=row["Facility_Type_Name"].ToString();
				}
				if(row["Facility_Type_Description"]!=null)
				{
					model.Facility_Type_Description=row["Facility_Type_Description"].ToString();
				}
				if(row["Facility_Type_Image"]!=null)
				{
					model.Facility_Type_Image=row["Facility_Type_Image"].ToString();
				}
				if(row["Facility_Type_Map_Image"]!=null)
				{
					model.Facility_Type_Map_Image=row["Facility_Type_Map_Image"].ToString();
				}
				if(row["Facility_Type_Function_Url"]!=null)
				{
					model.Facility_Type_Function_Url=row["Facility_Type_Function_Url"].ToString();
				}
				if(row["Facility_Type_Function_img"]!=null)
				{
					model.Facility_Type_Function_img=row["Facility_Type_Function_img"].ToString();
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
			strSql.Append("select Facility_Type_ID,Facility_Type_Name,Facility_Type_Description,Facility_Type_Image,Facility_Type_Map_Image,Facility_Type_Function_Url,Facility_Type_Function_img ");
			strSql.Append(" FROM FacilityType ");
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
			strSql.Append(" Facility_Type_ID,Facility_Type_Name,Facility_Type_Description,Facility_Type_Image,Facility_Type_Map_Image,Facility_Type_Function_Url,Facility_Type_Function_img ");
			strSql.Append(" FROM FacilityType ");
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
			strSql.Append("select count(1) FROM FacilityType ");
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
				strSql.Append("order by T.Facility_Type_ID desc");
			}
			strSql.Append(")AS Row, T.*  from FacilityType T ");
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
			parameters[0].Value = "FacilityType";
			parameters[1].Value = "Facility_Type_ID";
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

