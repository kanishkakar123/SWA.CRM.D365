namespace SWA.CRM.D365.Common.Model
{
    public enum CaseType 
    {
        Enquiry,
        Complaint
    }

    public enum ServiceCategory 
    {
        SMSService,
        Survey, 
        IVR,
        ATIT, 
        OAuthService
    }

    public enum AuthorizationType 
    {
        AuthToken, 
        AppKey 
    }

    public enum RequestMethod 
    {
        GET, 
        POST
    }
}
