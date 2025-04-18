using System;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class swa_configuration 
    {
		public static swa_configuration GetById(CRMDataContext dataContext, Guid id)
		{
			return (from entity in dataContext.swa_configurationSet
					where entity.Id == id
					select entity).FirstOrDefault();
		}

		public static swa_configuration GetByName(CRMDataContext dataContext, string configName)
		{
			return (from entity in dataContext.swa_configurationSet
					where entity.swa_name.Equals(configName)
					where entity.StateCode.Value == (int)swa_configuration_statecode.Active
					select entity).FirstOrDefault();
		}
	}
}
