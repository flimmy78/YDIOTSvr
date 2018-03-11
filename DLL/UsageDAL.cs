/**  版本信息模板在安装目录下，可自行修改。
* Usage.cs
*
* 功 能： N/A
* 类 名： Usage
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:44   N/A    初版
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
    /// 数据访问类:UsageDAL
	/// </summary>
	public partial class UsageDAL
	{
        public UsageDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Usage_ID", "Usage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Usage_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Usage");
			strSql.Append(" where Usage_ID=@Usage_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Usage_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(UsageEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Usage(");
			strSql.Append("Usage_Name,Usage_Dict)");
			strSql.Append(" values (");
			strSql.Append("@Usage_Name,@Usage_Dict)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Usage_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Usage_Dict", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Usage_Name;
			parameters[1].Value = model.Usage_Dict;

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
		public bool Update(UsageEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Usage set ");
			strSql.Append("Usage_Name=@Usage_Name,");
			strSql.Append("Usage_Dict=@Usage_Dict");
			strSql.Append(" where Usage_ID=@Usage_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Usage_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Usage_Dict", SqlDbType.NVarChar,50),
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Usage_Name;
			parameters[1].Value = model.Usage_Dict;
			parameters[2].Value = model.Usage_ID;

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
		public bool Delete(int Usage_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Usage ");
			strSql.Append(" where Usage_ID=@Usage_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Usage_ID;

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
		public bool DeleteList(string Usage_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Usage ");
			strSql.Append(" where Usage_ID in ("+Usage_IDlist + ")  ");
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
		public UsageEntity GetModel(int Usage_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Usage_ID,Usage_Name,Usage_Dict from Usage ");
			strSql.Append(" where Usage_ID=@Usage_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Usage_ID;

			UsageEntity model=new UsageEntity();
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
		public UsageEntity DataRowToModel(DataRow row)
		{
			UsageEntity model=new UsageEntity();
			if (row != null)
			{
				if(row["Usage_ID"]!=null && row["Usage_ID"].ToString()!="")
				{
					model.Usage_ID=int.Parse(row["Usage_ID"].ToString());
				}
				if(row["Usage_Name"]!=null)
				{
					model.Usage_Name=row["Usage_Name"].ToString();
				}
				if(row["Usage_Dict"]!=null)
				{
					model.Usage_Dict=row["Usage_Dict"].ToString();
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
			strSql.Append("select Usage_ID,Usage_Name,Usage_Dict ");
			strSql.Append(" FROM Usage ");
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
			strSql.Append(" Usage_ID,Usage_Name,Usage_Dict ");
			strSql.Append(" FROM Usage ");
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
			strSql.Append("select count(1) FROM Usage ");
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
				strSql.Append("order by T.Usage_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Usage T ");
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
			parameters[0].Value = "Usage";
			parameters[1].Value = "Usage_ID";
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

