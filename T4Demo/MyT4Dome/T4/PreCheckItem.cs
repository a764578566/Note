using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("PreCheckItems")]
	public class PreCheckItem : BaseEntity
	{  
		/// <summary>
        /// 预检单Id
        /// </summary>        
        public Guid PreCheckId { get; set; }  
		/// <summary>
        /// 预检分组Id
        /// </summary>        
        public Guid GroupId { get; set; }  
		/// <summary>
        /// 预检项Id
        /// </summary>        
        public Guid ItemId { get; set; }  
		/// <summary>
        /// 预检值Id
        /// </summary>        
        public Guid ValueId { get; set; }  
		/// <summary>
        /// 预检结果
        /// </summary>        
        public string Content { get; set; }		
    }
}
