/**  版本信息模板在安装目录下，可自行修改。
* MapSite.cs
*
* 功 能： N/A
* 类 名： MapSite
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:35   N/A    初版
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
	/// 数据访问类:MapSite
	/// </summary>
	public partial class MapSiteDAL
	{
        public MapSiteDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MS_ID", "MapSite"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MS_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MapSite");
			strSql.Append(" where MS_ID=@MS_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = MS_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MapSiteEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MapSite(");
			strSql.Append("GroupID,MS_Name,MS_longitude,MS_dimensionality,MS_Description,MS_area)");
			strSql.Append(" values (");
			strSql.Append("@GroupID,@MS_Name,@MS_longitude,@MS_dimensionality,@MS_Description,@MS_area)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupID", SqlDbType.Int,4),
					new SqlParameter("@MS_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MS_longitude", SqlDbType.Float,8),
					new SqlParameter("@MS_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@MS_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@MS_area", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.GroupID;
			parameters[1].Value = model.MS_Name;
			parameters[2].Value = model.MS_longitude;
			parameters[3].Value = model.MS_dimensionality;
			parameters[4].Value = model.MS_Description;
			parameters[5].Value = model.MS_area;

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
		public bool Update(MapSiteEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MapSite set ");
			strSql.Append("GroupID=@GroupID,");
			strSql.Append("MS_Name=@MS_Name,");
			strSql.Append("MS_longitude=@MS_longitude,");
			strSql.Append("MS_dimensionality=@MS_dimensionality,");
			strSql.Append("MS_Description=@MS_Description,");
			strSql.Append("MS_area=@MS_area");
			strSql.Append(" where MS_ID=@MS_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupID", SqlDbType.Int,4),
					new SqlParameter("@MS_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MS_longitude", SqlDbType.Float,8),
					new SqlParameter("@MS_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@MS_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@MS_area", SqlDbType.NVarChar,50),
					new SqlParameter("@MS_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.GroupID;
			parameters[1].Value = model.MS_Name;
			parameters[2].Value = model.MS_longitude;
			parameters[3].Value = model.MS_dimensionality;
			parameters[4].Value = model.MS_Description;
			parameters[5].Value = model.MS_area;
			parameters[6].Value = model.MS_ID;

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
		public bool Delete(int MS_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MapSite ");
			strSql.Append(" where MS_ID=@MS_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = MS_ID;

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
		public bool DeleteList(string MS_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MapSite ");
			strSql.Append(" where MS_ID in ("+MS_IDlist + ")  ");
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
		public MapSiteEntity GetModel(int MS_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MS_ID,GroupID,MS_Name,MS_longitude,MS_dimensionality,MS_Description,MS_area from MapSite ");
			strSql.Append(" where MS_ID=@MS_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MS_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = MS_ID;

			MapSiteEntity model=new MapSiteEntity();
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
		public MapSiteEntity DataRowToModel(DataRow row)
		{
			MapSiteEntity model=new MapSiteEntity();
			if (row != null)
			{
				if(row["MS_ID"]!=null && row["MS_ID"].ToString()!="")
				{
					model.MS_ID=int.Parse(row["MS_ID"].ToString());
				}
				if(row["GroupID"]!=null && row["GroupID"].ToString()!="")
				{
					model.GroupID=int.Parse(row["GroupID"].ToString());
				}
				if(row["MS_Name"]!=null)
				{
					model.MS_Name=row["MS_Name"].ToString();
				}
				if(row["MS_longitude"]!=null && row["MS_longitude"].ToString()!="")
				{
					model.MS_longitude=decimal.Parse(row["MS_longitude"].ToString());
				}
				if(row["MS_dimensionality"]!=null && row["MS_dimensionality"].ToString()!="")
				{
					model.MS_dimensionality=decimal.Parse(row["MS_dimensionality"].ToString());
				}
				if(row["MS_Description"]!=null)
				{
					model.MS_Description=row["MS_Description"].ToString();
				}
				if(row["MS_area"]!=null)
				{
					model.MS_area=row["MS_area"].ToString();
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
			strSql.Append("select MS_ID,GroupID,MS_Name,MS_longitude,MS_dimensionality,MS_Description,MS_area ");
			strSql.Append(" FROM MapSite ");
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
			strSql.Append(" MS_ID,GroupID,MS_Name,MS_longitude,MS_dimensionality,MS_Description,MS_area ");
			strSql.Append(" FROM MapSite ");
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
			strSql.Append("select count(1) FROM MapSite ");
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
				strSql.Append("order by T.MS_ID desc");
			}
			strSql.Append(")AS Row, T.*  from MapSite T ");
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
			parameters[0].Value = "MapSite";
			parameters[1].Value = "MS_ID";
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

