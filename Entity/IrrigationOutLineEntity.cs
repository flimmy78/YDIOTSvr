using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//用经纬度坐标描述灌区或者村庄的轮廓
		public class IrrigationOutLineEntity
	{
   		     
      	/// <summary>
		/// OL_ID
        /// </summary>		
		private int _ol_id;
        public int OL_ID
        {
            get{ return _ol_id; }
            set{ _ol_id = value; }
        }        
		/// <summary>
		/// Gp_ID
        /// </summary>		
		private int _gp_id;
        public int Gp_ID
        {
            get{ return _gp_id; }
            set{ _gp_id = value; }
        }        
		/// <summary>
		/// OL_longitude
        /// </summary>		
		private decimal _ol_longitude;
        public decimal OL_longitude
        {
            get{ return _ol_longitude; }
            set{ _ol_longitude = value; }
        }        
		/// <summary>
		/// OL_dimensionality
        /// </summary>		
		private decimal _ol_dimensionality;
        public decimal OL_dimensionality
        {
            get{ return _ol_dimensionality; }
            set{ _ol_dimensionality = value; }
        }        
		   
	}
}

