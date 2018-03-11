/**  版本信息模板在安装目录下，可自行修改。
* IrrigationgConfig.cs
*
* 功 能： N/A
* 类 名： IrrigationgConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:32   N/A    初版
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
	/// 数据访问类:IrrigationgConfigDAL
	/// </summary>
	public partial class IrrigationgConfigDAL
	{
        public IrrigationgConfigDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AIC_ID", "IrrigationgConfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AIC_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from IrrigationgConfig");
			strSql.Append(" where AIC_ID=@AIC_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = AIC_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IrrigationgConfigEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into IrrigationgConfig(");
			strSql.Append("AIC_Is_Auto,MS_ID,Soil_Moisture_Low,Soil_Moisture_Low_Valid,Soil_Moisture_Mid,Soil_Moisture_Mid_Valid,Soil_Moisture_Deep,Soil_Moisture_Deep_Valid,AIC_Moisture_Low,AIC_Moisture_High,AIC_Moisture_Unit,AIC_Water_Volume,AIC_Flow_Gauge,AIC_Polling_Interval,AIC_Start_Action1_Acutuation,AIC_Start_Action1_State,AIC_Start_Action2_Acutuation,AIC_Start_Action2_State,AIC_Start_Action3_Acutuation,AIC_Start_Action3_State,AIC_Start_Action4_Acutuation,AIC_Start_Action4_State,AIC_Shut_Action1_Acutuation,AIC_Shut_Action1_State,AIC_Shut_Action2_Acutuation,AIC_Shut_Action2_State,AIC_Shut_Action3_Acutuation,AIC_Shut_Action3_State,AIC_Shut_Action4_Acutuation,AIC_Shut_Action4_State)");
			strSql.Append(" values (");
			strSql.Append("@AIC_Is_Auto,@MS_ID,@Soil_Moisture_Low,@Soil_Moisture_Low_Valid,@Soil_Moisture_Mid,@Soil_Moisture_Mid_Valid,@Soil_Moisture_Deep,@Soil_Moisture_Deep_Valid,@AIC_Moisture_Low,@AIC_Moisture_High,@AIC_Moisture_Unit,@AIC_Water_Volume,@AIC_Flow_Gauge,@AIC_Polling_Interval,@AIC_Start_Action1_Acutuation,@AIC_Start_Action1_State,@AIC_Start_Action2_Acutuation,@AIC_Start_Action2_State,@AIC_Start_Action3_Acutuation,@AIC_Start_Action3_State,@AIC_Start_Action4_Acutuation,@AIC_Start_Action4_State,@AIC_Shut_Action1_Acutuation,@AIC_Shut_Action1_State,@AIC_Shut_Action2_Acutuation,@AIC_Shut_Action2_State,@AIC_Shut_Action3_Acutuation,@AIC_Shut_Action3_State,@AIC_Shut_Action4_Acutuation,@AIC_Shut_Action4_State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AIC_Is_Auto", SqlDbType.Bit,1),
					new SqlParameter("@MS_ID", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Low", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Low_Valid", SqlDbType.Bit,1),
					new SqlParameter("@Soil_Moisture_Mid", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Mid_Valid", SqlDbType.Bit,1),
					new SqlParameter("@Soil_Moisture_Deep", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Deep_Valid", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Moisture_Low", SqlDbType.Int,4),
					new SqlParameter("@AIC_Moisture_High", SqlDbType.Int,4),
					new SqlParameter("@AIC_Moisture_Unit", SqlDbType.NVarChar,10),
					new SqlParameter("@AIC_Water_Volume", SqlDbType.Float,8),
					new SqlParameter("@AIC_Flow_Gauge", SqlDbType.Int,4),
					new SqlParameter("@AIC_Polling_Interval", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action1_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action1_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Start_Action2_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action2_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Start_Action3_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action3_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Start_Action4_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action4_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Shut_Action1_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Shut_Action1_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Shut_Action2_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Shut_Action2_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Shut_Action3_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Shut_Action3_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Shut_Action4_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Shut_Action4_State", SqlDbType.Bit,1)};
			parameters[0].Value = model.AIC_Is_Auto;
			parameters[1].Value = model.MS_ID;
			parameters[2].Value = model.Soil_Moisture_Low;
			parameters[3].Value = model.Soil_Moisture_Low_Valid;
			parameters[4].Value = model.Soil_Moisture_Mid;
			parameters[5].Value = model.Soil_Moisture_Mid_Valid;
			parameters[6].Value = model.Soil_Moisture_Deep;
			parameters[7].Value = model.Soil_Moisture_Deep_Valid;
			parameters[8].Value = model.AIC_Moisture_Low;
			parameters[9].Value = model.AIC_Moisture_High;
			parameters[10].Value = model.AIC_Moisture_Unit;
			parameters[11].Value = model.AIC_Water_Volume;
			parameters[12].Value = model.AIC_Flow_Gauge;
			parameters[13].Value = model.AIC_Polling_Interval;
			parameters[14].Value = model.AIC_Start_Action1_Acutuation;
			parameters[15].Value = model.AIC_Start_Action1_State;
			parameters[16].Value = model.AIC_Start_Action2_Acutuation;
			parameters[17].Value = model.AIC_Start_Action2_State;
			parameters[18].Value = model.AIC_Start_Action3_Acutuation;
			parameters[19].Value = model.AIC_Start_Action3_State;
			parameters[20].Value = model.AIC_Start_Action4_Acutuation;
			parameters[21].Value = model.AIC_Start_Action4_State;
			parameters[22].Value = model.AIC_Shut_Action1_Acutuation;
			parameters[23].Value = model.AIC_Shut_Action1_State;
			parameters[24].Value = model.AIC_Shut_Action2_Acutuation;
			parameters[25].Value = model.AIC_Shut_Action2_State;
			parameters[26].Value = model.AIC_Shut_Action3_Acutuation;
			parameters[27].Value = model.AIC_Shut_Action3_State;
			parameters[28].Value = model.AIC_Shut_Action4_Acutuation;
			parameters[29].Value = model.AIC_Shut_Action4_State;

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
		public bool Update(IrrigationgConfigEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update IrrigationgConfig set ");
			strSql.Append("AIC_Is_Auto=@AIC_Is_Auto,");
			strSql.Append("MS_ID=@MS_ID,");
			strSql.Append("Soil_Moisture_Low=@Soil_Moisture_Low,");
			strSql.Append("Soil_Moisture_Low_Valid=@Soil_Moisture_Low_Valid,");
			strSql.Append("Soil_Moisture_Mid=@Soil_Moisture_Mid,");
			strSql.Append("Soil_Moisture_Mid_Valid=@Soil_Moisture_Mid_Valid,");
			strSql.Append("Soil_Moisture_Deep=@Soil_Moisture_Deep,");
			strSql.Append("Soil_Moisture_Deep_Valid=@Soil_Moisture_Deep_Valid,");
			strSql.Append("AIC_Moisture_Low=@AIC_Moisture_Low,");
			strSql.Append("AIC_Moisture_High=@AIC_Moisture_High,");
			strSql.Append("AIC_Moisture_Unit=@AIC_Moisture_Unit,");
			strSql.Append("AIC_Water_Volume=@AIC_Water_Volume,");
			strSql.Append("AIC_Flow_Gauge=@AIC_Flow_Gauge,");
			strSql.Append("AIC_Polling_Interval=@AIC_Polling_Interval,");
			strSql.Append("AIC_Start_Action1_Acutuation=@AIC_Start_Action1_Acutuation,");
			strSql.Append("AIC_Start_Action1_State=@AIC_Start_Action1_State,");
			strSql.Append("AIC_Start_Action2_Acutuation=@AIC_Start_Action2_Acutuation,");
			strSql.Append("AIC_Start_Action2_State=@AIC_Start_Action2_State,");
			strSql.Append("AIC_Start_Action3_Acutuation=@AIC_Start_Action3_Acutuation,");
			strSql.Append("AIC_Start_Action3_State=@AIC_Start_Action3_State,");
			strSql.Append("AIC_Start_Action4_Acutuation=@AIC_Start_Action4_Acutuation,");
			strSql.Append("AIC_Start_Action4_State=@AIC_Start_Action4_State,");
			strSql.Append("AIC_Shut_Action1_Acutuation=@AIC_Shut_Action1_Acutuation,");
			strSql.Append("AIC_Shut_Action1_State=@AIC_Shut_Action1_State,");
			strSql.Append("AIC_Shut_Action2_Acutuation=@AIC_Shut_Action2_Acutuation,");
			strSql.Append("AIC_Shut_Action2_State=@AIC_Shut_Action2_State,");
			strSql.Append("AIC_Shut_Action3_Acutuation=@AIC_Shut_Action3_Acutuation,");
			strSql.Append("AIC_Shut_Action3_State=@AIC_Shut_Action3_State,");
			strSql.Append("AIC_Shut_Action4_Acutuation=@AIC_Shut_Action4_Acutuation,");
			strSql.Append("AIC_Shut_Action4_State=@AIC_Shut_Action4_State");
			strSql.Append(" where AIC_ID=@AIC_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIC_Is_Auto", SqlDbType.Bit,1),
					new SqlParameter("@MS_ID", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Low", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Low_Valid", SqlDbType.Bit,1),
					new SqlParameter("@Soil_Moisture_Mid", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Mid_Valid", SqlDbType.Bit,1),
					new SqlParameter("@Soil_Moisture_Deep", SqlDbType.Int,4),
					new SqlParameter("@Soil_Moisture_Deep_Valid", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Moisture_Low", SqlDbType.Int,4),
					new SqlParameter("@AIC_Moisture_High", SqlDbType.Int,4),
					new SqlParameter("@AIC_Moisture_Unit", SqlDbType.NVarChar,10),
					new SqlParameter("@AIC_Water_Volume", SqlDbType.Float,8),
					new SqlParameter("@AIC_Flow_Gauge", SqlDbType.Int,4),
					new SqlParameter("@AIC_Polling_Interval", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action1_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action1_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Start_Action2_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action2_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Start_Action3_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action3_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Start_Action4_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Start_Action4_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Shut_Action1_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Shut_Action1_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Shut_Action2_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Shut_Action2_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Shut_Action3_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Shut_Action3_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_Shut_Action4_Acutuation", SqlDbType.Int,4),
					new SqlParameter("@AIC_Shut_Action4_State", SqlDbType.Bit,1),
					new SqlParameter("@AIC_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.AIC_Is_Auto;
			parameters[1].Value = model.MS_ID;
			parameters[2].Value = model.Soil_Moisture_Low;
			parameters[3].Value = model.Soil_Moisture_Low_Valid;
			parameters[4].Value = model.Soil_Moisture_Mid;
			parameters[5].Value = model.Soil_Moisture_Mid_Valid;
			parameters[6].Value = model.Soil_Moisture_Deep;
			parameters[7].Value = model.Soil_Moisture_Deep_Valid;
			parameters[8].Value = model.AIC_Moisture_Low;
			parameters[9].Value = model.AIC_Moisture_High;
			parameters[10].Value = model.AIC_Moisture_Unit;
			parameters[11].Value = model.AIC_Water_Volume;
			parameters[12].Value = model.AIC_Flow_Gauge;
			parameters[13].Value = model.AIC_Polling_Interval;
			parameters[14].Value = model.AIC_Start_Action1_Acutuation;
			parameters[15].Value = model.AIC_Start_Action1_State;
			parameters[16].Value = model.AIC_Start_Action2_Acutuation;
			parameters[17].Value = model.AIC_Start_Action2_State;
			parameters[18].Value = model.AIC_Start_Action3_Acutuation;
			parameters[19].Value = model.AIC_Start_Action3_State;
			parameters[20].Value = model.AIC_Start_Action4_Acutuation;
			parameters[21].Value = model.AIC_Start_Action4_State;
			parameters[22].Value = model.AIC_Shut_Action1_Acutuation;
			parameters[23].Value = model.AIC_Shut_Action1_State;
			parameters[24].Value = model.AIC_Shut_Action2_Acutuation;
			parameters[25].Value = model.AIC_Shut_Action2_State;
			parameters[26].Value = model.AIC_Shut_Action3_Acutuation;
			parameters[27].Value = model.AIC_Shut_Action3_State;
			parameters[28].Value = model.AIC_Shut_Action4_Acutuation;
			parameters[29].Value = model.AIC_Shut_Action4_State;
			parameters[30].Value = model.AIC_ID;

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
		public bool Delete(int AIC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from IrrigationgConfig ");
			strSql.Append(" where AIC_ID=@AIC_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = AIC_ID;

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
		public bool DeleteList(string AIC_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from IrrigationgConfig ");
			strSql.Append(" where AIC_ID in ("+AIC_IDlist + ")  ");
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
		public IrrigationgConfigEntity GetModel(int AIC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AIC_ID,AIC_Is_Auto,MS_ID,Soil_Moisture_Low,Soil_Moisture_Low_Valid,Soil_Moisture_Mid,Soil_Moisture_Mid_Valid,Soil_Moisture_Deep,Soil_Moisture_Deep_Valid,AIC_Moisture_Low,AIC_Moisture_High,AIC_Moisture_Unit,AIC_Water_Volume,AIC_Flow_Gauge,AIC_Polling_Interval,AIC_Start_Action1_Acutuation,AIC_Start_Action1_State,AIC_Start_Action2_Acutuation,AIC_Start_Action2_State,AIC_Start_Action3_Acutuation,AIC_Start_Action3_State,AIC_Start_Action4_Acutuation,AIC_Start_Action4_State,AIC_Shut_Action1_Acutuation,AIC_Shut_Action1_State,AIC_Shut_Action2_Acutuation,AIC_Shut_Action2_State,AIC_Shut_Action3_Acutuation,AIC_Shut_Action3_State,AIC_Shut_Action4_Acutuation,AIC_Shut_Action4_State from IrrigationgConfig ");
			strSql.Append(" where AIC_ID=@AIC_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AIC_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = AIC_ID;

			IrrigationgConfigEntity model=new IrrigationgConfigEntity();
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
		public IrrigationgConfigEntity DataRowToModel(DataRow row)
		{
			IrrigationgConfigEntity model=new IrrigationgConfigEntity();
			if (row != null)
			{
				if(row["AIC_ID"]!=null && row["AIC_ID"].ToString()!="")
				{
					model.AIC_ID=int.Parse(row["AIC_ID"].ToString());
				}
				if(row["AIC_Is_Auto"]!=null && row["AIC_Is_Auto"].ToString()!="")
				{
					if((row["AIC_Is_Auto"].ToString()=="1")||(row["AIC_Is_Auto"].ToString().ToLower()=="true"))
					{
						model.AIC_Is_Auto=true;
					}
					else
					{
						model.AIC_Is_Auto=false;
					}
				}
				if(row["MS_ID"]!=null && row["MS_ID"].ToString()!="")
				{
					model.MS_ID=int.Parse(row["MS_ID"].ToString());
				}
				if(row["Soil_Moisture_Low"]!=null && row["Soil_Moisture_Low"].ToString()!="")
				{
					model.Soil_Moisture_Low=int.Parse(row["Soil_Moisture_Low"].ToString());
				}
				if(row["Soil_Moisture_Low_Valid"]!=null && row["Soil_Moisture_Low_Valid"].ToString()!="")
				{
					if((row["Soil_Moisture_Low_Valid"].ToString()=="1")||(row["Soil_Moisture_Low_Valid"].ToString().ToLower()=="true"))
					{
						model.Soil_Moisture_Low_Valid=true;
					}
					else
					{
						model.Soil_Moisture_Low_Valid=false;
					}
				}
				if(row["Soil_Moisture_Mid"]!=null && row["Soil_Moisture_Mid"].ToString()!="")
				{
					model.Soil_Moisture_Mid=int.Parse(row["Soil_Moisture_Mid"].ToString());
				}
				if(row["Soil_Moisture_Mid_Valid"]!=null && row["Soil_Moisture_Mid_Valid"].ToString()!="")
				{
					if((row["Soil_Moisture_Mid_Valid"].ToString()=="1")||(row["Soil_Moisture_Mid_Valid"].ToString().ToLower()=="true"))
					{
						model.Soil_Moisture_Mid_Valid=true;
					}
					else
					{
						model.Soil_Moisture_Mid_Valid=false;
					}
				}
				if(row["Soil_Moisture_Deep"]!=null && row["Soil_Moisture_Deep"].ToString()!="")
				{
					model.Soil_Moisture_Deep=int.Parse(row["Soil_Moisture_Deep"].ToString());
				}
				if(row["Soil_Moisture_Deep_Valid"]!=null && row["Soil_Moisture_Deep_Valid"].ToString()!="")
				{
					if((row["Soil_Moisture_Deep_Valid"].ToString()=="1")||(row["Soil_Moisture_Deep_Valid"].ToString().ToLower()=="true"))
					{
						model.Soil_Moisture_Deep_Valid=true;
					}
					else
					{
						model.Soil_Moisture_Deep_Valid=false;
					}
				}
				if(row["AIC_Moisture_Low"]!=null && row["AIC_Moisture_Low"].ToString()!="")
				{
					model.AIC_Moisture_Low=int.Parse(row["AIC_Moisture_Low"].ToString());
				}
				if(row["AIC_Moisture_High"]!=null && row["AIC_Moisture_High"].ToString()!="")
				{
					model.AIC_Moisture_High=int.Parse(row["AIC_Moisture_High"].ToString());
				}
				if(row["AIC_Moisture_Unit"]!=null)
				{
					model.AIC_Moisture_Unit=row["AIC_Moisture_Unit"].ToString();
				}
				if(row["AIC_Water_Volume"]!=null && row["AIC_Water_Volume"].ToString()!="")
				{
					model.AIC_Water_Volume=decimal.Parse(row["AIC_Water_Volume"].ToString());
				}
				if(row["AIC_Flow_Gauge"]!=null && row["AIC_Flow_Gauge"].ToString()!="")
				{
					model.AIC_Flow_Gauge=int.Parse(row["AIC_Flow_Gauge"].ToString());
				}
				if(row["AIC_Polling_Interval"]!=null && row["AIC_Polling_Interval"].ToString()!="")
				{
					model.AIC_Polling_Interval=int.Parse(row["AIC_Polling_Interval"].ToString());
				}
				if(row["AIC_Start_Action1_Acutuation"]!=null && row["AIC_Start_Action1_Acutuation"].ToString()!="")
				{
					model.AIC_Start_Action1_Acutuation=int.Parse(row["AIC_Start_Action1_Acutuation"].ToString());
				}
				if(row["AIC_Start_Action1_State"]!=null && row["AIC_Start_Action1_State"].ToString()!="")
				{
					if((row["AIC_Start_Action1_State"].ToString()=="1")||(row["AIC_Start_Action1_State"].ToString().ToLower()=="true"))
					{
						model.AIC_Start_Action1_State=true;
					}
					else
					{
						model.AIC_Start_Action1_State=false;
					}
				}
				if(row["AIC_Start_Action2_Acutuation"]!=null && row["AIC_Start_Action2_Acutuation"].ToString()!="")
				{
					model.AIC_Start_Action2_Acutuation=int.Parse(row["AIC_Start_Action2_Acutuation"].ToString());
				}
				if(row["AIC_Start_Action2_State"]!=null && row["AIC_Start_Action2_State"].ToString()!="")
				{
					if((row["AIC_Start_Action2_State"].ToString()=="1")||(row["AIC_Start_Action2_State"].ToString().ToLower()=="true"))
					{
						model.AIC_Start_Action2_State=true;
					}
					else
					{
						model.AIC_Start_Action2_State=false;
					}
				}
				if(row["AIC_Start_Action3_Acutuation"]!=null && row["AIC_Start_Action3_Acutuation"].ToString()!="")
				{
					model.AIC_Start_Action3_Acutuation=int.Parse(row["AIC_Start_Action3_Acutuation"].ToString());
				}
				if(row["AIC_Start_Action3_State"]!=null && row["AIC_Start_Action3_State"].ToString()!="")
				{
					if((row["AIC_Start_Action3_State"].ToString()=="1")||(row["AIC_Start_Action3_State"].ToString().ToLower()=="true"))
					{
						model.AIC_Start_Action3_State=true;
					}
					else
					{
						model.AIC_Start_Action3_State=false;
					}
				}
				if(row["AIC_Start_Action4_Acutuation"]!=null && row["AIC_Start_Action4_Acutuation"].ToString()!="")
				{
					model.AIC_Start_Action4_Acutuation=int.Parse(row["AIC_Start_Action4_Acutuation"].ToString());
				}
				if(row["AIC_Start_Action4_State"]!=null && row["AIC_Start_Action4_State"].ToString()!="")
				{
					if((row["AIC_Start_Action4_State"].ToString()=="1")||(row["AIC_Start_Action4_State"].ToString().ToLower()=="true"))
					{
						model.AIC_Start_Action4_State=true;
					}
					else
					{
						model.AIC_Start_Action4_State=false;
					}
				}
				if(row["AIC_Shut_Action1_Acutuation"]!=null && row["AIC_Shut_Action1_Acutuation"].ToString()!="")
				{
					model.AIC_Shut_Action1_Acutuation=int.Parse(row["AIC_Shut_Action1_Acutuation"].ToString());
				}
				if(row["AIC_Shut_Action1_State"]!=null && row["AIC_Shut_Action1_State"].ToString()!="")
				{
					if((row["AIC_Shut_Action1_State"].ToString()=="1")||(row["AIC_Shut_Action1_State"].ToString().ToLower()=="true"))
					{
						model.AIC_Shut_Action1_State=true;
					}
					else
					{
						model.AIC_Shut_Action1_State=false;
					}
				}
				if(row["AIC_Shut_Action2_Acutuation"]!=null && row["AIC_Shut_Action2_Acutuation"].ToString()!="")
				{
					model.AIC_Shut_Action2_Acutuation=int.Parse(row["AIC_Shut_Action2_Acutuation"].ToString());
				}
				if(row["AIC_Shut_Action2_State"]!=null && row["AIC_Shut_Action2_State"].ToString()!="")
				{
					if((row["AIC_Shut_Action2_State"].ToString()=="1")||(row["AIC_Shut_Action2_State"].ToString().ToLower()=="true"))
					{
						model.AIC_Shut_Action2_State=true;
					}
					else
					{
						model.AIC_Shut_Action2_State=false;
					}
				}
				if(row["AIC_Shut_Action3_Acutuation"]!=null && row["AIC_Shut_Action3_Acutuation"].ToString()!="")
				{
					model.AIC_Shut_Action3_Acutuation=int.Parse(row["AIC_Shut_Action3_Acutuation"].ToString());
				}
				if(row["AIC_Shut_Action3_State"]!=null && row["AIC_Shut_Action3_State"].ToString()!="")
				{
					if((row["AIC_Shut_Action3_State"].ToString()=="1")||(row["AIC_Shut_Action3_State"].ToString().ToLower()=="true"))
					{
						model.AIC_Shut_Action3_State=true;
					}
					else
					{
						model.AIC_Shut_Action3_State=false;
					}
				}
				if(row["AIC_Shut_Action4_Acutuation"]!=null && row["AIC_Shut_Action4_Acutuation"].ToString()!="")
				{
					model.AIC_Shut_Action4_Acutuation=int.Parse(row["AIC_Shut_Action4_Acutuation"].ToString());
				}
				if(row["AIC_Shut_Action4_State"]!=null && row["AIC_Shut_Action4_State"].ToString()!="")
				{
					if((row["AIC_Shut_Action4_State"].ToString()=="1")||(row["AIC_Shut_Action4_State"].ToString().ToLower()=="true"))
					{
						model.AIC_Shut_Action4_State=true;
					}
					else
					{
						model.AIC_Shut_Action4_State=false;
					}
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
			strSql.Append("select AIC_ID,AIC_Is_Auto,MS_ID,Soil_Moisture_Low,Soil_Moisture_Low_Valid,Soil_Moisture_Mid,Soil_Moisture_Mid_Valid,Soil_Moisture_Deep,Soil_Moisture_Deep_Valid,AIC_Moisture_Low,AIC_Moisture_High,AIC_Moisture_Unit,AIC_Water_Volume,AIC_Flow_Gauge,AIC_Polling_Interval,AIC_Start_Action1_Acutuation,AIC_Start_Action1_State,AIC_Start_Action2_Acutuation,AIC_Start_Action2_State,AIC_Start_Action3_Acutuation,AIC_Start_Action3_State,AIC_Start_Action4_Acutuation,AIC_Start_Action4_State,AIC_Shut_Action1_Acutuation,AIC_Shut_Action1_State,AIC_Shut_Action2_Acutuation,AIC_Shut_Action2_State,AIC_Shut_Action3_Acutuation,AIC_Shut_Action3_State,AIC_Shut_Action4_Acutuation,AIC_Shut_Action4_State ");
			strSql.Append(" FROM IrrigationgConfig ");
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
			strSql.Append(" AIC_ID,AIC_Is_Auto,MS_ID,Soil_Moisture_Low,Soil_Moisture_Low_Valid,Soil_Moisture_Mid,Soil_Moisture_Mid_Valid,Soil_Moisture_Deep,Soil_Moisture_Deep_Valid,AIC_Moisture_Low,AIC_Moisture_High,AIC_Moisture_Unit,AIC_Water_Volume,AIC_Flow_Gauge,AIC_Polling_Interval,AIC_Start_Action1_Acutuation,AIC_Start_Action1_State,AIC_Start_Action2_Acutuation,AIC_Start_Action2_State,AIC_Start_Action3_Acutuation,AIC_Start_Action3_State,AIC_Start_Action4_Acutuation,AIC_Start_Action4_State,AIC_Shut_Action1_Acutuation,AIC_Shut_Action1_State,AIC_Shut_Action2_Acutuation,AIC_Shut_Action2_State,AIC_Shut_Action3_Acutuation,AIC_Shut_Action3_State,AIC_Shut_Action4_Acutuation,AIC_Shut_Action4_State ");
			strSql.Append(" FROM IrrigationgConfig ");
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
			strSql.Append("select count(1) FROM IrrigationgConfig ");
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
				strSql.Append("order by T.AIC_ID desc");
			}
			strSql.Append(")AS Row, T.*  from IrrigationgConfig T ");
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
			parameters[0].Value = "IrrigationgConfig";
			parameters[1].Value = "AIC_ID";
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

