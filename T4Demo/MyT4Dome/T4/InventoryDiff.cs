using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("InventoryDiffs")]
	public class InventoryDiff : BaseEntity
	{  
		/// <summary>
        /// 盘点单
        /// </summary>        
        public Guid BillId { get; set; }  
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
        /// 单价
        /// </summary>        
        public int Price { get; set; }  
		/// <summary>
        /// 盘点量
        /// </summary>        
        public int Count { get; set; }  
		/// <summary>
        /// 库存量
        /// </summary>        
        public int Stock { get; set; }  
		/// <summary>
        /// 差异量
        /// </summary>        
        public int Diff { get; set; }  
		/// <summary>
        /// 盘点金额
        /// </summary>        
        public int? Amount { get; set; }  
		/// <summary>
        /// 库存金额
        /// </summary>        
        public int? StockAmount { get; set; }  
		/// <summary>
        /// 差异金额
        /// </summary>        
        public int? DiffAmount { get; set; }		
    }
}
