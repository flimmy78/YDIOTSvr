/**  版本信息模板在安装目录下，可自行修改。
* MainMenu_Limits.cs
*
* 功 能： N/A
* 类 名： MainMenu_Limits
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
    /// 数据访问类:MainMenuLimitsDAL
	/// </summary>
    public partial class MainMenuLimitsDAL
	{
		public MainMenuLimitsDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ML_ID", "MainMenu_Limits"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ML_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MainMenu_Limits");
			strSql.Append(" where ML_ID=@ML_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ML_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ML_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MainMenuLimitsEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MainMenu_Limits(");
			strSql.Append("Gp_ID,Rl_ID,Us_ID,Menu_ID,Limits)");
			strSql.Append(" values (");
			strSql.Append("@Gp_ID,@Rl_ID,@Us_ID,@Menu_ID,@Limits)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Gp_ID", SqlDbType.Int,4),
					new SqlParameter("@Rl_ID", SqlDbType.Int,4),
					new SqlParameter("@Us_ID", SqlDbType.Int,4),
					new SqlParameter("@Menu_ID", SqlDbType.Int,4),
					new SqlParameter("@Limits", SqlDbType.Int,4)};
			parameters[0].Value = model.Gp_ID;
			parameters[1].Value = model.Rl_ID;
			parameters[2].Value = model.Us_ID;
			parameters[3].Value = model.Menu_ID;
			parameters[4].Value = model.Limits;

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
        public bool Update(MainMenuLimitsEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MainMenu_Limits set ");
			strSql.Append("Gp_ID=@Gp_ID,");
			strSql.Append("Rl_ID=@Rl_ID,");
			strSql.Append("Us_ID=@Us_ID,");
			strSql.Append("Menu_ID=@Menu_ID,");
			strSql.Append("Limits=@Limits");
			strSql.Append(" where ML_ID=@ML_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Gp_ID", SqlDbType.Int,4),
					new SqlParameter("@Rl_ID", SqlDbType.Int,4),
					new SqlParameter("@Us_ID", SqlDbType.Int,4),
					new SqlParameter("@Menu_ID", SqlDbType.Int,4),
					new SqlParameter("@Limits", SqlDbType.Int,4),
					new SqlParameter("@ML_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Gp_ID;
			parameters[1].Value = model.Rl_ID;
			parameters[2].Value = model.Us_ID;
			parameters[3].Value = model.Menu_ID;
			parameters[4].Value = model.Limits;
			parameters[5].Value = model.ML_ID;

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
		public bool Delete(int ML_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MainMenu_Limits ");
			strSql.Append(" where ML_ID=@ML_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ML_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ML_ID;

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
		public bool DeleteList(string ML_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MainMenu_Limits ");
			strSql.Append(" where ML_ID in ("+ML_IDlist + ")  ");
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
        public MainMenuLimitsEntity GetModel(int ML_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ML_ID,Gp_ID,Rl_ID,Us_ID,Menu_ID,Limits from MainMenu_Limits ");
			strSql.Append(" where ML_ID=@ML_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ML_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ML_ID;

            MainMenuLimitsEntity model = new MainMenuLimitsEntity();
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
        public MainMenuLimitsEntity DataRowToModel(DataRow row)
		{
            MainMenuLimitsEntity model = new MainMenuLimitsEntity();
			if (row != null)
			{
				if(row["ML_ID"]!=null && row["ML_ID"].ToString()!="")
				{
					model.ML_ID=int.Parse(row["ML_ID"].ToString());
				}
				if(row["Gp_ID"]!=null && row["Gp_ID"].ToString()!="")
				{
					model.Gp_ID=int.Parse(row["Gp_ID"].ToString());
				}
				if(row["Rl_ID"]!=null && row["Rl_ID"].ToString()!="")
				{
					model.Rl_ID=int.Parse(row["Rl_ID"].ToString());
				}
				if(row["Us_ID"]!=null && row["Us_ID"].ToString()!="")
				{
					model.Us_ID=int.Parse(row["Us_ID"].ToString());
				}
				if(row["Menu_ID"]!=null && row["Menu_ID"].ToString()!="")
				{
					model.Menu_ID=int.Parse(row["Menu_ID"].ToString());
				}
				if(row["Limits"]!=null && row["Limits"].ToString()!="")
				{
					model.Limits=int.Parse(row["Limits"].ToString());
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
			strSql.Append("select ML_ID,Gp_ID,Rl_ID,Us_ID,Menu_ID,Limits ");
			strSql.Append(" FROM MainMenu_Limits ");
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
			strSql.Append(" ML_ID,Gp_ID,Rl_ID,Us_ID,Menu_ID,Limits ");
			strSql.Append(" FROM MainMenu_Limits ");
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
			strSql.Append("select count(1) FROM MainMenu_Limits ");
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
				strSql.Append("order by T.ML_ID desc");
			}
			strSql.Append(")AS Row, T.*  from MainMenu_Limits T ");
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
			parameters[0].Value = "MainMenu_Limits";
			parameters[1].Value = "ML_ID";
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

