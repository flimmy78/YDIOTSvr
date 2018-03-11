using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//测量点配置表
		public class MapSiteConfigEntity
	{
   		     
      	/// <summary>
		/// 测量点配置ID
        /// </summary>		
		private int _msc_id;
        public int Msc_ID
        {
            get{ return _msc_id; }
            set{ _msc_id = value; }
        }        
		/// <summary>
		/// DTU
        /// </summary>		
		private string _dtu_id;
        public string DTU_ID
        {
            get{ return _dtu_id; }
            set{ _dtu_id = value; }
        }        
		/// <summary>
		/// 模块ID（module 表）
        /// </summary>		
		private string _md_id;
        public string Md_ID
        {
            get{ return _md_id; }
            set{ _md_id = value; }
        }        
		/// <summary>
		/// 传感器ID(控制器 、执行器等) 来自 Sensor_type 表
        /// </summary>		
		private int _st_id;
        public int St_ID
        {
            get{ return _st_id; }
            set{ _st_id = value; }
        }        
		/// <summary>
		/// 暂时不用 st_ID 即表示控制器又可表示执行器）
        /// </summary>		
		private int _at_id;
        public int At_ID
        {
            get{ return _at_id; }
            set{ _at_id = value; }
        }        
		/// <summary>
		/// 端口号
        /// </summary>		
		private string _md_port;
        public string Md_port
        {
            get{ return _md_port; }
            set{ _md_port = value; }
        }        
		/// <summary>
		/// 值类型ID
        /// </summary>		
		private int _valuetypeid;
        public int ValueTypeID
        {
            get{ return _valuetypeid; }
            set{ _valuetypeid = value; }
        }        
		/// <summary>
		/// 值名称
        /// </summary>		
		private string _valuename;
        public string ValueName
        {
            get{ return _valuename; }
            set{ _valuename = value; }
        }        
		/// <summary>
		/// 是否在地图上显示当前配置的器件信息
        /// </summary>		
		private bool _msc_is_display;
        public bool MSC_Is_Display
        {
            get{ return _msc_is_display; }
            set{ _msc_is_display = value; }
        }        
		/// <summary>
		/// 用于将水位测量值根据气压等因素影响下修正
        /// </summary>		
		private decimal _correctedvalue;
        public decimal CorrectedValue
        {
            get{ return _correctedvalue; }
            set{ _correctedvalue = value; }
        }        
		/// <summary>
		/// 最后轮询时间
        /// </summary>		
		private DateTime _pl_time;
        public DateTime PL_Time
        {
            get{ return _pl_time; }
            set{ _pl_time = value; }
        }        
		/// <summary>
		/// 最后轮询的值
        /// </summary>		
		private decimal _pl_value;
        public decimal PL_Value
        {
            get{ return _pl_value; }
            set{ _pl_value = value; }
        }        
		   
	}
}

