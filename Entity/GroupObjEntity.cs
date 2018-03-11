using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//GroupObj
		public class GroupObjEntity
	{
   		     
      	/// <summary>
		/// Gp_ID
        /// </summary>		
		private int _gp_id;
        public int Gp_ID
        {
            get{ return _gp_id; }
            set{ _gp_id = value; }
        }        
		/// <summary>
		/// 组织编码
        /// </summary>		
		private string _gp_code;
        public string Gp_Code
        {
            get{ return _gp_code; }
            set{ _gp_code = value; }
        }        
		/// <summary>
		/// 组织名称
        /// </summary>		
		private string _gp_name;
        public string Gp_Name
        {
            get{ return _gp_name; }
            set{ _gp_name = value; }
        }        
		/// <summary>
		/// Gp_sys_title
        /// </summary>		
		private string _gp_sys_title;
        public string Gp_sys_title
        {
            get{ return _gp_sys_title; }
            set{ _gp_sys_title = value; }
        }        
		/// <summary>
		/// Gp_sys_title_vice
        /// </summary>		
		private string _gp_sys_title_vice;
        public string Gp_sys_title_vice
        {
            get{ return _gp_sys_title_vice; }
            set{ _gp_sys_title_vice = value; }
        }        
		/// <summary>
		/// 介绍
        /// </summary>		
		private string _gp_introduction;
        public string Gp_introduction
        {
            get{ return _gp_introduction; }
            set{ _gp_introduction = value; }
        }        
		/// <summary>
		/// 面积大小
        /// </summary>		
		private string _gp_size;
        public string Gp_size
        {
            get{ return _gp_size; }
            set{ _gp_size = value; }
        }        
		/// <summary>
		/// 地图图片路径
        /// </summary>		
		private string _gp_map;
        public string Gp_map
        {
            get{ return _gp_map; }
            set{ _gp_map = value; }
        }        
		/// <summary>
		/// Gp_map_size
        /// </summary>		
		private int _gp_map_size;
        public int Gp_map_size
        {
            get{ return _gp_map_size; }
            set{ _gp_map_size = value; }
        }        
		/// <summary>
		/// Gp_map_icon_width
        /// </summary>		
		private int _gp_map_icon_width;
        public int Gp_map_icon_width
        {
            get{ return _gp_map_icon_width; }
            set{ _gp_map_icon_width = value; }
        }        
		/// <summary>
		/// Gp_map_icon_height
        /// </summary>		
		private int _gp_map_icon_height;
        public int Gp_map_icon_height
        {
            get{ return _gp_map_icon_height; }
            set{ _gp_map_icon_height = value; }
        }        
		/// <summary>
		/// Gp_map_icon_color
        /// </summary>		
		private string _gp_map_icon_color;
        public string Gp_map_icon_color
        {
            get{ return _gp_map_icon_color; }
            set{ _gp_map_icon_color = value; }
        }        
		/// <summary>
		/// Gp_map_icon_bg_color
        /// </summary>		
		private string _gp_map_icon_bg_color;
        public string Gp_map_icon_bg_color
        {
            get{ return _gp_map_icon_bg_color; }
            set{ _gp_map_icon_bg_color = value; }
        }        
		/// <summary>
		/// 东经
        /// </summary>		
		private decimal _gp_longitude_center;
        public decimal Gp_longitude_center
        {
            get{ return _gp_longitude_center; }
            set{ _gp_longitude_center = value; }
        }        
		/// <summary>
		/// 北纬度
        /// </summary>		
		private decimal _gp_dimensionality_center;
        public decimal Gp_dimensionality_center
        {
            get{ return _gp_dimensionality_center; }
            set{ _gp_dimensionality_center = value; }
        }        
		/// <summary>
		/// 东经
        /// </summary>		
		private decimal _gp_longitude_east;
        public decimal Gp_longitude_east
        {
            get{ return _gp_longitude_east; }
            set{ _gp_longitude_east = value; }
        }        
		/// <summary>
		/// 西经
        /// </summary>		
		private decimal _gp_longitude_west;
        public decimal Gp_longitude_west
        {
            get{ return _gp_longitude_west; }
            set{ _gp_longitude_west = value; }
        }        
		/// <summary>
		/// 北纬度
        /// </summary>		
		private decimal _gp_dimensionality_south;
        public decimal Gp_dimensionality_south
        {
            get{ return _gp_dimensionality_south; }
            set{ _gp_dimensionality_south = value; }
        }        
		/// <summary>
		/// 南纬度
        /// </summary>		
		private decimal _gp_dimensionality_north;
        public decimal Gp_dimensionality_north
        {
            get{ return _gp_dimensionality_north; }
            set{ _gp_dimensionality_north = value; }
        }        
		/// <summary>
		/// 授权用户数
        /// </summary>		
		private int _gp_user_number;
        public int Gp_user_number
        {
            get{ return _gp_user_number; }
            set{ _gp_user_number = value; }
        }        
		/// <summary>
		/// 机井数
        /// </summary>		
		private int _gp_well_number;
        public int Gp_well_number
        {
            get{ return _gp_well_number; }
            set{ _gp_well_number = value; }
        }        
		/// <summary>
		/// DTU数
        /// </summary>		
		private int _gp_dtu_number;
        public int Gp_DTU_number
        {
            get{ return _gp_dtu_number; }
            set{ _gp_dtu_number = value; }
        }        
		/// <summary>
		/// 授权卡数
        /// </summary>		
		private int _gp_card_number;
        public int Gp_card_number
        {
            get{ return _gp_card_number; }
            set{ _gp_card_number = value; }
        }        
		/// <summary>
		/// 密码-读写密码
        /// </summary>		
		private int _gp_card_password;
        public int Gp_card_password
        {
            get{ return _gp_card_password; }
            set{ _gp_card_password = value; }
        }        
		/// <summary>
		/// 轮询时间间隔
        /// </summary>		
		private int _gp_polling_interval;
        public int Gp_polling_interval
        {
            get{ return _gp_polling_interval; }
            set{ _gp_polling_interval = value; }
        }        
		/// <summary>
		/// 存储的时间间隔
        /// </summary>		
		private int _gp_store_interval;
        public int Gp_store_interval
        {
            get{ return _gp_store_interval; }
            set{ _gp_store_interval = value; }
        }        
		/// <summary>
		/// 父ID
        /// </summary>		
		private int _gp_pid;
        public int Gp_PID
        {
            get{ return _gp_pid; }
            set{ _gp_pid = value; }
        }        
		/// <summary>
		/// 地图等级
        /// </summary>		
		private int _gp_map_level;
        public int GP_Map_Level
        {
            get{ return _gp_map_level; }
            set{ _gp_map_level = value; }
        }        
		/// <summary>
		/// 地图线的颜色
        /// </summary>		
		private int _gp_mapline_color;
        public int GP_MapLine_Color
        {
            get{ return _gp_mapline_color; }
            set{ _gp_mapline_color = value; }
        }        
		/// <summary>
		/// 地图线的宽度 
        /// </summary>		
		private int _gp_mapline_width;
        public int GP_MapLine_Width
        {
            get{ return _gp_mapline_width; }
            set{ _gp_mapline_width = value; }
        }        
		/// <summary>
		/// 地图区域的透明度
        /// </summary>		
		private decimal _gp_map_opacity;
        public decimal GP_Map_Opacity
        {
            get{ return _gp_map_opacity; }
            set{ _gp_map_opacity = value; }
        }        
		/// <summary>
		/// 用户看到系统的名称
        /// </summary>		
		private string _gp_sysname;
        public string Gp_SysName
        {
            get{ return _gp_sysname; }
            set{ _gp_sysname = value; }
        }        
		/// <summary>
		/// 所属灌区名称
        /// </summary>		
		private string _gp_irrigatename;
        public string Gp_IrrigateName
        {
            get{ return _gp_irrigatename; }
            set{ _gp_irrigatename = value; }
        }        
		/// <summary>
		/// Remote_password
        /// </summary>		
		private string _remote_password;
        public string Remote_password
        {
            get{ return _remote_password; }
            set{ _remote_password = value; }
        }        
		   
	}
}

