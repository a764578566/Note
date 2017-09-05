using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Manufactures")]
	public class Manufacture : ChainEntity
	{  
		/// <summary>
        /// 数据来源 1：系统初始 2：自建 
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 厂商类型： 1-车辆 2-配件 3-辅料 4-周边其他 
        /// </summary>        
        public string Type { get; set; }  
		/// <summary>
        /// 省份编码
        /// </summary>        
        public string AreaCode { get; set; }  
		/// <summary>
        /// 厂商代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 厂商名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 厂商简称
        /// </summary>        
        public string ShortName { get; set; }  
		/// <summary>
        /// 首字母
        /// </summary>        
        public string FirstChar { get; set; }  
		/// <summary>
        /// 拼音
        /// </summary>        
        public string Bopomofo { get; set; }  
		/// <summary>
        /// 简拼
        /// </summary>        
        public string ShortBopomofo { get; set; }  
		/// <summary>
        /// 地址
        /// </summary>        
        public string Address { get; set; }  
		/// <summary>
        /// 联系人
        /// </summary>        
        public string ContactUser { get; set; }  
		/// <summary>
        /// 联系方式
        /// </summary>        
        public string ContactInfo { get; set; }		
    }
}
