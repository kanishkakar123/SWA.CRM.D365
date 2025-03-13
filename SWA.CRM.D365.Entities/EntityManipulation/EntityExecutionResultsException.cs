using System;
using System.Collections.Generic;

namespace SWA.CRM.D365.Entities.Base
{
    public class EntityExecutionResultsException : Exception
    {
        private List<Exception> exceptions = new List<Exception>();

        public EntityExecutionResultsException(string message, EntityExecutionResultCollection results) : base(message)
        {
            foreach (var item in results.Results)
            {
                if (item.Exception != null)
                {
                    exceptions.Add(item.Exception);
                }
            }
        }

        public IEnumerable<Exception> Exceptions
        {
            get { return exceptions; }
        }
    }
}
