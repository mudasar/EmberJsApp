using System;
using Pos.Core.Enums;
using Pos.Core.Interfaces;

namespace Pos.Core.Domain
{
    public class Product : BaseEntity, IProduct
    {
        public string Title { get; set; }
        public decimal BasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Instock { get; set; }
        public string BarCodeNumber { get; set; }
        public bool IsDiscountinued { get; set; }

        public byte[] Image { get; set; }
        public Measurement Measurement { get; set; }

        public virtual Category Category { get; set; }

    }
}
