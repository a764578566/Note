using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("MaintenanceLogs")]
	public class MaintenanceLog : BaseEntity
	{  
		/// <summary>
        /// 维修工单（Maintenances表-Id字段）
        /// </summary>        
        public Guid? MaintenanceId { get; set; }  
		/// <summary>
        /// 操作描述
        /// </summary>        
        public string Operation { get; set; }  
		/// <summary>
        /// 操作员
        /// </summary>        
        public string Operator { get; set; }  
		/// <summary>
        /// 状态
        /// </summary>        
        public Guid? Status { get; set; }		
    }
}
