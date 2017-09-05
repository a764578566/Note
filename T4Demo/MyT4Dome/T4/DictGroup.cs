using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("DictGroups")]
	public class DictGroup : BaseEntity
	{  
		/// <summary>
        /// 名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
