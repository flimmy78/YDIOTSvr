/**  版本信息模板在安装目录下，可自行修改。
* DTU.cs
*
* 功 能： N/A
* 类 名： DTU
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:28   N/A    初版
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
	/// 数据访问类:DTU
	/// </summary>
	public partial class DTUDAL
	{
		public DTUDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string DTU_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DTU");
			strSql.Append(" where DTU_ID=@DTU_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = DTU_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DTUEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DTU(");
			strSql.Append("DTU_ID,DTU_tp_ID,Vi_ID,DTU_name,DTU_longitude,DTU_dimensionality,DTU_sim,Mo_ID,polling-delay-time,polling-time,GP_ID)");
			strSql.Append(" values (");
			strSql.Append("@DTU_ID,@DTU_tp_ID,@Vi_ID,@DTU_name,@DTU_longitude,@DTU_dimensionality,@DTU_sim,@Mo_ID,@polling-delay-time,@polling-time,@GP_ID)");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_tp_ID", SqlDbType.Int,4),
					new SqlParameter("@Vi_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_name", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_longitude", SqlDbType.Float,8),
					new SqlParameter("@DTU_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@DTU_sim", SqlDbType.NVarChar,50),
					new SqlParameter("@Mo_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@polling-delay-time", SqlDbType.Int,4),
					new SqlParameter("@polling-time", SqlDbType.Int,4),
					new SqlParameter("@GP_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.DTU_ID;
			parameters[1].Value = model.DTU_tp_ID;
			parameters[2].Value = model.Vi_ID;
			parameters[3].Value = model.DTU_name;
			parameters[4].Value = model.DTU_longitude;
			parameters[5].Value = model.DTU_dimensionality;
			parameters[6].Value = model.DTU_sim;
			parameters[7].Value = model.Mo_ID;
			parameters[8].Value = model.polling_delay_time;
			parameters[9].Value = model.polling_time;
			parameters[10].Value = model.GP_ID;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(DTUEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DTU set ");
			strSql.Append("DTU_tp_ID=@DTU_tp_ID,");
			strSql.Append("Vi_ID=@Vi_ID,");
			strSql.Append("DTU_name=@DTU_name,");
			strSql.Append("DTU_longitude=@DTU_longitude,");
			strSql.Append("DTU_dimensionality=@DTU_dimensionality,");
			strSql.Append("DTU_sim=@DTU_sim,");
			strSql.Append("Mo_ID=@Mo_ID,");
			strSql.Append("polling-delay-time=@polling-delay-time,");
			strSql.Append("polling-time=@polling-time,");
			strSql.Append("GP_ID=@GP_ID");
			strSql.Append(" where DTU_ID=@DTU_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_tp_ID", SqlDbType.Int,4),
					new SqlParameter("@Vi_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_name", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_longitude", SqlDbType.Float,8),
					new SqlParameter("@DTU_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@DTU_sim", SqlDbType.NVarChar,50),
					new SqlParameter("@Mo_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@polling-delay-time", SqlDbType.Int,4),
					new SqlParameter("@polling-time", SqlDbType.Int,4),
					new SqlParameter("@GP_ID", SqlDbType.Int,4),
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.DTU_tp_ID;
			parameters[1].Value = model.Vi_ID;
			parameters[2].Value = model.DTU_name;
			parameters[3].Value = model.DTU_longitude;
			parameters[4].Value = model.DTU_dimensionality;
			parameters[5].Value = model.DTU_sim;
			parameters[6].Value = model.Mo_ID;
			parameters[7].Value = model.polling_delay_time;
			parameters[8].Value = model.polling_time;
			parameters[9].Value = model.GP_ID;
			parameters[10].Value = model.DTU_ID;

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
		public bool Delete(string DTU_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DTU ");
			strSql.Append(" where DTU_ID=@DTU_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = DTU_ID;

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
		public bool DeleteList(string DTU_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DTU ");
			strSql.Append(" where DTU_ID in ("+DTU_IDlist + ")  ");
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
		public DTUEntity GetModel(string DTU_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DTU_ID,DTU_tp_ID,Vi_ID,DTU_name,DTU_longitude,DTU_dimensionality,DTU_sim,Mo_ID,polling-delay-time,polling-time,GP_ID from DTU ");
			strSql.Append(" where DTU_ID=@DTU_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = DTU_ID;

			DTUEntity model=new DTUEntity();
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
		public DTUEntity DataRowToModel(DataRow row)
		{
			DTUEntity model=new DTUEntity();
			if (row != null)
			{
				if(row["DTU_ID"]!=null)
				{
					model.DTU_ID=row["DTU_ID"].ToString();
				}
				if(row["DTU_tp_ID"]!=null && row["DTU_tp_ID"].ToString()!="")
				{
					model.DTU_tp_ID=int.Parse(row["DTU_tp_ID"].ToString());
				}
				if(row["Vi_ID"]!=null)
				{
					model.Vi_ID=row["Vi_ID"].ToString();
				}
				if(row["DTU_name"]!=null)
				{
					model.DTU_name=row["DTU_name"].ToString();
				}
				if(row["DTU_longitude"]!=null && row["DTU_longitude"].ToString()!="")
				{
					model.DTU_longitude=decimal.Parse(row["DTU_longitude"].ToString());
				}
				if(row["DTU_dimensionality"]!=null && row["DTU_dimensionality"].ToString()!="")
				{
					model.DTU_dimensionality=decimal.Parse(row["DTU_dimensionality"].ToString());
				}
				if(row["DTU_sim"]!=null)
				{
					model.DTU_sim=row["DTU_sim"].ToString();
				}
				if(row["Mo_ID"]!=null)
				{
					model.Mo_ID=row["Mo_ID"].ToString();
				}
				if(row["polling-delay-time"]!=null && row["polling-delay-time"].ToString()!="")
				{
					model.polling_delay_time=int.Parse(row["polling-delay-time"].ToString());
				}
				if(row["polling-time"]!=null && row["polling-time"].ToString()!="")
				{
					model.polling_time=int.Parse(row["polling-time"].ToString());
				}
				if(row["GP_ID"]!=null && row["GP_ID"].ToString()!="")
				{
					model.GP_ID=int.Parse(row["GP_ID"].ToString());
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
			strSql.Append("select DTU_ID,DTU_tp_ID,Vi_ID,DTU_name,DTU_longitude,DTU_dimensionality,DTU_sim,Mo_ID,polling-delay-time,polling-time,GP_ID ");
			strSql.Append(" FROM DTU ");
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
			strSql.Append(" DTU_ID,DTU_tp_ID,Vi_ID,DTU_name,DTU_longitude,DTU_dimensionality,DTU_sim,Mo_ID,polling-delay-time,polling-time,GP_ID ");
			strSql.Append(" FROM DTU ");
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
			strSql.Append("select count(1) FROM DTU ");
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
				strSql.Append("order by T.DTU_ID desc");
			}
			strSql.Append(")AS Row, T.*  from DTU T ");
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
			parameters[0].Value = "DTU";
			parameters[1].Value = "DTU_ID";
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

