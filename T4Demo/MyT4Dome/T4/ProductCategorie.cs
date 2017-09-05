using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ProductCategories")]
	public class ProductCategorie : ChainEntity
	{  
		/// <summary>
        /// 产品数据来源 1： 数据中心 2 ：自建
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 上级分类
        /// </summary>        
        public Guid ParentId { get; set; }  
		/// <summary>
        /// 分类编码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 分类名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 层级
        /// </summary>        
        public int Level { get; set; }  
		/// <summary>
        /// 是否有子节点
        /// </summary>        
        public bool HasChild { get; set; }		
    }
}
