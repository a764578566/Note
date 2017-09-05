using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Dicts")]
	public class Dict : BaseEntity
	{  
		/// <summary>
        /// 分组Id
        /// </summary>        
        public Guid GroupId { get; set; }  
		/// <summary>
        /// 标识
        /// </summary>        
        public string Key { get; set; }  
		/// <summary>
        /// 名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
