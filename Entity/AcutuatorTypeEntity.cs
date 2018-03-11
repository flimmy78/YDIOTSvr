using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace YDIOTSvr.DataLayer.Entity
{
    //执行器类型表
    public class AcutuatorTypeEntity
    {

        /// <summary>
        /// 传感器ID  从 100000-999999
        /// </summary>		
        private int _at_id;
        public int At_ID
        {
            get { return _at_id; }
            set { _at_id = value; }
        }
        /// <summary>
        /// 执行器产品型号
        /// </summary>		
        private string _at_modelnumber;
        public string At_ModelNumber
        {
            get { return _at_modelnumber; }
            set { _at_modelnumber = value; }
        }
        /// <summary>
        /// 执行器名称
        /// </summary>		
        private string _at_name;
        public string At_name
        {
            get { return _at_name; }
            set { _at_name = value; }
        }
        /// <summary>
        /// 供应商
        /// </summary>		
        private string _at_manufacture;
        public string At_manufacture
        {
            get { return _at_manufacture; }
            set { _at_manufacture = value; }
        }
        /// <summary>
        /// At_attr_name_1
        /// </summary>		
        private string _at_attr_name_1;
        public string At_attr_name_1
        {
            get { return _at_attr_name_1; }
            set { _at_attr_name_1 = value; }
        }
        /// <summary>
        /// At_attr_value_1
        /// </summary>		
        private string _at_attr_value_1;
        public string At_attr_value_1
        {
            get { return _at_attr_value_1; }
            set { _at_attr_value_1 = value; }
        }
        /// <summary>
        /// At_attr_name_2
        /// </summary>		
        private string _at_attr_name_2;
        public string At_attr_name_2
        {
            get { return _at_attr_name_2; }
            set { _at_attr_name_2 = value; }
        }
        /// <summary>
        /// At_attr_value_2
        /// </summary>		
        private string _at_attr_value_2;
        public string At_attr_value_2
        {
            get { return _at_attr_value_2; }
            set { _at_attr_value_2 = value; }
        }
        /// <summary>
        /// 工作时图片
        /// </summary>		
        private string _at_map_working;
        public string At_map_working
        {
            get { return _at_map_working; }
            set { _at_map_working = value; }
        }
        /// <summary>
        /// 空闲时图片
        /// </summary>		
        private string _at_map_idle;
        public string At_map_idle
        {
            get { return _at_map_idle; }
            set { _at_map_idle = value; }
        }
        /// <summary>
        /// 离线时图片
        /// </summary>		
        private string _at_map_offline;
        public string At_map_offline
        {
            get { return _at_map_offline; }
            set { _at_map_offline = value; }
        }

    }
}

