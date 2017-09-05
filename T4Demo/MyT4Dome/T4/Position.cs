using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Positions")]
	public class Position : ChainEntity
	{  
		/// <summary>
        /// 部门Id
        /// </summary>        
        public Guid DepartmentId { get; set; }  
		/// <summary>
        /// 职位类型
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 职位编码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 职位名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
