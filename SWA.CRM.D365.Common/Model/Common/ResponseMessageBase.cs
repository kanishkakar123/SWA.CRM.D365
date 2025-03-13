using System;

namespace SWA.CRM.D365.Common.Model
{
    public class ResponseMessageBase : ModelBase
    {
        public ResponseMessageBase() { }

        public ResponseMessageBase(Guid transactionId, string sourceSystem) : base(transactionId, sourceSystem) { }

        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public ErrorMessage Error{ get; set; }
    }
}
