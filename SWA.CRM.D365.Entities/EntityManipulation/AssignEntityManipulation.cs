using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    public class AssignEntityManipulation : EntityManipulationBase
    {
        public AssignRequest Request { get; set; }

        public AssignEntityManipulation(EntityReference target, EntityReference owner)
        {
            AssignRequest assignRequest = new AssignRequest();
            assignRequest.Target = target;
            assignRequest.Assignee = owner;
            this.Request = assignRequest;
        }

        public override string Action { get { return "AssignEntity"; } }

        public override void Execute(IOrganizationService organizationService)
        {
            organizationService.Execute((OrganizationRequest)this.Request);
        }
    }
}
