using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Suppliers")]
	public class Supplier : ChainEntity
	{  
		/// <summary>
        /// 数据来源
        /// </summary>        
        public string DataSource { get; set; }  
		/// <summary>
        /// 类型
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 名称
        /// </summary>        
        public string Name { get; set; }  
		/// <summary>
        /// 简称
        /// </summary>        
        public string ShortName { get; set; }  
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
        /// 地址
        /// </summary>        
        public string Address { get; set; }  
		/// <summary>
        /// 省份城市Id
        /// </summary>        
        public Guid? AreaId { get; set; }  
		/// <summary>
        /// 邮编
        /// </summary>        
        public string Postal { get; set; }  
		/// <summary>
        /// 联系人
        /// </summary>        
        public string ContactUser { get; set; }  
		/// <summary>
        /// 联系电话
        /// </summary>        
        public string Tel { get; set; }  
		/// <summary>
        /// 联系邮箱
        /// </summary>        
        public string Email { get; set; }  
		/// <summary>
        /// 传真
        /// </summary>        
        public string Fax { get; set; }  
		/// <summary>
        /// 其他联系信息
        /// </summary>        
        public string ContactInfo { get; set; }		
    }
}
