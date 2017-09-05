using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Customers")]
	public class Customer : ChainEntity
	{  
		/// <summary>
        /// 会员Id
        /// </summary>        
        public Guid? MemberId { get; set; }  
		/// <summary>
        /// 上级
        /// </summary>        
        public Guid ParentId { get; set; }  
		/// <summary>
        /// 客户级别
        /// </summary>        
        public Guid? Level { get; set; }  
		/// <summary>
        /// 客户类型
        /// </summary>        
        public Guid? Type { get; set; }  
		/// <summary>
        /// 客户编号
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 客户名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 手机号
        /// </summary>        
        public string Phone { get; set; }  
		/// <summary>
        /// 电话
        /// </summary>        
        public string Tel { get; set; }  
		/// <summary>
        /// 性别
        /// </summary>        
        public bool? Sex { get; set; }  
		/// <summary>
        /// 生日
        /// </summary>        
        public DateTime? Birthday { get; set; }  
		/// <summary>
        /// 传真
        /// </summary>        
        public string Fax { get; set; }  
		/// <summary>
        /// 邮箱
        /// </summary>        
        public string Email { get; set; }  
		/// <summary>
        /// 最后一级区县Id
        /// </summary>        
        public Guid? AreaId { get; set; }  
		/// <summary>
        /// 省市区Id列表
        /// </summary>        
        public string CityIdList { get; set; }  
		/// <summary>
        /// 省市区名称列表
        /// </summary>        
        public string CityNameList { get; set; }  
		/// <summary>
        /// 客户地址
        /// </summary>        
        public string Address { get; set; }  
		/// <summary>
        /// 其他联系信息
        /// </summary>        
        public string ContactInfo { get; set; }  
		/// <summary>
        /// 客户来源
        /// </summary>        
        public Guid? Source { get; set; }  
		/// <summary>
        /// 来源备注
        /// </summary>        
        public string SourceInfo { get; set; }  
		/// <summary>
        /// 驾驶证号
        /// </summary>        
        public string DriverNo { get; set; }  
		/// <summary>
        /// 身份证号
        /// </summary>        
        public string IdentityCard { get; set; }  
		/// <summary>
        /// 首次进店时间
        /// </summary>        
        public DateTime? FirstEnter { get; set; }  
		/// <summary>
        /// 末次进店时间
        /// </summary>        
        public DateTime? LastEnter { get; set; }  
		/// <summary>
        /// 经办人员工Id
        /// </summary>        
        public Guid Employee { get; set; }		
    }
}
