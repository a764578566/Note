using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("CustomerVehicles")]
	public class CustomerVehicle : ChainEntity
	{  
		/// <summary>
        /// 客户Id
        /// </summary>        
        public Guid CustomerId { get; set; }  
		/// <summary>
        /// 车辆信息Id
        /// </summary>        
        public Guid VehicleId { get; set; }  
		/// <summary>
        /// 车辆名称
        /// </summary>        
        public string VehicleName { get; set; }  
		/// <summary>
        /// 车身颜色
        /// </summary>        
        public string VehicleColor { get; set; }  
		/// <summary>
        /// 品牌
        /// </summary>        
        public string Brand { get; set; }  
		/// <summary>
        /// 厂商
        /// </summary>        
        public string Manufacture { get; set; }  
		/// <summary>
        /// 车系
        /// </summary>        
        public string Series { get; set; }  
		/// <summary>
        /// 车型
        /// </summary>        
        public string Model { get; set; }  
		/// <summary>
        /// 行驶证号
        /// </summary>        
        public string DriverNo { get; set; }  
		/// <summary>
        /// 车牌号
        /// </summary>        
        public string PlateNo { get; set; }  
		/// <summary>
        /// 发动机号
        /// </summary>        
        public string EngineNo { get; set; }  
		/// <summary>
        /// 底盘信息
        /// </summary>        
        public string ChassisNo { get; set; }  
		/// <summary>
        /// VIN
        /// </summary>        
        public string VIN { get; set; }  
		/// <summary>
        /// 购车日期
        /// </summary>        
        public DateTime? PurchaseDate { get; set; }  
		/// <summary>
        /// 验车时间
        /// </summary>        
        public DateTime? Validate { get; set; }  
		/// <summary>
        /// 上牌日期
        /// </summary>        
        public DateTime? RegisterDate { get; set; }  
		/// <summary>
        /// 保险到期日
        /// </summary>        
        public DateTime? InsuranceDue { get; set; }  
		/// <summary>
        /// 保险公司名称
        /// </summary>        
        public string InsuranceCompany { get; set; }  
		/// <summary>
        /// 首次进店时间
        /// </summary>        
        public DateTime? FirstEnter { get; set; }  
		/// <summary>
        /// 末次进店时间
        /// </summary>        
        public DateTime? LastEnter { get; set; }		
    }
}
