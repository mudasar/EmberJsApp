using System;
using Pos.Core.Enums;
using Pos.Core.Interfaces;

namespace Pos.Core.Domain
{
    public class CashPayment : BaseEntity , IPayment
    {
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public IPurchaseOrder PurchaseOrder { get; set; }
        public Decimal AmountPaid { get; set; }
        public string PaidBy { get; set; }

    }
}