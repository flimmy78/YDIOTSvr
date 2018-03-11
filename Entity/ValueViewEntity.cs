using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//ValueView
		public class ValueViewEntity
	{
   		     
      	/// <summary>
		/// TypeName
        /// </summary>		
		private string _typename;
        public string TypeName
        {
            get{ return _typename; }
            set{ _typename = value; }
        }        
		/// <summary>
		/// Unit
        /// </summary>		
		private string _unit;
        public string Unit
        {
            get{ return _unit; }
            set{ _unit = value; }
        }        
		/// <summary>
		/// Value
        /// </summary>		
		private decimal _value;
        public decimal Value
        {
            get{ return _value; }
            set{ _value = value; }
        }        
		/// <summary>
		/// PL_Time
        /// </summary>		
		private DateTime _pl_time;
        public DateTime PL_Time
        {
            get{ return _pl_time; }
            set{ _pl_time = value; }
        }        
		/// <summary>
		/// Msc_ID
        /// </summary>		
		private int _msc_id;
        public int Msc_ID
        {
            get{ return _msc_id; }
            set{ _msc_id = value; }
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
		private int _st_id;
        public int St_ID
        {
            get{ return _st_id; }
            set{ _st_id = value; }
        }        
		/// <summary>
		/// At_ID
        /// </summary>		
		private int _at_id;
        public int At_ID
        {
            get{ return _at_id; }
            set{ _at_id = value; }
        }        
		/// <summary>
		/// Md_port
        /// </summary>		
		private string _md_port;
        public string Md_port
        {
            get{ return _md_port; }
            set{ _md_port = value; }
        }        
		/// <summary>
		/// MSC_Is_Display
        /// </summary>		
		private bool _msc_is_display;
        public bool MSC_Is_Display
        {
            get{ return _msc_is_display; }
            set{ _msc_is_display = value; }
        }        
		/// <summary>
		/// ValueTypeID
        /// </summary>		
		private int _valuetypeid;
        public int ValueTypeID
        {
            get{ return _valuetypeid; }
            set{ _valuetypeid = value; }
        }        
		/// <summary>
		/// Facility_ID
        /// </summary>		
		private int _facility_id;
        public int Facility_ID
        {
            get{ return _facility_id; }
            set{ _facility_id = value; }
        }        
		/// <summary>
		/// Usage_Dict
        /// </summary>		
		private string _usage_dict;
        public string Usage_Dict
        {
            get{ return _usage_dict; }
            set{ _usage_dict = value; }
        }        
		/// <summary>
		/// Usage_Name
        /// </summary>		
		private string _usage_name;
        public string Usage_Name
        {
            get{ return _usage_name; }
            set{ _usage_name = value; }
        }        
		/// <summary>
		/// Usage_ID
        /// </summary>		
		private int _usage_id;
        public int Usage_ID
        {
            get{ return _usage_id; }
            set{ _usage_id = value; }
        }        
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
		/// Expr1
        /// </summary>		
		private int _expr1;
        public int Expr1
        {
            get{ return _expr1; }
            set{ _expr1 = value; }
        }        
		   
	}
}

