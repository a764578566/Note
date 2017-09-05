using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("PaymentSettings")]
	public class PaymentSetting : ChainEntity
	{  
		/// <summary>
        /// 支持的支付方式
        /// </summary>        
        public Guid Payment { get; set; }  
		/// <summary>
        /// 绑定账号
        /// </summary>        
        public string Account { get; set; }		
    }
}
