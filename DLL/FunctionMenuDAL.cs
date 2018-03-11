/**  版本信息模板在安装目录下，可自行修改。
* FunctionMenu.cs
*
* 功 能： N/A
* 类 名： FunctionMenu
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
	/// 数据访问类:FunctionMenu
	/// </summary>
	public partial class FunctionMenuDAL
	{
        public FunctionMenuDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FM_ID", "FunctionMenu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FM_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FunctionMenu");
			strSql.Append(" where FM_ID=@FM_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FM_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = FM_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(FunctionMenuEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FunctionMenu(");
			strSql.Append("Menu_ID,FM_Operating,FM_OperDes,FM_Limits)");
			strSql.Append(" values (");
			strSql.Append("@Menu_ID,@FM_Operating,@FM_OperDes,@FM_Limits)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Menu_ID", SqlDbType.Int,4),
					new SqlParameter("@FM_Operating", SqlDbType.NVarChar,50),
					new SqlParameter("@FM_OperDes", SqlDbType.NVarChar,50),
					new SqlParameter("@FM_Limits", SqlDbType.Int,4)};
			parameters[0].Value = model.Menu_ID;
			parameters[1].Value = model.FM_Operating;
			parameters[2].Value = model.FM_OperDes;
			parameters[3].Value = model.FM_Limits;

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
		public bool Update(FunctionMenuEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FunctionMenu set ");
			strSql.Append("Menu_ID=@Menu_ID,");
			strSql.Append("FM_Operating=@FM_Operating,");
			strSql.Append("FM_OperDes=@FM_OperDes,");
			strSql.Append("FM_Limits=@FM_Limits");
			strSql.Append(" where FM_ID=@FM_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Menu_ID", SqlDbType.Int,4),
					new SqlParameter("@FM_Operating", SqlDbType.NVarChar,50),
					new SqlParameter("@FM_OperDes", SqlDbType.NVarChar,50),
					new SqlParameter("@FM_Limits", SqlDbType.Int,4),
					new SqlParameter("@FM_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Menu_ID;
			parameters[1].Value = model.FM_Operating;
			parameters[2].Value = model.FM_OperDes;
			parameters[3].Value = model.FM_Limits;
			parameters[4].Value = model.FM_ID;

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
		public bool Delete(int FM_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FunctionMenu ");
			strSql.Append(" where FM_ID=@FM_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FM_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = FM_ID;

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
		public bool DeleteList(string FM_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FunctionMenu ");
			strSql.Append(" where FM_ID in ("+FM_IDlist + ")  ");
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
		public FunctionMenuEntity GetModel(int FM_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FM_ID,Menu_ID,FM_Operating,FM_OperDes,FM_Limits from FunctionMenu ");
			strSql.Append(" where FM_ID=@FM_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FM_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = FM_ID;

			FunctionMenuEntity model=new FunctionMenuEntity();
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
		public FunctionMenuEntity DataRowToModel(DataRow row)
		{
			FunctionMenuEntity model=new FunctionMenuEntity();
			if (row != null)
			{
				if(row["FM_ID"]!=null && row["FM_ID"].ToString()!="")
				{
					model.FM_ID=int.Parse(row["FM_ID"].ToString());
				}
				if(row["Menu_ID"]!=null && row["Menu_ID"].ToString()!="")
				{
					model.Menu_ID=int.Parse(row["Menu_ID"].ToString());
				}
				if(row["FM_Operating"]!=null)
				{
					model.FM_Operating=row["FM_Operating"].ToString();
				}
				if(row["FM_OperDes"]!=null)
				{
					model.FM_OperDes=row["FM_OperDes"].ToString();
				}
				if(row["FM_Limits"]!=null && row["FM_Limits"].ToString()!="")
				{
					model.FM_Limits=int.Parse(row["FM_Limits"].ToString());
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
			strSql.Append("select FM_ID,Menu_ID,FM_Operating,FM_OperDes,FM_Limits ");
			strSql.Append(" FROM FunctionMenu ");
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
			strSql.Append(" FM_ID,Menu_ID,FM_Operating,FM_OperDes,FM_Limits ");
			strSql.Append(" FROM FunctionMenu ");
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
			strSql.Append("select count(1) FROM FunctionMenu ");
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
				strSql.Append("order by T.FM_ID desc");
			}
			strSql.Append(")AS Row, T.*  from FunctionMenu T ");
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
			parameters[0].Value = "FunctionMenu";
			parameters[1].Value = "FM_ID";
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

