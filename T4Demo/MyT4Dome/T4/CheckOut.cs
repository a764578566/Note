using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CheckOuts")]
	public class CheckOut : BaseEntity
	{  
		/// <summary>
        /// 结算单Id
        /// </summary>        
        public Guid SettlementId { get; set; }  
		/// <summary>
        /// 支付方式
        /// </summary>        
        public Guid PaymentMethod { get; set; }  
		/// <summary>
        /// 支付金额
        /// </summary>        
        public int Amount { get; set; }  
		/// <summary>
        /// 账号
        /// </summary>        
        public string Account { get; set; }  
		/// <summary>
        /// 附加信息
        /// </summary>        
        public string AppendInfo { get; set; }		
    }
}
