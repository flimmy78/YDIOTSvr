using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//statisticsItemForUasge
		public class statisticsItemForUasgeEntity
	{
   		     
      	/// <summary>
		/// ID
        /// </summary>		
		private int _id;
        public int ID
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// SI_ID
        /// </summary>		
		private int _si_id;
        public int SI_ID
        {
            get{ return _si_id; }
            set{ _si_id = value; }
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

