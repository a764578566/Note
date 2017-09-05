using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("EmployeesStatistics")]
	public class EmployeesStatistic : BaseEntity
	{  
		/// <summary>
        /// 员工id （Employees表-Id字段）
        /// </summary>        
        public Guid EmployeesId { get; set; }  
		/// <summary>
        /// 累计实际工时
        /// </summary>        
        public double? TotalHours { get; set; }  
		/// <summary>
        /// 累计维修工时
        /// </summary>        
        public double? TotalMaintainHours { get; set; }  
		/// <summary>
        /// 累计预检（次数）
        /// </summary>        
        public double? TotalPreChecks { get; set; }  
		/// <summary>
        /// 累计验收（次数）
        /// </summary>        
        public double? TotalCompletions { get; set; }		
    }
}
