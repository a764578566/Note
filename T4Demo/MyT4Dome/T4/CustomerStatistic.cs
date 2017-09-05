using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CustomerStatistics")]
	public class CustomerStatistic : BaseEntity
	{  
		/// <summary>
        /// 客户Id
        /// </summary>        
        public Guid CustomerId { get; set; }  
		/// <summary>
        /// 累计工时
        /// </summary>        
        public double? TotalHours { get; set; }  
		/// <summary>
        /// 累计预检
        /// </summary>        
        public double? TotalPreChecks { get; set; }  
		/// <summary>
        /// 累计验收
        /// </summary>        
        public double? TotalCompletions { get; set; }		
    }
}
