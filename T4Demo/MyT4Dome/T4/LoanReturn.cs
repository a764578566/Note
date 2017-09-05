using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("LoanReturns")]
	public class LoanReturn : ChainEntity
	{  
		/// <summary>
        /// 原始借出单
        /// </summary>        
        public Guid? LoanId { get; set; }  
		/// <summary>
        /// 单号
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 流水号
        /// </summary>        
        public string SerialNum { get; set; }  
		/// <summary>
        /// 归还给
        /// </summary>        
        public Guid InUnit { get; set; }  
		/// <summary>
        /// 归还方
        /// </summary>        
        public Guid OutUnit { get; set; }  
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
