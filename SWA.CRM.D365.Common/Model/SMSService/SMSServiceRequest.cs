using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SWA.CRM.D365.Common.Model
{
    public class SMSServiceRequest
    {
        [Required]
        [JsonProperty(PropertyName = "mobileNo")]
        [MaxLength(10, ErrorMessage = "Error : Mobile Number should not be greater than 10 digits")]
        public string MobileNumber {  get; set; }

        [Required]
        [JsonProperty(PropertyName = "message")]
        [MaxLength(200, ErrorMessage = "Error : Message should not be greater than 200 characters")]
        public string Message { get; set; }
    }
}
