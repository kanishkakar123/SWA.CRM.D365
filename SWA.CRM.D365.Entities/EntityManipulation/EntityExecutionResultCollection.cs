using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Entities.Base
{
    public class EntityExecutionResultCollection
    {
        private List<EntityExecutionResult> results = new List<EntityExecutionResult>();

        public void Add(EntityExecutionResult result)
        {
            results.Add(result);
        }

        public IEnumerable<EntityExecutionResult> Results => results;

        public bool HasErrors => results.Any(x => x.Status == EntityExecutionResult.StatusTypes.Error);

        public EntityExecutionResultsException Exception
        {
            get
            {
                if (HasErrors)
                {
                    return new EntityExecutionResultsException("An error occured when executing this entity manipulation collection. See the results for more detail", this);
                }

                return null;
            }
        }
    }
}
