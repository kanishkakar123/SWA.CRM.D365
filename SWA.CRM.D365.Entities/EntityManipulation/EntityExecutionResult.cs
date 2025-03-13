using System;

namespace SWA.CRM.D365.Entities.Base
{
    public class EntityExecutionResult
    {
        public enum StatusTypes
        {
            Success,
            Error
        }

        public StatusTypes Status { get; set; }

        public EntityManipulationBase EntityManipulation { get; set; }

        public Exception Exception { get; set; }
    }
}
