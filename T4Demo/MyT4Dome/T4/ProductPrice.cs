using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ProductPrices")]
	public class ProductPrice : BaseEntity
	{  
		/// <summary>
        /// 维修明细Id（MaintenanceItems表 -Id字段）
        /// </summary>        
        public Guid ItemId { get; set; }  
		/// <summary>
        /// 产品Id（Products表-Id字段）
        /// </summary>        
        public Guid ProductId { get; set; }  
		/// <summary>
        /// 产品品牌
        /// </summary>        
        public string Brand { get; set; }  
		/// <summary>
        /// 产品编号
        /// </summary>        
        public string ProductCode { get; set; }  
		/// <summary>
        /// 产品名称
        /// </summary>        
        public string ProductName { get; set; }  
		/// <summary>
        /// 产品分类（默认）
        /// </summary>        
        public string ProductCategory { get; set; }  
		/// <summary>
        /// 产品规格
        /// </summary>        
        public string ProductSpecification { get; set; }  
		/// <summary>
        /// 数量
        /// </summary>        
        public int Count { get; set; }  
		/// <summary>
        /// 单价
        /// </summary>        
        public int Price { get; set; }  
		/// <summary>
        /// 折扣率
        /// </summary>        
        public int? Discount { get; set; }  
		/// <summary>
        /// 总金额
        /// </summary>        
        public int Amount { get; set; }		
    }
}
