using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SWA.CRM.D365.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Plugins
{
    public class TaskPostCreate : PluginBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPreCreate"/> class.
        /// </summary>
        public TaskPostCreate() : base(typeof(TaskPreCreate))
        {
            // Implement your custom configuration handling.
        }

        /// <summary>
        /// Main entry point for he business logic that the plug-in is to execute.
        /// </summary>
        /// <param name="localContext">The <see cref="LocalPluginContext"/> which contains the
        /// <see cref="IPluginExecutionContext"/>,
        /// <see cref="IOrganizationService"/>
        /// and <see cref="ITracingService"/>
        /// </param>
        /// <remarks>
        /// For improved performance, Microsoft Dynamics 365 caches plug-in instances.
        /// The plug-in's Execute method should be written to be stateless as the constructor
        /// is not called for every invocation of the plug-in. Also, multiple system threads
        /// could execute the plug-in at the same time. All per invocation state information
        /// is stored in the context. This means that you should not use global variables in plug-ins.
        /// </remarks>
        protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
        {
            if (localContext == null) { throw new InvalidPluginExecutionException("localContext"); }

            IOrganizationService service = localContext.OrganizationService;
            IPluginExecutionContext context = localContext.PluginExecutionContext;
            ITracingService logger = localContext.TracingService;
            CRMDataContext dataContext = localContext.DataContext;

            logger.Trace("Start TaskPostCreate");
            try
            {
                Task task = localContext.GetTargetEntity().ToEntity<Task>();
                if (task != null && task.RegardingObjectId != null && string.Equals(task.RegardingObjectId.LogicalName, Incident.EntityLogicalName, StringComparison.OrdinalIgnoreCase))
                {
                    if (task.Contains(Task.Fields.OwnerId) && task.GetAttributeValue<EntityReference>("ownerid") != null)
                    {
                        // Get the 'ownerid' (which can be User or Team)
                        EntityReference ownerRef = task.GetAttributeValue<EntityReference>("ownerid");
                        if (ownerRef != null && ownerRef.LogicalName == "team")
                        {
                            logger.Trace("team");

                            Guid teamId = ownerRef.Id;
                            logger.Trace("owner" + ownerRef.Id.ToString());
                            logger.Trace("regaridng" + task.RegardingObjectId.Id.ToString());

                            

                            // 2. Get team's default queue
                            QueryExpression query = new QueryExpression("queue");
                            query.ColumnSet = new ColumnSet("queueid", "name");
                            query.Criteria.AddCondition("ownerid", ConditionOperator.Equal, teamId);
                            query.Criteria.AddCondition("queuetypecode", ConditionOperator.Equal, 1); //default queue

                            EntityCollection queues = service.RetrieveMultiple(query);
                            if (queues.Entities.Count > 0)
                            {
                                logger.Trace("queues.Entities.Count" + queues.Entities.Count.ToString());

                                Entity defaultQueue = queues.Entities[0];
                                // 3. Create a QueueItem to route the Case
                                Entity queueItem = new Entity("queueitem");
                                queueItem["objectid"] = new EntityReference("task", task.Id); // The task
                                queueItem["queueid"] = new EntityReference("queue", defaultQueue.Id); // Team’s default queue
                                service.Create(queueItem);
                                logger.Trace("created queueitem 1");

                            }
                        }
                        else if (ownerRef != null && ownerRef.LogicalName == "systemuser")
                        {
                            Guid userId = ownerRef.Id;

                            // Retrieve user to get the position
                            Entity user = service.Retrieve("systemuser", userId, new ColumnSet("positionid"));
                            logger.Trace("Retrieve 1");

                            if (user.Contains("positionid"))
                            {
                                EntityReference positionRef = (EntityReference)user["positionid"];

                                // Get the Position Name (optional)
                                Entity position = service.Retrieve("position", positionRef.Id, new ColumnSet("name"));
                                string positionName = position.GetAttributeValue<string>("name");
                                logger.Trace("positionName 1" + positionName);

                                //Entity caseToUpdate = new Entity("incident", task.RegardingObjectId.Id);
                                //caseToUpdate["statecode"] = new OptionSetValue(116950003);  // pending department review
                                ////service.Update(caseToUpdate);
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                HelperMethods.LogPluginError("TaskPostCreate", ex, logger);
            }

            logger.Trace("End TaskPostCreate");
        }
    }
}
