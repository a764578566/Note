using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("LoanDetails")]
	public class LoanDetail : BaseEntity
	{  
		/// <summary>
        /// 借出单
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
        /// 总金额
        /// </summary>        
        public int? Amount { get; set; }		
    }
}
