using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Auto_Irrigate_Config
		public class AutoIrrigateConfigEntity
	{
   		     
      	/// <summary>
		/// Trigger_Facility_ID
        /// </summary>		
		private int _trigger_facility_id;
        public int Trigger_Facility_ID
        {
            get{ return _trigger_facility_id; }
            set{ _trigger_facility_id = value; }
        }        
		/// <summary>
		/// Auto_Irrigate_Facility_ID
        /// </summary>		
		private int _auto_irrigate_facility_id;
        public int Auto_Irrigate_Facility_ID
        {
            get{ return _auto_irrigate_facility_id; }
            set{ _auto_irrigate_facility_id = value; }
        }        
		/// <summary>
		/// StartOrStop_MSC_ID
        /// </summary>		
		private int _startorstop_msc_id;
        public int StartOrStop_MSC_ID
        {
            get{ return _startorstop_msc_id; }
            set{ _startorstop_msc_id = value; }
        }        
		/// <summary>
		/// State_MSC_ID
        /// </summary>		
		private int _state_msc_id;
        public int State_MSC_ID
        {
            get{ return _state_msc_id; }
            set{ _state_msc_id = value; }
        }        
		/// <summary>
		/// 自动灌溉时长，单位分钟
        /// </summary>		
		private int _irrigate_duration;
        public int Irrigate_Duration
        {
            get{ return _irrigate_duration; }
            set{ _irrigate_duration = value; }
        }        
		/// <summary>
		/// Auto_Irrigate_Enabled
        /// </summary>		
		private bool _auto_irrigate_enabled;
        public bool Auto_Irrigate_Enabled
        {
            get{ return _auto_irrigate_enabled; }
            set{ _auto_irrigate_enabled = value; }
        }        
		   
	}
}

