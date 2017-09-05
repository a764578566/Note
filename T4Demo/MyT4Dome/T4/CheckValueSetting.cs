using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CheckValueSettings")]
	public class CheckValueSetting : ChainEntity
	{  
		/// <summary>
        /// 数据来源 1：系统初始 2：自建
        /// </summary>        
        public int DataSource { get; set; }  
		/// <summary>
        /// 预检项目
        /// </summary>        
        public Guid ItemId { get; set; }  
		/// <summary>
        /// 值
        /// </summary>        
        public string Value { get; set; }  
		/// <summary>
        /// 值类型 1：不可编辑 2：可编辑 
        /// </summary>        
        public string EditType { get; set; }  
		/// <summary>
        /// 是否预先选中
        /// </summary>        
        public bool PreSelected { get; set; }		
    }
}
