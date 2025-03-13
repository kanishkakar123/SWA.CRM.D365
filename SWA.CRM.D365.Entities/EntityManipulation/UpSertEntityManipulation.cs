using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    public class UpSertEntityManipulation : CrudEntityManipulationBase
    {
        public UpSertEntityManipulation(Entity targetEntity)
            : base(targetEntity)
        {
        }

        public override string Action { get { return "UpSertEntity"; } }

        public override void Execute(IOrganizationService organizationService)
        {
            try
            {
                this.TargetEntity.EntityState = new EntityState?((EntityState)2);
                organizationService.Update(this.TargetEntity);
            }
            catch
            {
                this.TargetEntity.EntityState = (new EntityState?((EntityState)1));
                organizationService.Create(this.TargetEntity);
            }
        }
    }
}
