using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using SWA.CRM.D365.Entities.Base;
using System;
using System.Activities;
using System.Globalization;
using System.ServiceModel;

namespace SWA.CRM.D365.Workflows
{
    public abstract class WorkFlowActivityBase : CodeActivity
    {
        public sealed class LocalWorkflowContext
        {
            internal IServiceProvider ServiceProvider { get; private set; }
            //internal IServiceProvider ServiceProvider
            //{
            //    get;

            //    private set;
            //}

            internal IOrganizationService OrganizationService
            {
                get;

                private set;
            }

            internal IWorkflowContext WorkflowExecutionContext
            {
                get;

                private set;
            }

            internal ITracingService TracingService
            {
                get;

                private set;
            }

            /// <summary>
            /// Create Early Bound DataContext using Entites solution
            /// </summary>
            internal CRMDataContext DataContext
            {
                get;

                private set;
            }

            private LocalWorkflowContext()
            {
            }

            internal LocalWorkflowContext(CodeActivityContext executionContext)
            {
                if (executionContext == null)
                {
                    throw new ArgumentNullException("executionContext");
                }

                // Obtain Service provider
                this.ServiceProvider = (IServiceProvider)executionContext.GetExtension<IServiceProvider>();

                // Obtain the execution context service from the service provider.
                this.WorkflowExecutionContext = (IWorkflowContext)executionContext.GetExtension<IWorkflowContext>();

                try
                {
                    ((IProxyTypesAssemblyProvider)WorkflowExecutionContext).ProxyTypesAssembly = typeof(Account).Assembly;
                }
                catch (System.InvalidCastException)
                {
                    // do nothing as this errors when the plugin is run from the 'Replay Plug-in Execution' function from the plugin registration tool.
                }

                // Obtain the tracing service from the service provider.
                this.TracingService = (ITracingService)executionContext.GetExtension<ITracingService>();

                // Obtain the Organization Service factory service from the service provider
                IOrganizationServiceFactory factory = (IOrganizationServiceFactory)executionContext.GetExtension<IOrganizationServiceFactory>();

                // Use the factory to generate the Organization Service.
                this.OrganizationService = factory.CreateOrganizationService(this.WorkflowExecutionContext.UserId);

                // Create new Early Binding Context
                DataContext = new CRMDataContext(OrganizationService);
            }

            internal void Trace(string message)
            {
                if (string.IsNullOrWhiteSpace(message) || this.TracingService == null)
                {
                    return;
                }

                if (this.WorkflowExecutionContext == null)
                {
                    this.TracingService.Trace(message);
                }
                else
                {
                    this.TracingService.Trace(
                        "{0}, Correlation Id: {1}, Initiating User: {2}",
                        message,
                        this.WorkflowExecutionContext.CorrelationId,
                        this.WorkflowExecutionContext.InitiatingUserId);
                }
            }
        }

        /// <summary>
        /// Gets or sets the name of the child class.
        /// </summary>
        /// <value>The name of the child class.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "WorkFlowActivityBase")]
        protected string ChildClassName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkFlowActivityBase"/> class.
        /// </summary>
        /// <param name="childClassName">The <see cref=" cred="Type"/> of the derived class.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "WorkFlowActivityBase")]
        internal WorkFlowActivityBase(Type childClassName)
        {
            ChildClassName = childClassName.ToString();
        }

        protected override void Execute(CodeActivityContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("serviceProvider");
            }

            // Construct the Local plug-in context.
            LocalWorkflowContext localcontext = new LocalWorkflowContext(context);

            localcontext.Trace(string.Format(CultureInfo.InvariantCulture, "Entered {0}.Execute()", this.ChildClassName));

            try
            {
                ExecuteCRMWorkFlowActivity(context, localcontext);
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

        public virtual void ExecuteCRMWorkFlowActivity(CodeActivityContext context, LocalWorkflowContext crmWorkflowContext)
        {
            // Do nothing. 
        }
    }
}
