using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class Template
    {
        public static Template GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.TemplateSet
                    where entity.Id.Equals(id)
                    select entity).FirstOrDefault();
        }

        public static Template GetByName(CRMDataContext dataContext, string templateName)
        {
            return (from entity in dataContext.TemplateSet
                    where entity.Title.Equals(templateName)
                    select entity).FirstOrDefault();
        }

        public static Entity GetByName(IOrganizationService service, string templateName)
        {
            Entity template = null;

            string fetchXML = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                  <entity name='template'>
                                    <attribute name='title' />
                                    <attribute name='templatetypecode' />
                                    <attribute name='ispersonal' />
                                    <attribute name='languagecode' />
                                    <attribute name='templateid' />
                                    <order attribute='title' descending='false' />
                                    <filter type='and'>
                                      <condition attribute='title' operator='eq' value='{0}' />
                                    </filter>
                                  </entity>
                                </fetch>";

            fetchXML = string.Format(fetchXML, templateName);
            EntityCollection templateCollection = service.RetrieveMultiple(new FetchExpression(fetchXML));

            if (templateCollection.Entities.Count > 0)
            {
                template = templateCollection.Entities[0];
            }

            return template;
        }
    }
}

