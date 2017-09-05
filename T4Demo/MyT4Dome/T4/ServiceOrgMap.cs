using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ServiceOrgMap")]
	public class ServiceOrgMap : ChainEntity
	{  
		/// <summary>
        /// 服务Id
        /// </summary>        
        public Guid ServiceId { get; set; }  
		/// <summary>
        /// 车价范围Id
        /// </summary>        
        public Guid? PriceRange { get; set; }  
		/// <summary>
        /// 工时
        /// </summary>        
        public double WorkingHour { get; set; }  
		/// <summary>
        /// 工时费（保存到分）
        /// </summary>        
        public int Price { get; set; }		
    }
}
