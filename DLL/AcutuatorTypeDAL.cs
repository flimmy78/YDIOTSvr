/**  版本信息模板在安装目录下，可自行修改。
* Acutuator_type.cs
*
* 功 能： N/A
* 类 名： Acutuator_type
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:26   N/A    初版
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
using YDIOTSvr.DataLayer.Entity;using YDIOTSvr.DataLayer.DAL;
using YDIOTSvr.DataLayer.SQLHelper;
namespace YDIOTSvr.DataLayer.DAL
{
	/// <summary>
    /// 数据访问类:AcutuatorTypeDAL
	/// </summary>
	public partial class AcutuatorTypeDAL
	{
        public AcutuatorTypeDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("At_ID", "Acutuator_type"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int At_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Acutuator_type");
			strSql.Append(" where At_ID=@At_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@At_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = At_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AcutuatorTypeEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Acutuator_type(");
			strSql.Append("At_ModelNumber,At_name,At_manufacture,At_attr_name_1,At_attr_value_1,At_attr_name_2,At_attr_value_2,At_map_working,At_map_idle,At_map_offline)");
			strSql.Append(" values (");
			strSql.Append("@At_ModelNumber,@At_name,@At_manufacture,@At_attr_name_1,@At_attr_value_1,@At_attr_name_2,@At_attr_value_2,@At_map_working,@At_map_idle,@At_map_offline)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@At_ModelNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@At_name", SqlDbType.NVarChar,50),
					new SqlParameter("@At_manufacture", SqlDbType.NVarChar,50),
					new SqlParameter("@At_attr_name_1", SqlDbType.NVarChar,50),
					new SqlParameter("@At_attr_value_1", SqlDbType.NVarChar,50),
					new SqlParameter("@At_attr_name_2", SqlDbType.NVarChar,50),
					new SqlParameter("@At_attr_value_2", SqlDbType.NVarChar,50),
					new SqlParameter("@At_map_working", SqlDbType.NVarChar,50),
					new SqlParameter("@At_map_idle", SqlDbType.NVarChar,50),
					new SqlParameter("@At_map_offline", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.At_ModelNumber;
			parameters[1].Value = model.At_name;
			parameters[2].Value = model.At_manufacture;
			parameters[3].Value = model.At_attr_name_1;
			parameters[4].Value = model.At_attr_value_1;
			parameters[5].Value = model.At_attr_name_2;
			parameters[6].Value = model.At_attr_value_2;
			parameters[7].Value = model.At_map_working;
			parameters[8].Value = model.At_map_idle;
			parameters[9].Value = model.At_map_offline;

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
		public bool Update(AcutuatorTypeEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Acutuator_type set ");
			strSql.Append("At_ModelNumber=@At_ModelNumber,");
			strSql.Append("At_name=@At_name,");
			strSql.Append("At_manufacture=@At_manufacture,");
			strSql.Append("At_attr_name_1=@At_attr_name_1,");
			strSql.Append("At_attr_value_1=@At_attr_value_1,");
			strSql.Append("At_attr_name_2=@At_attr_name_2,");
			strSql.Append("At_attr_value_2=@At_attr_value_2,");
			strSql.Append("At_map_working=@At_map_working,");
			strSql.Append("At_map_idle=@At_map_idle,");
			strSql.Append("At_map_offline=@At_map_offline");
			strSql.Append(" where At_ID=@At_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@At_ModelNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@At_name", SqlDbType.NVarChar,50),
					new SqlParameter("@At_manufacture", SqlDbType.NVarChar,50),
					new SqlParameter("@At_attr_name_1", SqlDbType.NVarChar,50),
					new SqlParameter("@At_attr_value_1", SqlDbType.NVarChar,50),
					new SqlParameter("@At_attr_name_2", SqlDbType.NVarChar,50),
					new SqlParameter("@At_attr_value_2", SqlDbType.NVarChar,50),
					new SqlParameter("@At_map_working", SqlDbType.NVarChar,50),
					new SqlParameter("@At_map_idle", SqlDbType.NVarChar,50),
					new SqlParameter("@At_map_offline", SqlDbType.NVarChar,50),
					new SqlParameter("@At_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.At_ModelNumber;
			parameters[1].Value = model.At_name;
			parameters[2].Value = model.At_manufacture;
			parameters[3].Value = model.At_attr_name_1;
			parameters[4].Value = model.At_attr_value_1;
			parameters[5].Value = model.At_attr_name_2;
			parameters[6].Value = model.At_attr_value_2;
			parameters[7].Value = model.At_map_working;
			parameters[8].Value = model.At_map_idle;
			parameters[9].Value = model.At_map_offline;
			parameters[10].Value = model.At_ID;

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
		public bool Delete(int At_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Acutuator_type ");
			strSql.Append(" where At_ID=@At_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@At_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = At_ID;

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
		public bool DeleteList(string At_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Acutuator_type ");
			strSql.Append(" where At_ID in ("+At_IDlist + ")  ");
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
		public AcutuatorTypeEntity GetModel(int At_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 At_ID,At_ModelNumber,At_name,At_manufacture,At_attr_name_1,At_attr_value_1,At_attr_name_2,At_attr_value_2,At_map_working,At_map_idle,At_map_offline from Acutuator_type ");
			strSql.Append(" where At_ID=@At_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@At_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = At_ID;

			AcutuatorTypeEntity model=new AcutuatorTypeEntity();
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
		public AcutuatorTypeEntity DataRowToModel(DataRow row)
		{
			AcutuatorTypeEntity model=new AcutuatorTypeEntity();
			if (row != null)
			{
				if(row["At_ID"]!=null && row["At_ID"].ToString()!="")
				{
					model.At_ID=int.Parse(row["At_ID"].ToString());
				}
				if(row["At_ModelNumber"]!=null)
				{
					model.At_ModelNumber=row["At_ModelNumber"].ToString();
				}
				if(row["At_name"]!=null)
				{
					model.At_name=row["At_name"].ToString();
				}
				if(row["At_manufacture"]!=null)
				{
					model.At_manufacture=row["At_manufacture"].ToString();
				}
				if(row["At_attr_name_1"]!=null)
				{
					model.At_attr_name_1=row["At_attr_name_1"].ToString();
				}
				if(row["At_attr_value_1"]!=null)
				{
					model.At_attr_value_1=row["At_attr_value_1"].ToString();
				}
				if(row["At_attr_name_2"]!=null)
				{
					model.At_attr_name_2=row["At_attr_name_2"].ToString();
				}
				if(row["At_attr_value_2"]!=null)
				{
					model.At_attr_value_2=row["At_attr_value_2"].ToString();
				}
				if(row["At_map_working"]!=null)
				{
					model.At_map_working=row["At_map_working"].ToString();
				}
				if(row["At_map_idle"]!=null)
				{
					model.At_map_idle=row["At_map_idle"].ToString();
				}
				if(row["At_map_offline"]!=null)
				{
					model.At_map_offline=row["At_map_offline"].ToString();
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
			strSql.Append("select At_ID,At_ModelNumber,At_name,At_manufacture,At_attr_name_1,At_attr_value_1,At_attr_name_2,At_attr_value_2,At_map_working,At_map_idle,At_map_offline ");
			strSql.Append(" FROM Acutuator_type ");
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
			strSql.Append(" At_ID,At_ModelNumber,At_name,At_manufacture,At_attr_name_1,At_attr_value_1,At_attr_name_2,At_attr_value_2,At_map_working,At_map_idle,At_map_offline ");
			strSql.Append(" FROM Acutuator_type ");
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
			strSql.Append("select count(1) FROM Acutuator_type ");
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
				strSql.Append("order by T.At_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Acutuator_type T ");
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
			parameters[0].Value = "Acutuator_type";
			parameters[1].Value = "At_ID";
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

