using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    public class UpdateEntityManipulation : CrudEntityManipulationBase
    {
        public UpdateEntityManipulation(Entity targetEntity)
            : base(targetEntity)
        {
        }

        public override string Action { get { return "UpdateEntity"; } }

        public override void Execute(IOrganizationService organizationService)
        {
            this.TargetEntity.EntityState = (new EntityState?((EntityState)2));
            organizationService.Update(this.TargetEntity);
        }
    }
}
