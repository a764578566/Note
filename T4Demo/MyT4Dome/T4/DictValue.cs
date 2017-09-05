using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("DictValues")]
	public class DictValue : BaseEntity
	{  
		/// <summary>
        /// 字典Id
        /// </summary>        
        public Guid DictId { get; set; }  
		/// <summary>
        /// 标识
        /// </summary>        
        public string Key { get; set; }  
		/// <summary>
        /// 字典值
        /// </summary>        
        public string Value { get; set; }		
    }
}
