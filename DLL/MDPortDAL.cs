/**  版本信息模板在安装目录下，可自行修改。
* MD_Port.cs
*
* 功 能： N/A
* 类 名： MD_Port
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:36   N/A    初版
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
    /// 数据访问类:MDPortDAL
	/// </summary>
	public partial class MDPortDAL
	{
        public MDPortDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MDPortEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MD_Port(");
			strSql.Append("MD_Type,MD_Port,Port_ID)");
			strSql.Append(" values (");
			strSql.Append("@MD_Type,@MD_Port,@Port_ID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MD_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@MD_Port", SqlDbType.NVarChar,50),
					new SqlParameter("@Port_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.MD_Type;
			parameters[1].Value = model.MD_Port;
			parameters[2].Value = model.Port_ID;

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
        public bool Update(MDPortEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MD_Port set ");
			strSql.Append("MD_Type=@MD_Type,");
			strSql.Append("MD_Port=@MD_Port,");
			strSql.Append("Port_ID=@Port_ID");
			strSql.Append(" where MP_ID=@MP_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MD_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@MD_Port", SqlDbType.NVarChar,50),
					new SqlParameter("@Port_ID", SqlDbType.Int,4),
					new SqlParameter("@MP_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.MD_Type;
			parameters[1].Value = model.MD_Port;
			parameters[2].Value = model.Port_ID;
			parameters[3].Value = model.MP_ID;

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
		public bool Delete(int MP_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MD_Port ");
			strSql.Append(" where MP_ID=@MP_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MP_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = MP_ID;

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
		public bool DeleteList(string MP_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MD_Port ");
			strSql.Append(" where MP_ID in ("+MP_IDlist + ")  ");
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
        public MDPortEntity GetModel(int MP_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MP_ID,MD_Type,MD_Port,Port_ID from MD_Port ");
			strSql.Append(" where MP_ID=@MP_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MP_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = MP_ID;

            MDPortEntity model = new MDPortEntity();
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
        public MDPortEntity DataRowToModel(DataRow row)
		{
            MDPortEntity model = new MDPortEntity();
			if (row != null)
			{
				if(row["MP_ID"]!=null && row["MP_ID"].ToString()!="")
				{
					model.MP_ID=int.Parse(row["MP_ID"].ToString());
				}
				if(row["MD_Type"]!=null)
				{
					model.MD_Type=row["MD_Type"].ToString();
				}
				if(row["MD_Port"]!=null)
				{
					model.MD_Port=row["MD_Port"].ToString();
				}
				if(row["Port_ID"]!=null && row["Port_ID"].ToString()!="")
				{
					model.Port_ID=int.Parse(row["Port_ID"].ToString());
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
			strSql.Append("select MP_ID,MD_Type,MD_Port,Port_ID ");
			strSql.Append(" FROM MD_Port ");
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
			strSql.Append(" MP_ID,MD_Type,MD_Port,Port_ID ");
			strSql.Append(" FROM MD_Port ");
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
			strSql.Append("select count(1) FROM MD_Port ");
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
				strSql.Append("order by T.MP_ID desc");
			}
			strSql.Append(")AS Row, T.*  from MD_Port T ");
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
			parameters[0].Value = "MD_Port";
			parameters[1].Value = "MP_ID";
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

