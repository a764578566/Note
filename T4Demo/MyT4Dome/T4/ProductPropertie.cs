using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ProductProperties")]
	public class ProductPropertie : ChainEntity
	{  
		/// <summary>
        /// 数据来源
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 产品分类Id
        /// </summary>        
        public Guid ProductCategoryId { get; set; }  
		/// <summary>
        /// 属性标识
        /// </summary>        
        public string Key { get; set; }  
		/// <summary>
        /// 属性名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
