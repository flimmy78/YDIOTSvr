/**  版本信息模板在安装目录下，可自行修改。
* land.cs
*
* 功 能： N/A
* 类 名： land
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:34   N/A    初版
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
	/// 数据访问类:land
	/// </summary>
	public partial class LandDAL
	{
        public LandDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Land_ID", "land"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Land_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from land");
			strSql.Append(" where Land_ID=@Land_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Land_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Land_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LandEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into land(");
			strSql.Append("Pump_ID,Valve_ID,Moisture_ID,FlowGauge_ID,Land_Name,Land_longitude,Land_dimensionality,Land_Description,Land_Area,Land_Water_Volume,Land_Water_Volume_Unit,Land_Is_Auto,Land_Moisture_Low,Land_Moisture_High,Land_Moisture_Unit,Land_Polling_Interval)");
			strSql.Append(" values (");
			strSql.Append("@Pump_ID,@Valve_ID,@Moisture_ID,@FlowGauge_ID,@Land_Name,@Land_longitude,@Land_dimensionality,@Land_Description,@Land_Area,@Land_Water_Volume,@Land_Water_Volume_Unit,@Land_Is_Auto,@Land_Moisture_Low,@Land_Moisture_High,@Land_Moisture_Unit,@Land_Polling_Interval)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Pump_ID", SqlDbType.Int,4),
					new SqlParameter("@Valve_ID", SqlDbType.Int,4),
					new SqlParameter("@Moisture_ID", SqlDbType.Int,4),
					new SqlParameter("@FlowGauge_ID", SqlDbType.Int,4),
					new SqlParameter("@Land_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Land_longitude", SqlDbType.Float,8),
					new SqlParameter("@Land_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@Land_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Land_Area", SqlDbType.NVarChar,50),
					new SqlParameter("@Land_Water_Volume", SqlDbType.Float,8),
					new SqlParameter("@Land_Water_Volume_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Land_Is_Auto", SqlDbType.Bit,1),
					new SqlParameter("@Land_Moisture_Low", SqlDbType.Int,4),
					new SqlParameter("@Land_Moisture_High", SqlDbType.Int,4),
					new SqlParameter("@Land_Moisture_Unit", SqlDbType.NVarChar,10),
					new SqlParameter("@Land_Polling_Interval", SqlDbType.Int,4)};
			parameters[0].Value = model.Pump_ID;
			parameters[1].Value = model.Valve_ID;
			parameters[2].Value = model.Moisture_ID;
			parameters[3].Value = model.FlowGauge_ID;
			parameters[4].Value = model.Land_Name;
			parameters[5].Value = model.Land_longitude;
			parameters[6].Value = model.Land_dimensionality;
			parameters[7].Value = model.Land_Description;
			parameters[8].Value = model.Land_Area;
			parameters[9].Value = model.Land_Water_Volume;
			parameters[10].Value = model.Land_Water_Volume_Unit;
			parameters[11].Value = model.Land_Is_Auto;
			parameters[12].Value = model.Land_Moisture_Low;
			parameters[13].Value = model.Land_Moisture_High;
			parameters[14].Value = model.Land_Moisture_Unit;
			parameters[15].Value = model.Land_Polling_Interval;

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
		public bool Update(LandEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update land set ");
			strSql.Append("Pump_ID=@Pump_ID,");
			strSql.Append("Valve_ID=@Valve_ID,");
			strSql.Append("Moisture_ID=@Moisture_ID,");
			strSql.Append("FlowGauge_ID=@FlowGauge_ID,");
			strSql.Append("Land_Name=@Land_Name,");
			strSql.Append("Land_longitude=@Land_longitude,");
			strSql.Append("Land_dimensionality=@Land_dimensionality,");
			strSql.Append("Land_Description=@Land_Description,");
			strSql.Append("Land_Area=@Land_Area,");
			strSql.Append("Land_Water_Volume=@Land_Water_Volume,");
			strSql.Append("Land_Water_Volume_Unit=@Land_Water_Volume_Unit,");
			strSql.Append("Land_Is_Auto=@Land_Is_Auto,");
			strSql.Append("Land_Moisture_Low=@Land_Moisture_Low,");
			strSql.Append("Land_Moisture_High=@Land_Moisture_High,");
			strSql.Append("Land_Moisture_Unit=@Land_Moisture_Unit,");
			strSql.Append("Land_Polling_Interval=@Land_Polling_Interval");
			strSql.Append(" where Land_ID=@Land_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Pump_ID", SqlDbType.Int,4),
					new SqlParameter("@Valve_ID", SqlDbType.Int,4),
					new SqlParameter("@Moisture_ID", SqlDbType.Int,4),
					new SqlParameter("@FlowGauge_ID", SqlDbType.Int,4),
					new SqlParameter("@Land_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Land_longitude", SqlDbType.Float,8),
					new SqlParameter("@Land_dimensionality", SqlDbType.Float,8),
					new SqlParameter("@Land_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@Land_Area", SqlDbType.NVarChar,50),
					new SqlParameter("@Land_Water_Volume", SqlDbType.Float,8),
					new SqlParameter("@Land_Water_Volume_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Land_Is_Auto", SqlDbType.Bit,1),
					new SqlParameter("@Land_Moisture_Low", SqlDbType.Int,4),
					new SqlParameter("@Land_Moisture_High", SqlDbType.Int,4),
					new SqlParameter("@Land_Moisture_Unit", SqlDbType.NVarChar,10),
					new SqlParameter("@Land_Polling_Interval", SqlDbType.Int,4),
					new SqlParameter("@Land_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Pump_ID;
			parameters[1].Value = model.Valve_ID;
			parameters[2].Value = model.Moisture_ID;
			parameters[3].Value = model.FlowGauge_ID;
			parameters[4].Value = model.Land_Name;
			parameters[5].Value = model.Land_longitude;
			parameters[6].Value = model.Land_dimensionality;
			parameters[7].Value = model.Land_Description;
			parameters[8].Value = model.Land_Area;
			parameters[9].Value = model.Land_Water_Volume;
			parameters[10].Value = model.Land_Water_Volume_Unit;
			parameters[11].Value = model.Land_Is_Auto;
			parameters[12].Value = model.Land_Moisture_Low;
			parameters[13].Value = model.Land_Moisture_High;
			parameters[14].Value = model.Land_Moisture_Unit;
			parameters[15].Value = model.Land_Polling_Interval;
			parameters[16].Value = model.Land_ID;

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
		public bool Delete(int Land_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from land ");
			strSql.Append(" where Land_ID=@Land_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Land_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Land_ID;

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
		public bool DeleteList(string Land_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from land ");
			strSql.Append(" where Land_ID in ("+Land_IDlist + ")  ");
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
		public LandEntity GetModel(int Land_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Land_ID,Pump_ID,Valve_ID,Moisture_ID,FlowGauge_ID,Land_Name,Land_longitude,Land_dimensionality,Land_Description,Land_Area,Land_Water_Volume,Land_Water_Volume_Unit,Land_Is_Auto,Land_Moisture_Low,Land_Moisture_High,Land_Moisture_Unit,Land_Polling_Interval from land ");
			strSql.Append(" where Land_ID=@Land_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Land_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Land_ID;

			LandEntity model=new LandEntity();
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
		public LandEntity DataRowToModel(DataRow row)
		{
			LandEntity model=new LandEntity();
			if (row != null)
			{
				if(row["Land_ID"]!=null && row["Land_ID"].ToString()!="")
				{
					model.Land_ID=int.Parse(row["Land_ID"].ToString());
				}
				if(row["Pump_ID"]!=null && row["Pump_ID"].ToString()!="")
				{
					model.Pump_ID=int.Parse(row["Pump_ID"].ToString());
				}
				if(row["Valve_ID"]!=null && row["Valve_ID"].ToString()!="")
				{
					model.Valve_ID=int.Parse(row["Valve_ID"].ToString());
				}
				if(row["Moisture_ID"]!=null && row["Moisture_ID"].ToString()!="")
				{
					model.Moisture_ID=int.Parse(row["Moisture_ID"].ToString());
				}
				if(row["FlowGauge_ID"]!=null && row["FlowGauge_ID"].ToString()!="")
				{
					model.FlowGauge_ID=int.Parse(row["FlowGauge_ID"].ToString());
				}
				if(row["Land_Name"]!=null)
				{
					model.Land_Name=row["Land_Name"].ToString();
				}
				if(row["Land_longitude"]!=null && row["Land_longitude"].ToString()!="")
				{
					model.Land_longitude=decimal.Parse(row["Land_longitude"].ToString());
				}
				if(row["Land_dimensionality"]!=null && row["Land_dimensionality"].ToString()!="")
				{
					model.Land_dimensionality=decimal.Parse(row["Land_dimensionality"].ToString());
				}
				if(row["Land_Description"]!=null)
				{
					model.Land_Description=row["Land_Description"].ToString();
				}
				if(row["Land_Area"]!=null)
				{
					model.Land_Area=row["Land_Area"].ToString();
				}
				if(row["Land_Water_Volume"]!=null && row["Land_Water_Volume"].ToString()!="")
				{
					model.Land_Water_Volume=decimal.Parse(row["Land_Water_Volume"].ToString());
				}
				if(row["Land_Water_Volume_Unit"]!=null)
				{
					model.Land_Water_Volume_Unit=row["Land_Water_Volume_Unit"].ToString();
				}
				if(row["Land_Is_Auto"]!=null && row["Land_Is_Auto"].ToString()!="")
				{
					if((row["Land_Is_Auto"].ToString()=="1")||(row["Land_Is_Auto"].ToString().ToLower()=="true"))
					{
						model.Land_Is_Auto=true;
					}
					else
					{
						model.Land_Is_Auto=false;
					}
				}
				if(row["Land_Moisture_Low"]!=null && row["Land_Moisture_Low"].ToString()!="")
				{
					model.Land_Moisture_Low=int.Parse(row["Land_Moisture_Low"].ToString());
				}
				if(row["Land_Moisture_High"]!=null && row["Land_Moisture_High"].ToString()!="")
				{
					model.Land_Moisture_High=int.Parse(row["Land_Moisture_High"].ToString());
				}
				if(row["Land_Moisture_Unit"]!=null)
				{
					model.Land_Moisture_Unit=row["Land_Moisture_Unit"].ToString();
				}
				if(row["Land_Polling_Interval"]!=null && row["Land_Polling_Interval"].ToString()!="")
				{
					model.Land_Polling_Interval=int.Parse(row["Land_Polling_Interval"].ToString());
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
			strSql.Append("select Land_ID,Pump_ID,Valve_ID,Moisture_ID,FlowGauge_ID,Land_Name,Land_longitude,Land_dimensionality,Land_Description,Land_Area,Land_Water_Volume,Land_Water_Volume_Unit,Land_Is_Auto,Land_Moisture_Low,Land_Moisture_High,Land_Moisture_Unit,Land_Polling_Interval ");
			strSql.Append(" FROM land ");
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
			strSql.Append(" Land_ID,Pump_ID,Valve_ID,Moisture_ID,FlowGauge_ID,Land_Name,Land_longitude,Land_dimensionality,Land_Description,Land_Area,Land_Water_Volume,Land_Water_Volume_Unit,Land_Is_Auto,Land_Moisture_Low,Land_Moisture_High,Land_Moisture_Unit,Land_Polling_Interval ");
			strSql.Append(" FROM land ");
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
			strSql.Append("select count(1) FROM land ");
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
				strSql.Append("order by T.Land_ID desc");
			}
			strSql.Append(")AS Row, T.*  from land T ");
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
			parameters[0].Value = "land";
			parameters[1].Value = "Land_ID";
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

