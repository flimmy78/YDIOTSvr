using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//超声波流量计的表。用于描述灌溉计量的工具的
		public class FlowGaugeEntity
	{
   		     
      	/// <summary>
		/// FlowGauge_ID
        /// </summary>		
		private int _flowgauge_id;
        public int FlowGauge_ID
        {
            get{ return _flowgauge_id; }
            set{ _flowgauge_id = value; }
        }        
		/// <summary>
		/// 水阀名称
        /// </summary>		
		private string _fg_name;
        public string FG_Name
        {
            get{ return _fg_name; }
            set{ _fg_name = value; }
        }        
		/// <summary>
		/// 经度
        /// </summary>		
		private decimal _fg_longitude;
        public decimal FG_longitude
        {
            get{ return _fg_longitude; }
            set{ _fg_longitude = value; }
        }        
		/// <summary>
		/// 纬度
        /// </summary>		
		private decimal _fg_dimensionality;
        public decimal FG_dimensionality
        {
            get{ return _fg_dimensionality; }
            set{ _fg_dimensionality = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _fg_description;
        public string FG_Description
        {
            get{ return _fg_description; }
            set{ _fg_description = value; }
        }        
		/// <summary>
		/// 通讯配置规则(MapSite_Config)
        /// </summary>		
		private int _msc_id;
        public int Msc_ID
        {
            get{ return _msc_id; }
            set{ _msc_id = value; }
        }        
		/// <summary>
		/// 品牌
        /// </summary>		
		private string _fg_brand;
        public string FG_Brand
        {
            get{ return _fg_brand; }
            set{ _fg_brand = value; }
        }        
		/// <summary>
		/// 规格
        /// </summary>		
		private string _fg_specification;
        public string FG_Specification
        {
            get{ return _fg_specification; }
            set{ _fg_specification = value; }
        }        
		/// <summary>
		/// 制造商
        /// </summary>		
		private string _fg_manufacturer;
        public string FG_Manufacturer
        {
            get{ return _fg_manufacturer; }
            set{ _fg_manufacturer = value; }
        }        
		   
	}
}

