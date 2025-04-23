namespace SWA.CRM.D365.Plugins
{
    public static class Constants
    {
        #region [Plugin Error Messages/Codes]

        public const int OpenTaskValidationErrorCode = 1001;
        public const string OpenTaskValidationErrorMessage = "There are existing open tasks for this case. Please ensure all open tasks are completed before creating new ones.";

        #endregion
    }
}
