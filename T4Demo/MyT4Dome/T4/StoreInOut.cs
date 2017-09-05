using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("StoreInOuts")]
	public class StoreInOut : ChainEntity
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
        /// 领料退料人（目前维修领退料时需要）
        /// </summary>        
        public Guid? Employee { get; set; }  
		/// <summary>
        /// 出入库类型
        /// </summary>        
        public string IOType { get; set; }  
		/// <summary>
        /// 单据类型
        /// </summary>        
        public Guid BillType { get; set; }  
		/// <summary>
        /// 关联业务单据
        /// </summary>        
        public Guid? BillId { get; set; }  
		/// <summary>
        /// 原始出入库单据Id
        /// </summary>        
        public Guid? OriginalIOId { get; set; }  
		/// <summary>
        /// 状态
        /// </summary>        
        public Guid Status { get; set; }		
    }
}
