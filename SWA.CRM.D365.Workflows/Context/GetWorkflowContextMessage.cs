using System.Activities;
using Microsoft.Xrm.Sdk.Workflow;

namespace SWA.CRM.D365.Workflows
{
    public class GetWorkflowContextMessage : WorkFlowActivityBase
    {
        [Output("ContextMessage")]
        public OutArgument<string> ContextMessage { get; set; }

        public GetWorkflowContextMessage() : base(typeof(GetWorkflowContextMessage))
        {
        }


        public override void ExecuteCRMWorkFlowActivity(CodeActivityContext executionContext, LocalWorkflowContext crmWorkflowContext)
        {
            ContextMessage.Set(executionContext, crmWorkflowContext.WorkflowExecutionContext.MessageName.ToLower());
        }
    }
}
