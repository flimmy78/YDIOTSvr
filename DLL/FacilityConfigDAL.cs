/**  版本信息模板在安装目录下，可自行修改。
* Facility_Config.cs
*
* 功 能： N/A
* 类 名： Facility_Config
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:29   N/A    初版
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
    /// 数据访问类:FacilityConfigDAL
	/// </summary>
	public partial class FacilityConfigDAL
	{
		public FacilityConfigDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Facility_ID", "Facility_Config"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Facility_ID,int Msc_ID,int Usage_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Facility_Config");
			strSql.Append(" where Facility_ID=@Facility_ID and Msc_ID=@Msc_ID and Usage_ID=@Usage_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Facility_ID;
			parameters[1].Value = Msc_ID;
			parameters[2].Value = Usage_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FacilityConfigEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Facility_Config(");
			strSql.Append("Facility_ID,Msc_ID,Usage_ID)");
			strSql.Append(" values (");
			strSql.Append("@Facility_ID,@Msc_ID,@Usage_ID)");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Facility_ID;
			parameters[1].Value = model.Msc_ID;
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
		/// 更新一条数据
		/// </summary>
        public bool Update(FacilityConfigEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Facility_Config set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("Facility_ID=@Facility_ID,");
			strSql.Append("Msc_ID=@Msc_ID,");
			strSql.Append("Usage_ID=@Usage_ID");
			strSql.Append(" where Facility_ID=@Facility_ID and Msc_ID=@Msc_ID and Usage_ID=@Usage_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Facility_ID;
			parameters[1].Value = model.Msc_ID;
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
		public bool Delete(int Facility_ID,int Msc_ID,int Usage_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Facility_Config ");
			strSql.Append(" where Facility_ID=@Facility_ID and Msc_ID=@Msc_ID and Usage_ID=@Usage_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Facility_ID;
			parameters[1].Value = Msc_ID;
			parameters[2].Value = Usage_ID;

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
        public FacilityConfigEntity GetModel(int Facility_ID, int Msc_ID, int Usage_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Facility_ID,Msc_ID,Usage_ID from Facility_Config ");
			strSql.Append(" where Facility_ID=@Facility_ID and Msc_ID=@Msc_ID and Usage_ID=@Usage_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@Usage_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Facility_ID;
			parameters[1].Value = Msc_ID;
			parameters[2].Value = Usage_ID;

            FacilityConfigEntity model = new FacilityConfigEntity();
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
        public FacilityConfigEntity DataRowToModel(DataRow row)
		{
            FacilityConfigEntity model = new FacilityConfigEntity();
			if (row != null)
			{
				if(row["Facility_ID"]!=null && row["Facility_ID"].ToString()!="")
				{
					model.Facility_ID=int.Parse(row["Facility_ID"].ToString());
				}
				if(row["Msc_ID"]!=null && row["Msc_ID"].ToString()!="")
				{
					model.Msc_ID=int.Parse(row["Msc_ID"].ToString());
				}
				if(row["Usage_ID"]!=null && row["Usage_ID"].ToString()!="")
				{
					model.Usage_ID=int.Parse(row["Usage_ID"].ToString());
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
			strSql.Append("select Facility_ID,Msc_ID,Usage_ID ");
			strSql.Append(" FROM Facility_Config ");
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
			strSql.Append(" Facility_ID,Msc_ID,Usage_ID ");
			strSql.Append(" FROM Facility_Config ");
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
			strSql.Append("select count(1) FROM Facility_Config ");
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
			strSql.Append(")AS Row, T.*  from Facility_Config T ");
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
			parameters[0].Value = "Facility_Config";
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

