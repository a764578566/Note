using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Vehicles")]
	public class Vehicle : ChainEntity
	{  
		/// <summary>
        /// 数据来源
        /// </summary>        
        public int DataSource { get; set; }  
		/// <summary>
        /// 品牌Id
        /// </summary>        
        public Guid BrandId { get; set; }  
		/// <summary>
        /// 品牌名称（冗余字段）
        /// </summary>        
        public string BrandName { get; set; }  
		/// <summary>
        /// 厂商Id
        /// </summary>        
        public Guid ManufactureId { get; set; }  
		/// <summary>
        /// 厂商名称
        /// </summary>        
        public string ManufactureName { get; set; }  
		/// <summary>
        /// 车系Id
        /// </summary>        
        public Guid SeriesId { get; set; }  
		/// <summary>
        /// 车系名称
        /// </summary>        
        public string SeriesName { get; set; }  
		/// <summary>
        /// 车型Id
        /// </summary>        
        public Guid? ModelId { get; set; }  
		/// <summary>
        /// 车型名称
        /// </summary>        
        public string ModelName { get; set; }  
		/// <summary>
        /// 车辆销售名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 首字母
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
        /// 车价范围Id
        /// </summary>        
        public Guid PriceRangeId { get; set; }  
		/// <summary>
        /// 车价范围名称
        /// </summary>        
        public string PriceRange { get; set; }  
		/// <summary>
        /// 上市年份
        /// </summary>        
        public string ListingYear { get; set; }  
		/// <summary>
        /// 上市月份
        /// </summary>        
        public string ListingMonth { get; set; }  
		/// <summary>
        /// 年款
        /// </summary>        
        public string VehicleYear { get; set; }  
		/// <summary>
        /// 产地类型
        /// </summary>        
        public string OriginType { get; set; }  
		/// <summary>
        /// 国别
        /// </summary>        
        public string CountryType { get; set; }  
		/// <summary>
        /// 环保标准
        /// </summary>        
        public string EnvStandard { get; set; }  
		/// <summary>
        /// 排量
        /// </summary>        
        public string Displacement { get; set; }  
		/// <summary>
        /// 燃油类型
        /// </summary>        
        public string FuelType { get; set; }  
		/// <summary>
        /// 变速器类型
        /// </summary>        
        public string Transmission { get; set; }  
		/// <summary>
        /// 车辆类型
        /// </summary>        
        public string CarType { get; set; }  
		/// <summary>
        /// 车辆大小
        /// </summary>        
        public string CarSize { get; set; }  
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
    }
}
