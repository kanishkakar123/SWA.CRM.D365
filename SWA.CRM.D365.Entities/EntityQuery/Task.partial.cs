using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class Task
    {
        public static Task GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.TaskSet
                    where entity.Id.Equals(id)
                    select entity).FirstOrDefault();
        }

        public static IEnumerable<Task> GetByRegardingObject(CRMDataContext dataContext, Guid regardingObjectId)
        {
            return (from entity in dataContext.TaskSet
                    where entity.RegardingObjectId.Id.Equals(regardingObjectId)
                    where entity.StateCode.Value == (int)task_statecode.Open
                    select entity);
        }

        public static EntityCollection GetByRegardingObject(IOrganizationService service, Guid regardingObjectId)
        {
            string fetchXML = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                  <entity name='task'>
                                    <attribute name='activityid' />
                                    <filter type='and'>
                                      <condition attribute='statecode' operator='eq' value='0' />
                                    </filter>
                                    <link-entity name='incident' from='incidentid' to='regardingobjectid' link-type='inner' alias='ab'>
                                      <filter type='and'>
                                        <condition attribute='incidentid' operator='eq' uiname='test case' uitype='incident' value='{0}' />
                                      </filter>
                                    </link-entity>
                                  </entity>
                                </fetch>";

            fetchXML = string.Format(fetchXML, regardingObjectId);
            return service.RetrieveMultiple(new Microsoft.Xrm.Sdk.Query.FetchExpression(fetchXML));            
        }
    }
}

