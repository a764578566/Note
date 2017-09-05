using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("OrganizationInfos")]
	public class OrganizationInfo : ChainEntity
	{  
		/// <summary>
        /// 地址
        /// </summary>        
        public string Address { get; set; }  
		/// <summary>
        /// 省份城市Id
        /// </summary>        
        public Guid? AreaId { get; set; }  
		/// <summary>
        /// 联系人
        /// </summary>        
        public string ContactUser { get; set; }  
		/// <summary>
        /// 联系方式
        /// </summary>        
        public string ContactInfo { get; set; }  
		/// <summary>
        /// 坐标X
        /// </summary>        
        public string XCoordinate { get; set; }  
		/// <summary>
        /// 坐标Y
        /// </summary>        
        public string YCoordinate { get; set; }		
    }
}
