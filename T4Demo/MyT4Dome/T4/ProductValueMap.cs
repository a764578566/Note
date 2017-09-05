using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ProductValueMap")]
	public class ProductValueMap : ChainEntity
	{  
		/// <summary>
        /// 数据来源
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 产品Id
        /// </summary>        
        public Guid ProductId { get; set; }  
		/// <summary>
        /// 产品属性Id
        /// </summary>        
        public Guid PropertyId { get; set; }  
		/// <summary>
        /// 产品属性值
        /// </summary>        
        public string Value { get; set; }		
    }
}
