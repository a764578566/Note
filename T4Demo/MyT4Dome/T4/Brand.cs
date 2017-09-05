using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Brands")]
	public class Brand : ChainEntity
	{  
		/// <summary>
        /// 数据来源 1：系统初始 2：自建 
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 品牌类型： 1-车辆 2-配件 3-辅料 4-周边其他 
        /// </summary>        
        public string Type { get; set; }  
		/// <summary>
        /// 品牌代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 品牌名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 品牌简称
        /// </summary>        
        public string ShortName { get; set; }  
		/// <summary>
        /// 品牌首字母
        /// </summary>        
        public string FirstChar { get; set; }  
		/// <summary>
        /// 拼音
        /// </summary>        
        public string Bopomofo { get; set; }  
		/// <summary>
        /// 简拼
        /// </summary>        
        public string ShortBopomofo { get; set; }  
		/// <summary>
        /// 默认LogoId
        /// </summary>        
        public Guid? Logo { get; set; }  
		/// <summary>
        /// 是否热门品牌
        /// </summary>        
        public bool IsHot { get; set; }		
    }
}
