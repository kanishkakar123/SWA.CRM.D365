using System.Activities;
using Microsoft.Xrm.Sdk.Workflow;
using SWA.CRM.D365.Entities.Base;

namespace SWA.CRM.D365.Workflows
{
    public class GetConfigurationValue : WorkFlowActivityBase
    {
        [Input("Key")]
        [RequiredArgument]
        public InArgument<string> Key { get; set; }

        [Output("Value")]
        public OutArgument<string> Value { get; set; }

        public GetConfigurationValue() : base(typeof(GetConfigurationValue))
        {
        }


        public override void ExecuteCRMWorkFlowActivity(CodeActivityContext executionContext, LocalWorkflowContext crmWorkflowContext)
        {
            Value.Set(executionContext, swa_configuration.GetByName(crmWorkflowContext.DataContext, Key.Get(executionContext)));
        }
    }
}
