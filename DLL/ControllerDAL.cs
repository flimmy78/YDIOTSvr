/**  版本信息模板在安装目录下，可自行修改。
* Controller.cs
*
* 功 能： N/A
* 类 名： Controller
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
	/// 数据访问类:Controller
	/// </summary>
	public partial class ControllerDAL
	{
		public ControllerDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Cn_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Controller");
			strSql.Append(" where Cn_ID=@Cn_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Cn_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Cn_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ControllerEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Controller(");
			strSql.Append("Cn_ID,DTU_ID,Cn_addr,Cp_ID,Cn_longitude,Cn_dimensionality)");
			strSql.Append(" values (");
			strSql.Append("@Cn_ID,@DTU_ID,@Cn_addr,@Cp_ID,@Cn_longitude,@Cn_dimensionality)");
			SqlParameter[] parameters = {
					new SqlParameter("@Cn_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cn_addr", SqlDbType.Int,4),
					new SqlParameter("@Cp_ID", SqlDbType.Int,4),
					new SqlParameter("@Cn_longitude", SqlDbType.NVarChar,50),
					new SqlParameter("@Cn_dimensionality", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Cn_ID;
			parameters[1].Value = model.DTU_ID;
			parameters[2].Value = model.Cn_addr;
			parameters[3].Value = model.Cp_ID;
			parameters[4].Value = model.Cn_longitude;
			parameters[5].Value = model.Cn_dimensionality;

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
		public bool Update(ControllerEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Controller set ");
			strSql.Append("DTU_ID=@DTU_ID,");
			strSql.Append("Cn_addr=@Cn_addr,");
			strSql.Append("Cp_ID=@Cp_ID,");
			strSql.Append("Cn_longitude=@Cn_longitude,");
			strSql.Append("Cn_dimensionality=@Cn_dimensionality");
			strSql.Append(" where Cn_ID=@Cn_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Cn_addr", SqlDbType.Int,4),
					new SqlParameter("@Cp_ID", SqlDbType.Int,4),
					new SqlParameter("@Cn_longitude", SqlDbType.NVarChar,50),
					new SqlParameter("@Cn_dimensionality", SqlDbType.NVarChar,50),
					new SqlParameter("@Cn_ID", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.DTU_ID;
			parameters[1].Value = model.Cn_addr;
			parameters[2].Value = model.Cp_ID;
			parameters[3].Value = model.Cn_longitude;
			parameters[4].Value = model.Cn_dimensionality;
			parameters[5].Value = model.Cn_ID;

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
		public bool Delete(string Cn_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Controller ");
			strSql.Append(" where Cn_ID=@Cn_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Cn_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Cn_ID;

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
		public bool DeleteList(string Cn_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Controller ");
			strSql.Append(" where Cn_ID in ("+Cn_IDlist + ")  ");
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
		public ControllerEntity GetModel(string Cn_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Cn_ID,DTU_ID,Cn_addr,Cp_ID,Cn_longitude,Cn_dimensionality from Controller ");
			strSql.Append(" where Cn_ID=@Cn_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Cn_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Cn_ID;

			ControllerEntity model=new ControllerEntity();
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
		public ControllerEntity DataRowToModel(DataRow row)
		{
			ControllerEntity model=new ControllerEntity();
			if (row != null)
			{
				if(row["Cn_ID"]!=null)
				{
					model.Cn_ID=row["Cn_ID"].ToString();
				}
				if(row["DTU_ID"]!=null)
				{
					model.DTU_ID=row["DTU_ID"].ToString();
				}
				if(row["Cn_addr"]!=null && row["Cn_addr"].ToString()!="")
				{
					model.Cn_addr=int.Parse(row["Cn_addr"].ToString());
				}
				if(row["Cp_ID"]!=null && row["Cp_ID"].ToString()!="")
				{
					model.Cp_ID=int.Parse(row["Cp_ID"].ToString());
				}
				if(row["Cn_longitude"]!=null)
				{
					model.Cn_longitude=row["Cn_longitude"].ToString();
				}
				if(row["Cn_dimensionality"]!=null)
				{
					model.Cn_dimensionality=row["Cn_dimensionality"].ToString();
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
			strSql.Append("select Cn_ID,DTU_ID,Cn_addr,Cp_ID,Cn_longitude,Cn_dimensionality ");
			strSql.Append(" FROM Controller ");
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
			strSql.Append(" Cn_ID,DTU_ID,Cn_addr,Cp_ID,Cn_longitude,Cn_dimensionality ");
			strSql.Append(" FROM Controller ");
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
			strSql.Append("select count(1) FROM Controller ");
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
				strSql.Append("order by T.Cn_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Controller T ");
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
			parameters[0].Value = "Controller";
			parameters[1].Value = "Cn_ID";
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

