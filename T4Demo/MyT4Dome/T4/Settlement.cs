using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entity
{    
	[Table("Settlements")]
	public class Settlement : BaseEntity
	{  
		/// <summary>
        /// 结算单类型
        /// </summary>        
        public Guid Type { get; set; }  
		/// <summary>
        /// 
        /// </summary>        
        public string BillCode { get; set; }  
		/// <summary>
        /// 关联单据
        /// </summary>        
        public Guid? BillId { get; set; }  
		/// <summary>
        /// VIP卡号
        /// </summary>        
        public string VIPCard { get; set; }  
		/// <summary>
        /// 优惠金额
        /// </summary>        
        public int? Discount { get; set; }  
		/// <summary>
        /// 应收金额
        /// </summary>        
        public int ReceivableAmount { get; set; }  
		/// <summary>
        /// 减免金额
        /// </summary>        
        public int? DeduceAmount { get; set; }  
		/// <summary>
        /// 实收金额
        /// </summary>        
        public int ActualAmount { get; set; }  
		/// <summary>
        /// 结算方
        /// </summary>        
        public Guid SettlementUnit { get; set; }  
		/// <summary>
        /// 资金流向（应收、应付）
        /// </summary>        
        public string CapitalFlow { get; set; }  
		/// <summary>
        /// 资金往来方
        /// </summary>        
        public Guid? CapitalExchangeUnit { get; set; }  
		/// <summary>
        /// 结算方式
        /// </summary>        
        public Guid? SettlementMethod { get; set; }  
		/// <summary>
        /// 结算时间
        /// </summary>        
        public DateTime? SettlementedOnUtc { get; set; }  
		/// <summary>
        /// 收银员
        /// </summary>        
        public Guid? Cashier { get; set; }  
		/// <summary>
        /// 结算单状态
        /// </summary>        
        public Guid Status { get; set; }		
    }
}
