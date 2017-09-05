using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ProductSpecifications")]
	public class ProductSpecification : ChainEntity
	{  
		/// <summary>
        /// 数据来源
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 规格编码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 规格号
        /// </summary>        
        public string Name { get; set; }		
    }
}
