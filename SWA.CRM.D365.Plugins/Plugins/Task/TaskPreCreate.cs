using Microsoft.Xrm.Sdk;
using SWA.CRM.D365.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Plugins
{
    public class TaskPreCreate : PluginBase
    {
        public TaskPreCreate() : base(typeof(TaskPreCreate))
        {
            // Implement your custom configuration handling.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionSendNotification"/> class.
        /// </summary>
        /// <param name="unsecure">Contains public (unsecured) configuration information.</param>
        /// <param name="secure">Contains non-public (secured) configuration information. 
        /// When using Microsoft Dynamics 365 for Outlook with Offline Access, 
        /// the secure string is not passed to a plug-in that executes while the client is offline.</param>
        //public TaskPreCreate(string unsecure, string secure) : base(typeof(TaskPreCreate)) 
        //{
        //    // Implement your custom configuration handling.
        //}


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

            //try
            //{
            logger.Trace("Get target task");
            Task task = localContext.GetTargetEntity().ToEntity<Task>();

            if (task != null && task.RegardingObjectId != null && string.Equals(task.RegardingObjectId.LogicalName, Incident.EntityLogicalName, StringComparison.OrdinalIgnoreCase))
            {
                logger.Trace($"Regarding case : {task.RegardingObjectId.Name} ({task.RegardingObjectId.Id})");

                logger.Trace("Get open tasks for case");
                IEnumerable<Task> openTasks = Task.GetByRegardingObject(dataContext, task.RegardingObjectId.Id);
                //EntityCollection openTasks = Task.GetByRegardingObject(service, task.RegardingObjectId.Id);

                if (openTasks != null && openTasks.Any())
                //if (openTasks != null && openTasks.Entities.Count > 0)
                {
                    logger.Trace($"{openTasks.Count()} task(s) are open for the case");
                    //logger.Trace($"{openTasks.Entities.Count} task(s) are open for the case");
                    throw new InvalidPluginExecutionException("There are existing open tasks for this case. Please ensure all open tasks are completed before creating new ones.");
                }
                else
                {
                    logger.Trace($"No open task found for the case");
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    logger.Trace($"Error processing TaskPreCreate : {ex.Message}{Environment.NewLine}StackTrace : {ex.StackTrace}");

            //    if (ex.InnerException != null)
            //    {
            //        logger.Trace($"Inner Exception : {ex.InnerException.Message}{Environment.NewLine}StackTrace : {ex.InnerException.StackTrace}");
            //    }
            //}

            logger.Trace("End TaskPreCreate");
        }
    }
}
