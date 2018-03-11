using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//DTU
		public class DTUEntity
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
        /// DTU_ID
        /// </summary>		
        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }        
		/// <summary>
		/// 类型ID
        /// </summary>		
		private int _dtu_tp_id;
        public int DTU_tp_ID
        {
            get{ return _dtu_tp_id; }
            set{ _dtu_tp_id = value; }
        }        
		/// <summary>
		/// groupID（村庄或者灌区 ID)
        /// </summary>		
		private string _vi_id;
        public string Vi_ID
        {
            get{ return _vi_id; }
            set{ _vi_id = value; }
        }        
		/// <summary>
		/// DTU名称
        /// </summary>		
		private string _dtu_name;
        public string DTU_name
        {
            get{ return _dtu_name; }
            set{ _dtu_name = value; }
        }        
		/// <summary>
		/// 经度
        /// </summary>		
		private decimal _dtu_longitude;
        public decimal DTU_longitude
        {
            get{ return _dtu_longitude; }
            set{ _dtu_longitude = value; }
        }        
		/// <summary>
		/// 纬度
        /// </summary>		
		private decimal _dtu_dimensionality;
        public decimal DTU_dimensionality
        {
            get{ return _dtu_dimensionality; }
            set{ _dtu_dimensionality = value; }
        }        
		/// <summary>
		/// 手机号
        /// </summary>		
		private string _dtu_sim;
        public string DTU_sim
        {
            get{ return _dtu_sim; }
            set{ _dtu_sim = value; }
        }        
		/// <summary>
		/// 运营商名称
        /// </summary>		
		private string _mo_id;
        public string Mo_ID
        {
            get{ return _mo_id; }
            set{ _mo_id = value; }
        }        
		/// <summary>
		/// polling_delay_time
        /// </summary>		
		private int _polling_delay_time;
        public int polling_delay_time
        {
            get{ return _polling_delay_time; }
            set{ _polling_delay_time = value; }
        }        
		/// <summary>
		/// polling_time
        /// </summary>		
		private int _polling_time;
        public int polling_time
        {
            get{ return _polling_time; }
            set{ _polling_time = value; }
        }        
		/// <summary>
		/// GP_ID
        /// </summary>		
		private int _gp_id;
        public int GP_ID
        {
            get{ return _gp_id; }
            set{ _gp_id = value; }
        }        
		   
	}
}

