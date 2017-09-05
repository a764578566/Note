using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CheckGroupSettings")]
	public class CheckGroupSetting : ChainEntity
	{  
		/// <summary>
        /// 数据来源
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 分组标识
        /// </summary>        
        public string Key { get; set; }  
		/// <summary>
        /// 分组名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 模版
        /// </summary>        
        public string Templet { get; set; }		
    }
}
