using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("MaintenanceRecommends")]
	public class MaintenanceRecommend : BaseEntity
	{  
		/// <summary>
        /// 维修工单（Maintenances表-Id字段）
        /// </summary>        
        public Guid MaintenanceId { get; set; }  
		/// <summary>
        /// 建议维修项目
        /// </summary>        
        public string Content { get; set; }		
    }
}
