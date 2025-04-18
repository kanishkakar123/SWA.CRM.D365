using Microsoft.Xrm.Sdk;
using SWA.CRM.D365.Common.Model;
using System;
using System.Linq;
using System.Web;

namespace SWA.CRM.D365.Common.Services
{
    public class SMSService
    {
        private IOrganizationService organizationService;
        private ServiceConfiguration serviceConfiguration;

        public SMSService(IOrganizationService organizationService)
        {
            this.organizationService = organizationService;
            this.serviceConfiguration = new ServiceConfiguration(organizationService, ServiceCategory.SMSService);
        }

        public SMSServiceResponse SendSMS(SMSServiceRequest request)
        {
            string endpoint = serviceConfiguration.SMSServiceConfig.SMSEndpoint;
            string appKey = serviceConfiguration.SMSServiceConfig.AppKey;
            var properties = from p in request.GetType().GetProperties()
                             where p.GetValue(request, null) != null && !string.IsNullOrEmpty(p.GetValue(request, null).ToString())
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(request, null).ToString());
            string queryString = String.Join("&", properties.ToArray());
            string requestUrl = endpoint + queryString;

            SMSServiceResponse serviceResponse = ServiceInvocation.ServiceRequest<SMSServiceResponse>(RequestMethod.GET, AuthorizationType.AppKey, requestUrl, null, appKey, null);

            return serviceResponse;
        }
    }
}
