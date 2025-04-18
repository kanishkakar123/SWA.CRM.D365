using System;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class Contact
    {
        public static Contact GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.ContactSet
                    where entity.Id == id
                    select entity).FirstOrDefault();
        }

        public static Contact GetByName(CRMDataContext dataContext, string contactFullName)
        {
            return (from entity in dataContext.ContactSet
                    where entity.FullName.Equals(contactFullName)
                    where entity.StateCode.Value == (int)contact_statecode.Active
                    orderby entity.ModifiedOn descending
                    select entity).FirstOrDefault();
        }

        public static Contact GetByName(CRMDataContext dataContext, string contactFullName, Guid organizationId)
        {
            return (from entity in dataContext.ContactSet
                    where entity.FullName.Equals(contactFullName)
                    where entity.ParentCustomerId.Id.Equals(organizationId)
                    where entity.StateCode.Value == (int)contact_statecode.Active
                    select entity).FirstOrDefault();
        }

        public static Contact GetByNameWithoutEmail(CRMDataContext dataContext, string contactFullName, Guid organizationId)
        {
            return (from entity in dataContext.ContactSet
                    where entity.FullName.Equals(contactFullName)
                    where entity.ParentCustomerId.Id.Equals(organizationId)
                    where entity.StateCode.Value == (int)contact_statecode.Active
                    where entity.EMailAddress1 == null
                    select entity).FirstOrDefault();
        }


        public static Contact GetByEmail(CRMDataContext dataContext, string contactEmailAddress)
        {
            return (from entity in dataContext.ContactSet
                    where entity.EMailAddress1.Equals(contactEmailAddress, StringComparison.OrdinalIgnoreCase)
                    where entity.StateCode.Value == (int)contact_statecode.Active
                    select entity).FirstOrDefault();
        }

        public static bool IsContactInTheSystem(CRMDataContext dataContext, string contactEmailAddress)
        {
            IEnumerable<Guid> contactExist = (from entity in dataContext.ContactSet
                                              where entity.EMailAddress1.Equals(contactEmailAddress, StringComparison.OrdinalIgnoreCase)
                                              where entity.StateCode.Value == (int)contact_statecode.Active
                                              select entity.Id);

            return (contactExist.Any());
        }
    }
}
