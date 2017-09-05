using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("SuspendedBills")]
	public class SuspendedBill : ChainEntity
	{  
		/// <summary>
        /// 挂起单据类型 01：维修工单 02：销售单
        /// </summary>        
        public string Type { get; set; }  
		/// <summary>
        /// 关联的单据Id
        /// </summary>        
        public Guid? BillId { get; set; }  
		/// <summary>
        /// 挂起数据  JSON格式
        /// </summary>        
        public string Data { get; set; }  
		/// <summary>
        /// 挂起关键数据 方便列表展示和搜索 JSON格式
        /// </summary>        
        public string KeyData { get; set; }		
    }
}
