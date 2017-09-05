using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("PlateNoBelongs")]
	public class PlateNoBelong : ChainEntity
	{  
		/// <summary>
        /// 数据来源
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 归属地区Id
        /// </summary>        
        public Guid AreaId { get; set; }  
		/// <summary>
        /// 牌号起始
        /// </summary>        
        public string PlateNoStart { get; set; }		
    }
}
