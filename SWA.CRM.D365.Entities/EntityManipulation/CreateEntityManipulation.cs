using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    public class CreateEntityManipulation : CrudEntityManipulationBase
    {
        public CreateEntityManipulation(Entity targetEntity)
            : base(targetEntity)
        {
        }

        public override string Action { get { return "CreateEntity"; } }

        public override void Execute(IOrganizationService organizationService)
        {
            this.TargetEntity.EntityState = (new EntityState?((EntityState)1));
            organizationService.Create(this.TargetEntity);
        }

        public System.Guid Create(IOrganizationService organizationService)
        {
            this.TargetEntity.EntityState = (new EntityState?((EntityState)1));
            return organizationService.Create(this.TargetEntity);
        }
    }
}
