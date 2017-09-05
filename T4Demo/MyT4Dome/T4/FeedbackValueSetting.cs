using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("FeedbackValueSettings")]
	public class FeedbackValueSetting : ChainEntity
	{  
		/// <summary>
        /// 数据来源 1：系统初始 2：自建
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 回访项目
        /// </summary>        
        public Guid ItemId { get; set; }  
		/// <summary>
        /// 值
        /// </summary>        
        public string Value { get; set; }  
		/// <summary>
        /// 值类型 1：不可编辑 2：可编辑 
        /// </summary>        
        public string ValueType { get; set; }  
		/// <summary>
        /// 是否预先选中
        /// </summary>        
        public bool PreSelected { get; set; }		
    }
}
