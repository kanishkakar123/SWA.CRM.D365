using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Common.Services
{
    public enum ServiceCategory { SMSService, EmailService, OAuthService }
    public struct BaseURL
    {
        public string ProductionAPI { get; set; }
        public string StagingAPI { get; set; }
        public string AlibabaOSS { get; set; }
        public string BotpressCloud { get; set; }
    }
    public struct SMSServiceConfig
    {
        public string SendSMSEndpoint { get; set; } ///SMSGateway/Api/smssender/SendSms
        public string AppKey { get; set; } // 6B59BB27-38B5-44D3-AFE0-************
    }
    public struct OAuthServiceConfig
    {
        public static string apiKey => "";

        public static string apiSecret => "";

        public static string BaseTokenUrl => "";

        public static string GetRequestUrl => "";

        public static string PostRequestUrl => "";
    }

    public class ServiceConfiguration
    {
        private IOrganizationService organizationService;
        //private Entity swaConfig;

        public BaseURL BaseURL { get; set; }
        public SMSServiceConfig SMSServiceConfig { get; set; }
        public OAuthServiceConfig OAuthServiceConfig { get; set; }

        public ServiceConfiguration(IOrganizationService organizationService, ServiceCategory serviceCategory)
        {
            this.organizationService = organizationService;
            BuildServiceConfiguration(serviceCategory);
        }

        private void BuildServiceConfiguration(ServiceCategory serviceCategory)
        {
            // Get Particular Service Config Data metioned in 'serviceCategory' from CRM entity 'SWA Config' and store in the structures
            GetServiceConfigurationCRM(serviceCategory);

            BaseURL = new BaseURL()
            {
                // Get values from SWA Config record in BaseURL properties
            };

            switch (serviceCategory) 
            {
                case ServiceCategory.SMSService:

                    SMSServiceConfig = new SMSServiceConfig()
                    {
                        // Get values from SWA Config record in SMSServiceConfig properties
                    };
                    break;

                case ServiceCategory.EmailService:
                    break;

                case ServiceCategory.OAuthService:
                    OAuthServiceConfig = new OAuthServiceConfig()
                    {
                        // Get values from SWA Config record in OAuthServiceConfig properties
                    };
                    break;
            }
        }

        private void GetServiceConfigurationCRM(ServiceCategory serviceCategory)
        {

        }
    }
}
