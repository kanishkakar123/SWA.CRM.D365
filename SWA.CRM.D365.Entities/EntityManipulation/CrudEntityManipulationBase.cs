using Microsoft.Xrm.Sdk;
using System;

namespace SWA.CRM.D365.Entities.Base
{
    public abstract class CrudEntityManipulationBase : EntityManipulationBase
    {
        private readonly Entity targetEntity;

        public Entity TargetEntity
        {
            get { return this.targetEntity; }
        }

        public CrudEntityManipulationBase(Entity targetEntity)
        {
            if (targetEntity == null)
                throw new ArgumentNullException(
                    "The paramter targetEntity cannot be null. Please ensure that a valid targetEntity object is passed into the EntityManipulation");


            this.targetEntity = targetEntity.Clone(); //always clone to snapshot the changes that have to be made. There is a risk that as it is a ref type values might be changed ourside before the save is called.
        }
    }
}
