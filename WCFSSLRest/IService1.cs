using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFSSLRest
{
   [ServiceContract]
    public interface ISecureRESTSvcTest
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "/Customer/{CustID}")]
        Customer GetCustomerData(string CustID);
    }
}
