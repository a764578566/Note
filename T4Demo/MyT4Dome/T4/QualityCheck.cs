using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("QualityChecks")]
	public class QualityCheck : BaseEntity
	{  
		/// <summary>
        /// 维修工项Id
        /// </summary>        
        public Guid MaintenanceItemId { get; set; }  
		/// <summary>
        /// 质检结果
        /// </summary>        
        public string Result { get; set; }  
		/// <summary>
        /// 原因
        /// </summary>        
        public string Reason { get; set; }		
    }
}
