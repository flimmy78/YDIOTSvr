using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Usage
		public class UsageEntity
	{
   		     
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
		/// Usage_Name
        /// </summary>		
		private string _usage_name;
        public string Usage_Name
        {
            get{ return _usage_name; }
            set{ _usage_name = value; }
        }        
		/// <summary>
		/// Usage_Dict
        /// </summary>		
		private string _usage_dict;
        public string Usage_Dict
        {
            get{ return _usage_dict; }
            set{ _usage_dict = value; }
        }        
		   
	}
}

