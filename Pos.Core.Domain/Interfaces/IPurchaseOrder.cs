using System;
using System.Collections.Generic;
using Pos.Core.Domain;
using Pos.Core.Enums;

namespace Pos.Core.Interfaces
{
    public interface IPurchaseOrder
    {
        DateTime OrderDate { get; set; }
        decimal OrderTotal { get; set; }

        /// <summary>
        /// user who processed the order in case of Website order its OnlineUser
        /// </summary>
        User Operator { get; set; }

        User OrderBy { get; set; }
        string Comments { get; set; }
        IPayment Payment { get; set; }
        OrderStatus OrderStatus { get; set; }
        IList<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        int Id { get; set; }
    }
}