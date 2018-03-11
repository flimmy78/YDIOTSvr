using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//墒情传感器的表。有三个探针，分处于浅中深三层；每个探针都有一个配置规则，相当于一个传感器。
		public class MoistureEntity
	{
   		     
      	/// <summary>
		/// Moisture_ID
        /// </summary>		
		private int _moisture_id;
        public int Moisture_ID
        {
            get{ return _moisture_id; }
            set{ _moisture_id = value; }
        }        
		/// <summary>
		/// 水阀名称
        /// </summary>		
		private string _moisture_name;
        public string Moisture_Name
        {
            get{ return _moisture_name; }
            set{ _moisture_name = value; }
        }        
		/// <summary>
		/// 经度
        /// </summary>		
		private decimal _moisture_longitude;
        public decimal Moisture_longitude
        {
            get{ return _moisture_longitude; }
            set{ _moisture_longitude = value; }
        }        
		/// <summary>
		/// 纬度
        /// </summary>		
		private decimal _moisture_dimensionality;
        public decimal Moisture_dimensionality
        {
            get{ return _moisture_dimensionality; }
            set{ _moisture_dimensionality = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _moisture_description;
        public string Moisture_Description
        {
            get{ return _moisture_description; }
            set{ _moisture_description = value; }
        }        
		/// <summary>
		/// 浅层探针的通讯配置规则
        /// </summary>		
		private int _msc_id_low;
        public int Msc_ID_Low
        {
            get{ return _msc_id_low; }
            set{ _msc_id_low = value; }
        }        
		/// <summary>
		/// 浅层探针的通讯配置规则是否用于自动灌溉
        /// </summary>		
		private bool _msc_id_low_is_valid;
        public bool Msc_ID_Low_is_valid
        {
            get{ return _msc_id_low_is_valid; }
            set{ _msc_id_low_is_valid = value; }
        }        
		/// <summary>
		/// 中层探针的通讯配置规则
        /// </summary>		
		private int _msc_id_mid;
        public int Msc_ID_Mid
        {
            get{ return _msc_id_mid; }
            set{ _msc_id_mid = value; }
        }        
		/// <summary>
		/// 中层探针的通讯配置规则是否用于灌溉
        /// </summary>		
		private bool _msc_id_mid_is_valid;
        public bool Msc_ID_Mid_is_valid
        {
            get{ return _msc_id_mid_is_valid; }
            set{ _msc_id_mid_is_valid = value; }
        }        
		/// <summary>
		/// 深层探针的通讯配置规则
        /// </summary>		
		private int _msc_id_deep;
        public int Msc_ID_Deep
        {
            get{ return _msc_id_deep; }
            set{ _msc_id_deep = value; }
        }        
		/// <summary>
		/// 深层探针的通讯配置规则是否用于灌溉
        /// </summary>		
		private bool _msc_id_deep_is_valid;
        public bool Msc_ID_Deep_is_valid
        {
            get{ return _msc_id_deep_is_valid; }
            set{ _msc_id_deep_is_valid = value; }
        }        
		/// <summary>
		/// 品牌
        /// </summary>		
		private string _moisture_brand;
        public string Moisture_Brand
        {
            get{ return _moisture_brand; }
            set{ _moisture_brand = value; }
        }        
		/// <summary>
		/// 规格
        /// </summary>		
		private string _moisture_specification;
        public string Moisture_Specification
        {
            get{ return _moisture_specification; }
            set{ _moisture_specification = value; }
        }        
		/// <summary>
		/// 单位
        /// </summary>		
		private string _moisture_unit;
        public string Moisture_Unit
        {
            get{ return _moisture_unit; }
            set{ _moisture_unit = value; }
        }        
		/// <summary>
		/// 量程
        /// </summary>		
		private string _moisture_range;
        public string Moisture_Range
        {
            get{ return _moisture_range; }
            set{ _moisture_range = value; }
        }        
		/// <summary>
		/// 探针长度
        /// </summary>		
		private string _moisture_probe_length;
        public string Moisture_Probe_Length
        {
            get{ return _moisture_probe_length; }
            set{ _moisture_probe_length = value; }
        }        
		   
	}
}

