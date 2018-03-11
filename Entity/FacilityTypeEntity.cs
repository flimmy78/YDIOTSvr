using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YDIOTSvr.DataLayer.Entity{
	 	//FacilityType
		public class FacilityTypeEntity
	{
   		     
      	/// <summary>
		/// Facility_Type_ID
        /// </summary>		
		private int _facility_type_id;
        public int Facility_Type_ID
        {
            get{ return _facility_type_id; }
            set{ _facility_type_id = value; }
        }        
		/// <summary>
		/// Facility_Type_Name
        /// </summary>		
		private string _facility_type_name;
        public string Facility_Type_Name
        {
            get{ return _facility_type_name; }
            set{ _facility_type_name = value; }
        }        
		/// <summary>
		/// Facility_Type_Description
        /// </summary>		
		private string _facility_type_description;
        public string Facility_Type_Description
        {
            get{ return _facility_type_description; }
            set{ _facility_type_description = value; }
        }        
		/// <summary>
		/// Facility_Type_Image
        /// </summary>		
		private string _facility_type_image;
        public string Facility_Type_Image
        {
            get{ return _facility_type_image; }
            set{ _facility_type_image = value; }
        }        
		/// <summary>
		/// 地图图片
        /// </summary>		
		private string _facility_type_map_image;
        public string Facility_Type_Map_Image
        {
            get{ return _facility_type_map_image; }
            set{ _facility_type_map_image = value; }
        }        
		/// <summary>
		/// Facility_Type_Function_Url
        /// </summary>		
		private string _facility_type_function_url;
        public string Facility_Type_Function_Url
        {
            get{ return _facility_type_function_url; }
            set{ _facility_type_function_url = value; }
        }        
		/// <summary>
		/// Facility_Type_Function_img
        /// </summary>		
		private string _facility_type_function_img;
        public string Facility_Type_Function_img
        {
            get{ return _facility_type_function_img; }
            set{ _facility_type_function_img = value; }
        }        
		   
	}
}

