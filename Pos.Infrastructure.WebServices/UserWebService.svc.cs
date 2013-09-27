using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Pos.Core.Domain;
using Pos.Core.Interfaces;
using Pos.Infrastructure.Services.Interfaces;

namespace Pos.Infrastructure.WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserWebService : IUserWebService
    {
        #region Fields

        private readonly IUserService _userService;

        #endregion

        #region ctor

        public UserWebService(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region public methods IUserWebService

        public User Login(string username, string password)
        {
            return _userService.Login(username, password);
        }


        public void Dispose()
        {
            
        }

        #endregion
    }
}
