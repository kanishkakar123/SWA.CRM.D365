﻿namespace SWA.CRM.D365.Common.Model
{
    public class AccessToken
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
        public string error { get; set; }
        public string error_description { get; set; }
    }
}
