using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("InventoryScopes")]
	public class InventoryScope : BaseEntity
	{  
		/// <summary>
        /// 盘点单
        /// </summary>        
        public Guid BillId { get; set; }  
		/// <summary>
        /// 商品Id\库位Id...
        /// </summary>        
        public Guid ObjectId { get; set; }		
    }
}
