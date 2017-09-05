using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("UseReturnDetails")]
	public class UseReturnDetail : BaseEntity
	{  
		/// <summary>
        /// 
        /// </summary>        
        public Guid BillId { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public Guid ProductId { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string Brand { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string ProductCode { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string ProductName { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string ProductCategory { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string ProductSpecification { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public int Count { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public int Price { get; set; }  
		/// <summary>
        /// 总金额
        /// </summary>        
        public int Amount { get; set; }		
    }
}
