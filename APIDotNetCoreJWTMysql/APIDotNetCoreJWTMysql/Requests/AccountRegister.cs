using Newtonsoft.Json;

namespace APIDotNetCoreJWTMysql.Requests
{
    public class AccountRegister
    {
        [JsonProperty(PropertyName = "userLogin", NullValueHandling = NullValueHandling.Ignore)]
        public string UserLogin { get; set; }
        [JsonProperty(PropertyName = "dateRegister", NullValueHandling = NullValueHandling.Ignore)]
        public string dateRegister { get; set; }
        [JsonProperty(PropertyName = "inputType", NullValueHandling = NullValueHandling.Ignore)]
        public string inputType { get; set; }
        [JsonProperty(PropertyName = "inputValue", NullValueHandling = NullValueHandling.Ignore)]
        public string inputValue { get; set; }
    }
}
