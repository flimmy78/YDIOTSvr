using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Facility_Config
		public class FacilityConfigEntity
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
		/// Msc_ID
        /// </summary>		
		private int _msc_id;
        public int Msc_ID
        {
            get{ return _msc_id; }
            set{ _msc_id = value; }
        }        
		/// <summary>
		/// Usage_ID
        /// </summary>		
		private int _usage_id;
        public int Usage_ID
        {
            get{ return _usage_id; }
            set{ _usage_id = value; }
        }        
		   
	}
}

