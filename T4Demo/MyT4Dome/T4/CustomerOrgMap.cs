using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CustomerOrgMap")]
	public class CustomerOrgMap : ChainEntity
	{  
		/// <summary>
        /// 客户Id
        /// </summary>        
        public Guid CustomerId { get; set; }  
		/// <summary>
        /// 首次进店时间
        /// </summary>        
        public DateTime? FirstEnter { get; set; }  
		/// <summary>
        /// 末次进店时间
        /// </summary>        
        public DateTime? LastEnter { get; set; }		
    }
}
