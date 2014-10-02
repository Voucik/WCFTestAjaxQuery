using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfServiceHost
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract()]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<Data.Test> GetTestData();

        [OperationContract]
        [WebInvoke(Method = "POST")]
        void AddTestData(Data.Test value);
    }
}
