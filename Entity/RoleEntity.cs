using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Role
		public class RoleEntity
	{
   		     
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
		/// Rl_name
        /// </summary>		
		private string _rl_name;
        public string Rl_name
        {
            get{ return _rl_name; }
            set{ _rl_name = value; }
        }        
		/// <summary>
		/// Rl_introduction
        /// </summary>		
		private string _rl_introduction;
        public string Rl_introduction
        {
            get{ return _rl_introduction; }
            set{ _rl_introduction = value; }
        }        
		   
	}
}

