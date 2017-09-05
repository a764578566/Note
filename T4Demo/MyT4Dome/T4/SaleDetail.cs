using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("SaleDetails")]
	public class SaleDetail : BaseEntity
	{  
		/// <summary>
        /// 销售单
        /// </summary>        
        public Guid BillId { get; set; }  
		/// <summary>
        /// 产品Id
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
        /// 产品分类
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
        /// 价格(不含税)
        /// </summary>        
        public int? ExTaxPrice { get; set; }  
		/// <summary>
        /// 折扣率
        /// </summary>        
        public int? Discount { get; set; }  
		/// <summary>
        /// 总金额(含税)
        /// </summary>        
        public int? Amount { get; set; }  
		/// <summary>
        /// 总金额(不含税)
        /// </summary>        
        public int? ExTaxAmount { get; set; }		
    }
}
