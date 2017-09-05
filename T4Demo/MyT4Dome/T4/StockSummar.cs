using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("StockSummary")]
	public class StockSummar : ChainEntity
	{  
		/// <summary>
        /// 库位Id
        /// </summary>        
        public Guid LocationId { get; set; }  
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
        /// 库存量
        /// </summary>        
        public int Count { get; set; }  
		/// <summary>
        /// 成本价
        /// </summary>        
        public int CostPrice { get; set; }		
    }
}
