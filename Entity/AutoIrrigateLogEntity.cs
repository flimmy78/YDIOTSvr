using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Auto_Irrigate_Log
		public class AutoIrrigateLogEntity
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
		/// Auto_Irrigate_Facility_ID
        /// </summary>		
		private int _auto_irrigate_facility_id;
        public int Auto_Irrigate_Facility_ID
        {
            get{ return _auto_irrigate_facility_id; }
            set{ _auto_irrigate_facility_id = value; }
        }        
		/// <summary>
		/// Auto_Irrigate_StartTime
        /// </summary>		
		private DateTime _auto_irrigate_starttime;
        public DateTime Auto_Irrigate_StartTime
        {
            get{ return _auto_irrigate_starttime; }
            set{ _auto_irrigate_starttime = value; }
        }        
		/// <summary>
		/// Auto_Irrigate_EndTime
        /// </summary>		
		private DateTime _auto_irrigate_endtime;
        public DateTime Auto_Irrigate_EndTime
        {
            get{ return _auto_irrigate_endtime; }
            set{ _auto_irrigate_endtime = value; }
        }        
		/// <summary>
		/// Auto_Irrigate_State
        /// </summary>		
		private string _auto_irrigate_state;
        public string Auto_Irrigate_State
        {
            get{ return _auto_irrigate_state; }
            set{ _auto_irrigate_state = value; }
        }        
		   
	}
}

