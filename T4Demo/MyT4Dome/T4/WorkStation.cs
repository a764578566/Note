using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("WorkStations")]
	public class WorkStation : BaseEntity
	{  
		/// <summary>
        /// 车间Id
        /// </summary>        
        public Guid WorkShopId { get; set; }  
		/// <summary>
        /// 工位代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 工位名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
