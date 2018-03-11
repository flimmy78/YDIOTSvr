using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//ModuleSensor
		public class StationSensorEntity
	{
   		     
      	/// <summary>
		/// Md_ID
        /// </summary>		
		private string _md_id;
        public string Md_ID
        {
            get{ return _md_id; }
            set{ _md_id = value; }
        }        
		/// <summary>
		/// St_ID
        /// </summary>		
		private string _st_id;
        public string St_ID
        {
            get{ return _st_id; }
            set{ _st_id = value; }
        }        
		/// <summary>
		/// Md_port
        /// </summary>		
		private int _md_port;
        public int Md_port
        {
            get{ return _md_port; }
            set{ _md_port = value; }
        }        
		/// <summary>
		/// Md_port_type
        /// </summary>		
		private string _md_port_type;
        public string Md_port_type
        {
            get{ return _md_port_type; }
            set{ _md_port_type = value; }
        }        
		   
	}
}

