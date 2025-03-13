using System;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class SystemUser
    {
        public static SystemUser GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.SystemUserSet
                    where entity.Id == id
                    select entity).FirstOrDefault();
        }

        public static SystemUser GetByName(CRMDataContext dataContext, string fullName)
        {
            return (from entity in dataContext.SystemUserSet
                    where entity.FullName.Equals(fullName)
                    select entity).FirstOrDefault();
        }

        public static Guid GetUserId(CRMDataContext dataContext, string fullName)
        {
            return (from entity in dataContext.SystemUserSet
                    where entity.FullName.Equals(fullName)
                    select entity.Id).FirstOrDefault();
        }

        public static SystemUser GetByEmail(CRMDataContext dataContext, string emailId)
        {
            return (from entity in dataContext.SystemUserSet
                    where entity.InternalEMailAddress.Equals(emailId)
                    select entity).FirstOrDefault();
        }

        public static SystemUser GetByUsername(CRMDataContext dataContext, string username)
        {
            return (from entity in dataContext.SystemUserSet
                    where entity.DomainName.Equals(username)
                    select entity).FirstOrDefault();
        }
    }
}
