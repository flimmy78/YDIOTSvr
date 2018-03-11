using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//MD_Port
		public class MDPortEntity
	{
   		     
      	/// <summary>
		/// MP_ID
        /// </summary>		
		private int _mp_id;
        public int MP_ID
        {
            get{ return _mp_id; }
            set{ _mp_id = value; }
        }        
		/// <summary>
		/// MD_Type
        /// </summary>		
		private string _md_type;
        public string MD_Type
        {
            get{ return _md_type; }
            set{ _md_type = value; }
        }        
		/// <summary>
		/// MD_Port
        /// </summary>		
		private string _md_port;
        public string MD_Port
        {
            get{ return _md_port; }
            set{ _md_port = value; }
        }        
		/// <summary>
		/// Port_ID
        /// </summary>		
		private int _port_id;
        public int Port_ID
        {
            get{ return _port_id; }
            set{ _port_id = value; }
        }        
		   
	}
}

