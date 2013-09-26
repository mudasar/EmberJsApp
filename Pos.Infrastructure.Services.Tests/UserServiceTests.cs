using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pos.Core.Data;
using Pos.Core.Domain;
using Pos.Core.Enums;
using Pos.Core.Interfaces;
using Pos.Infrastructure.Data.Repositories;
using Pos.Infrastructure.Services.Interfaces;

namespace Pos.Infrastructure.Services.Tests
{
    [TestFixture]
    public class UserServiceTests
    {

        private IUserService _userService;

        [SetUp]
        public void Set_Up_Service()
        {
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");

            DataContextBase _dataContext = new DataContextBase(GetTestDbName());
            _dataContext.Database.Delete();
            _dataContext.Database.Create();
            IRepository<User> _repository = new GenericRepository<User>(_dataContext);
            _userService = new UserService(_repository);

        }

        protected string GetTestDbName()
        {
            string testDbName = "Data Source=" + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)) + @"\\POS.Data.Tests.Db.sdf;Persist Security Info=False";
            return testDbName;
        }

        [Test]
        public void Can_Add_User()
        {
            var user = _userService.AddUser(new User()
            {
                FirstName ="ali", LastName ="wajdan", UserName = "ali", Password = "123456",
                DateOfBirth = DateTime.Now.AddYears(-25), LastModified = DateTime.Now, 
                UserRole = new UserRole(){ LastModified =  DateTime.Now, Title = "Admin", UserInRole = UserInRole.Administrator}
            });
            Assert.IsNotNull(user);
            Assert.AreNotEqual(user.Id, 0);
        }


        [Test]
        public void Get_All_User_List()
        {
            Can_Add_User();
            var userList = _userService.GetAllUsers();
            Assert.IsNotNull(userList);
            Assert.AreEqual(1,userList.Count);
        }

        [Test]
        public void User_Can_Login()
        {
            var user = _userService.AddUser(new User()
            {
                FirstName = "ali",
                LastName = "wajdan",
                UserName = "ali",
                Password = "123456",
                DateOfBirth = DateTime.Now.AddYears(-25),
                LastModified = DateTime.Now,
                Status = true,
                UserRole = new UserRole() { LastModified = DateTime.Now, Title = "Admin", UserInRole = UserInRole.Administrator }
            });

            var luser = _userService.Login("ali", "123456");
            Assert.IsNotNull(luser);
            Assert.AreNotEqual(user.Id, 0);
            Assert.AreEqual(luser.FirstName , user.FirstName);
        }

        [Test]
        public void Disabled_User_Cannot_Login()
        {
            var user = _userService.AddUser(new User()
            {
                FirstName = "ali",
                LastName = "wajdan",
                UserName = "ali",
                Password = "123456",
                DateOfBirth = DateTime.Now.AddYears(-25),
                LastModified = DateTime.Now,
                Status = false,
                UserRole = new UserRole() { LastModified = DateTime.Now, Title = "Admin", UserInRole = UserInRole.Administrator }
            });

            var luser = _userService.Login("ali", "123456");
            Assert.IsNull(luser);
        }
    }
}
