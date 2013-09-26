namespace Pos.Core.Interfaces
{
    public interface ICreditpayment
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string Address2 { get; set; }
        string Postcode { get; set; }
        string State { get; set; }
        string Country { get; set; }
        string CreditCardNumber { get; set; }
        string CreditCardType { get; set; }
        string CVV2Code { get; set; }
        int ExpiryYear { get; set; }
        int ExpiryMonth { get; set; }
        int StartYear { get; set; }
        int StartMonth { get; set; }
        int Id { get; set; }
    }
}