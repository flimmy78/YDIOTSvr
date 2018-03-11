using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//RS485Addr
		public class RS485AddressEntity
	{
   		     
      	/// <summary>
		/// RS485Addr
        /// </summary>		
		private int _rs485addr;
        public int RS485Addr
        {
            get{ return _rs485addr; }
            set{ _rs485addr = value; }
        }        
		   
	}
}

