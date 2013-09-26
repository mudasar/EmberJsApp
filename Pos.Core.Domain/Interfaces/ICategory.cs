using System.Collections.Generic;
using Pos.Core.Domain;

namespace Pos.Core.Interfaces
{
    public interface ICategory
    {
        string Name { get; set; }
        bool Status { get; set; }
        string Description { get; set; }
        byte[] Picture { get; set; }

        Category ParentCategory { get; set; }
        IList<Product> Products { get; set; }
        int Id { get; set; }
    }
}