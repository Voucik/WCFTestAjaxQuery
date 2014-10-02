using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace WcfServiceHost
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        private static List<Data.Test> _data = new List<Data.Test>() { new Data.Test() { ID = 0, Name = "a" }, new Data.Test() { ID = 1, Name = "B" } };
        public List<Data.Test> GetTestData()
        {
            return _data;
        }

        public void AddTestData(Data.Test value)
        {
            _data.Add(value);
        }
    }
}
