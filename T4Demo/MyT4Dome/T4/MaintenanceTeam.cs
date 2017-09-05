using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("MaintenanceTeams")]
	public class MaintenanceTeam : BaseEntity
	{  
		/// <summary>
        /// 维修工项（MaintenanceItems表-Id字段）
        /// </summary>        
        public Guid ItemId { get; set; }  
		/// <summary>
        /// 指派给（Employees表-Id字段）
        /// </summary>        
        public Guid Employee { get; set; }  
		/// <summary>
        /// 工项指派类型 1.指派 2.转派
        /// </summary>        
        public string Type { get; set; }  
		/// <summary>
        /// 派工时间
        /// </summary>        
        public DateTime AssignedOnUtc { get; set; }  
		/// <summary>
        /// 施工开始时间
        /// </summary>        
        public DateTime? BeginOnUtc { get; set; }  
		/// <summary>
        /// 施工结束时间
        /// </summary>        
        public DateTime? EndOnUtc { get; set; }  
		/// <summary>
        /// 实际总工时
        /// </summary>        
        public double? TotalHours { get; set; }  
		/// <summary>
        /// 施工进度：未开始、进行中、已完成 （DictValues表-Id字段）
        /// </summary>        
        public Guid Status { get; set; }		
    }
}
