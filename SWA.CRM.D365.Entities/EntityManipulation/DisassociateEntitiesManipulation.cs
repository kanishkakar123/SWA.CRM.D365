using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public class DisassociateEntitiesManipulation : EntityManipulationBase
    {
        private Entity firstEntity;

        private IEnumerable<Entity> relatedEntities;

        private string relationshiptName;

        public override string Action { get { return "DisassociateEntities"; } }

        public DisassociateEntitiesManipulation(Entity firstEntity, IEnumerable<Entity> relatedEntities, string relationshipName)
        {
            this.firstEntity = firstEntity;
            this.relatedEntities = relatedEntities;
            this.relationshiptName = relationshipName;
        }

        public DisassociateEntitiesManipulation(Entity firstEntity, Entity relatedEntity, string relationshipName)
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

            organizationService.Disassociate(firstEntity.LogicalName, firstEntity.Id, relationship2, relatedEntities1);
        }
    }
}
