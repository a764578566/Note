using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CustomerVehicleOrgMap")]
	public class CustomerVehicleOrgMap : ChainEntity
	{  
		/// <summary>
        /// 客户车辆Id
        /// </summary>        
        public Guid CustomerVehicleId { get; set; }  
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
