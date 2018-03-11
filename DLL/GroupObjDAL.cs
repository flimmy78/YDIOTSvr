/**  版本信息模板在安装目录下，可自行修改。
* GroupObj.cs
*
* 功 能： N/A
* 类 名： GroupObj
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:31   N/A    初版
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
	/// 数据访问类:GroupObj
	/// </summary>
	public partial class GroupObjDAL
	{
        public GroupObjDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Gp_ID", "GroupObj"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Gp_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GroupObj");
			strSql.Append(" where Gp_ID=@Gp_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Gp_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Gp_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(GroupObjEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GroupObj(");
			strSql.Append("Gp_Code,Gp_Name,Gp_sys_title,Gp_sys_title_vice,Gp_introduction,Gp_size,Gp_map,Gp_map_size,Gp_map_icon_width,Gp_map_icon_height,Gp_map_icon_color,Gp_map_icon_bg_color,Gp_longitude_center,Gp_dimensionality_center,Gp_longitude_east,Gp_longitude_west,Gp_dimensionality_south,Gp_dimensionality_north,Gp_user_number,Gp_well_number,Gp_DTU_number,Gp_card_number,Gp_card_password,Gp_polling_interval,Gp_store_interval,Gp_PID,GP_Map_Level,GP_MapLine_Color,GP_MapLine_Width,GP_Map_Opacity,Gp_SysName,Gp_IrrigateName,Remote_password)");
			strSql.Append(" values (");
			strSql.Append("@Gp_Code,@Gp_Name,@Gp_sys_title,@Gp_sys_title_vice,@Gp_introduction,@Gp_size,@Gp_map,@Gp_map_size,@Gp_map_icon_width,@Gp_map_icon_height,@Gp_map_icon_color,@Gp_map_icon_bg_color,@Gp_longitude_center,@Gp_dimensionality_center,@Gp_longitude_east,@Gp_longitude_west,@Gp_dimensionality_south,@Gp_dimensionality_north,@Gp_user_number,@Gp_well_number,@Gp_DTU_number,@Gp_card_number,@Gp_card_password,@Gp_polling_interval,@Gp_store_interval,@Gp_PID,@GP_Map_Level,@GP_MapLine_Color,@GP_MapLine_Width,@GP_Map_Opacity,@Gp_SysName,@Gp_IrrigateName,@Remote_password)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Gp_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_sys_title", SqlDbType.NVarChar,2000),
					new SqlParameter("@Gp_sys_title_vice", SqlDbType.NVarChar,2000),
					new SqlParameter("@Gp_introduction", SqlDbType.NText),
					new SqlParameter("@Gp_size", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_map", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_map_size", SqlDbType.Int,4),
					new SqlParameter("@Gp_map_icon_width", SqlDbType.Int,4),
					new SqlParameter("@Gp_map_icon_height", SqlDbType.Int,4),
					new SqlParameter("@Gp_map_icon_color", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_map_icon_bg_color", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_longitude_center", SqlDbType.Float,8),
					new SqlParameter("@Gp_dimensionality_center", SqlDbType.Float,8),
					new SqlParameter("@Gp_longitude_east", SqlDbType.Float,8),
					new SqlParameter("@Gp_longitude_west", SqlDbType.Float,8),
					new SqlParameter("@Gp_dimensionality_south", SqlDbType.Float,8),
					new SqlParameter("@Gp_dimensionality_north", SqlDbType.Float,8),
					new SqlParameter("@Gp_user_number", SqlDbType.Int,4),
					new SqlParameter("@Gp_well_number", SqlDbType.Int,4),
					new SqlParameter("@Gp_DTU_number", SqlDbType.Int,4),
					new SqlParameter("@Gp_card_number", SqlDbType.Int,4),
					new SqlParameter("@Gp_card_password", SqlDbType.Int,4),
					new SqlParameter("@Gp_polling_interval", SqlDbType.Int,4),
					new SqlParameter("@Gp_store_interval", SqlDbType.Int,4),
					new SqlParameter("@Gp_PID", SqlDbType.Int,4),
					new SqlParameter("@GP_Map_Level", SqlDbType.Int,4),
					new SqlParameter("@GP_MapLine_Color", SqlDbType.Int,4),
					new SqlParameter("@GP_MapLine_Width", SqlDbType.Int,4),
					new SqlParameter("@GP_Map_Opacity", SqlDbType.Float,8),
					new SqlParameter("@Gp_SysName", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_IrrigateName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remote_password", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Gp_Code;
			parameters[1].Value = model.Gp_Name;
			parameters[2].Value = model.Gp_sys_title;
			parameters[3].Value = model.Gp_sys_title_vice;
			parameters[4].Value = model.Gp_introduction;
			parameters[5].Value = model.Gp_size;
			parameters[6].Value = model.Gp_map;
			parameters[7].Value = model.Gp_map_size;
			parameters[8].Value = model.Gp_map_icon_width;
			parameters[9].Value = model.Gp_map_icon_height;
			parameters[10].Value = model.Gp_map_icon_color;
			parameters[11].Value = model.Gp_map_icon_bg_color;
			parameters[12].Value = model.Gp_longitude_center;
			parameters[13].Value = model.Gp_dimensionality_center;
			parameters[14].Value = model.Gp_longitude_east;
			parameters[15].Value = model.Gp_longitude_west;
			parameters[16].Value = model.Gp_dimensionality_south;
			parameters[17].Value = model.Gp_dimensionality_north;
			parameters[18].Value = model.Gp_user_number;
			parameters[19].Value = model.Gp_well_number;
			parameters[20].Value = model.Gp_DTU_number;
			parameters[21].Value = model.Gp_card_number;
			parameters[22].Value = model.Gp_card_password;
			parameters[23].Value = model.Gp_polling_interval;
			parameters[24].Value = model.Gp_store_interval;
			parameters[25].Value = model.Gp_PID;
			parameters[26].Value = model.GP_Map_Level;
			parameters[27].Value = model.GP_MapLine_Color;
			parameters[28].Value = model.GP_MapLine_Width;
			parameters[29].Value = model.GP_Map_Opacity;
			parameters[30].Value = model.Gp_SysName;
			parameters[31].Value = model.Gp_IrrigateName;
			parameters[32].Value = model.Remote_password;

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
		public bool Update(GroupObjEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GroupObj set ");
			strSql.Append("Gp_Code=@Gp_Code,");
			strSql.Append("Gp_Name=@Gp_Name,");
			strSql.Append("Gp_sys_title=@Gp_sys_title,");
			strSql.Append("Gp_sys_title_vice=@Gp_sys_title_vice,");
			strSql.Append("Gp_introduction=@Gp_introduction,");
			strSql.Append("Gp_size=@Gp_size,");
			strSql.Append("Gp_map=@Gp_map,");
			strSql.Append("Gp_map_size=@Gp_map_size,");
			strSql.Append("Gp_map_icon_width=@Gp_map_icon_width,");
			strSql.Append("Gp_map_icon_height=@Gp_map_icon_height,");
			strSql.Append("Gp_map_icon_color=@Gp_map_icon_color,");
			strSql.Append("Gp_map_icon_bg_color=@Gp_map_icon_bg_color,");
			strSql.Append("Gp_longitude_center=@Gp_longitude_center,");
			strSql.Append("Gp_dimensionality_center=@Gp_dimensionality_center,");
			strSql.Append("Gp_longitude_east=@Gp_longitude_east,");
			strSql.Append("Gp_longitude_west=@Gp_longitude_west,");
			strSql.Append("Gp_dimensionality_south=@Gp_dimensionality_south,");
			strSql.Append("Gp_dimensionality_north=@Gp_dimensionality_north,");
			strSql.Append("Gp_user_number=@Gp_user_number,");
			strSql.Append("Gp_well_number=@Gp_well_number,");
			strSql.Append("Gp_DTU_number=@Gp_DTU_number,");
			strSql.Append("Gp_card_number=@Gp_card_number,");
			strSql.Append("Gp_card_password=@Gp_card_password,");
			strSql.Append("Gp_polling_interval=@Gp_polling_interval,");
			strSql.Append("Gp_store_interval=@Gp_store_interval,");
			strSql.Append("Gp_PID=@Gp_PID,");
			strSql.Append("GP_Map_Level=@GP_Map_Level,");
			strSql.Append("GP_MapLine_Color=@GP_MapLine_Color,");
			strSql.Append("GP_MapLine_Width=@GP_MapLine_Width,");
			strSql.Append("GP_Map_Opacity=@GP_Map_Opacity,");
			strSql.Append("Gp_SysName=@Gp_SysName,");
			strSql.Append("Gp_IrrigateName=@Gp_IrrigateName,");
			strSql.Append("Remote_password=@Remote_password");
			strSql.Append(" where Gp_ID=@Gp_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Gp_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_sys_title", SqlDbType.NVarChar,2000),
					new SqlParameter("@Gp_sys_title_vice", SqlDbType.NVarChar,2000),
					new SqlParameter("@Gp_introduction", SqlDbType.NText),
					new SqlParameter("@Gp_size", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_map", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_map_size", SqlDbType.Int,4),
					new SqlParameter("@Gp_map_icon_width", SqlDbType.Int,4),
					new SqlParameter("@Gp_map_icon_height", SqlDbType.Int,4),
					new SqlParameter("@Gp_map_icon_color", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_map_icon_bg_color", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_longitude_center", SqlDbType.Float,8),
					new SqlParameter("@Gp_dimensionality_center", SqlDbType.Float,8),
					new SqlParameter("@Gp_longitude_east", SqlDbType.Float,8),
					new SqlParameter("@Gp_longitude_west", SqlDbType.Float,8),
					new SqlParameter("@Gp_dimensionality_south", SqlDbType.Float,8),
					new SqlParameter("@Gp_dimensionality_north", SqlDbType.Float,8),
					new SqlParameter("@Gp_user_number", SqlDbType.Int,4),
					new SqlParameter("@Gp_well_number", SqlDbType.Int,4),
					new SqlParameter("@Gp_DTU_number", SqlDbType.Int,4),
					new SqlParameter("@Gp_card_number", SqlDbType.Int,4),
					new SqlParameter("@Gp_card_password", SqlDbType.Int,4),
					new SqlParameter("@Gp_polling_interval", SqlDbType.Int,4),
					new SqlParameter("@Gp_store_interval", SqlDbType.Int,4),
					new SqlParameter("@Gp_PID", SqlDbType.Int,4),
					new SqlParameter("@GP_Map_Level", SqlDbType.Int,4),
					new SqlParameter("@GP_MapLine_Color", SqlDbType.Int,4),
					new SqlParameter("@GP_MapLine_Width", SqlDbType.Int,4),
					new SqlParameter("@GP_Map_Opacity", SqlDbType.Float,8),
					new SqlParameter("@Gp_SysName", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_IrrigateName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remote_password", SqlDbType.NVarChar,50),
					new SqlParameter("@Gp_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Gp_Code;
			parameters[1].Value = model.Gp_Name;
			parameters[2].Value = model.Gp_sys_title;
			parameters[3].Value = model.Gp_sys_title_vice;
			parameters[4].Value = model.Gp_introduction;
			parameters[5].Value = model.Gp_size;
			parameters[6].Value = model.Gp_map;
			parameters[7].Value = model.Gp_map_size;
			parameters[8].Value = model.Gp_map_icon_width;
			parameters[9].Value = model.Gp_map_icon_height;
			parameters[10].Value = model.Gp_map_icon_color;
			parameters[11].Value = model.Gp_map_icon_bg_color;
			parameters[12].Value = model.Gp_longitude_center;
			parameters[13].Value = model.Gp_dimensionality_center;
			parameters[14].Value = model.Gp_longitude_east;
			parameters[15].Value = model.Gp_longitude_west;
			parameters[16].Value = model.Gp_dimensionality_south;
			parameters[17].Value = model.Gp_dimensionality_north;
			parameters[18].Value = model.Gp_user_number;
			parameters[19].Value = model.Gp_well_number;
			parameters[20].Value = model.Gp_DTU_number;
			parameters[21].Value = model.Gp_card_number;
			parameters[22].Value = model.Gp_card_password;
			parameters[23].Value = model.Gp_polling_interval;
			parameters[24].Value = model.Gp_store_interval;
			parameters[25].Value = model.Gp_PID;
			parameters[26].Value = model.GP_Map_Level;
			parameters[27].Value = model.GP_MapLine_Color;
			parameters[28].Value = model.GP_MapLine_Width;
			parameters[29].Value = model.GP_Map_Opacity;
			parameters[30].Value = model.Gp_SysName;
			parameters[31].Value = model.Gp_IrrigateName;
			parameters[32].Value = model.Remote_password;
			parameters[33].Value = model.Gp_ID;

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
		public bool Delete(int Gp_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GroupObj ");
			strSql.Append(" where Gp_ID=@Gp_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Gp_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Gp_ID;

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
		public bool DeleteList(string Gp_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GroupObj ");
			strSql.Append(" where Gp_ID in ("+Gp_IDlist + ")  ");
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
		public GroupObjEntity GetModel(int Gp_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Gp_ID,Gp_Code,Gp_Name,Gp_sys_title,Gp_sys_title_vice,Gp_introduction,Gp_size,Gp_map,Gp_map_size,Gp_map_icon_width,Gp_map_icon_height,Gp_map_icon_color,Gp_map_icon_bg_color,Gp_longitude_center,Gp_dimensionality_center,Gp_longitude_east,Gp_longitude_west,Gp_dimensionality_south,Gp_dimensionality_north,Gp_user_number,Gp_well_number,Gp_DTU_number,Gp_card_number,Gp_card_password,Gp_polling_interval,Gp_store_interval,Gp_PID,GP_Map_Level,GP_MapLine_Color,GP_MapLine_Width,GP_Map_Opacity,Gp_SysName,Gp_IrrigateName,Remote_password from GroupObj ");
			strSql.Append(" where Gp_ID=@Gp_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Gp_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Gp_ID;

			GroupObjEntity model=new GroupObjEntity();
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
		public GroupObjEntity DataRowToModel(DataRow row)
		{
			GroupObjEntity model=new GroupObjEntity();
			if (row != null)
			{
				if(row["Gp_ID"]!=null && row["Gp_ID"].ToString()!="")
				{
					model.Gp_ID=int.Parse(row["Gp_ID"].ToString());
				}
				if(row["Gp_Code"]!=null)
				{
					model.Gp_Code=row["Gp_Code"].ToString();
				}
				if(row["Gp_Name"]!=null)
				{
					model.Gp_Name=row["Gp_Name"].ToString();
				}
				if(row["Gp_sys_title"]!=null)
				{
					model.Gp_sys_title=row["Gp_sys_title"].ToString();
				}
				if(row["Gp_sys_title_vice"]!=null)
				{
					model.Gp_sys_title_vice=row["Gp_sys_title_vice"].ToString();
				}
				if(row["Gp_introduction"]!=null)
				{
					model.Gp_introduction=row["Gp_introduction"].ToString();
				}
				if(row["Gp_size"]!=null)
				{
					model.Gp_size=row["Gp_size"].ToString();
				}
				if(row["Gp_map"]!=null)
				{
					model.Gp_map=row["Gp_map"].ToString();
				}
				if(row["Gp_map_size"]!=null && row["Gp_map_size"].ToString()!="")
				{
					model.Gp_map_size=int.Parse(row["Gp_map_size"].ToString());
				}
				if(row["Gp_map_icon_width"]!=null && row["Gp_map_icon_width"].ToString()!="")
				{
					model.Gp_map_icon_width=int.Parse(row["Gp_map_icon_width"].ToString());
				}
				if(row["Gp_map_icon_height"]!=null && row["Gp_map_icon_height"].ToString()!="")
				{
					model.Gp_map_icon_height=int.Parse(row["Gp_map_icon_height"].ToString());
				}
				if(row["Gp_map_icon_color"]!=null)
				{
					model.Gp_map_icon_color=row["Gp_map_icon_color"].ToString();
				}
				if(row["Gp_map_icon_bg_color"]!=null)
				{
					model.Gp_map_icon_bg_color=row["Gp_map_icon_bg_color"].ToString();
				}
				if(row["Gp_longitude_center"]!=null && row["Gp_longitude_center"].ToString()!="")
				{
					model.Gp_longitude_center=decimal.Parse(row["Gp_longitude_center"].ToString());
				}
				if(row["Gp_dimensionality_center"]!=null && row["Gp_dimensionality_center"].ToString()!="")
				{
					model.Gp_dimensionality_center=decimal.Parse(row["Gp_dimensionality_center"].ToString());
				}
				if(row["Gp_longitude_east"]!=null && row["Gp_longitude_east"].ToString()!="")
				{
					model.Gp_longitude_east=decimal.Parse(row["Gp_longitude_east"].ToString());
				}
				if(row["Gp_longitude_west"]!=null && row["Gp_longitude_west"].ToString()!="")
				{
					model.Gp_longitude_west=decimal.Parse(row["Gp_longitude_west"].ToString());
				}
				if(row["Gp_dimensionality_south"]!=null && row["Gp_dimensionality_south"].ToString()!="")
				{
					model.Gp_dimensionality_south=decimal.Parse(row["Gp_dimensionality_south"].ToString());
				}
				if(row["Gp_dimensionality_north"]!=null && row["Gp_dimensionality_north"].ToString()!="")
				{
					model.Gp_dimensionality_north=decimal.Parse(row["Gp_dimensionality_north"].ToString());
				}
				if(row["Gp_user_number"]!=null && row["Gp_user_number"].ToString()!="")
				{
					model.Gp_user_number=int.Parse(row["Gp_user_number"].ToString());
				}
				if(row["Gp_well_number"]!=null && row["Gp_well_number"].ToString()!="")
				{
					model.Gp_well_number=int.Parse(row["Gp_well_number"].ToString());
				}
				if(row["Gp_DTU_number"]!=null && row["Gp_DTU_number"].ToString()!="")
				{
					model.Gp_DTU_number=int.Parse(row["Gp_DTU_number"].ToString());
				}
				if(row["Gp_card_number"]!=null && row["Gp_card_number"].ToString()!="")
				{
					model.Gp_card_number=int.Parse(row["Gp_card_number"].ToString());
				}
				if(row["Gp_card_password"]!=null && row["Gp_card_password"].ToString()!="")
				{
					model.Gp_card_password=int.Parse(row["Gp_card_password"].ToString());
				}
				if(row["Gp_polling_interval"]!=null && row["Gp_polling_interval"].ToString()!="")
				{
					model.Gp_polling_interval=int.Parse(row["Gp_polling_interval"].ToString());
				}
				if(row["Gp_store_interval"]!=null && row["Gp_store_interval"].ToString()!="")
				{
					model.Gp_store_interval=int.Parse(row["Gp_store_interval"].ToString());
				}
				if(row["Gp_PID"]!=null && row["Gp_PID"].ToString()!="")
				{
					model.Gp_PID=int.Parse(row["Gp_PID"].ToString());
				}
				if(row["GP_Map_Level"]!=null && row["GP_Map_Level"].ToString()!="")
				{
					model.GP_Map_Level=int.Parse(row["GP_Map_Level"].ToString());
				}
				if(row["GP_MapLine_Color"]!=null && row["GP_MapLine_Color"].ToString()!="")
				{
					model.GP_MapLine_Color=int.Parse(row["GP_MapLine_Color"].ToString());
				}
				if(row["GP_MapLine_Width"]!=null && row["GP_MapLine_Width"].ToString()!="")
				{
					model.GP_MapLine_Width=int.Parse(row["GP_MapLine_Width"].ToString());
				}
				if(row["GP_Map_Opacity"]!=null && row["GP_Map_Opacity"].ToString()!="")
				{
					model.GP_Map_Opacity=decimal.Parse(row["GP_Map_Opacity"].ToString());
				}
				if(row["Gp_SysName"]!=null)
				{
					model.Gp_SysName=row["Gp_SysName"].ToString();
				}
				if(row["Gp_IrrigateName"]!=null)
				{
					model.Gp_IrrigateName=row["Gp_IrrigateName"].ToString();
				}
				if(row["Remote_password"]!=null)
				{
					model.Remote_password=row["Remote_password"].ToString();
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
			strSql.Append("select Gp_ID,Gp_Code,Gp_Name,Gp_sys_title,Gp_sys_title_vice,Gp_introduction,Gp_size,Gp_map,Gp_map_size,Gp_map_icon_width,Gp_map_icon_height,Gp_map_icon_color,Gp_map_icon_bg_color,Gp_longitude_center,Gp_dimensionality_center,Gp_longitude_east,Gp_longitude_west,Gp_dimensionality_south,Gp_dimensionality_north,Gp_user_number,Gp_well_number,Gp_DTU_number,Gp_card_number,Gp_card_password,Gp_polling_interval,Gp_store_interval,Gp_PID,GP_Map_Level,GP_MapLine_Color,GP_MapLine_Width,GP_Map_Opacity,Gp_SysName,Gp_IrrigateName,Remote_password ");
			strSql.Append(" FROM GroupObj ");
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
			strSql.Append(" Gp_ID,Gp_Code,Gp_Name,Gp_sys_title,Gp_sys_title_vice,Gp_introduction,Gp_size,Gp_map,Gp_map_size,Gp_map_icon_width,Gp_map_icon_height,Gp_map_icon_color,Gp_map_icon_bg_color,Gp_longitude_center,Gp_dimensionality_center,Gp_longitude_east,Gp_longitude_west,Gp_dimensionality_south,Gp_dimensionality_north,Gp_user_number,Gp_well_number,Gp_DTU_number,Gp_card_number,Gp_card_password,Gp_polling_interval,Gp_store_interval,Gp_PID,GP_Map_Level,GP_MapLine_Color,GP_MapLine_Width,GP_Map_Opacity,Gp_SysName,Gp_IrrigateName,Remote_password ");
			strSql.Append(" FROM GroupObj ");
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
			strSql.Append("select count(1) FROM GroupObj ");
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
				strSql.Append("order by T.Gp_ID desc");
			}
			strSql.Append(")AS Row, T.*  from GroupObj T ");
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
			parameters[0].Value = "GroupObj";
			parameters[1].Value = "Gp_ID";
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

