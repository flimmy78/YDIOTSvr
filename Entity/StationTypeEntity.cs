using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//Module_type
		public class StationTypeEntity
	{
   		     
      	/// <summary>
		/// Mp_ID
        /// </summary>		
		private string _mp_id;
        public string Mp_ID
        {
            get{ return _mp_id; }
            set{ _mp_id = value; }
        }        
		/// <summary>
		/// Mp_ID_from_recall
        /// </summary>		
		private string _mp_id_from_recall;
        public string Mp_ID_from_recall
        {
            get{ return _mp_id_from_recall; }
            set{ _mp_id_from_recall = value; }
        }        
		/// <summary>
		/// Mp_name
        /// </summary>		
		private string _mp_name;
        public string Mp_name
        {
            get{ return _mp_name; }
            set{ _mp_name = value; }
        }        
		/// <summary>
		/// Mp_manufacture
        /// </summary>		
		private string _mp_manufacture;
        public string Mp_manufacture
        {
            get{ return _mp_manufacture; }
            set{ _mp_manufacture = value; }
        }        
		/// <summary>
		/// Mp_analog_input_number
        /// </summary>		
		private int _mp_analog_input_number;
        public int Mp_analog_input_number
        {
            get{ return _mp_analog_input_number; }
            set{ _mp_analog_input_number = value; }
        }        
		/// <summary>
		/// Mp_switching_input_number
        /// </summary>		
		private int _mp_switching_input_number;
        public int Mp_switching_input_number
        {
            get{ return _mp_switching_input_number; }
            set{ _mp_switching_input_number = value; }
        }        
		/// <summary>
		/// Mp_switching_output_number
        /// </summary>		
		private int _mp_switching_output_number;
        public int Mp_switching_output_number
        {
            get{ return _mp_switching_output_number; }
            set{ _mp_switching_output_number = value; }
        }        
		/// <summary>
		/// Mp_Counter_number
        /// </summary>		
		private int _mp_counter_number;
        public int Mp_Counter_number
        {
            get{ return _mp_counter_number; }
            set{ _mp_counter_number = value; }
        }        
		   
	}
}

