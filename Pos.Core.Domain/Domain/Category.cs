using System.Collections.Generic;
using Pos.Core.Interfaces;

namespace Pos.Core.Domain
{
    public class Category : BaseEntity, ICategory
    {
       public string Name { get; set; }
       public bool Status { get; set; }
       public string Description { get; set; }
       public byte[] Picture { get; set; }

       public virtual Category ParentCategory { get; set; }
       public virtual IList<Product> Products { get; set; } 

    }
}
