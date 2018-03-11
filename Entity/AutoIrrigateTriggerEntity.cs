using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Auto_Irrigate_Trigger
		public class AutoIrrigateTriggerEntity
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
		/// Trigger_MSC_ID_1
        /// </summary>		
		private int _trigger_msc_id_1;
        public int Trigger_MSC_ID_1
        {
            get{ return _trigger_msc_id_1; }
            set{ _trigger_msc_id_1 = value; }
        }        
		/// <summary>
		/// Trigger_MSC_ID_2
        /// </summary>		
		private int _trigger_msc_id_2;
        public int Trigger_MSC_ID_2
        {
            get{ return _trigger_msc_id_2; }
            set{ _trigger_msc_id_2 = value; }
        }        
		/// <summary>
		/// Trigger_MSC_ID_3
        /// </summary>		
		private int _trigger_msc_id_3;
        public int Trigger_MSC_ID_3
        {
            get{ return _trigger_msc_id_3; }
            set{ _trigger_msc_id_3 = value; }
        }        
		/// <summary>
		/// Trigger_Threshold_LowLimit
        /// </summary>		
		private decimal _trigger_threshold_lowlimit;
        public decimal Trigger_Threshold_LowLimit
        {
            get{ return _trigger_threshold_lowlimit; }
            set{ _trigger_threshold_lowlimit = value; }
        }        
		/// <summary>
		/// Trigger_Threshold_UpperLimit
        /// </summary>		
		private decimal _trigger_threshold_upperlimit;
        public decimal Trigger_Threshold_UpperLimit
        {
            get{ return _trigger_threshold_upperlimit; }
            set{ _trigger_threshold_upperlimit = value; }
        }        
		   
	}
}

