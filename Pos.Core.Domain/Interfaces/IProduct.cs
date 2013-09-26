using System;
using Pos.Core.Domain;
using Pos.Core.Enums;

namespace Pos.Core.Interfaces
{
    public interface IProduct
    {
        string Title { get; set; }
        decimal BasePrice { get; set; }
        decimal SalePrice { get; set; }
        DateTime DateAdded { get; set; }
        bool Instock { get; set; }
        string BarCodeNumber { get; set; }
        bool IsDiscountinued { get; set; }
        byte[] Image { get; set; }
        Measurement Measurement { get; set; }
        DateTime LastModified { get; set; }
        Category Category { get; set; }
        int Id { get; set; }
    }
}