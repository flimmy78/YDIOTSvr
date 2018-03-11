/**  版本信息模板在安装目录下，可自行修改。
* Module.cs
*
* 功 能： N/A
* 类 名： Module
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:37   N/A    初版
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
	/// 数据访问类:Module
	/// </summary>
	public partial class ModuleDAL
	{
        public ModuleDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Md_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Module");
			strSql.Append(" where Md_ID=@Md_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Md_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(StationEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Module(");
			strSql.Append("DTU_ID,Address,Md_ID,Mp_ID,Md_Protocol,Md_Baud,Md_0dd_even_check,Md_Stopbit)");
			strSql.Append(" values (");
			strSql.Append("@DTU_ID,@Address,@Md_ID,@Mp_ID,@Md_Protocol,@Md_Baud,@Md_0dd_even_check,@Md_Stopbit)");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.Int,4),
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Mp_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_Protocol", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_Baud", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_0dd_even_check", SqlDbType.Bit,1),
					new SqlParameter("@Md_Stopbit", SqlDbType.Int,4)};
			parameters[0].Value = model.DTU_ID;
			parameters[1].Value = model.Address;
			parameters[2].Value = model.Md_ID;
			parameters[3].Value = model.Mp_ID;
			parameters[4].Value = model.Md_Protocol;
			parameters[5].Value = model.Md_Baud;
			parameters[6].Value = model.Md_0dd_even_check;
			parameters[7].Value = model.Md_Stopbit;

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
		public bool Update(StationEntity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Module set ");
			strSql.Append("DTU_ID=@DTU_ID,");
			strSql.Append("Address=@Address,");
			strSql.Append("Mp_ID=@Mp_ID,");
			strSql.Append("Md_Protocol=@Md_Protocol,");
			strSql.Append("Md_Baud=@Md_Baud,");
			strSql.Append("Md_0dd_even_check=@Md_0dd_even_check,");
			strSql.Append("Md_Stopbit=@Md_Stopbit");
			strSql.Append(" where Md_ID=@Md_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DTU_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.Int,4),
					new SqlParameter("@Mp_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_Protocol", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_Baud", SqlDbType.NVarChar,50),
					new SqlParameter("@Md_0dd_even_check", SqlDbType.Bit,1),
					new SqlParameter("@Md_Stopbit", SqlDbType.Int,4),
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.DTU_ID;
			parameters[1].Value = model.Address;
			parameters[2].Value = model.Mp_ID;
			parameters[3].Value = model.Md_Protocol;
			parameters[4].Value = model.Md_Baud;
			parameters[5].Value = model.Md_0dd_even_check;
			parameters[6].Value = model.Md_Stopbit;
			parameters[7].Value = model.Md_ID;

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
		public bool Delete(string Md_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Module ");
			strSql.Append(" where Md_ID=@Md_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Md_ID;

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
		public bool DeleteList(string Md_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Module ");
			strSql.Append(" where Md_ID in ("+Md_IDlist + ")  ");
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
		public StationEntity GetModel(string Md_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DTU_ID,Address,Md_ID,Mp_ID,Md_Protocol,Md_Baud,Md_0dd_even_check,Md_Stopbit from Module ");
			strSql.Append(" where Md_ID=@Md_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Md_ID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Md_ID;

			StationEntity model=new StationEntity();
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
		public StationEntity DataRowToModel(DataRow row)
		{
			StationEntity model=new StationEntity();
			if (row != null)
			{
				if(row["DTU_ID"]!=null)
				{
					model.DTU_ID=row["DTU_ID"].ToString();
				}
				if(row["Address"]!=null && row["Address"].ToString()!="")
				{
					model.Address=row["Address"].ToString().ToString();
				}
				if(row["Md_ID"]!=null)
				{
					model.Md_ID=row["Md_ID"].ToString();
				}
				if(row["Mp_ID"]!=null)
				{
					model.Mp_ID=row["Mp_ID"].ToString();
				}
				if(row["Md_Protocol"]!=null)
				{
					model.Md_Protocol=row["Md_Protocol"].ToString();
				}
				if(row["Md_Baud"]!=null)
				{
					model.Md_Baud=row["Md_Baud"].ToString();
				}
				if(row["Md_0dd_even_check"]!=null && row["Md_0dd_even_check"].ToString()!="")
				{
					if((row["Md_0dd_even_check"].ToString()=="1")||(row["Md_0dd_even_check"].ToString().ToLower()=="true"))
					{
						model.Md_0dd_even_check=true;
					}
					else
					{
						model.Md_0dd_even_check=false;
					}
				}
				if(row["Md_Stopbit"]!=null && row["Md_Stopbit"].ToString()!="")
				{
					model.Md_Stopbit=int.Parse(row["Md_Stopbit"].ToString());
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
			strSql.Append("select DTU_ID,Address,Md_ID,Mp_ID,Md_Protocol,Md_Baud,Md_0dd_even_check,Md_Stopbit ");
			strSql.Append(" FROM Module ");
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
			strSql.Append(" DTU_ID,Address,Md_ID,Mp_ID,Md_Protocol,Md_Baud,Md_0dd_even_check,Md_Stopbit ");
			strSql.Append(" FROM Module ");
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
			strSql.Append("select count(1) FROM Module ");
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
				strSql.Append("order by T.Md_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Module T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}
		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

