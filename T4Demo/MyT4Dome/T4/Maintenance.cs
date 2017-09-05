using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Maintenances")]
	public class Maintenance : ChainEntity
	{  
		/// <summary>
        /// 单号
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 预检单（PreChecks表-Id字段）
        /// </summary>        
        public Guid? PreCheckId { get; set; }  
		/// <summary>
        /// 关联的维修工单 返工单需要此字段
        /// </summary>        
        public Guid? MaintReturnId { get; set; }  
		/// <summary>
        /// 客户Id（Customers表-Id字段）
        /// </summary>        
        public Guid CustomerId { get; set; }  
		/// <summary>
        /// 客户车辆Id（CustomerVehicles表-Id字段）
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
        /// 车牌号
        /// </summary>        
        public string PlateNo { get; set; }  
		/// <summary>
        /// 工单类型 例如：一般维修、定期保养、事故维修、保险事故、索赔、内返、外返…（DictValues表-Id字段）
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 送修人
        /// </summary>        
        public string ContactUser { get; set; }  
		/// <summary>
        /// 联系方式
        /// </summary>        
        public string ContactInfo { get; set; }  
		/// <summary>
        /// 本次介绍人
        /// </summary>        
        public string Introducer { get; set; }  
		/// <summary>
        /// 介绍人电话
        /// </summary>        
        public string IntroPhone { get; set; }  
		/// <summary>
        /// 本次行驶里程数
        /// </summary>        
        public double? Mileage { get; set; }  
		/// <summary>
        /// 建议下次保养日期
        /// </summary>        
        public DateTime? NextDate { get; set; }  
		/// <summary>
        /// 建议下次保养里程
        /// </summary>        
        public double? NextMileage { get; set; }  
		/// <summary>
        /// 上次进店里程
        /// </summary>        
        public double? LastMileage { get; set; }  
		/// <summary>
        /// 上次进店时间
        /// </summary>        
        public DateTime? LastEnterDate { get; set; }  
		/// <summary>
        /// 出厂里程数
        /// </summary>        
        public double? LeaveMileage { get; set; }  
		/// <summary>
        /// 维修工位
        /// </summary>        
        public string Location { get; set; }  
		/// <summary>
        /// 预计交车时间
        /// </summary>        
        public DateTime? ExpectLeave { get; set; }  
		/// <summary>
        /// 工单状态（DictValues表-Id字段）
        /// </summary>        
        public Guid Status { get; set; }  
		/// <summary>
        /// 服务顾问员工Id
        /// </summary>        
        public Guid? Employee { get; set; }		
    }
}
