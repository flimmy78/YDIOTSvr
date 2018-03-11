/**  版本信息模板在安装目录下，可自行修改。
* ValueView.cs
*
* 功 能： N/A
* 类 名： ValueView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:50   N/A    初版
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
using YDIOTSvr.DataLayer.Entity;using YDIOTSvr.DataLayer.DAL;//Please add references
using YDIOTSvr.DataLayer.SQLHelper;
namespace YDIOTSvr.DataLayer.DAL
{
	/// <summary>
    /// 数据访问类:ValueViewDAL
	/// </summary>
	public partial class ValueViewDAL
	{
		public ValueViewDAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ValueViewEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ValueView(");
			strSql.Append("TypeName,Unit,Value,PL_Time,Msc_ID,DTU_ID,Md_ID,St_ID,At_ID,Md_port,MSC_Is_Display,ValueTypeID,Facility_ID,Usage_Dict,Usage_Name,Usage_ID,Pl_ID,Expr1)");
			strSql.Append(" values (");
			strSql.Append("@TypeName,@Unit,@Value,@PL_Time,@Msc_ID,@DTU_ID,@Md_ID,@St_ID,@At_ID,@Md_port,@MSC_Is_Display,@ValueTypeID,@Facility_ID,@Usage_Dict,@Usage_Name,@Usage_ID,@Pl_ID,@Expr1)");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Value", SqlDbType.Float,8),
					new SqlParameter("@PL_Time", SqlDbType.DateTime),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@St_ID", SqlDbType.Int,4),
					new SqlParameter("@At_ID", SqlDbType.Int,4),
					new SqlParameter("@Md_port", SqlDbType.NVarChar,50),
					new SqlParameter("@MSC_Is_Display", SqlDbType.Bit,1),
					new SqlParameter("@ValueTypeID", SqlDbType.Int,4),
					new SqlParameter("@Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Usage_Dict", SqlDbType.NVarChar,50),
					new SqlParameter("@Usage_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Usage_ID", SqlDbType.Int,4),
					new SqlParameter("@Pl_ID", SqlDbType.Int,4),
					new SqlParameter("@Expr1", SqlDbType.Int,4)};
			parameters[0].Value = model.TypeName;
			parameters[1].Value = model.Unit;
			parameters[2].Value = model.Value;
			parameters[3].Value = model.PL_Time;
			parameters[4].Value = model.Msc_ID;
			parameters[5].Value = model.DTU_ID;
			parameters[6].Value = model.Md_ID;
			parameters[7].Value = model.St_ID;
			parameters[8].Value = model.At_ID;
			parameters[9].Value = model.Md_port;
			parameters[10].Value = model.MSC_Is_Display;
			parameters[11].Value = model.ValueTypeID;
			parameters[12].Value = model.Facility_ID;
			parameters[13].Value = model.Usage_Dict;
			parameters[14].Value = model.Usage_Name;
			parameters[15].Value = model.Usage_ID;
			parameters[16].Value = model.Pl_ID;
			parameters[17].Value = model.Expr1;

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
		public bool Update(ValueViewEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ValueView set ");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("Value=@Value,");
			strSql.Append("PL_Time=@PL_Time,");
			strSql.Append("Msc_ID=@Msc_ID,");
			strSql.Append("DTU_ID=@DTU_ID,");
			strSql.Append("Md_ID=@Md_ID,");
			strSql.Append("St_ID=@St_ID,");
			strSql.Append("At_ID=@At_ID,");
			strSql.Append("Md_port=@Md_port,");
			strSql.Append("MSC_Is_Display=@MSC_Is_Display,");
			strSql.Append("ValueTypeID=@ValueTypeID,");
			strSql.Append("Facility_ID=@Facility_ID,");
			strSql.Append("Usage_Dict=@Usage_Dict,");
			strSql.Append("Usage_Name=@Usage_Name,");
			strSql.Append("Usage_ID=@Usage_ID,");
			strSql.Append("Pl_ID=@Pl_ID,");
			strSql.Append("Expr1=@Expr1");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Value", SqlDbType.Float,8),
					new SqlParameter("@PL_Time", SqlDbType.DateTime),
					new SqlParameter("@Msc_ID", SqlDbType.Int,4),
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@St_ID", SqlDbType.Int,4),
					new SqlParameter("@At_ID", SqlDbType.Int,4),
					new SqlParameter("@Md_port", SqlDbType.NVarChar,50),
					new SqlParameter("@MSC_Is_Display", SqlDbType.Bit,1),
					new SqlParameter("@ValueTypeID", SqlDbType.Int,4),
					new SqlParameter("@Facility_ID", SqlDbType.Int,4),
					new SqlParameter("@Usage_Dict", SqlDbType.NVarChar,50),
					new SqlParameter("@Usage_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Usage_ID", SqlDbType.Int,4),
					new SqlParameter("@Pl_ID", SqlDbType.Int,4),
					new SqlParameter("@Expr1", SqlDbType.Int,4)};
			parameters[0].Value = model.TypeName;
			parameters[1].Value = model.Unit;
			parameters[2].Value = model.Value;
			parameters[3].Value = model.PL_Time;
			parameters[4].Value = model.Msc_ID;
			parameters[5].Value = model.DTU_ID;
			parameters[6].Value = model.Md_ID;
			parameters[7].Value = model.St_ID;
			parameters[8].Value = model.At_ID;
			parameters[9].Value = model.Md_port;
			parameters[10].Value = model.MSC_Is_Display;
			parameters[11].Value = model.ValueTypeID;
			parameters[12].Value = model.Facility_ID;
			parameters[13].Value = model.Usage_Dict;
			parameters[14].Value = model.Usage_Name;
			parameters[15].Value = model.Usage_ID;
			parameters[16].Value = model.Pl_ID;
			parameters[17].Value = model.Expr1;

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
			strSql.Append("delete from ValueView ");
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
		public ValueViewEntity GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TypeName,Unit,Value,PL_Time,Msc_ID,DTU_ID,Md_ID,St_ID,At_ID,Md_port,MSC_Is_Display,ValueTypeID,Facility_ID,Usage_Dict,Usage_Name,Usage_ID,Pl_ID,Expr1 from ValueView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ValueViewEntity model=new ValueViewEntity();
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
		public ValueViewEntity DataRowToModel(DataRow row)
		{
			ValueViewEntity model=new ValueViewEntity();
			if (row != null)
			{
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["Unit"]!=null)
				{
					model.Unit=row["Unit"].ToString();
				}
				if(row["Value"]!=null && row["Value"].ToString()!="")
				{
					model.Value=decimal.Parse(row["Value"].ToString());
				}
				if(row["PL_Time"]!=null && row["PL_Time"].ToString()!="")
				{
					model.PL_Time=DateTime.Parse(row["PL_Time"].ToString());
				}
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
				if(row["ValueTypeID"]!=null && row["ValueTypeID"].ToString()!="")
				{
					model.ValueTypeID=int.Parse(row["ValueTypeID"].ToString());
				}
				if(row["Facility_ID"]!=null && row["Facility_ID"].ToString()!="")
				{
					model.Facility_ID=int.Parse(row["Facility_ID"].ToString());
				}
				if(row["Usage_Dict"]!=null)
				{
					model.Usage_Dict=row["Usage_Dict"].ToString();
				}
				if(row["Usage_Name"]!=null)
				{
					model.Usage_Name=row["Usage_Name"].ToString();
				}
				if(row["Usage_ID"]!=null && row["Usage_ID"].ToString()!="")
				{
					model.Usage_ID=int.Parse(row["Usage_ID"].ToString());
				}
				if(row["Pl_ID"]!=null && row["Pl_ID"].ToString()!="")
				{
					model.Pl_ID=int.Parse(row["Pl_ID"].ToString());
				}
				if(row["Expr1"]!=null && row["Expr1"].ToString()!="")
				{
					model.Expr1=int.Parse(row["Expr1"].ToString());
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
			strSql.Append("select TypeName,Unit,Value,PL_Time,Msc_ID,DTU_ID,Md_ID,St_ID,At_ID,Md_port,MSC_Is_Display,ValueTypeID,Facility_ID,Usage_Dict,Usage_Name,Usage_ID,Pl_ID,Expr1 ");
			strSql.Append(" FROM ValueView ");
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
			strSql.Append(" TypeName,Unit,Value,PL_Time,Msc_ID,DTU_ID,Md_ID,St_ID,At_ID,Md_port,MSC_Is_Display,ValueTypeID,Facility_ID,Usage_Dict,Usage_Name,Usage_ID,Pl_ID,Expr1 ");
			strSql.Append(" FROM ValueView ");
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
			strSql.Append("select count(1) FROM ValueView ");
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
				strSql.Append("order by T.Valve_ID desc");
			}
			strSql.Append(")AS Row, T.*  from ValueView T ");
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
			parameters[0].Value = "ValueView";
			parameters[1].Value = "Valve_ID";
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

