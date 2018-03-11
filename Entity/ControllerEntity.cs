using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Controller
		public class ControllerEntity
	{
   		     
      	/// <summary>
		/// Cn_ID
        /// </summary>		
		private string _cn_id;
        public string Cn_ID
        {
            get{ return _cn_id; }
            set{ _cn_id = value; }
        }        
		/// <summary>
		/// DTU_ID
        /// </summary>		
		private string _dtu_id;
        public string DTU_ID
        {
            get{ return _dtu_id; }
            set{ _dtu_id = value; }
        }        
		/// <summary>
		/// Cn_addr
        /// </summary>		
		private int _cn_addr;
        public int Cn_addr
        {
            get{ return _cn_addr; }
            set{ _cn_addr = value; }
        }        
		/// <summary>
		/// Cp_ID
        /// </summary>		
		private int _cp_id;
        public int Cp_ID
        {
            get{ return _cp_id; }
            set{ _cp_id = value; }
        }        
		/// <summary>
		/// Cn_longitude
        /// </summary>		
		private string _cn_longitude;
        public string Cn_longitude
        {
            get{ return _cn_longitude; }
            set{ _cn_longitude = value; }
        }        
		/// <summary>
		/// Cn_dimensionality
        /// </summary>		
		private string _cn_dimensionality;
        public string Cn_dimensionality
        {
            get{ return _cn_dimensionality; }
            set{ _cn_dimensionality = value; }
        }        
		   
	}
}

