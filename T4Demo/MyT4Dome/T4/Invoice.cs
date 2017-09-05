using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Invoices")]
	public class Invoice : BaseEntity
	{  
		/// <summary>
        /// 结算单Id
        /// </summary>        
        public Guid SettlementId { get; set; }  
		/// <summary>
        /// 发票类型
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 抬头
        /// </summary>        
        public string Title { get; set; }  
		/// <summary>
        /// 内容
        /// </summary>        
        public string Content { get; set; }  
		/// <summary>
        /// 开票金额
        /// </summary>        
        public double? Amount { get; set; }  
		/// <summary>
        /// 发票号
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 状态 1：有效 0：作废 
        /// </summary>        
        public string Status { get; set; }  
		/// <summary>
        /// 原因
        /// </summary>        
        public string Reason { get; set; }		
    }
}
