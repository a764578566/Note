using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Feedbacks")]
	public class Feedback : ChainEntity
	{  
		/// <summary>
        /// 回访类型
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 关联单据
        /// </summary>        
        public Guid? BillId { get; set; }  
		/// <summary>
        /// 采访对象
        /// </summary>        
        public string Interviewee { get; set; }		
    }
}
