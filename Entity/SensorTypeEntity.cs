using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Sensor_type
		public class SensorTypeEntity
	{
   		     
      	/// <summary>
		/// 传感器ID 从 1-99999
        /// </summary>		
		private int _st_id;
        public int St_ID
        {
            get{ return _st_id; }
            set{ _st_id = value; }
        }        
		/// <summary>
		/// 传感器型号(St_type)
        /// </summary>		
		private string _st_modelnumber;
        public string St_ModelNumber
        {
            get{ return _st_modelnumber; }
            set{ _st_modelnumber = value; }
        }        
		/// <summary>
		/// 控制器名称
        /// </summary>		
		private string _st_name;
        public string St_name
        {
            get{ return _st_name; }
            set{ _st_name = value; }
        }        
		/// <summary>
		/// 单位
        /// </summary>		
		private string _vt_id;
        public string VT_ID
        {
            get{ return _vt_id; }
            set{ _vt_id = value; }
        }        
		/// <summary>
		/// 说明
        /// </summary>		
		private string _st_attr;
        public string St_attr
        {
            get{ return _st_attr; }
            set{ _st_attr = value; }
        }        
		/// <summary>
		/// 供应商
        /// </summary>		
		private string _st_manufacture;
        public string St_manufacture
        {
            get{ return _st_manufacture; }
            set{ _st_manufacture = value; }
        }        
		/// <summary>
		/// 读数最小值
        /// </summary>		
		private int _st_analog_min_value;
        public int St_analog_min_value
        {
            get{ return _st_analog_min_value; }
            set{ _st_analog_min_value = value; }
        }        
		/// <summary>
		/// 读数最大值
        /// </summary>		
		private int _st_analog_max_value;
        public int St_analog_max_value
        {
            get{ return _st_analog_max_value; }
            set{ _st_analog_max_value = value; }
        }        
		/// <summary>
		/// 量程最小值
        /// </summary>		
		private int _st_analog_min_range;
        public int St_analog_min_range
        {
            get{ return _st_analog_min_range; }
            set{ _st_analog_min_range = value; }
        }        
		/// <summary>
		/// 量程最大值
        /// </summary>		
		private int _st_analog_max_range;
        public int St_analog_max_range
        {
            get{ return _st_analog_max_range; }
            set{ _st_analog_max_range = value; }
        }        
		/// <summary>
		/// 每脉冲代表的数量
        /// </summary>		
		private decimal _st_counter_value_per_pulse;
        public decimal St_counter_value_per_pulse
        {
            get{ return _st_counter_value_per_pulse; }
            set{ _st_counter_value_per_pulse = value; }
        }        
		/// <summary>
		/// 开关量为开时的状态时的值
        /// </summary>		
		private string _st_switching_true_state;
        public string St_switching_true_state
        {
            get{ return _st_switching_true_state; }
            set{ _st_switching_true_state = value; }
        }        
		/// <summary>
		/// 开关量为开时的状态时的值
        /// </summary>		
		private string _st_switching_false_state;
        public string St_switching_false_state
        {
            get{ return _st_switching_false_state; }
            set{ _st_switching_false_state = value; }
        }        
		/// <summary>
		/// 不同状态的图片
        /// </summary>		
		private string _st_map_1;
        public string St_map_1
        {
            get{ return _st_map_1; }
            set{ _st_map_1 = value; }
        }        
		/// <summary>
		/// 不同状态的图片
        /// </summary>		
		private string _st_map_2;
        public string St_map_2
        {
            get{ return _st_map_2; }
            set{ _st_map_2 = value; }
        }        
		/// <summary>
		/// 不同状态的图片
        /// </summary>		
		private string _st_map_3;
        public string St_map_3
        {
            get{ return _st_map_3; }
            set{ _st_map_3 = value; }
        }        
		/// <summary>
		/// 不同状态的图片
        /// </summary>		
		private string _st_map_4;
        public string St_map_4
        {
            get{ return _st_map_4; }
            set{ _st_map_4 = value; }
        }        
		/// <summary>
		/// 不同状态的图片
        /// </summary>		
		private string _st_map_5;
        public string St_map_5
        {
            get{ return _st_map_5; }
            set{ _st_map_5 = value; }
        }        
		   
	}
}

