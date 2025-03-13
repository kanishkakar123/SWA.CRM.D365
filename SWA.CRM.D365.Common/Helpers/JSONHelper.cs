using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;

namespace SWA.CRM.D365.Common.Helpers
{
    public static class JSONHelper
    {
        public static bool TryGetString(JObject jobject, string jsonPath, out string value)
        {
            var token = jobject.SelectToken(jsonPath);

            if (token == null)
            {
                value = null;
                return false;
            }

            value = token.Value<string>();
            return true;
        }

        public static string JsonSerializer(Object dto, Type type)
        {
            // Snake Case 
            var jsonSerializerSetting = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };

            var message = JsonConvert.SerializeObject(dto, type, jsonSerializerSetting);

            return message;
        }

        public static T JsonDeserializer<T>(string message)
        {
            // Snake Case 
            var jsonSerializerSetting = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };

            var dto = JsonConvert.DeserializeObject<T>(message, jsonSerializerSetting);
            return dto;
        }
    }
}
