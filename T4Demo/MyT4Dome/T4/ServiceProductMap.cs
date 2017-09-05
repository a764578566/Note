using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ServiceProductMap")]
	public class ServiceProductMap : BaseEntity
	{  
		/// <summary>
        /// 维修项目Id
        /// </summary>        
        public Guid ServiceId { get; set; }  
		/// <summary>
        /// 产品Id
        /// </summary>        
        public Guid ProductId { get; set; }  
		/// <summary>
        /// 车辆Id
        /// </summary>        
        public Guid VehicleId { get; set; }		
    }
}
