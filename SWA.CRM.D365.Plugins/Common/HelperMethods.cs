using Microsoft.Xrm.Sdk;
using System;

namespace SWA.CRM.D365.Plugins
{
    public static class HelperMethods
    {
        public static void LogPluginError(string plugin, Exception ex, ITracingService logger)
        {
            logger.Trace($"Error processing {plugin} : {ex.Message}{Environment.NewLine}StackTrace : {ex.StackTrace}");

            if (ex.InnerException != null)
            {
                logger.Trace($"Inner Exception : {ex.InnerException.Message}{Environment.NewLine}StackTrace : {ex.InnerException.StackTrace}");
            }
        }
    }
}
