using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//描述需要自动灌溉或者手动灌溉的每一个地块的信息。每个地块需要一个墒情传感器来启动；需要一个水阀来控制管路；需要一个泵来提水。
		public class LandEntity
	{
   		     
      	/// <summary>
		/// Land_ID
        /// </summary>		
		private int _land_id;
        public int Land_ID
        {
            get{ return _land_id; }
            set{ _land_id = value; }
        }        
		/// <summary>
		/// 地块灌溉所用泵(pump表)
        /// </summary>		
		private int _pump_id;
        public int Pump_ID
        {
            get{ return _pump_id; }
            set{ _pump_id = value; }
        }        
		/// <summary>
		/// 灌溉所用阀ID(Valve表)
        /// </summary>		
		private int _valve_id;
        public int Valve_ID
        {
            get{ return _valve_id; }
            set{ _valve_id = value; }
        }        
		/// <summary>
		/// 地块灌溉所用墒情
        /// </summary>		
		private int _moisture_id;
        public int Moisture_ID
        {
            get{ return _moisture_id; }
            set{ _moisture_id = value; }
        }        
		/// <summary>
		/// 用于监控灌溉水量的流量传感器，来自FlowGauge表
        /// </summary>		
		private int _flowgauge_id;
        public int FlowGauge_ID
        {
            get{ return _flowgauge_id; }
            set{ _flowgauge_id = value; }
        }        
		/// <summary>
		/// 地块名称
        /// </summary>		
		private string _land_name;
        public string Land_Name
        {
            get{ return _land_name; }
            set{ _land_name = value; }
        }        
		/// <summary>
		/// 经度
        /// </summary>		
		private decimal _land_longitude;
        public decimal Land_longitude
        {
            get{ return _land_longitude; }
            set{ _land_longitude = value; }
        }        
		/// <summary>
		/// 纬度
        /// </summary>		
		private decimal _land_dimensionality;
        public decimal Land_dimensionality
        {
            get{ return _land_dimensionality; }
            set{ _land_dimensionality = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _land_description;
        public string Land_Description
        {
            get{ return _land_description; }
            set{ _land_description = value; }
        }        
		/// <summary>
		/// 地块面积
        /// </summary>		
		private string _land_area;
        public string Land_Area
        {
            get{ return _land_area; }
            set{ _land_area = value; }
        }        
		/// <summary>
		/// 浇水量
        /// </summary>		
		private decimal _land_water_volume;
        public decimal Land_Water_Volume
        {
            get{ return _land_water_volume; }
            set{ _land_water_volume = value; }
        }        
		/// <summary>
		/// 浇水量单位
        /// </summary>		
		private string _land_water_volume_unit;
        public string Land_Water_Volume_Unit
        {
            get{ return _land_water_volume_unit; }
            set{ _land_water_volume_unit = value; }
        }        
		/// <summary>
		/// 是否自动灌溉。不论是否自动灌溉，肯定支持手工灌溉
        /// </summary>		
		private bool _land_is_auto;
        public bool Land_Is_Auto
        {
            get{ return _land_is_auto; }
            set{ _land_is_auto = value; }
        }        
		/// <summary>
		/// 灌溉启动的墒情下限
        /// </summary>		
		private int _land_moisture_low;
        public int Land_Moisture_Low
        {
            get{ return _land_moisture_low; }
            set{ _land_moisture_low = value; }
        }        
		/// <summary>
		/// 灌溉停止的墒情上限。不用，备用
        /// </summary>		
		private int _land_moisture_high;
        public int Land_Moisture_High
        {
            get{ return _land_moisture_high; }
            set{ _land_moisture_high = value; }
        }        
		/// <summary>
		/// 灌溉墒情的单位，默认%
        /// </summary>		
		private string _land_moisture_unit;
        public string Land_Moisture_Unit
        {
            get{ return _land_moisture_unit; }
            set{ _land_moisture_unit = value; }
        }        
		/// <summary>
		/// 灌溉中，轮询超声波流量计的时间间隔。单位分钟
        /// </summary>		
		private int _land_polling_interval;
        public int Land_Polling_Interval
        {
            get{ return _land_polling_interval; }
            set{ _land_polling_interval = value; }
        }        
		   
	}
}

