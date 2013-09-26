using System;
using System.Collections.Generic;
using Pos.Core.Enums;
using Pos.Core.Interfaces;

namespace Pos.Core.Domain
{
    public class PurchaseOrder : BaseEntity, IPurchaseOrder
    {

        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
        /// <summary>
        /// user who processed the order in case of Website order its OnlineUser
        /// </summary>
        public User Operator { get; set; }
        public User OrderBy { get; set; }

        public string Comments { get; set; }

        public IPayment Payment { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public virtual IList<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}
