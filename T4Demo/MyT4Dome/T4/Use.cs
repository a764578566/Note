using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Uses")]
	public class Use : ChainEntity
	{  
		/// <summary>
        /// 单号
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 流水号
        /// </summary>        
        public string SerialNum { get; set; }  
		/// <summary>
        /// 领用人
        /// </summary>        
        public Guid TakeUser { get; set; }  
		/// <summary>
        /// 领用部门
        /// </summary>        
        public Guid? TakeDepartment { get; set; }  
		/// <summary>
        /// 用途
        /// </summary>        
        public string Usage { get; set; }  
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
