/**  版本信息模板在安装目录下，可自行修改。
* Facility.cs
*
* 功 能： N/A
* 类 名： Facility
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
	/// 数据访问类:Facility
	/// </summary>
	public partial class FacilityDAL
	{
        public FacilityDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Facility_ID", "Facility"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Facility_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Facility");
			strSql.Append(" where Facility_ID=@Facility_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Facility_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(FacilityEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Facility(");
			strSql.Append("GroupID,Facility_Type,Facility_Name,Facility_longitude,Facility_dimensionality,power,IsOnGIS,Well_head_height,Well_bottom_height,rateOfFlow)");
			strSql.Append(" values (");
			strSql.Append("@GroupID,@Facility_Type,@Facility_Name,@Facility_longitude,@Facility_dimensionality,@power,@IsOnGIS,@Well_head_height,@Well_bottom_height,@rateOfFlow)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupID", SqlDbType.Int,4),
					new SqlParameter("@Facility_Type", SqlDbType.Int,4),
					new SqlParameter("@Facility_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Facility_longitude", SqlDbType.Float,8),
					new SqlParameter("@Facility_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@power", SqlDbType.Float,8),
					new SqlParameter("@IsOnGIS", SqlDbType.Bit,1),
					new SqlParameter("@Well_head_height", SqlDbType.Int,4),
					new SqlParameter("@Well_bottom_height", SqlDbType.Int,4),
					new SqlParameter("@rateOfFlow", SqlDbType.Float,8)};
			parameters[0].Value = model.GroupID;
			parameters[1].Value = model.Facility_Type;
			parameters[2].Value = model.Facility_Name;
			parameters[3].Value = model.Facility_longitude;
			parameters[4].Value = model.Facility_dimensionality;
			parameters[5].Value = model.power;
			parameters[6].Value = model.IsOnGIS;
			parameters[7].Value = model.Well_head_height;
			parameters[8].Value = model.Well_bottom_height;
			parameters[9].Value = model.rateOfFlow;

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
		public bool Update(FacilityEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Facility set ");
			strSql.Append("GroupID=@GroupID,");
			strSql.Append("Facility_Type=@Facility_Type,");
			strSql.Append("Facility_Name=@Facility_Name,");
			strSql.Append("Facility_longitude=@Facility_longitude,");
			strSql.Append("Facility_dimensionality=@Facility_dimensionality,");
			strSql.Append("power=@power,");
			strSql.Append("IsOnGIS=@IsOnGIS,");
			strSql.Append("Well_head_height=@Well_head_height,");
			strSql.Append("Well_bottom_height=@Well_bottom_height,");
			strSql.Append("rateOfFlow=@rateOfFlow");
			strSql.Append(" where Facility_ID=@Facility_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupID", SqlDbType.Int,4),
					new SqlParameter("@Facility_Type", SqlDbType.Int,4),
					new SqlParameter("@Facility_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Facility_longitude", SqlDbType.Float,8),
					new SqlParameter("@Facility_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@power", SqlDbType.Float,8),
					new SqlParameter("@IsOnGIS", SqlDbType.Bit,1),
					new SqlParameter("@Well_head_height", SqlDbType.Int,4),
					new SqlParameter("@Well_bottom_height", SqlDbType.Int,4),
					new SqlParameter("@rateOfFlow", SqlDbType.Float,8),
					new SqlParameter("@Facility_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.GroupID;
			parameters[1].Value = model.Facility_Type;
			parameters[2].Value = model.Facility_Name;
			parameters[3].Value = model.Facility_longitude;
			parameters[4].Value = model.Facility_dimensionality;
			parameters[5].Value = model.power;
			parameters[6].Value = model.IsOnGIS;
			parameters[7].Value = model.Well_head_height;
			parameters[8].Value = model.Well_bottom_height;
			parameters[9].Value = model.rateOfFlow;
			parameters[10].Value = model.Facility_ID;

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
		public bool Delete(int Facility_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Facility ");
			strSql.Append(" where Facility_ID=@Facility_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Facility_ID;

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
		public bool DeleteList(string Facility_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Facility ");
			strSql.Append(" where Facility_ID in ("+Facility_IDlist + ")  ");
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
		public FacilityEntity GetModel(int Facility_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Facility_ID,GroupID,Facility_Type,Facility_Name,Facility_longitude,Facility_dimensionality,power,IsOnGIS,Well_head_height,Well_bottom_height,rateOfFlow from Facility ");
			strSql.Append(" where Facility_ID=@Facility_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Facility_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Facility_ID;

			FacilityEntity model=new FacilityEntity();
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
		public FacilityEntity DataRowToModel(DataRow row)
		{
			FacilityEntity model=new FacilityEntity();
			if (row != null)
			{
				if(row["Facility_ID"]!=null && row["Facility_ID"].ToString()!="")
				{
					model.Facility_ID=int.Parse(row["Facility_ID"].ToString());
				}
				if(row["GroupID"]!=null && row["GroupID"].ToString()!="")
				{
					model.GroupID=int.Parse(row["GroupID"].ToString());
				}
				if(row["Facility_Type"]!=null && row["Facility_Type"].ToString()!="")
				{
					model.Facility_Type=int.Parse(row["Facility_Type"].ToString());
				}
				if(row["Facility_Name"]!=null)
				{
					model.Facility_Name=row["Facility_Name"].ToString();
				}
				if(row["Facility_longitude"]!=null && row["Facility_longitude"].ToString()!="")
				{
					model.Facility_longitude=decimal.Parse(row["Facility_longitude"].ToString());
				}
				if(row["Facility_dimensionality"]!=null && row["Facility_dimensionality"].ToString()!="")
				{
					model.Facility_dimensionality=decimal.Parse(row["Facility_dimensionality"].ToString());
				}
				if(row["power"]!=null && row["power"].ToString()!="")
				{
					model.power=decimal.Parse(row["power"].ToString());
				}
				if(row["IsOnGIS"]!=null && row["IsOnGIS"].ToString()!="")
				{
					if((row["IsOnGIS"].ToString()=="1")||(row["IsOnGIS"].ToString().ToLower()=="true"))
					{
						model.IsOnGIS=true;
					}
					else
					{
						model.IsOnGIS=false;
					}
				}
				if(row["Well_head_height"]!=null && row["Well_head_height"].ToString()!="")
				{
					model.Well_head_height=int.Parse(row["Well_head_height"].ToString());
				}
				if(row["Well_bottom_height"]!=null && row["Well_bottom_height"].ToString()!="")
				{
					model.Well_bottom_height=int.Parse(row["Well_bottom_height"].ToString());
				}
				if(row["rateOfFlow"]!=null && row["rateOfFlow"].ToString()!="")
				{
					model.rateOfFlow=decimal.Parse(row["rateOfFlow"].ToString());
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
			strSql.Append("select Facility_ID,GroupID,Facility_Type,Facility_Name,Facility_longitude,Facility_dimensionality,power,IsOnGIS,Well_head_height,Well_bottom_height,rateOfFlow ");
			strSql.Append(" FROM Facility ");
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
			strSql.Append(" Facility_ID,GroupID,Facility_Type,Facility_Name,Facility_longitude,Facility_dimensionality,power,IsOnGIS,Well_head_height,Well_bottom_height,rateOfFlow ");
			strSql.Append(" FROM Facility ");
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
			strSql.Append("select count(1) FROM Facility ");
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
				strSql.Append("order by T.Facility_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Facility T ");
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
			parameters[0].Value = "Facility";
			parameters[1].Value = "Facility_ID";
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

