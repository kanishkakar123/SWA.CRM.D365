using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;

namespace SWA.CRM.D365.Workflows
{
    public class GetWorkflowInitiatingUser : WorkFlowActivityBase
    {
        [Output("CurrentUser")]
        [ReferenceTarget("systemuser")]
        public OutArgument<EntityReference> CurrentUser { get; set; }

        public GetWorkflowInitiatingUser() : base(typeof(GetWorkflowInitiatingUser))
        {
        }


        public override void ExecuteCRMWorkFlowActivity(CodeActivityContext executionContext, LocalWorkflowContext crmWorkflowContext)
        {
            CurrentUser.Set(executionContext, new EntityReference("systemuser", crmWorkflowContext.WorkflowExecutionContext.InitiatingUserId));
        }
    }
}
