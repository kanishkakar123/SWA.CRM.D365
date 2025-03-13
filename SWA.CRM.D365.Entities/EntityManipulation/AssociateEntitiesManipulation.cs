using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public class AssociateEntitiesManipulation : EntityManipulationBase
    {
        private Entity firstEntity;

        private IEnumerable<Entity> relatedEntities;

        private string relationshiptName;

        public override string Action { get { return "AssociateEntities"; } }

        public AssociateEntitiesManipulation(Entity firstEntity, IEnumerable<Entity> relatedEntities, string relationshipName)
        {
            this.firstEntity = firstEntity;
            this.relatedEntities = relatedEntities;
            this.relationshiptName = relationshipName;
        }

        public AssociateEntitiesManipulation(Entity firstEntity, Entity relatedEntity, string relationshipName)
        {
            this.firstEntity = firstEntity;
            this.relatedEntities = new List<Entity>()
            {
               relatedEntity
            };

            this.relationshiptName = relationshipName;
        }
        public override void Execute(IOrganizationService organizationService)
        {
            Relationship relationship2 = new Relationship(relationshiptName);
            var relatedEntities1 = new EntityReferenceCollection
                (relatedEntities.Select(x => new EntityReference(x.LogicalName, x.Id)).ToList());

            organizationService.Associate(firstEntity.LogicalName, firstEntity.Id, relationship2, relatedEntities1);
        }
    }
}
