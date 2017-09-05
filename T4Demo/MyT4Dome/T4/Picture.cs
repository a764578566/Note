using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Pictures")]
	public class Picture : BaseEntity
	{  
		/// <summary>
        /// 数据来源 1：数据中心 2：业务 
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 图片Id
        /// </summary>        
        public Guid ObjectPictureId { get; set; }  
		/// <summary>
        /// 图片类型
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 关联的信息Id
        /// </summary>        
        public Guid ObjectId { get; set; }		
    }
}
