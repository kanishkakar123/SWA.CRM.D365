using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using SWA.CRM.D365.Entities.Base;
using System.Activities;

namespace SWA.CRM.D365.Workflows
{
    internal class DemoWorkflowActivity : WorkFlowActivityBase
    {
        public DemoWorkflowActivity() : base(typeof(DemoWorkflowActivity))
        {
        }

        public override void ExecuteCRMWorkFlowActivity(CodeActivityContext executionContext, LocalWorkflowContext crmWorkflowContext)
        {
            IWorkflowContext context = crmWorkflowContext.WorkflowExecutionContext;
            IOrganizationService service = crmWorkflowContext.OrganizationService;
            ITracingService logger = crmWorkflowContext.TracingService;
            CRMDataContext dataContext = crmWorkflowContext.DataContext;
        }
    }
}
