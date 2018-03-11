using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//设备表
		public class FacilityEntity
	{
   		     
      	/// <summary>
		/// Facility_ID
        /// </summary>		
		private int _facility_id;
        public int Facility_ID
        {
            get{ return _facility_id; }
            set{ _facility_id = value; }
        }        
		/// <summary>
		/// GroupID
        /// </summary>		
		private int _groupid;
        public int GroupID
        {
            get{ return _groupid; }
            set{ _groupid = value; }
        }        
		/// <summary>
		/// Facility_Type
        /// </summary>		
		private int _facility_type;
        public int Facility_Type
        {
            get{ return _facility_type; }
            set{ _facility_type = value; }
        }        
		/// <summary>
		/// Facility_Name
        /// </summary>		
		private string _facility_name;
        public string Facility_Name
        {
            get{ return _facility_name; }
            set{ _facility_name = value; }
        }        
		/// <summary>
		/// 经度
        /// </summary>		
		private decimal _facility_longitude;
        public decimal Facility_longitude
        {
            get{ return _facility_longitude; }
            set{ _facility_longitude = value; }
        }        
		/// <summary>
		/// 纬度
        /// </summary>		
		private decimal _facility_dimensionality;
        public decimal Facility_dimensionality
        {
            get{ return _facility_dimensionality; }
            set{ _facility_dimensionality = value; }
        }        
		/// <summary>
		/// 设备所有泵的功率,整数,单位:瓦
        /// </summary>		
		private decimal _power;
        public decimal power
        {
            get{ return _power; }
            set{ _power = value; }
        }        
		/// <summary>
		/// 设备是否在GIS中显示
        /// </summary>		
		private bool _isongis;
        public bool IsOnGIS
        {
            get{ return _isongis; }
            set{ _isongis = value; }
        }        
		/// <summary>
		/// Well_head_height
        /// </summary>		
		private int _well_head_height;
        public int Well_head_height
        {
            get{ return _well_head_height; }
            set{ _well_head_height = value; }
        }        
		/// <summary>
		/// Well_bottom_height
        /// </summary>		
		private int _well_bottom_height;
        public int Well_bottom_height
        {
            get{ return _well_bottom_height; }
            set{ _well_bottom_height = value; }
        }        
		/// <summary>
		/// 泵站、水井的流量，立方每小时
        /// </summary>		
		private decimal _rateofflow;
        public decimal rateOfFlow
        {
            get{ return _rateofflow; }
            set{ _rateofflow = value; }
        }        
		   
	}
}

