using System;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class Incident
    {

        #region public static methods

        public static Incident GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.IncidentSet
                    where entity.Id == id
                    select entity).FirstOrDefault();
        }

        #endregion
    }
}
