using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//HistoryItem
		public class HistoryItemEntity
	{
   		     
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
		/// HI_name
        /// </summary>		
		private string _hi_name;
        public string HI_name
        {
            get{ return _hi_name; }
            set{ _hi_name = value; }
        }        
		   
	}
}

