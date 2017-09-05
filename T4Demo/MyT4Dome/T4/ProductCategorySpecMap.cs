using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ProductCategorySpecMap")]
	public class ProductCategorySpecMap : ChainEntity
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
        /// 规格Id
        /// </summary>        
        public Guid ProductSpecificationId { get; set; }		
    }
}
