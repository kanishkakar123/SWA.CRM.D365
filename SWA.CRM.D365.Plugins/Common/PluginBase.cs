using SWA.CRM.D365.Entities.Base;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Globalization;

namespace SWA.CRM.D365.Plugins
{
    /// <summary>
    /// Base class for all plug-in classes.
    /// </summary>    
    public abstract class PluginBase : IPlugin
    {
        /// <summary>
        /// Plug-in context object. 
        /// </summary>
        protected class LocalPluginContext
        {

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "LocalPluginContext")]
            internal IServiceProvider ServiceProvider { get; private set; }

            /// <summary>
            /// The Microsoft Dynamics 365 organization service.
            /// </summary>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "LocalPluginContext")]
            internal IOrganizationService OrganizationService { get; private set; }

            internal IOrganizationServiceFactory OrganizationServiceFactory { get; private set; }

            /// <summary>
            /// IPluginExecutionContext contains information that describes the run-time environment in which the plug-in executes, information related to the execution pipeline, and entity business information.
            /// </summary>
            internal IPluginExecutionContext PluginExecutionContext { get; private set; }

            /// <summary>
            /// Synchronous registered plug-ins can post the execution context to the Microsoft Azure Service Bus. <br/> 
            /// It is through this notification service that synchronous plug-ins can send brokered messages to the Microsoft Azure Service Bus.
            /// </summary>
            internal IServiceEndpointNotificationService NotificationService { get; private set; }

            /// <summary>
            /// Provides logging run-time trace information for plug-ins. 
            /// </summary>
            internal ITracingService TracingService { get; private set; }

            /// <summary>
            /// Create Early Bound DataContext using Entites solution
            /// </summary>
            internal CRMDataContext DataContext { get; private set; }

            private LocalPluginContext() { }

            /// <summary>
            /// Helper object that stores the services available in this plug-in.
            /// </summary>
            /// <param name="serviceProvider"></param>
            internal LocalPluginContext(IServiceProvider serviceProvider)
            {
                if (serviceProvider == null)
                {
                    throw new InvalidPluginExecutionException("serviceProvider");
                }

                // Set Service Provider
                ServiceProvider = serviceProvider;

                // Obtain the execution context service from the service provider.
                PluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

                try
                {
                    // enables early bound/proxy types !
                    ((IProxyTypesAssemblyProvider)PluginExecutionContext).ProxyTypesAssembly = typeof(Entities.Base.Account).Assembly;
                }
                catch (System.InvalidCastException)
                {
                    // do nothing as this errors when the plugin is run from the 'Replay Plug-in Execution' function from the plugin registration tool.
                }

                // Obtain the tracing service from the service provider.
                TracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

                // Get the notification service from the service provider.
                NotificationService = (IServiceEndpointNotificationService)serviceProvider.GetService(typeof(IServiceEndpointNotificationService));

                // Obtain the organization factory service from the service provider.
                IOrganizationServiceFactory factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                OrganizationServiceFactory = factory;

                // Use the factory to generate the organization service.
                OrganizationService = factory.CreateOrganizationService(PluginExecutionContext.UserId);

                // Create Early Binding Context
                DataContext = new CRMDataContext(OrganizationService);
            }

            /// <summary>
            /// Writes a trace message to the CRM trace log.
            /// </summary>
            /// <param name="message">Message name to trace.</param>
            internal void Trace(string message)
            {
                if (string.IsNullOrWhiteSpace(message) || TracingService == null)
                {
                    return;
                }

                if (PluginExecutionContext == null)
                {
                    TracingService.Trace(message);
                }
                else
                {
                    TracingService.Trace(
                        "{0}, Correlation Id: {1}, Initiating User: {2}",
                        message,
                        PluginExecutionContext.CorrelationId,
                        PluginExecutionContext.InitiatingUserId);
                }
            }

            public Entity GetTargetEntity()
            {
                if (PluginExecutionContext.InputParameters.Contains("Target")
                    && PluginExecutionContext.InputParameters["Target"] is Entity)
                {
                    return (Entity)PluginExecutionContext.InputParameters["Target"];
                }

                throw new Exception("Target entity was not found in the input parameters.");
            }


            public Entity GetBusinessEntity()
            {
                if (PluginExecutionContext.OutputParameters.Contains("BusinessEntity")
                    && PluginExecutionContext.OutputParameters["BusinessEntity"] is Entity)
                {
                    return (Entity)PluginExecutionContext.OutputParameters["BusinessEntity"];
                }

                throw new Exception("Business entity was not found in the output parameters.");
            }


            public EntityReference GetTargetEntityReference()
            {
                if (PluginExecutionContext.InputParameters.Contains("Target")
                    && PluginExecutionContext.InputParameters["Target"] is EntityReference)
                {
                    return (EntityReference)PluginExecutionContext.InputParameters["Target"];
                }

                throw new Exception("Target Entity Reference was not found in the input parameters.");
            }


            public EntityReference GetEntityMoniker()
            {
                if (PluginExecutionContext.InputParameters.Contains("EntityMoniker")
                    && PluginExecutionContext.InputParameters["EntityMoniker"] is EntityReference)
                {
                    return (EntityReference)PluginExecutionContext.InputParameters["EntityMoniker"];
                }

                throw new Exception("Entity Moniker was not found in the input parameters.");
            }


            public Relationship GetRelationship()
            {
                if (PluginExecutionContext.InputParameters.Contains("Relationship")
                    && PluginExecutionContext.InputParameters["Relationship"] is Relationship)
                {
                    return (Relationship)PluginExecutionContext.InputParameters["Relationship"];
                }

                throw new Exception("Relationship was not found in the input parameters.");
            }


            public QueryExpression GetQueryExpression()
            {
                if (PluginExecutionContext.InputParameters.Contains("Query")
                    && PluginExecutionContext.InputParameters["Query"] is QueryExpression)
                {
                    return (QueryExpression)PluginExecutionContext.InputParameters["Query"];
                }

                throw new Exception("Query was not found in the input parameters.");
            }


            public EntityReferenceCollection GetRelatedEntities()
            {
                if (PluginExecutionContext.InputParameters.Contains("RelatedEntities")
                    && PluginExecutionContext.InputParameters["RelatedEntities"] is EntityReferenceCollection)
                {
                    return (EntityReferenceCollection)PluginExecutionContext.InputParameters["RelatedEntities"];
                }

                throw new Exception("RelatedEntities was not found in the input parameters.");
            }


            public void SetRelatedEntities(EntityReferenceCollection relatedEntities)
            {
                if (PluginExecutionContext.InputParameters.Contains("RelatedEntities")
                    && PluginExecutionContext.InputParameters["RelatedEntities"] is EntityReferenceCollection)
                {
                    PluginExecutionContext.InputParameters["RelatedEntities"] = relatedEntities;
                }
            }


            public void SetTargetEntity(Entity newTargetEntity)
            {
                PluginExecutionContext.InputParameters["Target"] = newTargetEntity;
            }

            public Entity GetPreImageEntity(string preImageAlias)
            {
                if (PluginExecutionContext.PreEntityImages.Contains(preImageAlias)
                    && PluginExecutionContext.PreEntityImages[preImageAlias] is Entity)
                {
                    return PluginExecutionContext.PreEntityImages[preImageAlias];
                }

                throw new InvalidPluginExecutionException(
                    $"Incorrect plug-in Configuration: The Pre Image has not been configured as part of Plugin Deployment -> Entity:{this.PluginExecutionContext.PrimaryEntityName}, Message Name:{this.PluginExecutionContext.MessageName} Stage:{this.PluginExecutionContext.Stage}");
            }

            public Entity GetPostImageEntity(string postImageAlias)
            {
                if (PluginExecutionContext.PostEntityImages.Contains(postImageAlias)
                    && PluginExecutionContext.PostEntityImages[postImageAlias] is Entity)
                {
                    return PluginExecutionContext.PostEntityImages[postImageAlias];
                }

                return null;
                // We can use logger to log the exception for internal validaiton
                //throw new InvalidPluginExecutionException(
                //    string.Format(
                //        "Incorrect plug-in Configuration: The Post Image has not been configured as part of Plugin Deployment -> Entity:{0}, Message Name:{1} Stage:{2}",
                //        this.PluginExecutionContext.PrimaryEntityName,
                //        this.PluginExecutionContext.MessageName,
                //        this.PluginExecutionContext.Stage));
            }
        }

        /// <summary>
        /// Gets or sets the name of the child class.
        /// </summary>
        /// <value>The name of the child class.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "PluginBase")]
        protected string ChildClassName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginBase"/> class.
        /// </summary>
        /// <param name="childClassName">The <see cref=" cred="Type"/> of the derived class.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "PluginBase")]
        internal PluginBase(Type childClassName)
        {
            ChildClassName = childClassName.ToString();
        }

        /// <summary>
        /// Main entry point for he business logic that the plug-in is to execute.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <remarks>
        /// For improved performance, Microsoft Dynamics 365 caches plug-in instances. 
        /// The plug-in's Execute method should be written to be stateless as the constructor 
        /// is not called for every invocation of the plug-in. Also, multiple system threads 
        /// could execute the plug-in at the same time. All per invocation state information 
        /// is stored in the context. This means that you should not use global variables in plug-ins.
        /// </remarks>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "CrmVSSolution411.NewProj.PluginBase+LocalPluginContext.Trace(System.String)", Justification = "Execute")]
        public void Execute(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                throw new InvalidPluginExecutionException("serviceProvider");
            }

            // Construct the local plug-in context.
            LocalPluginContext localcontext = new LocalPluginContext(serviceProvider);

            localcontext.Trace(string.Format(CultureInfo.InvariantCulture, "Entered {0}.Execute()", this.ChildClassName));

            try
            {
                // Invoke the custom implementation 
                ExecuteCrmPlugin(localcontext);
                // now exit - if the derived plug-in has incorrectly registered overlapping event registrations,
                // guard against multiple executions.
                return;
            }
            catch (FaultException<OrganizationServiceFault> e)
            {
                localcontext.Trace(string.Format(CultureInfo.InvariantCulture, "Exception: {0}", e.ToString()));

                // Handle the exception.
                throw new InvalidPluginExecutionException("OrganizationServiceFault", e);
            }
            finally
            {
                localcontext.Trace(string.Format(CultureInfo.InvariantCulture, "Exiting {0}.Execute()", this.ChildClassName));
            }
        }

        /// <summary>
        /// Placeholder for a custom plug-in implementation. 
        /// </summary>
        /// <param name="localcontext">Context for the current plug-in.</param>
        protected virtual void ExecuteCrmPlugin(LocalPluginContext localcontext)
        {
            // Do nothing. 
        }
    }
}
