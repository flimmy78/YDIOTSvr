using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//模块表
		public class StationEntity
	{

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
		/// Address
        /// </summary>		
		private String _Address;
        public String Address
        {
            get{ return _Address; }
            set{ _Address = value; }
        }        
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
		/// 测量点（map_site)
        /// </summary>		
		private string _mp_id;
        public string Mp_ID
        {
            get{ return _mp_id; }
            set{ _mp_id = value; }
        }        
		/// <summary>
		/// 协议(默认值 modbus)
        /// </summary>		
		private string _md_protocol;
        public string Md_Protocol
        {
            get{ return _md_protocol; }
            set{ _md_protocol = value; }
        }        
		/// <summary>
		/// 波特率
        /// </summary>		
		private string _md_baud;
        public string Md_Baud
        {
            get{ return _md_baud; }
            set{ _md_baud = value; }
        }        
		/// <summary>
		/// Md_0dd_even_check
        /// </summary>		
		private bool _md_0dd_even_check;
        public bool Md_0dd_even_check
        {
            get{ return _md_0dd_even_check; }
            set{ _md_0dd_even_check = value; }
        }        
		/// <summary>
		/// Md_Stopbit
        /// </summary>		
		private int _md_stopbit;
        public int Md_Stopbit
        {
            get{ return _md_stopbit; }
            set{ _md_stopbit = value; }
        }
        /// <summary>
        /// Md_SN
        /// </summary>		
        private string _md_sn;
        public string Md_SN
        {
            get { return _md_sn; }
            set { _md_sn = value; }
        } 
	}
}

