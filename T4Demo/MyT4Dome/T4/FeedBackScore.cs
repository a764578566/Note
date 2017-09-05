using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("FeedBackScores")]
	public class FeedBackScore : BaseEntity
	{  
		/// <summary>
        /// 回访单
        /// </summary>        
        public Guid FeedbackId { get; set; }  
		/// <summary>
        /// 员工Id
        /// </summary>        
        public Guid? Employee { get; set; }  
		/// <summary>
        /// 评分结果
        /// </summary>        
        public double? Score { get; set; }  
		/// <summary>
        /// 内容
        /// </summary>        
        public string Content { get; set; }		
    }
}
