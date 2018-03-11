using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//功能菜单权限
		public class FunctionMenuEntity
	{
   		     
      	/// <summary>
		/// FM_ID
        /// </summary>		
		private int _fm_id;
        public int FM_ID
        {
            get{ return _fm_id; }
            set{ _fm_id = value; }
        }        
		/// <summary>
		/// 具体功能界面-对应菜单名称）
        /// </summary>		
		private int _menu_id;
        public int Menu_ID
        {
            get{ return _menu_id; }
            set{ _menu_id = value; }
        }        
		/// <summary>
		/// 菜单ID
        /// </summary>		
		private string _fm_operating;
        public string FM_Operating
        {
            get{ return _fm_operating; }
            set{ _fm_operating = value; }
        }        
		/// <summary>
		/// 操作描述  比如-添加 修改 启动等
        /// </summary>		
		private string _fm_operdes;
        public string FM_OperDes
        {
            get{ return _fm_operdes; }
            set{ _fm_operdes = value; }
        }        
		/// <summary>
		/// 权限 0-无 1-有
        /// </summary>		
		private int _fm_limits;
        public int FM_Limits
        {
            get{ return _fm_limits; }
            set{ _fm_limits = value; }
        }        
		   
	}
}

