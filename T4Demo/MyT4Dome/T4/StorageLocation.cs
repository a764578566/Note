using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("StorageLocations")]
	public class StorageLocation : BaseEntity
	{  
		/// <summary>
        /// 仓库Id
        /// </summary>        
        public Guid StoreId { get; set; }  
		/// <summary>
        /// 库位代码
        /// </summary>        
        public string Code { get; set; }  
		/// <summary>
        /// 库位名称
        /// </summary>        
        public string Name { get; set; }		
    }
}
