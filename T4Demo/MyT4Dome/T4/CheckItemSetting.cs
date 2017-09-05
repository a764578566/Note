using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CheckItemSettings")]
	public class CheckItemSetting : ChainEntity
	{  
		/// <summary>
        /// 数据来源 1：系统初始 2：自建 
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 分组
        /// </summary>        
        public Guid Group { get; set; }  
		/// <summary>
        /// 标识
        /// </summary>        
        public string Key { get; set; }  
		/// <summary>
        /// 名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 值类型
        /// </summary>        
        public string ValueType { get; set; }  
		/// <summary>
        /// 控件类型
        /// </summary>        
        public string ControlType { get; set; }  
		/// <summary>
        /// 是否必填 1：必填 0：非必填 
        /// </summary>        
        public bool Required { get; set; }		
    }
}
