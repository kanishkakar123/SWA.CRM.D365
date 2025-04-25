using System;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class swa_sms
    {

        #region public static methods

        public static swa_sms GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.swa_smsSet
                    where entity.Id == id
                    select entity).FirstOrDefault();
        }

        public static swa_sms GetByRegardingObjectId(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.swa_smsSet
                    where entity.RegardingObjectId.Id == id
                    select entity).FirstOrDefault();
        }

        #endregion
    }
}
