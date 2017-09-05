using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("SaleReturns")]
	public class SaleReturn : ChainEntity
	{  
		/// <summary>
        /// 原始销售单
        /// </summary>        
        public Guid? SaleId { get; set; }  
		/// <summary>
        /// 单号
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 流水号
        /// </summary>        
        public string SerialNum { get; set; }  
		/// <summary>
        /// 类型
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 退还给
        /// </summary>        
        public Guid InUnit { get; set; }  
		/// <summary>
        /// 退货方
        /// </summary>        
        public Guid OutUnit { get; set; }  
		/// <summary>
        /// 销售员
        /// </summary>        
        public Guid Seller { get; set; }  
		/// <summary>
        /// 状态
        /// </summary>        
        public Guid Status { get; set; }  
		/// <summary>
        /// 审核人
        /// </summary>        
        public Guid? AuditedUser { get; set; }  
		/// <summary>
        /// 审核时间
        /// </summary>        
        public DateTime? AuditedOnUtc { get; set; }		
    }
}
