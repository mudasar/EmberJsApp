using System;
using Pos.Core.Enums;
using Pos.Core.Enums;

namespace Pos.Core.Interfaces
{
    public interface IPayment
    {
        PaymentType PaymentType { get; set; }
        PaymentStatus PaymentStatus { get; set; }
        DateTime PaymentDate { get; set; }
        IPurchaseOrder PurchaseOrder { get; set; }
    }
}