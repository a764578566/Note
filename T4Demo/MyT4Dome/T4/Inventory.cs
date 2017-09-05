using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Inventorys")]
	public class Inventory : ChainEntity
	{  
		/// <summary>
        /// 仓库Id
        /// </summary>        
        public Guid StoreId { get; set; }  
		/// <summary>
        /// 盘点范围类型
        /// </summary>        
        public string Scope { get; set; }  
		/// <summary>
        /// 单号
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 流水号
        /// </summary>        
        public byte[] SerialNum { get; set; }  
		/// <summary>
        /// 盘点负责人
        /// </summary>        
        public Guid Leader { get; set; }  
		/// <summary>
        /// 盘点参与人
        /// </summary>        
        public string Employees { get; set; }  
		/// <summary>
        /// 盘点开始时间
        /// </summary>        
        public DateTime? BeginOnUtc { get; set; }  
		/// <summary>
        /// 盘点截止时间
        /// </summary>        
        public DateTime? EndOnUtc { get; set; }  
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
        /// 原因
        /// </summary>        
        public string Reason { get; set; }		
    }
}
