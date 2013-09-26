using Pos.Core.Interfaces;

namespace Pos.Core.Domain
{
    public class PurchaseOrderItem : BaseEntity, IPurchaseOrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }

        public virtual Product Product { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}