using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;

namespace SWA.CRM.D365.Common.CRMHelper
{
    public class CRMConnection
    {
        private CrmServiceClient serviceClient = null;
        private string ConnectionString = string.Empty;

        public CRMConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IOrganizationService GetOrganizationService(long? timeoutValue = null)
        {
            if (serviceClient == null || !serviceClient.IsReady || !string.IsNullOrEmpty(serviceClient.LastCrmError))
            {
                if (string.IsNullOrEmpty(ConnectionString))
                {
                    throw new ApplicationException("The CRM connection string is not set.");
                }

                // if CrmService Timeout is not set then befault for CRM is 2min
                // so, only required if we are having timeout issue , e.g., 864000000000
                if (timeoutValue.HasValue)
                {
                    CrmServiceClient.MaxConnectionTimeout = new TimeSpan(timeoutValue.Value);
                }

                serviceClient = new CrmServiceClient(ConnectionString);
            }

            if (!string.IsNullOrEmpty(serviceClient.LastCrmError))
            {
                throw new ApplicationException(serviceClient.LastCrmError);
            }

            if (!serviceClient.IsReady)
            {
                throw new ApplicationException("The CRM Client was not in a ready state. This indicates there was a connectivity problem between the client and the crm server.");
            }

            return serviceClient.OrganizationWebProxyClient != null ? (IOrganizationService)serviceClient.OrganizationWebProxyClient : serviceClient.OrganizationServiceProxy;
        }
    }
}
