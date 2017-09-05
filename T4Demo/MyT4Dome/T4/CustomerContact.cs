using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CustomerContacts")]
	public class CustomerContact : BaseEntity
	{  
		/// <summary>
        /// 客户
        /// </summary>        
        public Guid CustomerId { get; set; }  
		/// <summary>
        /// 联系人姓名
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 联系电话
        /// </summary>        
        public string Phone { get; set; }  
		/// <summary>
        /// 其他联系信息
        /// </summary>        
        public string ContactInfo { get; set; }  
		/// <summary>
        /// 与车主关系
        /// </summary>        
        public Guid? RelationType { get; set; }		
    }
}
