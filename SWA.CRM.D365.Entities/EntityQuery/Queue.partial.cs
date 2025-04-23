using System;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class Queue
    {

        #region public static methods

        public static Queue GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.QueueSet
                    where entity.Id == id
                    select entity).FirstOrDefault();
        }

        public static Queue GetByName(CRMDataContext dataContext, string queueName)
        {
            return (from entity in dataContext.QueueSet
                    where entity.Name.Equals(queueName.Trim())
                    where entity.StateCode.Value == (int)queue_statecode.Active
                    select entity).FirstOrDefault();
        }

        public static Queue GetByTeam(CRMDataContext dataContext, Guid teamId)
        {
            return (from entity in dataContext.QueueSet
                    where entity.OwningTeam.Id.Equals(teamId)
                    where entity.StateCode.Value == (int)queue_statecode.Active
                    select entity).FirstOrDefault();
        }

        #endregion
    }
}
