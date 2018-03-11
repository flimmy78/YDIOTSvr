using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
		public class IrrigationgConfigEntity
	{
   		     
      	/// <summary>
		/// AIC_ID
        /// </summary>		
		private int _aic_id;
        public int AIC_ID
        {
            get{ return _aic_id; }
            set{ _aic_id = value; }
        }        
		/// <summary>
		/// 是否自动灌溉。不论是否自动灌溉，肯定支持手工灌溉
        /// </summary>		
		private bool _aic_is_auto;
        public bool AIC_Is_Auto
        {
            get{ return _aic_is_auto; }
            set{ _aic_is_auto = value; }
        }        
		/// <summary>
		/// MS_ID
        /// </summary>		
		private int _ms_id;
        public int MS_ID
        {
            get{ return _ms_id; }
            set{ _ms_id = value; }
        }        
		/// <summary>
		/// 浅层墒情传感器，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _soil_moisture_low;
        public int Soil_Moisture_Low
        {
            get{ return _soil_moisture_low; }
            set{ _soil_moisture_low = value; }
        }        
		/// <summary>
		/// 浅层墒情传感器是否用于控制自动灌溉
        /// </summary>		
		private bool _soil_moisture_low_valid;
        public bool Soil_Moisture_Low_Valid
        {
            get{ return _soil_moisture_low_valid; }
            set{ _soil_moisture_low_valid = value; }
        }        
		/// <summary>
		/// 中层墒情传感器，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _soil_moisture_mid;
        public int Soil_Moisture_Mid
        {
            get{ return _soil_moisture_mid; }
            set{ _soil_moisture_mid = value; }
        }        
		/// <summary>
		/// 中层墒情传感器是否用于控制自动灌溉
        /// </summary>		
		private bool _soil_moisture_mid_valid;
        public bool Soil_Moisture_Mid_Valid
        {
            get{ return _soil_moisture_mid_valid; }
            set{ _soil_moisture_mid_valid = value; }
        }        
		/// <summary>
		/// 深层墒情传感器，  来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _soil_moisture_deep;
        public int Soil_Moisture_Deep
        {
            get{ return _soil_moisture_deep; }
            set{ _soil_moisture_deep = value; }
        }        
		/// <summary>
		/// 深层墒情传感器是否用于控制自动灌溉
        /// </summary>		
		private bool _soil_moisture_deep_valid;
        public bool Soil_Moisture_Deep_Valid
        {
            get{ return _soil_moisture_deep_valid; }
            set{ _soil_moisture_deep_valid = value; }
        }        
		/// <summary>
		/// 灌溉启动的墒情下限
        /// </summary>		
		private int _aic_moisture_low;
        public int AIC_Moisture_Low
        {
            get{ return _aic_moisture_low; }
            set{ _aic_moisture_low = value; }
        }        
		/// <summary>
		/// 灌溉停止的墒情上限。不用，备用
        /// </summary>		
		private int _aic_moisture_high;
        public int AIC_Moisture_High
        {
            get{ return _aic_moisture_high; }
            set{ _aic_moisture_high = value; }
        }        
		/// <summary>
		/// 灌溉墒情的单位，默认%
        /// </summary>		
		private string _aic_moisture_unit;
        public string AIC_Moisture_Unit
        {
            get{ return _aic_moisture_unit; }
            set{ _aic_moisture_unit = value; }
        }        
		/// <summary>
		/// 这块地的灌溉水量
        /// </summary>		
		private decimal _aic_water_volume;
        public decimal AIC_Water_Volume
        {
            get{ return _aic_water_volume; }
            set{ _aic_water_volume = value; }
        }        
		/// <summary>
		/// 用于监控灌溉水量的流量传感器，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_flow_gauge;
        public int AIC_Flow_Gauge
        {
            get{ return _aic_flow_gauge; }
            set{ _aic_flow_gauge = value; }
        }        
		/// <summary>
		/// 灌溉中，轮询超声波流量计的时间间隔。单位分钟
        /// </summary>		
		private int _aic_polling_interval;
        public int AIC_Polling_Interval
        {
            get{ return _aic_polling_interval; }
            set{ _aic_polling_interval = value; }
        }        
		/// <summary>
		/// 开始灌溉的第一个执行器件，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_start_action1_acutuation;
        public int AIC_Start_Action1_Acutuation
        {
            get{ return _aic_start_action1_acutuation; }
            set{ _aic_start_action1_acutuation = value; }
        }        
		/// <summary>
		/// 开始灌溉的第一个执行器件的工作状态
        /// </summary>		
		private bool _aic_start_action1_state;
        public bool AIC_Start_Action1_State
        {
            get{ return _aic_start_action1_state; }
            set{ _aic_start_action1_state = value; }
        }        
		/// <summary>
		/// 开始灌溉的第2个执行器件，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_start_action2_acutuation;
        public int AIC_Start_Action2_Acutuation
        {
            get{ return _aic_start_action2_acutuation; }
            set{ _aic_start_action2_acutuation = value; }
        }        
		/// <summary>
		/// 开始灌溉的第2个执行器件的工作状态
        /// </summary>		
		private bool _aic_start_action2_state;
        public bool AIC_Start_Action2_State
        {
            get{ return _aic_start_action2_state; }
            set{ _aic_start_action2_state = value; }
        }        
		/// <summary>
		/// 开始灌溉的第3个执行器件，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_start_action3_acutuation;
        public int AIC_Start_Action3_Acutuation
        {
            get{ return _aic_start_action3_acutuation; }
            set{ _aic_start_action3_acutuation = value; }
        }        
		/// <summary>
		/// 开始灌溉的第3个执行器件的工作状态
        /// </summary>		
		private bool _aic_start_action3_state;
        public bool AIC_Start_Action3_State
        {
            get{ return _aic_start_action3_state; }
            set{ _aic_start_action3_state = value; }
        }        
		/// <summary>
		/// 开始灌溉的第4个执行器件，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_start_action4_acutuation;
        public int AIC_Start_Action4_Acutuation
        {
            get{ return _aic_start_action4_acutuation; }
            set{ _aic_start_action4_acutuation = value; }
        }        
		/// <summary>
		/// 开始灌溉的第4个执行器件的工作状态
        /// </summary>		
		private bool _aic_start_action4_state;
        public bool AIC_Start_Action4_State
        {
            get{ return _aic_start_action4_state; }
            set{ _aic_start_action4_state = value; }
        }        
		/// <summary>
		/// 结束灌溉的第一个执行器件，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_shut_action1_acutuation;
        public int AIC_Shut_Action1_Acutuation
        {
            get{ return _aic_shut_action1_acutuation; }
            set{ _aic_shut_action1_acutuation = value; }
        }        
		/// <summary>
		/// 结束灌溉的第一个执行器件的工作状态
        /// </summary>		
		private bool _aic_shut_action1_state;
        public bool AIC_Shut_Action1_State
        {
            get{ return _aic_shut_action1_state; }
            set{ _aic_shut_action1_state = value; }
        }        
		/// <summary>
		/// 结束灌溉的第2个执行器件，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_shut_action2_acutuation;
        public int AIC_Shut_Action2_Acutuation
        {
            get{ return _aic_shut_action2_acutuation; }
            set{ _aic_shut_action2_acutuation = value; }
        }        
		/// <summary>
		/// 结束灌溉的第2个执行器件的工作状态
        /// </summary>		
		private bool _aic_shut_action2_state;
        public bool AIC_Shut_Action2_State
        {
            get{ return _aic_shut_action2_state; }
            set{ _aic_shut_action2_state = value; }
        }        
		/// <summary>
		/// 结束灌溉的第3个执行器件，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_shut_action3_acutuation;
        public int AIC_Shut_Action3_Acutuation
        {
            get{ return _aic_shut_action3_acutuation; }
            set{ _aic_shut_action3_acutuation = value; }
        }        
		/// <summary>
		/// 结束灌溉的第3个执行器件的工作状态
        /// </summary>		
		private bool _aic_shut_action3_state;
        public bool AIC_Shut_Action3_State
        {
            get{ return _aic_shut_action3_state; }
            set{ _aic_shut_action3_state = value; }
        }        
		/// <summary>
		/// 结束灌溉的第4个执行器件，来自MapSite_Config的Msc_ID
        /// </summary>		
		private int _aic_shut_action4_acutuation;
        public int AIC_Shut_Action4_Acutuation
        {
            get{ return _aic_shut_action4_acutuation; }
            set{ _aic_shut_action4_acutuation = value; }
        }        
		/// <summary>
		/// 结束灌溉的第4个执行器件的工作状态
        /// </summary>		
		private bool _aic_shut_action4_state;
        public bool AIC_Shut_Action4_State
        {
            get{ return _aic_shut_action4_state; }
            set{ _aic_shut_action4_state = value; }
        }        
		   
	}
}

