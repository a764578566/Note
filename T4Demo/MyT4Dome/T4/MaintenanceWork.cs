using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("MaintenanceWorks")]
	public class MaintenanceWork : BaseEntity
	{  
		/// <summary>
        /// 
        /// </summary>        
        public Guid TeamId { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public DateTime BeginOnUtc { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public DateTime? EndOnUtc { get; set; }		
    }
}
