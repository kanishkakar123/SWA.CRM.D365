using Newtonsoft.Json;

namespace SWA.CRM.D365.Common.Model
{
    public class SMSServiceResponse : ResponseMessageBase
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
