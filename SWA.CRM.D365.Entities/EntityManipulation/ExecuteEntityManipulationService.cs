using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWA.CRM.D365.Entities.Base
{
    public static class ExecuteEntityManipulationService
    {
        public static EntityExecutionResultCollection Execute(IOrganizationService organizationService, EntityManipulationCollection entityManipulationCollection)
        {
            var results = new EntityExecutionResultCollection();
            foreach (EntityManipulationBase manipulationBase in entityManipulationCollection.Items)
            {
                var result = new EntityExecutionResult()
                {
                    EntityManipulation = manipulationBase
                };

                if (manipulationBase != null)
                {
                    try
                    {
                        manipulationBase.Execute(organizationService);
                        result.Status = EntityExecutionResult.StatusTypes.Success;
                    }
                    catch (Exception ex)
                    {
                        result.Exception = new EntityManipulationExecutionException(manipulationBase, ex);
                        result.Status = EntityExecutionResult.StatusTypes.Error;
                    }
                }

                results.Add(result);
            }

            return results;
        }
    }
}
