using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//IrrigationLog
		public class IrrigationLogEntity
	{
   		     
      	/// <summary>
		/// AIL_ID
        /// </summary>		
		private int _ail_id;
        public int AIL_ID
        {
            get{ return _ail_id; }
            set{ _ail_id = value; }
        }        
		/// <summary>
		/// AIL_Start_Time
        /// </summary>		
		private DateTime _ail_start_time;
        public DateTime AIL_Start_Time
        {
            get{ return _ail_start_time; }
            set{ _ail_start_time = value; }
        }        
		/// <summary>
		/// AIL_End_Time
        /// </summary>		
		private DateTime _ail_end_time;
        public DateTime AIL_End_Time
        {
            get{ return _ail_end_time; }
            set{ _ail_end_time = value; }
        }        
		/// <summary>
		/// 灌溉的规则
        /// </summary>		
		private int _aic_id;
        public int AIC_ID
        {
            get{ return _aic_id; }
            set{ _aic_id = value; }
        }        
		/// <summary>
		/// 灌溉时的浅层墒情
        /// </summary>		
		private int _soil_moisture_low;
        public int Soil_Moisture_Low
        {
            get{ return _soil_moisture_low; }
            set{ _soil_moisture_low = value; }
        }        
		/// <summary>
		/// 灌溉时的中层墒情
        /// </summary>		
		private int _soil_moisture_mid;
        public int Soil_Moisture_Mid
        {
            get{ return _soil_moisture_mid; }
            set{ _soil_moisture_mid = value; }
        }        
		/// <summary>
		/// 灌溉时的浅层墒情
        /// </summary>		
		private int _soil_moisture_high;
        public int Soil_Moisture_High
        {
            get{ return _soil_moisture_high; }
            set{ _soil_moisture_high = value; }
        }        
		/// <summary>
		/// Soil_Moisture_Unit
        /// </summary>		
		private string _soil_moisture_unit;
        public string Soil_Moisture_Unit
        {
            get{ return _soil_moisture_unit; }
            set{ _soil_moisture_unit = value; }
        }        
		/// <summary>
		/// AIL_Flow_Gauge_Start_Reading
        /// </summary>		
		private decimal _ail_flow_gauge_start_reading;
        public decimal AIL_Flow_Gauge_Start_Reading
        {
            get{ return _ail_flow_gauge_start_reading; }
            set{ _ail_flow_gauge_start_reading = value; }
        }        
		/// <summary>
		/// AIL_Flow_Gauge_End_Reading1
        /// </summary>		
		private decimal _ail_flow_gauge_end_reading1;
        public decimal AIL_Flow_Gauge_End_Reading1
        {
            get{ return _ail_flow_gauge_end_reading1; }
            set{ _ail_flow_gauge_end_reading1 = value; }
        }        
		/// <summary>
		/// 手工灌溉时的用户ID
        /// </summary>		
		private int _manual_irrigation_user;
        public int Manual_Irrigation_User
        {
            get{ return _manual_irrigation_user; }
            set{ _manual_irrigation_user = value; }
        }        
		   
	}
}

