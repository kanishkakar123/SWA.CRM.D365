using System;

namespace SWA.CRM.D365.Common.Model
{
    public abstract class ModelBase
    {
        public ModelBase() { }

        public ModelBase(Guid transactionId, string sourceSystem)
        {
            TransactionId = transactionId;
            SourceSystem = sourceSystem;
        }

        public Guid TransactionId { get; set; }

        public string SourceSystem { get; set; }
    }
}
