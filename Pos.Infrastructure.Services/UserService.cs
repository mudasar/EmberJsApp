using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pos.Core.Data;
using Pos.Core.Domain;
using Pos.Core.Interfaces;
using Pos.Infrastructure.Services.Interfaces;

namespace Pos.Infrastructure.Services
{
    public class UserService : IUserService
    {
        #region fields

        private IRepository<User> _repository;

        #endregion

        #region ctor
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        #endregion

        #region IUserService Members


        public User Login(string username, string password)
        {
            return
                _repository.FindBy(
                    x =>
                        x.UserName.Equals(username, StringComparison.InvariantCultureIgnoreCase) &&
                        x.Password.Equals(password, StringComparison.InvariantCultureIgnoreCase) && x.Status
                        ).FirstOrDefault();
        }

        public User AddUser(User user)
        {
            _repository.Add(user);
            return user;
        }

        public IList<User> GetAllUsers()
        {
            return _repository.GetAll().ToList();
        }

        #endregion
    }
}
