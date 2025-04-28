namespace SWA.CRM.D365.Common.Helpers
{
    public static class Constants
    {
        #region [Configuration Keys]

        public const string ConfigSmsApiUrl = "SmsApiUrl";
        public const string ConfigOrganizationUrl = "OrganizationUrl";

        #endregion

        #region [Templates]

        public const string CustomerEnquiryCreate = "Customer_EnquiryCreate";
        public const string CustomerEnquiryUpdate = "Customer_EnquiryUpdate";
        public const string CustomerEnquiryResolve = "Customer_EnquiryResolve";
        public const string CustomerComplaintCreate = "Customer_ComplaintCreate";
        public const string CustomerComplaintUpdate = "Customer_ComplaintUpdate";
        public const string CustomerComplaintResolve = "Customer_ComplaintResolve";
        public const string OwnerCaseAssignment = "Owner_CaseAssignment";
        public const string OwnerTaskAssignment = "Owner_TaskAssignment";

        #endregion
    }
}
