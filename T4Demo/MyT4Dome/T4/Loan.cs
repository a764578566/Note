using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Loans")]
	public class Loan : ChainEntity
	{  
		/// <summary>
        /// 借出给
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 流水号
        /// </summary>        
        public string SerialNum { get; set; }  
		/// <summary>
        /// 借出给
        /// </summary>        
        public Guid InUnit { get; set; }  
		/// <summary>
        /// 借出方
        /// </summary>        
        public Guid OutUnit { get; set; }  
		/// <summary>
        /// 原因
        /// </summary>        
        public string Reason { get; set; }  
		/// <summary>
        /// 预计归还时间
        /// </summary>        
        public DateTime? ExpectReturn { get; set; }  
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
		/// <summary>
        /// 更新时间
        /// </summary>        
        public DateTime UpdatedOnOtc { get; set; }		
    }
}
