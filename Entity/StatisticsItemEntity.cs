using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//StatisticsItem
		public class StatisticsItemEntity
	{
   		     
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
		/// SI_name
        /// </summary>		
		private string _si_name;
        public string SI_name
        {
            get{ return _si_name; }
            set{ _si_name = value; }
        }        
		/// <summary>
		/// StatisticsType
        /// </summary>		
		private string _statisticstype;
        public string StatisticsType
        {
            get{ return _statisticstype; }
            set{ _statisticstype = value; }
        }        
		   
	}
}

