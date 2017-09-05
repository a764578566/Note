using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Employees")]
	public class Employee : ChainEntity
	{  
		/// <summary>
        /// 关联的平台用户
        /// </summary>        
        public Guid? UserId { get; set; }  
		/// <summary>
        /// 员工代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 员工姓名
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 员工状态
        /// </summary>        
        public Guid Status { get; set; }  
		/// <summary>
        /// 联系方式
        /// </summary>        
        public string ContactInfo { get; set; }		
    }
}
