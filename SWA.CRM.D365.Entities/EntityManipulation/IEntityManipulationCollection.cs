using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    public interface IEntityManipulationCollection
    {
        void Add(EntityManipulationBase entityManipulation);

        void Remove(EntityManipulationBase entityManipulation);

        EntityExecutionResultCollection Excecute(IOrganizationService organizationService);
    }
}