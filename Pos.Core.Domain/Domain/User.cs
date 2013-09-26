using System;
using Pos.Core.Interfaces;

namespace Pos.Core.Domain
{
   public class User : BaseEntity, IUser
   {
       public Guid UserGuid { get; set; }
       public string UserName { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public DateTime DateOfBirth { get; set; }
       public string Phone { get; set; }
       public UserRole UserRole { get; set; }
       public bool Status { get; set; }
       public string Password { get; set; }
   }
}
