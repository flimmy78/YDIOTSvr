/**  版本信息模板在安装目录下，可自行修改。
* MapSite_Config.cs
*
* 功 能： N/A
* 类 名： MapSite_Config
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
    /// 数据访问类:MapSiteConfigDAL
	/// </summary>
    public partial class MapSiteConfigDAL
	{
		public MapSiteConfigDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Msc_ID", "MapSite_Config"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Msc_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MapSite_Config");
			strSql.Append(" where Msc_ID=@Msc_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Msc_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Msc_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MapSiteConfigEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MapSite_Config(");
			strSql.Append("DTU_ID,Md_ID,St_ID,At_ID,Md_port,ValueTypeID,ValueName,MSC_Is_Display,CorrectedValue,PL_Time,PL_Value)");
			strSql.Append(" values (");
			strSql.Append("@DTU_ID,@Md_ID,@St_ID,@At_ID,@Md_port,@ValueTypeID,@ValueName,@MSC_Is_Display,@CorrectedValue,@PL_Time,@PL_Value)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@St_ID", SqlDbType.Int,4),
					new SqlParameter("@At_ID", SqlDbType.Int,4),
					new SqlParameter("@Md_port", SqlDbType.NVarChar,50),
					new SqlParameter("@ValueTypeID", SqlDbType.Int,4),
					new SqlParameter("@ValueName", SqlDbType.NVarChar,50),
					new SqlParameter("@MSC_Is_Display", SqlDbType.Bit,1),
					new SqlParameter("@CorrectedValue", SqlDbType.Float,8),
					new SqlParameter("@PL_Time", SqlDbType.DateTime),
					new SqlParameter("@PL_Value", SqlDbType.Float,8)};
			parameters[0].Value = model.DTU_ID;
			parameters[1].Value = model.Md_ID;
			parameters[2].Value = model.St_ID;
			parameters[3].Value = model.At_ID;
			parameters[4].Value = model.Md_port;
			parameters[5].Value = model.ValueTypeID;
			parameters[6].Value = model.ValueName;
			parameters[7].Value = model.MSC_Is_Display;
			parameters[8].Value = model.CorrectedValue;
			parameters[9].Value = model.PL_Time;
			parameters[10].Value = model.PL_Value;

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
        public bool Update(MapSiteConfigEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MapSite_Config set ");
			strSql.Append("DTU_ID=@DTU_ID,");
			strSql.Append("Md_ID=@Md_ID,");
			strSql.Append("St_ID=@St_ID,");
			strSql.Append("At_ID=@At_ID,");
			strSql.Append("Md_port=@Md_port,");
			strSql.Append("ValueTypeID=@ValueTypeID,");
			strSql.Append("ValueName=@ValueName,");
			strSql.Append("MSC_Is_Display=@MSC_Is_Display,");
			strSql.Append("CorrectedValue=@CorrectedValue,");
			strSql.Append("PL_Time=@PL_Time,");
			strSql.Append("PL_Value=@PL_Value");
			strSql.Append(" where Msc_ID=@Msc_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@St_ID", SqlDbType.Int,4),
					new SqlParameter("@At_ID", SqlDbType.Int,4),
					new SqlParameter("@Md_port", SqlDbType.NVarChar,50),
					new SqlParameter("@ValueTypeID", SqlDbType.Int,4),
					new SqlParameter("@ValueName", SqlDbType.NVarChar,50),
					new SqlParameter("@MSC_Is_Display", SqlDbType.Bit,1),
					new SqlParameter("@CorrectedValue", SqlDbType.Float,8),
					new SqlParameter("@PL_Time", SqlDbType.DateTime),
					new SqlParameter("@PL_Value", SqlDbType.Float,8),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.DTU_ID;
			parameters[1].Value = model.Md_ID;
			parameters[2].Value = model.St_ID;
			parameters[3].Value = model.At_ID;
			parameters[4].Value = model.Md_port;
			parameters[5].Value = model.ValueTypeID;
			parameters[6].Value = model.ValueName;
			parameters[7].Value = model.MSC_Is_Display;
			parameters[8].Value = model.CorrectedValue;
			parameters[9].Value = model.PL_Time;
			parameters[10].Value = model.PL_Value;
			parameters[11].Value = model.Msc_ID;

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
		public bool Delete(int Msc_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MapSite_Config ");
			strSql.Append(" where Msc_ID=@Msc_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Msc_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Msc_ID;

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
		public bool DeleteList(string Msc_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MapSite_Config ");
			strSql.Append(" where Msc_ID in ("+Msc_IDlist + ")  ");
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
        public MapSiteConfigEntity GetModel(int Msc_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Msc_ID,DTU_ID,Md_ID,St_ID,At_ID,Md_port,ValueTypeID,ValueName,MSC_Is_Display,CorrectedValue,PL_Time,PL_Value from MapSite_Config ");
			strSql.Append(" where Msc_ID=@Msc_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Msc_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Msc_ID;

            MapSiteConfigEntity model = new MapSiteConfigEntity();
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
        public MapSiteConfigEntity DataRowToModel(DataRow row)
		{
            MapSiteConfigEntity model = new MapSiteConfigEntity();
			if (row != null)
			{
				if(row["Msc_ID"]!=null && row["Msc_ID"].ToString()!="")
				{
					model.Msc_ID=int.Parse(row["Msc_ID"].ToString());
				}
				if(row["DTU_ID"]!=null)
				{
					model.DTU_ID=row["DTU_ID"].ToString();
				}
				if(row["Md_ID"]!=null)
				{
					model.Md_ID=row["Md_ID"].ToString();
				}
				if(row["St_ID"]!=null && row["St_ID"].ToString()!="")
				{
					model.St_ID=int.Parse(row["St_ID"].ToString());
				}
				if(row["At_ID"]!=null && row["At_ID"].ToString()!="")
				{
					model.At_ID=int.Parse(row["At_ID"].ToString());
				}
				if(row["Md_port"]!=null)
				{
					model.Md_port=row["Md_port"].ToString();
				}
				if(row["ValueTypeID"]!=null && row["ValueTypeID"].ToString()!="")
				{
					model.ValueTypeID=int.Parse(row["ValueTypeID"].ToString());
				}
				if(row["ValueName"]!=null)
				{
					model.ValueName=row["ValueName"].ToString();
				}
				if(row["MSC_Is_Display"]!=null && row["MSC_Is_Display"].ToString()!="")
				{
					if((row["MSC_Is_Display"].ToString()=="1")||(row["MSC_Is_Display"].ToString().ToLower()=="true"))
					{
						model.MSC_Is_Display=true;
					}
					else
					{
						model.MSC_Is_Display=false;
					}
				}
				if(row["CorrectedValue"]!=null && row["CorrectedValue"].ToString()!="")
				{
					model.CorrectedValue=decimal.Parse(row["CorrectedValue"].ToString());
				}
				if(row["PL_Time"]!=null && row["PL_Time"].ToString()!="")
				{
					model.PL_Time=DateTime.Parse(row["PL_Time"].ToString());
				}
				if(row["PL_Value"]!=null && row["PL_Value"].ToString()!="")
				{
					model.PL_Value=decimal.Parse(row["PL_Value"].ToString());
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
			strSql.Append("select Msc_ID,DTU_ID,Md_ID,St_ID,At_ID,Md_port,ValueTypeID,ValueName,MSC_Is_Display,CorrectedValue,PL_Time,PL_Value ");
			strSql.Append(" FROM MapSite_Config ");
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
			strSql.Append(" Msc_ID,DTU_ID,Md_ID,St_ID,At_ID,Md_port,ValueTypeID,ValueName,MSC_Is_Display,CorrectedValue,PL_Time,PL_Value ");
			strSql.Append(" FROM MapSite_Config ");
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
			strSql.Append("select count(1) FROM MapSite_Config ");
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
				strSql.Append("order by T.Msc_ID desc");
			}
			strSql.Append(")AS Row, T.*  from MapSite_Config T ");
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
			parameters[0].Value = "MapSite_Config";
			parameters[1].Value = "Msc_ID";
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

