using Pos.Core.Interfaces;
using Pos.Core.Enums;

namespace Pos.Core.Domain
{
   public class UserRole : BaseEntity, IUserRole
   {
       public string Title { get; set; }
       public UserInRole UserInRole { get; set; }
    }
}
