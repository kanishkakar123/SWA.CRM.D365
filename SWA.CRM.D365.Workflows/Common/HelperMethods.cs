using Microsoft.Xrm.Sdk;
using System;

namespace SWA.CRM.D365.Workflows
{
    public static  class HelperMethods
    {
        public static void LogWorkflowError(string workflowName, Exception ex, ITracingService logger)
        {
            logger.Trace($"Error processing {workflowName} : {ex.Message}{Environment.NewLine}StackTrace : {ex.StackTrace}");

            if (ex.InnerException != null)
            {
                logger.Trace($"Inner Exception : {ex.InnerException.Message}{Environment.NewLine}StackTrace : {ex.InnerException.StackTrace}");
            }
        }
    }
}
