namespace SWA.CRM.D365.Common.Model
{
    public struct SMSServiceConfig
    {
        public string SMSEndpoint { get; set; } ///SMSGateway/Api/smssender/SendSms
        public string AppKey { get; set; } // 6B59BB27-38B5-44D3-AFE0-************
    }

    public struct OAuthServiceConfig
    {
        public static string apiKey => "";

        public static string apiSecret => "";

        public static string BaseTokenUrl => "";

        public static string GetRequestUrl => "";

        public static string PostRequestUrl => "";
    }
}
