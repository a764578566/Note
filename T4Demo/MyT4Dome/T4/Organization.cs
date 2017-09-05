using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Organizations")]
	public class Organization : ChainEntity
	{  
		/// <summary>
        /// 数据来源 1：系统初始 2：自建 
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 上级
        /// </summary>        
        public Guid ParentId { get; set; }  
		/// <summary>
        /// 组织代码（目前组织代码为6位）
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 组织名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 简称
        /// </summary>        
        public string ShortName { get; set; }  
		/// <summary>
        /// 组织类型： 1-总部 2-分公司办事处 3-门店 4-部门 
        /// </summary>        
        public int Type { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string Url { get; set; }		
    }
}
