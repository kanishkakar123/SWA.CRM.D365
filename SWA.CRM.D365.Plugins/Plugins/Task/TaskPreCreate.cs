using Microsoft.Xrm.Sdk;
using SWA.CRM.D365.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Plugins
{
    public class TaskPreCreate : PluginBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPreCreate"/> class.
        /// </summary>
        public TaskPreCreate() : base(typeof(TaskPreCreate))
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

            logger.Trace("Start TaskPreCreate");

            try
            {
                logger.Trace("Get target task");
                Task task = localContext.GetTargetEntity().ToEntity<Task>();

                if (task != null && task.RegardingObjectId != null && string.Equals(task.RegardingObjectId.LogicalName, Incident.EntityLogicalName, StringComparison.OrdinalIgnoreCase))
                {
                    logger.Trace($"Regarding case : {task.RegardingObjectId.Name} ({task.RegardingObjectId.Id})");

                    logger.Trace("Get open tasks for case");
                    IEnumerable<Task> openTasks = Task.GetByRegardingObject(dataContext, task.RegardingObjectId.Id);

                    if (openTasks != null && openTasks.Any())
                    {
                        logger.Trace($"{openTasks.Count()} task(s) are open for the case");
                        throw new InvalidPluginExecutionException(OperationStatus.Failed, Constants.OpenTaskValidationErrorCode, Constants.OpenTaskValidationErrorMessage);
                    }
                    else
                    {
                        logger.Trace("No open task found for the case");
                    }
                }
            }
            catch (InvalidPluginExecutionException ex)
            {
                if (ex.ErrorCode == Constants.OpenTaskValidationErrorCode)
                {
                    throw (ex);
                }
                else
                {
                    HelperMethods.LogPluginError("TaskPreCreate", ex, logger);
                }
            }
            catch (Exception ex)
            {
                HelperMethods.LogPluginError("TaskPreCreate", ex, logger);
            }

            logger.Trace("End TaskPreCreate");
        }
    }
}
