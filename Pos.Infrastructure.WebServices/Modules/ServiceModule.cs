using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Pos.Core.Data;
using Pos.Core.Domain;
using Pos.Core.Interfaces;
using Pos.Infrastructure.Data.Repositories;
using Pos.Infrastructure.Services;
using Pos.Infrastructure.Services.Interfaces;

namespace Pos.Infrastructure.WebServices.Modules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PosDb"].ConnectionString;
            this.Bind<IUser>().To<User>();
            this.Bind<IDataContext>().To<DataContextBase>().WithConstructorArgument("nameOrConnectionString", connectionString); ;
            this.Bind<IRepository<User>>().To<GenericRepository<User>>();
            this.Bind<IUserService>().To<UserService>();
        }
    }
}