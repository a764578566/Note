using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Departments")]
	public class Department : ChainEntity
	{  
		/// <summary>
        /// 部门代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 部门名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
