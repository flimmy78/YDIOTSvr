using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//功能模块表
		public class MenuEntity
	{
   		     
      	/// <summary>
		/// 菜单ID
        /// </summary>		
		private int _menu_id;
        public int Menu_ID
        {
            get{ return _menu_id; }
            set{ _menu_id = value; }
        }        
		/// <summary>
		/// 菜单类型 0-主菜单  1-功能菜单
        /// </summary>		
		private int _menu_type;
        public int Menu_Type
        {
            get{ return _menu_type; }
            set{ _menu_type = value; }
        }        
		/// <summary>
		/// 菜单名称
        /// </summary>		
		private string _menu_name;
        public string Menu_Name
        {
            get{ return _menu_name; }
            set{ _menu_name = value; }
        }        
		/// <summary>
		/// 菜单图标
        /// </summary>		
		private string _menu_icon;
        public string Menu_Icon
        {
            get{ return _menu_icon; }
            set{ _menu_icon = value; }
        }        
		/// <summary>
		/// 关联界面
        /// </summary>		
		private string _menu_page;
        public string Menu_Page
        {
            get{ return _menu_page; }
            set{ _menu_page = value; }
        }        
		/// <summary>
		/// 父菜单ID
        /// </summary>		
		private int _menu_pid;
        public int Menu_PID
        {
            get{ return _menu_pid; }
            set{ _menu_pid = value; }
        }        
		   
	}
}

