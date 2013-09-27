using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Pos.Core.Domain;
using Pos.Core.Interfaces;

namespace Pos.Infrastructure.WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IUserWebService
    {

        [OperationContract]
        [WebGet]
        User Login (string username, string password);



        // TODO: Add your service operations here
    }
}
