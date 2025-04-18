using System;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class Account
    {

        #region public static methods

        public static Account GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.AccountSet
                    where entity.Id == id
                    select entity).FirstOrDefault();
        }

        public static Account GetByName(CRMDataContext dataContext, string organizationName)
        {
            return (from entity in dataContext.AccountSet
                    where entity.Name.Equals(organizationName.Trim())
                    where entity.StateCode.Value == (int)account_statecode.Active
                    select entity).FirstOrDefault();
        }

        public static IEnumerable<Account> GetAllByName(CRMDataContext dataContext, string organizationName)
        {
            return (from entity in dataContext.AccountSet
                    where entity.Name.Equals(organizationName.Trim())
                    select entity);
        }

        public static Account GetByNameLike(CRMDataContext dataContext, string organizationName)
        {
            return (from entity in dataContext.AccountSet
                    where entity.Name.Contains(organizationName.Trim())
                    where entity.StateCode.Value == (int)account_statecode.Active
                    select entity).FirstOrDefault();
        }

        public static Account GetByOrganizationNo(CRMDataContext dataContext, string organizationNo)
        {
            return (from entity in dataContext.AccountSet
                    where entity.AccountNumber.Equals(organizationNo.Trim())
                    where entity.StateCode.Value == (int)account_statecode.Active
                    select entity).FirstOrDefault();
        }

        public static IEnumerable<Account> GetAllByOrganizationNo(CRMDataContext dataContext, string organizationNo)
        {
            return (from entity in dataContext.AccountSet
                    where entity.AccountNumber.Equals(organizationNo.Trim())
                    select entity);
        }

        public static bool IsOrganizationNameInTheSystem(CRMDataContext dataContext, string newOrganizationName)
        {
            var orgs = (from entity in dataContext.AccountSet
                        where entity.Name.Equals(newOrganizationName.Trim())
                        where entity.StateCode.Value == (int)account_statecode.Active
                        select entity.Id).ToList();

            return (orgs.Any());
        }

        #endregion
    }
}
