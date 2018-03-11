using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace YDIOTSvr.DataLayer.Entity
{
    //电磁阀表，描述电磁阀的信息
    public class ValveEntity
    {

        /// <summary>
        /// Valve_ID
        /// </summary>		
        private int _valve_id;
        public int Valve_ID
        {
            get { return _valve_id; }
            set { _valve_id = value; }
        }
        /// <summary>
        /// 水阀名称
        /// </summary>		
        private string _valve_name;
        public string Valve_Name
        {
            get { return _valve_name; }
            set { _valve_name = value; }
        }
        /// <summary>
        /// 经度
        /// </summary>		
        private decimal _valve_longitude;
        public decimal Valve_longitude
        {
            get { return _valve_longitude; }
            set { _valve_longitude = value; }
        }
        /// <summary>
        /// 纬度
        /// </summary>		
        private decimal _valve_dimensionality;
        public decimal Valve_dimensionality
        {
            get { return _valve_dimensionality; }
            set { _valve_dimensionality = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _valve_description;
        public string Valve_Description
        {
            get { return _valve_description; }
            set { _valve_description = value; }
        }
        /// <summary>
        /// 通讯配置规则
        /// </summary>		
        private int _msc_id;
        public int Msc_ID
        {
            get { return _msc_id; }
            set { _msc_id = value; }
        }
        /// <summary>
        /// 品牌
        /// </summary>		
        private string _valve_brand;
        public string Valve_Brand
        {
            get { return _valve_brand; }
            set { _valve_brand = value; }
        }
        /// <summary>
        /// 规格
        /// </summary>		
        private string _valve_specification;
        public string Valve_Specification
        {
            get { return _valve_specification; }
            set { _valve_specification = value; }
        }
        /// <summary>
        /// 潜水泵直径
        /// </summary>		
        private string _valve_diameter;
        public string Valve_Diameter
        {
            get { return _valve_diameter; }
            set { _valve_diameter = value; }
        }
        /// <summary>
        /// Valve_Manufacturer
        /// </summary>		
        private string _valve_manufacturer;
        public string Valve_Manufacturer
        {
            get { return _valve_manufacturer; }
            set { _valve_manufacturer = value; }
        }

    }
}

