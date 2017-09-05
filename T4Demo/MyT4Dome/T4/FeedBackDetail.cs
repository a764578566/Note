using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("FeedBackDetails")]
	public class FeedBackDetail : BaseEntity
	{  
		/// <summary>
        /// 回访单
        /// </summary>        
        public Guid FeedbackId { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public Guid? ItemId { get; set; }  
		/// <summary>
        /// 回访项
        /// </summary>        
        public string ItemName { get; set; }  
		/// <summary>
        /// 回访值Id
        /// </summary>        
        public Guid? ValueId { get; set; }  
		/// <summary>
        /// 最终回访内容
        /// </summary>        
        public string Content { get; set; }		
    }
}
