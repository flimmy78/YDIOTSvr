/**  版本信息模板在安装目录下，可自行修改。
* AcutuatorType.cs
*
* 功 能： N/A
* 类 名： AcutuatorType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/4/5 20:13:26   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：元大信息科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using YDIOTSvr.DataLayer.DAL;
using YDIOTSvr.DataLayer.Entity;
namespace YDIOTSvr.DataLayer.BLL
{
	/// <summary>
	/// 执行器类型表
	/// </summary>
	public partial class AcutuatorTypeBLL
	{
		private readonly AcutuatorTypeDAL dal=new AcutuatorTypeDAL();
		public AcutuatorTypeBLL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int At_ID)
		{
			return dal.Exists(At_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(AcutuatorTypeEntity model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AcutuatorTypeEntity model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int At_ID)
		{
			
			return dal.Delete(At_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string At_IDlist )
		{
			return dal.DeleteList(At_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AcutuatorTypeEntity GetModel(int At_ID)
		{
			
			return dal.GetModel(At_ID);
		}

	
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AcutuatorTypeEntity> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AcutuatorTypeEntity> DataTableToList(DataTable dt)
		{
			List<AcutuatorTypeEntity> modelList = new List<AcutuatorTypeEntity>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AcutuatorTypeEntity model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

