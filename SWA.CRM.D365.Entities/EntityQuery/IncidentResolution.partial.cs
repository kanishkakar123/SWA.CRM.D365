using System;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class IncidentResolution
    {

        #region public static methods

        public static IncidentResolution GetByCase(CRMDataContext dataContext, Guid caseId)
        {
            return (from entity in dataContext.IncidentResolutionSet
                    where entity.IncidentId.Id == caseId
                    select entity).FirstOrDefault();
        }

        #endregion
    }
}
