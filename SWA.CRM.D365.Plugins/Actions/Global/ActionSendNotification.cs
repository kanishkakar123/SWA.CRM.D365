using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using SWA.CRM.D365.Common.Helpers;
using SWA.CRM.D365.Common.Model;
using SWA.CRM.D365.Common.Services;
using SWA.CRM.D365.Entities.Base;
using System;

namespace SWA.CRM.D365.Plugins
{
    public class ActionSendNotification : PluginBase
    {
        public ActionSendNotification() : base(typeof(ActionSendNotification))
        {
            // Implement your custom configuration handling.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionSendNotification"/> class.
        /// </summary>
        /// <param name="unsecure">Contains public (unsecured) configuration information.</param>
        /// <param name="secure">Contains non-public (secured) configuration information. 
        /// When using Microsoft Dynamics 365 for Outlook with Offline Access, 
        /// the secure string is not passed to a plug-in that executes while the client is offline.</param>
        public ActionSendNotification(string unsecure, string secure) : base(typeof(DemoPlugin))
        {
            // Implement your custom configuration handling.
        }


        /// <summary>
        /// Main entry point for he business logic that the plug-in is to execute.
        /// </summary>
        /// <param name="localContext">The <see cref="LocalPluginContext"/> which contains the
        /// <see cref="IPluginExecutionContext"/>,
        /// <see cref="IOrganizationService"/>
        /// and <see cref="ITracingService"/>
        /// </param>
        /// <remarks>
        /// For improved performance, Microsoft Dynamics 365 caches plug-in instances.
        /// The plug-in's Execute method should be written to be stateless as the constructor
        /// is not called for every invocation of the plug-in. Also, multiple system threads
        /// could execute the plug-in at the same time. All per invocation state information
        /// is stored in the context. This means that you should not use global variables in plug-ins.
        /// </remarks>
        protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
        {
            if (localContext == null) { throw new InvalidPluginExecutionException("localContext"); }

            IOrganizationService service = localContext.OrganizationService;
            IPluginExecutionContext context = localContext.PluginExecutionContext;
            ITracingService logger = localContext.TracingService;
            CRMDataContext dataContext = localContext.DataContext;

            bool emailStatus = false, smsStatus = false;

            logger.Trace("Start ActionSendNotification");

            try
            {
                // Retrieve Input Parameters
                string baseTemplateName = (string)context.InputParameters["BaseTemplateName"];
                Guid regardingEntityId = new Guid((string)context.InputParameters["RegardingEntityId"]);
                string regardingEntityLogicalName = (string)context.InputParameters["RegardingEntityLogicalName"];
                Guid toEntityId = new Guid((string)context.InputParameters["ToEntityId"]);
                string toEntityLogicalName = (string)context.InputParameters["ToEntityLogicalName"];
                bool sendEmail = (bool)context.InputParameters["SendEmail"];
                bool sendSMS = (bool)context.InputParameters["SendSMS"];
                EntityReference fromUser = sendEmail ? (EntityReference)context.InputParameters["FromUser"] : null;
                EntityReference toEntity = new EntityReference(toEntityLogicalName, toEntityId);
                EntityReference regardingEntity = new EntityReference(regardingEntityLogicalName, regardingEntityId);

                if (sendEmail)
                {
                    // Get Email from Template
                    Template emailTemplate = Template.GetByName(dataContext, "EMAIL-" + baseTemplateName);
                    Email emailEntity = NotificationHelper.GetEmailFromTemplate(emailTemplate, regardingEntityId, regardingEntityLogicalName, service);

                    // Map and Create Email                 
                    emailEntity = NotificationHelper.MapEmail(emailEntity, toEntity, regardingEntity, fromUser);
                    Guid emailId = service.Create(emailEntity);

                    // Send Email
                    SendEmailRequest sendEmailRequest = new SendEmailRequest()
                    {
                        EmailId = emailId,
                        TrackingToken = "",
                        IssueSend = true
                    };

                    SendEmailResponse sendEmailResponse = (SendEmailResponse)service.Execute(sendEmailRequest);
                }

                if (sendSMS)
                {
                    // Get SMS from Template
                    Template smsTemplate = Template.GetByName(dataContext, "SMS-" + baseTemplateName);
                    Email emailEntity = NotificationHelper.GetEmailFromTemplate(smsTemplate, regardingEntityId, regardingEntityLogicalName, service);

                    // Map and Create SMS
                    Entity smsEntity = new Entity("swa_sms");
                    string message = emailEntity.Description;
                    string mobileNumber = NotificationHelper.GetMobileNumber(toEntityLogicalName, toEntityId, service);
                    smsEntity = NotificationHelper.MapSMS(smsEntity, message, mobileNumber, toEntity, regardingEntity);
                    Guid smsId = service.Create(smsEntity);

                    // Send SMS
                    SMSServiceRequest smsServiceRequest = new SMSServiceRequest() 
                    {
                        Message = message,
                        MobileNumber = mobileNumber
                    };

                    SMSService smsService = new SMSService(service);
                    SMSServiceResponse smsServiceResponse = smsService.SendSMS(smsServiceRequest);
                }
            }
            catch (Exception ex)
            {
                logger.Trace($"Error processing ActionSendNotification : {ex.Message}{Environment.NewLine}StackTrace : {ex.StackTrace}");

                if (ex.InnerException != null)
                {
                    logger.Trace($"Inner Exception : {ex.InnerException.Message}{Environment.NewLine}StackTrace : {ex.InnerException.StackTrace}");
                }
            }

            // Set Output Parameters
            context.OutputParameters["EmailStatus"] = emailStatus;
            context.OutputParameters["SMSStatus"] = smsStatus;

            logger.Trace("End ActionSendNotification");
        }
    }
}
