using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Polling_Log
		public class PollingLogEntity
	{
   		     
      	/// <summary>
		/// Pl_ID
        /// </summary>		
		private int _pl_id;
        public int Pl_ID
        {
            get{ return _pl_id; }
            set{ _pl_id = value; }
        }        
		/// <summary>
		/// 轮询时间
        /// </summary>		
		private DateTime _pl_time;
        public DateTime PL_Time
        {
            get{ return _pl_time; }
            set{ _pl_time = value; }
        }        
		/// <summary>
		/// 地址配置ID(MapSite_Config)
        /// </summary>		
		private int _msc_id;
        public int Msc_ID
        {
            get{ return _msc_id; }
            set{ _msc_id = value; }
        }        
		/// <summary>
		/// 值
        /// </summary>		
		private decimal _value;
        public decimal Value
        {
            get{ return _value; }
            set{ _value = value; }
        }        
		   
	}
}

