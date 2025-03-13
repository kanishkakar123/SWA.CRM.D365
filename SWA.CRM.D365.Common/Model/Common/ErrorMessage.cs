namespace SWA.CRM.D365.Common.Model
{
    public class Details
    {
    }

    public class Error
    {
        public string code { get; set; }
        public string message { get; set; }
        public Details details { get; set; }
    }

    public class ErrorMessage
    {
        public bool success { get; set; }
        public Error error { get; set; }
    }
}
