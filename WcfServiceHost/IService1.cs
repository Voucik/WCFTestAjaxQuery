using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfServiceHost
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract()]
        [WebInvoke(Method = "GET", UriTemplate = "/GetTestData", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<Data.Test> GetTestData();

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void AddTestData(Data.Test value);
    }
}
