using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using SWA.CRM.D365.Entities.Base;

namespace SWA.CRM.D365.Workflows
{
    public class GetWorkflowInitiatingUser : WorkFlowActivityBase
    {
        [Output("User")]
        [ReferenceTarget(SystemUser.EntityLogicalName)]
        public OutArgument<EntityReference> CurrentUser { get; set; }

        public GetWorkflowInitiatingUser() : base(typeof(GetWorkflowInitiatingUser))
        {
        }


        public override void ExecuteCRMWorkFlowActivity(CodeActivityContext executionContext, LocalWorkflowContext crmWorkflowContext)
        {
            CurrentUser.Set(executionContext, new EntityReference(SystemUser.EntityLogicalName, crmWorkflowContext.WorkflowExecutionContext.InitiatingUserId));
        }
    }
}
