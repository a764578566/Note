using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("PreChecks")]
	public class PreCheck : ChainEntity
	{  
		/// <summary>
        /// 预约单
        /// </summary>        
        public Guid? ReserveId { get; set; }  
		/// <summary>
        /// 单号
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 预检类别
        /// </summary>        
        public Guid? Type { get; set; }  
		/// <summary>
        /// 客户
        /// </summary>        
        public Guid CustomerId { get; set; }  
		/// <summary>
        /// 客户车辆
        /// </summary>        
        public Guid CustomerVehicleId { get; set; }  
		/// <summary>
        /// 车辆名称
        /// </summary>        
        public string VehicleName { get; set; }  
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
        /// 送修人
        /// </summary>        
        public string ContactUser { get; set; }  
		/// <summary>
        /// 联系方式
        /// </summary>        
        public string ContactInfo { get; set; }  
		/// <summary>
        /// 行驶里程
        /// </summary>        
        public double? Mileage { get; set; }  
		/// <summary>
        /// 油量
        /// </summary>        
        public double? Innage { get; set; }  
		/// <summary>
        /// 外观是否有异常
        /// </summary>        
        public bool Appearance { get; set; }  
		/// <summary>
        /// 内饰是否有异常
        /// </summary>        
        public bool Interior { get; set; }  
		/// <summary>
        /// 随车附件备注
        /// </summary>        
        public string AccessoryDescription { get; set; }  
		/// <summary>
        /// 仪表板备注
        /// </summary>        
        public string DashboardDescription { get; set; }  
		/// <summary>
        /// 客户详细描述
        /// </summary>        
        public string CustomerDescription { get; set; }  
		/// <summary>
        /// 预检开始时间
        /// </summary>        
        public DateTime? BeginTime { get; set; }  
		/// <summary>
        /// 预检结束时间
        /// </summary>        
        public DateTime? EndTime { get; set; }  
		/// <summary>
        /// 预检单状态
        /// </summary>        
        public Guid Status { get; set; }		
    }
}
