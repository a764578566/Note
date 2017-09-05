using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("WorkShops")]
	public class WorkShop : ChainEntity
	{  
		/// <summary>
        /// 车间代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 车间名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
