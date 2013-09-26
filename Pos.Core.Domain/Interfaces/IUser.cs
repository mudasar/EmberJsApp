using System;
using Pos.Core.Domain;

namespace Pos.Core.Interfaces
{
    public interface IUser
    {
        Guid UserGuid { get; set; }
        string UserName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string Phone { get; set; }
        UserRole UserRole { get; set; }
        bool Status { get; set; }
        int Id { get; set; }
        string Password { get; set; }
    }
}