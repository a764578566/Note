using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("ProductOrgMap")]
	public class ProductOrgMap : ChainEntity
	{  
		/// <summary>
        /// 产品Id
        /// </summary>        
        public Guid ProductId { get; set; }  
		/// <summary>
        /// 产品数据来源 1： 数据中心 2 ：自建
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 销售建议单价
        /// </summary>        
        public int Price { get; set; }  
		/// <summary>
        /// 默认库房
        /// </summary>        
        public Guid DefaultStore { get; set; }  
		/// <summary>
        /// 默认库位
        /// </summary>        
        public string DefaultLocation { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public int MaxCount { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public int MinCount { get; set; }		
    }
}
