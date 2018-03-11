/**  版本信息模板在安装目录下，可自行修改。
* Sensor_type.cs
*
* 功 能： N/A
* 类 名： Sensor_type
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:42   N/A    初版
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
using YDIOTSvr.DataLayer.SQLHelper;//Please add references
namespace YDIOTSvr.DataLayer.DAL
{
	/// <summary>
	/// 数据访问类:SensorTypeDAL
	/// </summary>
	public partial class SensorTypeDAL
	{
        public SensorTypeDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("St_ID", "Sensor_type"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int St_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sensor_type");
			strSql.Append(" where St_ID=@St_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@St_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = St_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SensorTypeEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sensor_type(");
			strSql.Append("St_ModelNumber,St_name,VT_ID,St_attr,St_manufacture,St_analog_min_value,St_analog_max_value,St_analog_min_range,St_analog_max_range,St_counter_value_per_pulse,St_switching_true_state,St_switching_false_state,St_map_1,St_map_2,St_map_3,St_map_4,St_map_5)");
			strSql.Append(" values (");
			strSql.Append("@St_ModelNumber,@St_name,@VT_ID,@St_attr,@St_manufacture,@St_analog_min_value,@St_analog_max_value,@St_analog_min_range,@St_analog_max_range,@St_counter_value_per_pulse,@St_switching_true_state,@St_switching_false_state,@St_map_1,@St_map_2,@St_map_3,@St_map_4,@St_map_5)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@St_ModelNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@St_name", SqlDbType.NVarChar,50),
					new SqlParameter("@VT_ID", SqlDbType.NVarChar,10),
					new SqlParameter("@St_attr", SqlDbType.NVarChar,50),
					new SqlParameter("@St_manufacture", SqlDbType.NVarChar,100),
					new SqlParameter("@St_analog_min_value", SqlDbType.Int,4),
					new SqlParameter("@St_analog_max_value", SqlDbType.Int,4),
					new SqlParameter("@St_analog_min_range", SqlDbType.Int,4),
					new SqlParameter("@St_analog_max_range", SqlDbType.Int,4),
					new SqlParameter("@St_counter_value_per_pulse", SqlDbType.Float,8),
					new SqlParameter("@St_switching_true_state", SqlDbType.NVarChar,50),
					new SqlParameter("@St_switching_false_state", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_1", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_2", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_3", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_4", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_5", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.St_ModelNumber;
			parameters[1].Value = model.St_name;
			parameters[2].Value = model.VT_ID;
			parameters[3].Value = model.St_attr;
			parameters[4].Value = model.St_manufacture;
			parameters[5].Value = model.St_analog_min_value;
			parameters[6].Value = model.St_analog_max_value;
			parameters[7].Value = model.St_analog_min_range;
			parameters[8].Value = model.St_analog_max_range;
			parameters[9].Value = model.St_counter_value_per_pulse;
			parameters[10].Value = model.St_switching_true_state;
			parameters[11].Value = model.St_switching_false_state;
			parameters[12].Value = model.St_map_1;
			parameters[13].Value = model.St_map_2;
			parameters[14].Value = model.St_map_3;
			parameters[15].Value = model.St_map_4;
			parameters[16].Value = model.St_map_5;

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
        public bool Update(SensorTypeEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sensor_type set ");
			strSql.Append("St_ModelNumber=@St_ModelNumber,");
			strSql.Append("St_name=@St_name,");
			strSql.Append("VT_ID=@VT_ID,");
			strSql.Append("St_attr=@St_attr,");
			strSql.Append("St_manufacture=@St_manufacture,");
			strSql.Append("St_analog_min_value=@St_analog_min_value,");
			strSql.Append("St_analog_max_value=@St_analog_max_value,");
			strSql.Append("St_analog_min_range=@St_analog_min_range,");
			strSql.Append("St_analog_max_range=@St_analog_max_range,");
			strSql.Append("St_counter_value_per_pulse=@St_counter_value_per_pulse,");
			strSql.Append("St_switching_true_state=@St_switching_true_state,");
			strSql.Append("St_switching_false_state=@St_switching_false_state,");
			strSql.Append("St_map_1=@St_map_1,");
			strSql.Append("St_map_2=@St_map_2,");
			strSql.Append("St_map_3=@St_map_3,");
			strSql.Append("St_map_4=@St_map_4,");
			strSql.Append("St_map_5=@St_map_5");
			strSql.Append(" where St_ID=@St_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@St_ModelNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@St_name", SqlDbType.NVarChar,50),
					new SqlParameter("@VT_ID", SqlDbType.NVarChar,10),
					new SqlParameter("@St_attr", SqlDbType.NVarChar,50),
					new SqlParameter("@St_manufacture", SqlDbType.NVarChar,100),
					new SqlParameter("@St_analog_min_value", SqlDbType.Int,4),
					new SqlParameter("@St_analog_max_value", SqlDbType.Int,4),
					new SqlParameter("@St_analog_min_range", SqlDbType.Int,4),
					new SqlParameter("@St_analog_max_range", SqlDbType.Int,4),
					new SqlParameter("@St_counter_value_per_pulse", SqlDbType.Float,8),
					new SqlParameter("@St_switching_true_state", SqlDbType.NVarChar,50),
					new SqlParameter("@St_switching_false_state", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_1", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_2", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_3", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_4", SqlDbType.NVarChar,50),
					new SqlParameter("@St_map_5", SqlDbType.NVarChar,50),
					new SqlParameter("@St_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.St_ModelNumber;
			parameters[1].Value = model.St_name;
			parameters[2].Value = model.VT_ID;
			parameters[3].Value = model.St_attr;
			parameters[4].Value = model.St_manufacture;
			parameters[5].Value = model.St_analog_min_value;
			parameters[6].Value = model.St_analog_max_value;
			parameters[7].Value = model.St_analog_min_range;
			parameters[8].Value = model.St_analog_max_range;
			parameters[9].Value = model.St_counter_value_per_pulse;
			parameters[10].Value = model.St_switching_true_state;
			parameters[11].Value = model.St_switching_false_state;
			parameters[12].Value = model.St_map_1;
			parameters[13].Value = model.St_map_2;
			parameters[14].Value = model.St_map_3;
			parameters[15].Value = model.St_map_4;
			parameters[16].Value = model.St_map_5;
			parameters[17].Value = model.St_ID;

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
		public bool Delete(int St_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sensor_type ");
			strSql.Append(" where St_ID=@St_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@St_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = St_ID;

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
		public bool DeleteList(string St_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sensor_type ");
			strSql.Append(" where St_ID in ("+St_IDlist + ")  ");
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
        public SensorTypeEntity GetModel(int St_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 St_ID,St_ModelNumber,St_name,VT_ID,St_attr,St_manufacture,St_analog_min_value,St_analog_max_value,St_analog_min_range,St_analog_max_range,St_counter_value_per_pulse,St_switching_true_state,St_switching_false_state,St_map_1,St_map_2,St_map_3,St_map_4,St_map_5 from Sensor_type ");
			strSql.Append(" where St_ID=@St_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@St_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = St_ID;

            SensorTypeEntity model = new SensorTypeEntity();
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
        public SensorTypeEntity DataRowToModel(DataRow row)
		{
            SensorTypeEntity model = new SensorTypeEntity();
			if (row != null)
			{
				if(row["St_ID"]!=null && row["St_ID"].ToString()!="")
				{
					model.St_ID=int.Parse(row["St_ID"].ToString());
				}
				if(row["St_ModelNumber"]!=null)
				{
					model.St_ModelNumber=row["St_ModelNumber"].ToString();
				}
				if(row["St_name"]!=null)
				{
					model.St_name=row["St_name"].ToString();
				}
				if(row["VT_ID"]!=null)
				{
					model.VT_ID=row["VT_ID"].ToString();
				}
				if(row["St_attr"]!=null)
				{
					model.St_attr=row["St_attr"].ToString();
				}
				if(row["St_manufacture"]!=null)
				{
					model.St_manufacture=row["St_manufacture"].ToString();
				}
				if(row["St_analog_min_value"]!=null && row["St_analog_min_value"].ToString()!="")
				{
					model.St_analog_min_value=int.Parse(row["St_analog_min_value"].ToString());
				}
				if(row["St_analog_max_value"]!=null && row["St_analog_max_value"].ToString()!="")
				{
					model.St_analog_max_value=int.Parse(row["St_analog_max_value"].ToString());
				}
				if(row["St_analog_min_range"]!=null && row["St_analog_min_range"].ToString()!="")
				{
					model.St_analog_min_range=int.Parse(row["St_analog_min_range"].ToString());
				}
				if(row["St_analog_max_range"]!=null && row["St_analog_max_range"].ToString()!="")
				{
					model.St_analog_max_range=int.Parse(row["St_analog_max_range"].ToString());
				}
				if(row["St_counter_value_per_pulse"]!=null && row["St_counter_value_per_pulse"].ToString()!="")
				{
					model.St_counter_value_per_pulse=decimal.Parse(row["St_counter_value_per_pulse"].ToString());
				}
				if(row["St_switching_true_state"]!=null)
				{
					model.St_switching_true_state=row["St_switching_true_state"].ToString();
				}
				if(row["St_switching_false_state"]!=null)
				{
					model.St_switching_false_state=row["St_switching_false_state"].ToString();
				}
				if(row["St_map_1"]!=null)
				{
					model.St_map_1=row["St_map_1"].ToString();
				}
				if(row["St_map_2"]!=null)
				{
					model.St_map_2=row["St_map_2"].ToString();
				}
				if(row["St_map_3"]!=null)
				{
					model.St_map_3=row["St_map_3"].ToString();
				}
				if(row["St_map_4"]!=null)
				{
					model.St_map_4=row["St_map_4"].ToString();
				}
				if(row["St_map_5"]!=null)
				{
					model.St_map_5=row["St_map_5"].ToString();
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
			strSql.Append("select St_ID,St_ModelNumber,St_name,VT_ID,St_attr,St_manufacture,St_analog_min_value,St_analog_max_value,St_analog_min_range,St_analog_max_range,St_counter_value_per_pulse,St_switching_true_state,St_switching_false_state,St_map_1,St_map_2,St_map_3,St_map_4,St_map_5 ");
			strSql.Append(" FROM Sensor_type ");
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
			strSql.Append(" St_ID,St_ModelNumber,St_name,VT_ID,St_attr,St_manufacture,St_analog_min_value,St_analog_max_value,St_analog_min_range,St_analog_max_range,St_counter_value_per_pulse,St_switching_true_state,St_switching_false_state,St_map_1,St_map_2,St_map_3,St_map_4,St_map_5 ");
			strSql.Append(" FROM Sensor_type ");
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
			strSql.Append("select count(1) FROM Sensor_type ");
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
				strSql.Append("order by T.St_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Sensor_type T ");
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
			parameters[0].Value = "Sensor_type";
			parameters[1].Value = "St_ID";
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

