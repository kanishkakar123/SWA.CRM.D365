using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public class EntityManipulationCollection : IEntityManipulationCollection
    {
        private readonly List<EntityManipulationBase> items = new List<EntityManipulationBase>();

        public int CreateEntityCount => this.GetManipulationTypeCount<CreateEntityManipulation>();

        public int UpdateEntityCount => this.GetManipulationTypeCount<UpdateEntityManipulation>();

        public int SetStateEntityCount => this.GetManipulationTypeCount<SetStateEntityManipulation>();

        public int DeleteEntityCount => this.GetManipulationTypeCount<DeleteEntityManipulation>();

        public IEnumerable<EntityManipulationBase> Items => items;

        public int GetManipulationTypeCount<TE>()
        {
            return items.Count(x => x.GetType() == typeof(TE));
        }

        public void Add(EntityManipulationBase entityManipulation)
        {
            if (entityManipulation == null)
                return;
            this.items.Add(entityManipulation);
        }

        public void Remove(EntityManipulationBase entityManipulation)
        {
            if (entityManipulation == null) return;

            this.items.Remove(entityManipulation);
        }

        public EntityExecutionResultCollection Excecute(IOrganizationService organisationService)
        {
            return ExecuteEntityManipulationService.Execute(organisationService, this);
        }



        public void ExecuteAndThrowExceptions(IOrganizationService organizationService)
        {
            var results = Excecute(organizationService);

            if (results.HasErrors)
            {
                throw new EntityExecutionResultsException("An error running this entity manipulation collection. See 'Results' property for more details.", results);
            }
        }
    }
}
