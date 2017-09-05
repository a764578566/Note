using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("PreCheckVehicles")]
	public class PreCheckVehicle : BaseEntity
	{  
		/// <summary>
        /// 预检单Id
        /// </summary>        
        public Guid PreCheckId { get; set; }  
		/// <summary>
        /// 故障现象
        /// </summary>        
        public string FaultDescription { get; set; }		
    }
}
