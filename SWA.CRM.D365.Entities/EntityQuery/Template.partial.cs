using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.CRM.D365.Entities.Base
{
    public partial class Template
    {
        public static Template GetById(CRMDataContext dataContext, Guid id)
        {
            return (from entity in dataContext.TemplateSet
                    where entity.Id.Equals(id)
                    select entity).FirstOrDefault();
        }

        public static Template GetByName(CRMDataContext dataContext, string templateName)
        {
            return (from entity in dataContext.TemplateSet
                    where entity.Title.Equals(templateName)
                    select entity).FirstOrDefault();
        }
    }
}

