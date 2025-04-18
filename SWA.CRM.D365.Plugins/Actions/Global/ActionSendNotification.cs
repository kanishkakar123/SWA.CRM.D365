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
            CreateEntityManipulation createEntityManipulation;

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

                logger.Trace("Input Parameters:");
                logger.Trace($"baseTemplateName: {baseTemplateName}");
                logger.Trace($"regardingEntityId: {regardingEntityId}");
                logger.Trace($"regardingEntityLogicalName: {regardingEntityLogicalName}");
                logger.Trace($"toEntityId: {toEntityId}");
                logger.Trace($"toEntityLogicalName: {toEntityLogicalName}");
                logger.Trace($"sendEmail: {sendEmail}");
                logger.Trace($"fromUser: {fromUser.Id}");
                logger.Trace($"sendSMS: {sendSMS}");

                if (sendEmail)
                {
                    Template emailTemplate;
                    Email emailEntity;
                    Guid emailId;
                    SendEmailRequest sendEmailRequest;
                    SendEmailResponse sendEmailResponse;

                    try
                    {
                        logger.Trace("Start email sending process");

                        // Get Email from Template
                        logger.Trace($"Fetching email template: EMAIL-{baseTemplateName}");
                        emailTemplate = Template.GetByName(dataContext, "EMAIL-" + baseTemplateName);

                        if (emailTemplate != null)
                        {
                            // Map and Create Email 
                            logger.Trace("Creating email record based on template");
                            emailEntity = NotificationHelper.GetEmailFromTemplate(emailTemplate, regardingEntityId, regardingEntityLogicalName, service);

                            if (emailEntity != null)
                            {
                                emailEntity = NotificationHelper.MapEmail(emailEntity, toEntity, regardingEntity, fromUser);

                                createEntityManipulation = new CreateEntityManipulation(emailEntity);
                                emailId = createEntityManipulation.Create(service);
                                logger.Trace($"Email record created : {emailId}");

                                // Send Email
                                //logger.Trace("Sending email");
                                //sendEmailRequest = new SendEmailRequest()
                                //{
                                //    EmailId = emailId,
                                //    //TrackingToken = "",
                                //    IssueSend = true
                                //};

                                //sendEmailResponse = (SendEmailResponse)service.Execute(sendEmailRequest);

                                //if (sendEmailResponse != null)
                                //{
                                //    emailStatus = true;
                                //    logger.Trace("Email sent successfully");
                                //}
                                //else
                                //{
                                //    emailStatus = false;
                                //    logger.Trace("Error sending email");
                                //}
                            }
                        }
                        else
                        {
                            logger.Trace($"Email template not found: EMAIL-{baseTemplateName}");
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Trace($"Error sending email: {ex.Message}");
                    }
                }

                if (sendSMS)
                {
                    Template smsTemplate;
                    Email emailEntity;
                    swa_sms smsEntity;
                    Guid smsId;
                    SMSServiceRequest smsServiceRequest;
                    SMSService smsService;
                    SMSServiceResponse smsServiceResponse;

                    try
                    {
                        logger.Trace("Start SMS sending process");

                        // Get SMS from Template
                        logger.Trace($"Fetching Email Template: SMS-{baseTemplateName}");
                        smsTemplate = Template.GetByName(dataContext, "SMS-" + baseTemplateName);

                        if (smsTemplate != null)
                        {
                            // Map and Create Email 
                            logger.Trace("Creating Email record based on template");
                            emailEntity = NotificationHelper.GetEmailFromTemplate(smsTemplate, regardingEntityId, regardingEntityLogicalName, service);

                            if (emailEntity != null)
                            {
                                // Map and Create SMS
                                logger.Trace("Creating SMS record based on template");
                                smsEntity = new swa_sms();
                                string subject = emailEntity.Subject;
                                string message = emailEntity.Description;
                                string mobileNumber = NotificationHelper.GetMobileNumber(toEntityLogicalName, toEntityId, service);
                                NotificationHelper.MapSMS(smsEntity, subject, message, toEntity, regardingEntity);

                                createEntityManipulation = new CreateEntityManipulation(smsEntity);
                                smsId = createEntityManipulation.Create(service);
                                logger.Trace($"SMS record created : {smsId}");

                                // Send SMS
                                //logger.Trace("Sending SMS");
                                //smsServiceRequest = new SMSServiceRequest()
                                //{
                                //    Message = message,
                                //    MobileNumber = mobileNumber
                                //};

                                //smsService = new SMSService(service);
                                //smsServiceResponse = smsService.SendSMS(smsServiceRequest);

                                //if (smsServiceResponse != null && smsServiceResponse.Success)
                                //{
                                //    // Need SMS response model
                                //    smsStatus = true;
                                //    logger.Trace("SMS sent successfully");
                                //}
                                //else
                                //{
                                //    smsStatus = false;
                                //    logger.Trace("Error sending SMS");
                                //}

                                smsStatus = true;
                            }
                        }
                        else
                        {
                            logger.Trace($"Email template not found: EMAIL-{baseTemplateName}");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
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
