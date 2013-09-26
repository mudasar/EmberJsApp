using System.Collections;
using System.Collections.Generic;
using Pos.Core.Domain;
using Pos.Core.Interfaces;

namespace Pos.Infrastructure.Services.Interfaces
{
    public interface IUserService
    {
        User Login(string username, string password);
        User AddUser(User user);
        IList<User> GetAllUsers();
    }
}