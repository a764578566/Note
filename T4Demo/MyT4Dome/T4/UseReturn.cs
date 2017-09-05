using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("UseReturns")]
	public class UseReturn : ChainEntity
	{  
		/// <summary>
        /// 
        /// </summary>        
        public Guid? UseId { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 流水号
        /// </summary>        
        public string SerialNum { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public Guid ReturnUser { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public Guid? ReturnDepartment { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public Guid Status { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public Guid? AuditedUser { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public DateTime? AuditedOnUtc { get; set; }		
    }
}
