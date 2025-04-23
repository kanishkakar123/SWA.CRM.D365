using System;
using System.Collections.Generic;
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
                    where entity.StateCode.Value == (int)queueitem_statecode.Active
                    select entity).FirstOrDefault();
        }

        public static Queue GetByTeam(CRMDataContext dataContext, Guid teamId)
        {
            return (from entity in dataContext.QueueSet
                    where entity.OwningTeam.Id.Equals(teamId)
                    where entity.StateCode.Value == (int)queueitem_statecode.Active
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
