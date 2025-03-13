using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.CRM.D365.Entities.Base
{
    public class EntityManipulationExecutionException : Exception
    {
        public EntityManipulationBase EntityManipulation { get; private set; }

        public EntityManipulationExecutionException(EntityManipulationBase manipulation, Exception exception) : base("An error happened when executing a manipulation. See inner exception for details.", exception)
        {
            EntityManipulation = manipulation;
        }
    }
}
