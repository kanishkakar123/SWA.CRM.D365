using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;
using SWA.CRM.D365.Common.Model;
using SWA.CRM.D365.Entities.Base;

namespace SWA.CRM.D365.Common.Services
{
    public enum ServiceCategory { SMSService, Survey, IVR, ATIT, OAuthService }

    public class ServiceConfiguration
    {
        private IOrganizationService organizationService;
        private CRMDataContext dataContext;
        private swa_configuration swaConfig;

        public SMSServiceConfig SMSServiceConfig { get; set; }
        public OAuthServiceConfig OAuthServiceConfig { get; set; }

        public ServiceConfiguration(IOrganizationService organizationService, ServiceCategory serviceCategory)
        {
            this.organizationService = organizationService;
            this.dataContext = new CRMDataContext(organizationService);
            BuildServiceConfiguration(serviceCategory);
        }

        private void BuildServiceConfiguration(ServiceCategory serviceCategory)
        {
            // Get Particular Service Config Data metioned in 'serviceCategory' from CRM entity 'SWA Config' and store in the structures
            GetServiceConfigurationCRM(serviceCategory);

            // Get values from SWA Config record in ServiceConfigStructs
            switch (serviceCategory)
            {
                case ServiceCategory.SMSService:
                    SMSServiceConfig = JsonConvert.DeserializeObject<SMSServiceConfig>(swaConfig.swa_value);
                    break;

                case ServiceCategory.Survey:
                    break;

                case ServiceCategory.IVR:
                    break;

                case ServiceCategory.ATIT:
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
            string configName = string.Empty;

            switch (serviceCategory)
            {
                case ServiceCategory.SMSService:
                    configName = "SmsApiUrl";
                    break;

                case ServiceCategory.Survey:
                    break;

                case ServiceCategory.IVR:
                    break;

                case ServiceCategory.ATIT:
                    break;

                case ServiceCategory.OAuthService:
                    OAuthServiceConfig = new OAuthServiceConfig()
                    {
                        // Get values from SWA Config record in OAuthServiceConfig properties
                    };
                    break;
            }

            swaConfig = swa_configuration.GetByName(dataContext, configName);
        }
    }
}
