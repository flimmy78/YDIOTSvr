/**  版本信息模板在安装目录下，可自行修改。
* User_log.cs
*
* 功 能： N/A
* 类 名： User_log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:46   N/A    初版
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
    /// 数据访问类:UserLogDAL
	/// </summary>
	public partial class UserLogDAL
	{
        public UserLogDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Ur_ID", "User_log"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Ur_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from User_log");
			strSql.Append(" where Ur_ID=@Ur_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Ur_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Ur_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(UserLogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into User_log(");
			strSql.Append("Us_ID,Us_operator,Us_object,Us_time)");
			strSql.Append(" values (");
			strSql.Append("@Us_ID,@Us_operator,@Us_object,@Us_time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Us_ID", SqlDbType.Int,4),
					new SqlParameter("@Us_operator", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_object", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_time", SqlDbType.DateTime)};
			parameters[0].Value = model.Us_ID;
			parameters[1].Value = model.Us_operator;
			parameters[2].Value = model.Us_object;
			parameters[3].Value = model.Us_time;

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
		public bool Update(UserLogEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update User_log set ");
			strSql.Append("Us_ID=@Us_ID,");
			strSql.Append("Us_operator=@Us_operator,");
			strSql.Append("Us_object=@Us_object,");
			strSql.Append("Us_time=@Us_time");
			strSql.Append(" where Ur_ID=@Ur_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Us_ID", SqlDbType.Int,4),
					new SqlParameter("@Us_operator", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_object", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_time", SqlDbType.DateTime),
					new SqlParameter("@Ur_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Us_ID;
			parameters[1].Value = model.Us_operator;
			parameters[2].Value = model.Us_object;
			parameters[3].Value = model.Us_time;
			parameters[4].Value = model.Ur_ID;

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
		public bool Delete(int Ur_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from User_log ");
			strSql.Append(" where Ur_ID=@Ur_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Ur_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Ur_ID;

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
		public bool DeleteList(string Ur_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from User_log ");
			strSql.Append(" where Ur_ID in ("+Ur_IDlist + ")  ");
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
        public UserLogEntity GetModel(int Ur_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Ur_ID,Us_ID,Us_operator,Us_object,Us_time from User_log ");
			strSql.Append(" where Ur_ID=@Ur_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Ur_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Ur_ID;

            UserLogEntity model = new UserLogEntity();
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
        public UserLogEntity DataRowToModel(DataRow row)
		{
            UserLogEntity model = new UserLogEntity();
			if (row != null)
			{
				if(row["Ur_ID"]!=null && row["Ur_ID"].ToString()!="")
				{
					model.Ur_ID=int.Parse(row["Ur_ID"].ToString());
				}
				if(row["Us_ID"]!=null && row["Us_ID"].ToString()!="")
				{
					model.Us_ID=int.Parse(row["Us_ID"].ToString());
				}
				if(row["Us_operator"]!=null)
				{
					model.Us_operator=row["Us_operator"].ToString();
				}
				if(row["Us_object"]!=null)
				{
					model.Us_object=row["Us_object"].ToString();
				}
				if(row["Us_time"]!=null && row["Us_time"].ToString()!="")
				{
					model.Us_time=DateTime.Parse(row["Us_time"].ToString());
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
			strSql.Append("select Ur_ID,Us_ID,Us_operator,Us_object,Us_time ");
			strSql.Append(" FROM User_log ");
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
			strSql.Append(" Ur_ID,Us_ID,Us_operator,Us_object,Us_time ");
			strSql.Append(" FROM User_log ");
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
			strSql.Append("select count(1) FROM User_log ");
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
				strSql.Append("order by T.Ur_ID desc");
			}
			strSql.Append(")AS Row, T.*  from User_log T ");
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
			parameters[0].Value = "User_log";
			parameters[1].Value = "Ur_ID";
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

