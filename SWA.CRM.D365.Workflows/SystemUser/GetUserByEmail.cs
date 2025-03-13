using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using SWA.CRM.D365.Entities.Base;

namespace SWA.CRM.D365.Workflows
{
    public class GetUserByEmail : WorkFlowActivityBase
    {
        [Input("Email")]
        [RequiredArgument]
        public InArgument<string> Email { get; set; }

        [Output("AssignToUser")]
        [ReferenceTarget("systemuser")]
        public OutArgument<EntityReference> User { get; set; }

        public GetUserByEmail() : base(typeof(GetUserByEmail))
        {
        }


        public override void ExecuteCRMWorkFlowActivity(CodeActivityContext executionContext, LocalWorkflowContext crmWorkflowContext)
        {
            SystemUser systemUser = SystemUser.GetByEmail(crmWorkflowContext.DataContext, Email.Get(executionContext));

            if (systemUser != null)
            {
                User.Set(executionContext, systemUser.ToEntityReference());
            }
        }
    }
}
