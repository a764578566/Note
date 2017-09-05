using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Purchases")]
	public class Purchase : ChainEntity
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
        /// 类型
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 采购方
        /// </summary>        
        public Guid InUnit { get; set; }  
		/// <summary>
        /// 供货方
        /// </summary>        
        public Guid OutUnit { get; set; }  
		/// <summary>
        /// 入库凭证
        /// </summary>        
        public string Voucher { get; set; }  
		/// <summary>
        /// 装箱单号
        /// </summary>        
        public string PackingCode { get; set; }  
		/// <summary>
        /// 箱号
        /// </summary>        
        public string PackageList { get; set; }  
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
