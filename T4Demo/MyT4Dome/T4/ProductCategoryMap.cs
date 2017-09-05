using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ProductCategoryMap")]
	public class ProductCategoryMap : ChainEntity
	{  
		/// <summary>
        /// 产品数据来源 1： 数据中心 2 ：自建
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 产品Id （Products表-Id字段）
        /// </summary>        
        public Guid ProductId { get; set; }  
		/// <summary>
        /// 产品分类Id（ProductCategories表-Id字段）
        /// </summary>        
        public Guid CategoryId { get; set; }  
		/// <summary>
        /// 是否主分类1：是 0：否
        /// </summary>        
        public bool IsDefault { get; set; }		
    }
}
