using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Products")]
	public class Product : ChainEntity
	{  
		/// <summary>
        /// 数据来源 1：系统初始 2自建
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 产品名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 建议零售价
        /// </summary>        
        public int Price { get; set; }  
		/// <summary>
        /// 品牌Id （Brands表-Id字段）
        /// </summary>        
        public Guid? BrandId { get; set; }  
		/// <summary>
        /// 产品编号
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 产品规格Id
        /// </summary>        
        public Guid? SpecificationId { get; set; }  
		/// <summary>
        /// 长
        /// </summary>        
        public double? Length { get; set; }  
		/// <summary>
        /// 宽
        /// </summary>        
        public double? Width { get; set; }  
		/// <summary>
        /// 高
        /// </summary>        
        public double? Height { get; set; }  
		/// <summary>
        /// 重量
        /// </summary>        
        public double? Weight { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string MadeIn { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string PackageInfo { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public Guid? Unit { get; set; }  
		/// <summary>
        /// 产品类别
        /// </summary>        
        public string Type { get; set; }		
    }
}
