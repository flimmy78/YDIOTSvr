using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//HistoryItemForUsage
		public class HistoryItemForUsageEntity
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
		/// HI_ID
        /// </summary>		
		private int _hi_id;
        public int HI_ID
        {
            get{ return _hi_id; }
            set{ _hi_id = value; }
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
		/// <summary>
		/// HistoryType
        /// </summary>		
		private string _historytype;
        public string HistoryType
        {
            get{ return _historytype; }
            set{ _historytype = value; }
        }        
		   
	}
}

