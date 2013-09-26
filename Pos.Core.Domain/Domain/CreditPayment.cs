using System;
using Pos.Core.Enums;
using Pos.Core.Interfaces;

namespace Pos.Core.Domain
{
    public class CreditPayment : BaseEntity, IPayment, ICreditpayment
    {
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public IPurchaseOrder PurchaseOrder { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2{ get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardType { get; set; }
        public string CVV2Code { get; set; }
        public int ExpiryYear { get; set; }
        public int ExpiryMonth { get; set; }
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
    }
}