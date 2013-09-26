using Pos.Core.Domain;

namespace Pos.Core.Interfaces
{
    public interface IPurchaseOrderItem
    {
        int OrderId { get; set; }
        int ProductId { get; set; }
        decimal Quantity { get; set; }
        decimal UnitPrice { get; set; }
        decimal SubTotal { get; set; }
        Product Product { get; set; }
        PurchaseOrder PurchaseOrder { get; set; }
        int Id { get; set; }
    }
}