using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//userState
		public class userStateEntity
	{
   		     
      	/// <summary>
		/// us_state
        /// </summary>		
		private string _us_state;
        public string us_state
        {
            get{ return _us_state; }
            set{ _us_state = value; }
        }        
		/// <summary>
		/// us_name
        /// </summary>		
		private string _us_name;
        public string us_name
        {
            get{ return _us_name; }
            set{ _us_name = value; }
        }        
		   
	}
}

