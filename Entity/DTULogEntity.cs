using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//DTU_log
		public class DTULogEntity
	{
   		     
      	/// <summary>
		/// Dl_ID
        /// </summary>		
		private int _dl_id;
        public int Dl_ID
        {
            get{ return _dl_id; }
            set{ _dl_id = value; }
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
		/// DTU_IP
        /// </summary>		
		private string _dtu_ip;
        public string DTU_IP
        {
            get{ return _dtu_ip; }
            set{ _dtu_ip = value; }
        }        
		/// <summary>
		/// 网络端口号
        /// </summary>		
		private int _dtu_port;
        public int DTU_port
        {
            get{ return _dtu_port; }
            set{ _dtu_port = value; }
        }        
		/// <summary>
		/// 登录时间
        /// </summary>		
		private DateTime _dtu_login_time;
        public DateTime DTU_login_time
        {
            get{ return _dtu_login_time; }
            set{ _dtu_login_time = value; }
        }        
		/// <summary>
		/// 退出时间
        /// </summary>		
		private DateTime _dtu_logout_time;
        public DateTime DTU_logout_time
        {
            get{ return _dtu_logout_time; }
            set{ _dtu_logout_time = value; }
        }        
		/// <summary>
		/// DTU_Logout_Value
        /// </summary>		
		private decimal _dtu_logout_value;
        public decimal DTU_Logout_Value
        {
            get{ return _dtu_logout_value; }
            set{ _dtu_logout_value = value; }
        }        
		   
	}
}

