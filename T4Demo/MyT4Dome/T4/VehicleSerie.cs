using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("VehicleSeries")]
	public class VehicleSerie : ChainEntity
	{  
		/// <summary>
        /// 数据来源 1：系统初始 2：自建 
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 品牌Id
        /// </summary>        
        public Guid BrandId { get; set; }  
		/// <summary>
        /// 车系名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 名称首字母
        /// </summary>        
        public string FirstChar { get; set; }  
		/// <summary>
        /// 拼音(全拼)
        /// </summary>        
        public string Bopomofo { get; set; }  
		/// <summary>
        /// 简拼
        /// </summary>        
        public string ShortBopomofo { get; set; }		
    }
}
