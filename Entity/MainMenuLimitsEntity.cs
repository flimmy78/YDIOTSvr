using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//主菜单权限
    public class MainMenuLimitsEntity
	{
   		     
      	/// <summary>
		/// ML_ID
        /// </summary>		
		private int _ml_id;
        public int ML_ID
        {
            get{ return _ml_id; }
            set{ _ml_id = value; }
        }        
		/// <summary>
		/// 组织ID -0 表示未设置组织权限
        /// </summary>		
		private int _gp_id;
        public int Gp_ID
        {
            get{ return _gp_id; }
            set{ _gp_id = value; }
        }        
		/// <summary>
		/// 角色ID 0-表示为设置角色权限
        /// </summary>		
		private int _rl_id;
        public int Rl_ID
        {
            get{ return _rl_id; }
            set{ _rl_id = value; }
        }        
		/// <summary>
		/// 人员ID  0-未设置人员的权限
        /// </summary>		
		private int _us_id;
        public int Us_ID
        {
            get{ return _us_id; }
            set{ _us_id = value; }
        }        
		/// <summary>
		/// Menu_ID
        /// </summary>		
		private int _menu_id;
        public int Menu_ID
        {
            get{ return _menu_id; }
            set{ _menu_id = value; }
        }        
		/// <summary>
		/// Limits
        /// </summary>		
		private int _limits;
        public int Limits
        {
            get{ return _limits; }
            set{ _limits = value; }
        }        
		   
	}
}

