using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("MaintenanceItems")]
	public class MaintenanceItem : BaseEntity
	{  
		/// <summary>
        /// 维修工单（Maintenances表-Id字段）
        /// </summary>        
        public Guid MaintenanceId { get; set; }  
		/// <summary>
        /// 关联维修工项Id 返工单需要此字段
        /// </summary>        
        public Guid? ItemId { get; set; }  
		/// <summary>
        /// 维修项目（Services表-Id字段）
        /// </summary>        
        public Guid? ServiceId { get; set; }  
		/// <summary>
        /// 附加或维修项目名称
        /// </summary>        
        public string ServiceName { get; set; }  
		/// <summary>
        /// 明细类型 1：维修项目2：附加项目
        /// </summary>        
        public string Type { get; set; }  
		/// <summary>
        /// 工时（维修项目）
        /// </summary>        
        public double? WorkHour { get; set; }  
		/// <summary>
        /// 单价（工时费或附加产品金额）
        /// </summary>        
        public int? Price { get; set; }  
		/// <summary>
        /// 折扣率
        /// </summary>        
        public int? Discount { get; set; }  
		/// <summary>
        /// 金额
        /// </summary>        
        public int? Amount { get; set; }  
		/// <summary>
        /// 责任人（造成返工的责任人）
        /// </summary>        
        public Guid? ResponsibleUser { get; set; }  
		/// <summary>
        /// 派工时间
        /// </summary>        
        public DateTime? AssignedOnUtc { get; set; }  
		/// <summary>
        /// 开始施工时间
        /// </summary>        
        public DateTime? BeginOnUtc { get; set; }  
		/// <summary>
        /// 结束施工时间
        /// </summary>        
        public DateTime? EndOnUtc { get; set; }  
		/// <summary>
        /// 状态（DictValues表-Id字段）
        /// </summary>        
        public Guid Status { get; set; }  
		/// <summary>
        /// 验收人
        /// </summary>        
        public Guid? Inspector { get; set; }  
		/// <summary>
        /// 验收时间
        /// </summary>        
        public DateTime? InspectedOnUtc { get; set; }		
    }
}
