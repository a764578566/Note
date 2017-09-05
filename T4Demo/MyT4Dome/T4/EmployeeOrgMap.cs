using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("EmployeeOrgMap")]
	public class EmployeeOrgMap : ChainEntity
	{  
		/// <summary>
        /// 员工Id
        /// </summary>        
        public Guid EmployeeId { get; set; }  
		/// <summary>
        /// 职位Id
        /// </summary>        
        public Guid? PositionId { get; set; }  
		/// <summary>
        /// 所在部门Id
        /// </summary>        
        public Guid? DepartmentId { get; set; }  
		/// <summary>
        /// 是否默认组织 1-是 0-否 
        /// </summary>        
        public bool IsDefault { get; set; }		
    }
}
