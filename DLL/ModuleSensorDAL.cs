/**  版本信息模板在安装目录下，可自行修改。
* ModuleSensor.cs
*
* 功 能： N/A
* 类 名： ModuleSensor
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:38   N/A    初版
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
	/// 数据访问类:ModuleSensorDAL
	/// </summary>
	public partial class ModuleSensorDAL
	{
        public ModuleSensorDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(StationSensorEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ModuleSensor(");
			strSql.Append("Md_ID,St_ID,Md_port,Md_port_type)");
			strSql.Append(" values (");
			strSql.Append("@Md_ID,@St_ID,@Md_port,@Md_port_type)");
			SqlParameter[] parameters = {
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@St_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_port", SqlDbType.Int,4),
					new SqlParameter("@Md_port_type", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Md_ID;
			parameters[1].Value = model.St_ID;
			parameters[2].Value = model.Md_port;
			parameters[3].Value = model.Md_port_type;

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
		public bool Update(StationSensorEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ModuleSensor set ");
			strSql.Append("Md_ID=@Md_ID,");
			strSql.Append("St_ID=@St_ID,");
			strSql.Append("Md_port=@Md_port,");
			strSql.Append("Md_port_type=@Md_port_type");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@St_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_port", SqlDbType.Int,4),
					new SqlParameter("@Md_port_type", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Md_ID;
			parameters[1].Value = model.St_ID;
			parameters[2].Value = model.Md_port;
			parameters[3].Value = model.Md_port_type;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ModuleSensor ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public StationSensorEntity GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Md_ID,St_ID,Md_port,Md_port_type from ModuleSensor ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			StationSensorEntity model=new StationSensorEntity();
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
		public StationSensorEntity DataRowToModel(DataRow row)
		{
			StationSensorEntity model=new StationSensorEntity();
			if (row != null)
			{
				if(row["Md_ID"]!=null)
				{
					model.Md_ID=row["Md_ID"].ToString();
				}
				if(row["St_ID"]!=null)
				{
					model.St_ID=row["St_ID"].ToString();
				}
				if(row["Md_port"]!=null && row["Md_port"].ToString()!="")
				{
					model.Md_port=int.Parse(row["Md_port"].ToString());
				}
				if(row["Md_port_type"]!=null)
				{
					model.Md_port_type=row["Md_port_type"].ToString();
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
			strSql.Append("select Md_ID,St_ID,Md_port,Md_port_type ");
			strSql.Append(" FROM ModuleSensor ");
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
			strSql.Append(" Md_ID,St_ID,Md_port,Md_port_type ");
			strSql.Append(" FROM ModuleSensor ");
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
			strSql.Append("select count(1) FROM ModuleSensor ");
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
				strSql.Append("order by T.Mp_ID desc");
			}
			strSql.Append(")AS Row, T.*  from ModuleSensor T ");
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
			parameters[0].Value = "ModuleSensor";
			parameters[1].Value = "Mp_ID";
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

