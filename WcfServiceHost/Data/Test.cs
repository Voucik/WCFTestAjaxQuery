using System.Runtime.Serialization;

namespace WcfServiceHost.Data
{
    [DataContract]
    public class Test
    {
        [DataMember(Name = "id")]
        public int ID { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}