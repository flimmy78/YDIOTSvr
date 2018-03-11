using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//水泵的表。通讯配置规则在Mapsite_Config

		public class PumpEntity
	{
   		     
      	/// <summary>
		/// Pump_ID
        /// </summary>		
		private int _pump_id;
        public int Pump_ID
        {
            get{ return _pump_id; }
            set{ _pump_id = value; }
        }        
		/// <summary>
		/// Pump_Name
        /// </summary>		
		private string _pump_name;
        public string Pump_Name
        {
            get{ return _pump_name; }
            set{ _pump_name = value; }
        }        
		/// <summary>
		/// 经度
        /// </summary>		
		private decimal _pump_longitude;
        public decimal Pump_longitude
        {
            get{ return _pump_longitude; }
            set{ _pump_longitude = value; }
        }        
		/// <summary>
		/// 纬度
        /// </summary>		
		private decimal _pump_dimensionality;
        public decimal Pump_dimensionality
        {
            get{ return _pump_dimensionality; }
            set{ _pump_dimensionality = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _pump_description;
        public string Pump_Description
        {
            get{ return _pump_description; }
            set{ _pump_description = value; }
        }        
		/// <summary>
		/// Pump_area
        /// </summary>		
		private string _pump_area;
        public string Pump_area
        {
            get{ return _pump_area; }
            set{ _pump_area = value; }
        }        
		/// <summary>
		/// Msc_ID
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
		private string _pump_brand;
        public string Pump_Brand
        {
            get{ return _pump_brand; }
            set{ _pump_brand = value; }
        }        
		/// <summary>
		/// 规格
        /// </summary>		
		private string _pump_specification;
        public string Pump_Specification
        {
            get{ return _pump_specification; }
            set{ _pump_specification = value; }
        }        
		/// <summary>
		/// 额定功率
        /// </summary>		
		private string _pump_power;
        public string Pump_Power
        {
            get{ return _pump_power; }
            set{ _pump_power = value; }
        }        
		/// <summary>
		/// 泵流量
        /// </summary>		
		private string _pump_flow;
        public string Pump_Flow
        {
            get{ return _pump_flow; }
            set{ _pump_flow = value; }
        }        
		/// <summary>
		/// 潜水泵直径
        /// </summary>		
		private string _pump_diameter;
        public string Pump_Diameter
        {
            get{ return _pump_diameter; }
            set{ _pump_diameter = value; }
        }        
		/// <summary>
		/// Pump_Manufacturer
        /// </summary>		
		private string _pump_manufacturer;
        public string Pump_Manufacturer
        {
            get{ return _pump_manufacturer; }
            set{ _pump_manufacturer = value; }
        }        
		   
	}
}

