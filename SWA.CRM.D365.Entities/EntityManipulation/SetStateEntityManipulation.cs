using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    public class SetStateEntityManipulation : EntityManipulationBase
    {
        public SetStateRequest Request { get; private set; }

        public SetStateEntityManipulation(Entity entity, OptionSetValue stateCode, OptionSetValue statusCode)
        {
            SetStateRequest setStateRequest = new SetStateRequest();
            setStateRequest.EntityMoniker = entity.ToEntityReference();
            setStateRequest.State = (stateCode);
            setStateRequest.Status = (statusCode);
            this.Request = setStateRequest;
        }

        public override string Action { get { return "SetStateEntity"; } }

        public SetStateEntityManipulation(SetStateRequest request)
        {
            this.Request = request;
        }

        public override void Execute(IOrganizationService organizationService)
        {
            organizationService.Execute((OrganizationRequest)this.Request);
        }
    }
}
