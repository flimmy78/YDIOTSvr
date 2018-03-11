using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//User
		public class UserEntity
	{
   		     
      	/// <summary>
		/// Us_ID
        /// </summary>		
		private int _us_id;
        public int Us_ID
        {
            get{ return _us_id; }
            set{ _us_id = value; }
        }        
		/// <summary>
		/// Rl_ID
        /// </summary>		
		private int _rl_id;
        public int Rl_ID
        {
            get{ return _rl_id; }
            set{ _rl_id = value; }
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
		/// <summary>
		/// 表示账号是否为系统管理员，默认为0
        /// </summary>		
		private bool _administration_id;
        public bool Administration_ID
        {
            get{ return _administration_id; }
            set{ _administration_id = value; }
        }        
		/// <summary>
		/// Department_name
        /// </summary>		
		private string _department_name;
        public string Department_name
        {
            get{ return _department_name; }
            set{ _department_name = value; }
        }        
		/// <summary>
		/// Us_name
        /// </summary>		
		private string _us_name;
        public string Us_name
        {
            get{ return _us_name; }
            set{ _us_name = value; }
        }        
		/// <summary>
		/// Us_password
        /// </summary>		
		private string _us_password;
        public string Us_password
        {
            get{ return _us_password; }
            set{ _us_password = value; }
        }        
		/// <summary>
		/// Us_truename
        /// </summary>		
		private string _us_truename;
        public string Us_truename
        {
            get{ return _us_truename; }
            set{ _us_truename = value; }
        }        
		/// <summary>
		/// Us_telphone
        /// </summary>		
		private string _us_telphone;
        public string Us_telphone
        {
            get{ return _us_telphone; }
            set{ _us_telphone = value; }
        }        
		/// <summary>
		/// Us_cellphone
        /// </summary>		
		private string _us_cellphone;
        public string Us_cellphone
        {
            get{ return _us_cellphone; }
            set{ _us_cellphone = value; }
        }        
		/// <summary>
		/// Us_address
        /// </summary>		
		private string _us_address;
        public string Us_address
        {
            get{ return _us_address; }
            set{ _us_address = value; }
        }        
		/// <summary>
		/// Us_email
        /// </summary>		
		private string _us_email;
        public string Us_email
        {
            get{ return _us_email; }
            set{ _us_email = value; }
        }        
		/// <summary>
		/// Us_State
        /// </summary>		
		private string _us_state;
        public string Us_State
        {
            get{ return _us_state; }
            set{ _us_state = value; }
        }        
		   
	}
}

