using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    /// <summary>
    /// This helper method used to perform CRUD actions in to CRM System
    /// </summary>
    public abstract class EntityManipulationBase
    {
        public abstract string Action { get; }

        public abstract void Execute(IOrganizationService organizationService);
    }
}
