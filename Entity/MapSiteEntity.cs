using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//如果当前是一个要灌溉的地块，则描述该地块的面积，以便设置灌溉量的人员参考
		public class MapSiteEntity
	{
   		     
      	/// <summary>
		/// 测量点ID
        /// </summary>		
		private int _ms_id;
        public int MS_ID
        {
            get{ return _ms_id; }
            set{ _ms_id = value; }
        }        
		/// <summary>
		/// 所属组织结构
        /// </summary>		
		private int _groupid;
        public int GroupID
        {
            get{ return _groupid; }
            set{ _groupid = value; }
        }        
		/// <summary>
		/// 测量点名称
        /// </summary>		
		private string _ms_name;
        public string MS_Name
        {
            get{ return _ms_name; }
            set{ _ms_name = value; }
        }        
		/// <summary>
		/// 经度
        /// </summary>		
		private decimal _ms_longitude;
        public decimal MS_longitude
        {
            get{ return _ms_longitude; }
            set{ _ms_longitude = value; }
        }        
		/// <summary>
		/// 纬度
        /// </summary>		
		private decimal _ms_dimensionality;
        public decimal MS_dimensionality
        {
            get{ return _ms_dimensionality; }
            set{ _ms_dimensionality = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _ms_description;
        public string MS_Description
        {
            get{ return _ms_description; }
            set{ _ms_description = value; }
        }        
		/// <summary>
		/// 面积
        /// </summary>		
		private string _ms_area;
        public string MS_area
        {
            get{ return _ms_area; }
            set{ _ms_area = value; }
        }        
		   
	}
}

