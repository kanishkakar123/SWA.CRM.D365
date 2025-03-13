using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    public class DeleteEntityManipulation : CrudEntityManipulationBase
    {
        public DeleteEntityManipulation(Entity targetEntity)
            : base(targetEntity)
        {
        }

        public override string Action { get { return "DeleteEntity"; } }

        public override void Execute(IOrganizationService organizationService)
        {
            organizationService.Delete(this.TargetEntity.LogicalName, this.TargetEntity.Id);
        }
    }
}
