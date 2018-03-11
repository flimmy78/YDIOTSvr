/**  版本信息模板在安装目录下，可自行修改。
* User.cs
*
* 功 能： N/A
* 类 名： User
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:45   N/A    初版
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
	/// 数据访问类:UserDAL
	/// </summary>
	public partial class UserDAL
	{
        public UserDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Us_ID", "User"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Us_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from User");
			strSql.Append(" where Us_ID=@Us_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Us_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Us_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(UserEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into User(");
			strSql.Append("Rl_ID,GP_ID,Administration_ID,Department_name,Us_name,Us_password,Us_truename,Us_telphone,Us_cellphone,Us_address,Us_email,Us_State)");
			strSql.Append(" values (");
			strSql.Append("@Rl_ID,@GP_ID,@Administration_ID,@Department_name,@Us_name,@Us_password,@Us_truename,@Us_telphone,@Us_cellphone,@Us_address,@Us_email,@Us_State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Rl_ID", SqlDbType.Int,4),
					new SqlParameter("@GP_ID", SqlDbType.Int,4),
					new SqlParameter("@Administration_ID", SqlDbType.Bit,1),
					new SqlParameter("@Department_name", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_name", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_password", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_truename", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_telphone", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_cellphone", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_address", SqlDbType.NVarChar,100),
					new SqlParameter("@Us_email", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_State", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Rl_ID;
			parameters[1].Value = model.GP_ID;
			parameters[2].Value = model.Administration_ID;
			parameters[3].Value = model.Department_name;
			parameters[4].Value = model.Us_name;
			parameters[5].Value = model.Us_password;
			parameters[6].Value = model.Us_truename;
			parameters[7].Value = model.Us_telphone;
			parameters[8].Value = model.Us_cellphone;
			parameters[9].Value = model.Us_address;
			parameters[10].Value = model.Us_email;
			parameters[11].Value = model.Us_State;

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
		public bool Update(UserEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update User set ");
			strSql.Append("Rl_ID=@Rl_ID,");
			strSql.Append("GP_ID=@GP_ID,");
			strSql.Append("Administration_ID=@Administration_ID,");
			strSql.Append("Department_name=@Department_name,");
			strSql.Append("Us_name=@Us_name,");
			strSql.Append("Us_password=@Us_password,");
			strSql.Append("Us_truename=@Us_truename,");
			strSql.Append("Us_telphone=@Us_telphone,");
			strSql.Append("Us_cellphone=@Us_cellphone,");
			strSql.Append("Us_address=@Us_address,");
			strSql.Append("Us_email=@Us_email,");
			strSql.Append("Us_State=@Us_State");
			strSql.Append(" where Us_ID=@Us_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Rl_ID", SqlDbType.Int,4),
					new SqlParameter("@GP_ID", SqlDbType.Int,4),
					new SqlParameter("@Administration_ID", SqlDbType.Bit,1),
					new SqlParameter("@Department_name", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_name", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_password", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_truename", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_telphone", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_cellphone", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_address", SqlDbType.NVarChar,100),
					new SqlParameter("@Us_email", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_State", SqlDbType.NVarChar,50),
					new SqlParameter("@Us_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Rl_ID;
			parameters[1].Value = model.GP_ID;
			parameters[2].Value = model.Administration_ID;
			parameters[3].Value = model.Department_name;
			parameters[4].Value = model.Us_name;
			parameters[5].Value = model.Us_password;
			parameters[6].Value = model.Us_truename;
			parameters[7].Value = model.Us_telphone;
			parameters[8].Value = model.Us_cellphone;
			parameters[9].Value = model.Us_address;
			parameters[10].Value = model.Us_email;
			parameters[11].Value = model.Us_State;
			parameters[12].Value = model.Us_ID;

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
		public bool Delete(int Us_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from User ");
			strSql.Append(" where Us_ID=@Us_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Us_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Us_ID;

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
		public bool DeleteList(string Us_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from User ");
			strSql.Append(" where Us_ID in ("+Us_IDlist + ")  ");
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
		public UserEntity GetModel(int Us_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Us_ID,Rl_ID,GP_ID,Administration_ID,Department_name,Us_name,Us_password,Us_truename,Us_telphone,Us_cellphone,Us_address,Us_email,Us_State from User ");
			strSql.Append(" where Us_ID=@Us_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Us_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Us_ID;

			UserEntity model=new UserEntity();
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
		public UserEntity DataRowToModel(DataRow row)
		{
			UserEntity model=new UserEntity();
			if (row != null)
			{
				if(row["Us_ID"]!=null && row["Us_ID"].ToString()!="")
				{
					model.Us_ID=int.Parse(row["Us_ID"].ToString());
				}
				if(row["Rl_ID"]!=null && row["Rl_ID"].ToString()!="")
				{
					model.Rl_ID=int.Parse(row["Rl_ID"].ToString());
				}
				if(row["GP_ID"]!=null && row["GP_ID"].ToString()!="")
				{
					model.GP_ID=int.Parse(row["GP_ID"].ToString());
				}
				if(row["Administration_ID"]!=null && row["Administration_ID"].ToString()!="")
				{
					if((row["Administration_ID"].ToString()=="1")||(row["Administration_ID"].ToString().ToLower()=="true"))
					{
						model.Administration_ID=true;
					}
					else
					{
						model.Administration_ID=false;
					}
				}
				if(row["Department_name"]!=null)
				{
					model.Department_name=row["Department_name"].ToString();
				}
				if(row["Us_name"]!=null)
				{
					model.Us_name=row["Us_name"].ToString();
				}
				if(row["Us_password"]!=null)
				{
					model.Us_password=row["Us_password"].ToString();
				}
				if(row["Us_truename"]!=null)
				{
					model.Us_truename=row["Us_truename"].ToString();
				}
				if(row["Us_telphone"]!=null)
				{
					model.Us_telphone=row["Us_telphone"].ToString();
				}
				if(row["Us_cellphone"]!=null)
				{
					model.Us_cellphone=row["Us_cellphone"].ToString();
				}
				if(row["Us_address"]!=null)
				{
					model.Us_address=row["Us_address"].ToString();
				}
				if(row["Us_email"]!=null)
				{
					model.Us_email=row["Us_email"].ToString();
				}
				if(row["Us_State"]!=null)
				{
					model.Us_State=row["Us_State"].ToString();
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
			strSql.Append("select Us_ID,Rl_ID,GP_ID,Administration_ID,Department_name,Us_name,Us_password,Us_truename,Us_telphone,Us_cellphone,Us_address,Us_email,Us_State ");
			strSql.Append(" FROM User ");
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
			strSql.Append(" Us_ID,Rl_ID,GP_ID,Administration_ID,Department_name,Us_name,Us_password,Us_truename,Us_telphone,Us_cellphone,Us_address,Us_email,Us_State ");
			strSql.Append(" FROM User ");
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
			strSql.Append("select count(1) FROM User ");
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
				strSql.Append("order by T.Us_ID desc");
			}
			strSql.Append(")AS Row, T.*  from User T ");
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
			parameters[0].Value = "User";
			parameters[1].Value = "Us_ID";
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

