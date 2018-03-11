using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//ValueType
		public class ValueTypeEntity
	{
   		     
      	/// <summary>
		/// VT_ID
        /// </summary>		
		private int _vt_id;
        public int VT_ID
        {
            get{ return _vt_id; }
            set{ _vt_id = value; }
        }        
		/// <summary>
		/// 类型名称
        /// </summary>		
		private string _typename;
        public string TypeName
        {
            get{ return _typename; }
            set{ _typename = value; }
        }        
		/// <summary>
		/// 单位
        /// </summary>		
		private string _unit;
        public string Unit
        {
            get{ return _unit; }
            set{ _unit = value; }
        }        
		   
	}
}

