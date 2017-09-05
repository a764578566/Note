using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CustomerSources")]
	public class CustomerSource : BaseEntity
	{  
		/// <summary>
        /// 上级
        /// </summary>        
        public Guid ParentId { get; set; }  
		/// <summary>
        /// 来源名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
