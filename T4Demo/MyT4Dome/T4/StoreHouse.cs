using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("StoreHouses")]
	public class StoreHouse : ChainEntity
	{  
		/// <summary>
        /// 仓库代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 仓库名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 仓库地址
        /// </summary>        
        public string Address { get; set; }  
		/// <summary>
        /// 省份城市Id
        /// </summary>        
        public Guid AreaId { get; set; }  
		/// <summary>
        /// 当前是否允许出库
        /// </summary>        
        public bool AllowOut { get; set; }  
		/// <summary>
        /// 当前是否允许入库
        /// </summary>        
        public bool AllowIn { get; set; }  
		/// <summary>
        /// 特殊标识
        /// </summary>        
        public string SpecialMark { get; set; }		
    }
}
