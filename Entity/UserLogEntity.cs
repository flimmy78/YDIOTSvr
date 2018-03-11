using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//User_log
		public class UserLogEntity
	{
   		     
      	/// <summary>
		/// Ur_ID
        /// </summary>		
		private int _ur_id;
        public int Ur_ID
        {
            get{ return _ur_id; }
            set{ _ur_id = value; }
        }        
		/// <summary>
		/// Us_ID
        /// </summary>		
		private int _us_id;
        public int Us_ID
        {
            get{ return _us_id; }
            set{ _us_id = value; }
        }        
		/// <summary>
		/// Us_operator
        /// </summary>		
		private string _us_operator;
        public string Us_operator
        {
            get{ return _us_operator; }
            set{ _us_operator = value; }
        }        
		/// <summary>
		/// Us_object
        /// </summary>		
		private string _us_object;
        public string Us_object
        {
            get{ return _us_object; }
            set{ _us_object = value; }
        }        
		/// <summary>
		/// Us_time
        /// </summary>		
		private DateTime _us_time;
        public DateTime Us_time
        {
            get{ return _us_time; }
            set{ _us_time = value; }
        }        
		   
	}
}

