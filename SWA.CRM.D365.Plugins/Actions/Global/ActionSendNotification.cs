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
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionSendNotification"/> class.
        /// </summary>
        public ActionSendNotification() : base(typeof(ActionSendNotification))
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
                logger.Trace("Retrieving Input Parameters");
                string baseTemplateName = (string)context.InputParameters["BaseTemplateName"];
                string regardingEntityURL = (string)context.InputParameters["RegardingEntityURL"];
                EntityReference regardingEntity = new DynamicUrlParser(regardingEntityURL).ToEntityReference(service);
                //EntityReference regardingEntity = new EntityReference("incident", new DynamicUrlParser(regardingEntityURL).Id);
                string toEntityURL = (string)context.InputParameters["ToEntityURL"];
                EntityReference toEntity = new DynamicUrlParser(toEntityURL).ToEntityReference(service);
                //EntityReference toEntity = new EntityReference("contact", new DynamicUrlParser(toEntityURL).Id);
                bool sendEmail = (bool)context.InputParameters["SendEmail"];
                bool sendSMS = (bool)context.InputParameters["SendSMS"];
                EntityReference fromUser = sendEmail ? (EntityReference)context.InputParameters["FromUser"] : null;

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
                        logger.Trace($"Email To : {toEntity.LogicalName} ({toEntity.Id})");

                        // If email to is team then send email to default queue of the team
                        if (toEntity.LogicalName == Team.EntityLogicalName)
                        {
                            logger.Trace("Get default queue of team");
                            Queue defaultQueue = Queue.GetByTeam(dataContext, toEntity.Id);

                            if (defaultQueue != null)
                            { 
                                toEntity = defaultQueue.ToEntityReference();
                                logger.Trace("Send email to default queue of team");
                            }
                        }

                        logger.Trace($"Get email address of {toEntity.LogicalName} ({toEntity.Id})");
                        string emailAddress = NotificationHelper.GetEmailAddress(toEntity, service);

                        if (!string.IsNullOrEmpty(emailAddress))
                        {
                            logger.Trace($"Email address : {emailAddress}");

                            // Get Email from Template
                            logger.Trace($"Fetching Template: Email_{baseTemplateName}");
                            emailTemplate = Template.GetByName(dataContext, "Email_" + baseTemplateName);
                            //emailTemplate = Template.GetByName(service, "Email_" + baseTemplateName).ToEntity<Template>();

                            if (emailTemplate != null)
                            {
                                // Map and Create Email 
                                logger.Trace("Creating email record based on template");
                                emailEntity = NotificationHelper.GetEmailFromTemplate(emailTemplate, regardingEntity, service);

                                if (emailEntity != null)
                                {
                                    emailEntity = NotificationHelper.MapEmail(emailEntity, toEntity, regardingEntity, fromUser);

                                    createEntityManipulation = new CreateEntityManipulation(emailEntity);
                                    emailId = createEntityManipulation.Create(service);
                                    logger.Trace($"Email record created : {emailId}");

                                    // Send Email
                                    logger.Trace("Sending email");
                                    sendEmailRequest = new SendEmailRequest()
                                    {
                                        EmailId = emailId,
                                        //TrackingToken = "",
                                        IssueSend = true
                                    };

                                    sendEmailResponse = (SendEmailResponse)service.Execute(sendEmailRequest);

                                    if (sendEmailResponse != null)
                                    {
                                        emailStatus = true;
                                        logger.Trace("Email sent successfully");
                                    }
                                    else
                                    {
                                        emailStatus = false;
                                        logger.Trace("Error sending email");
                                    }
                                }
                            }
                            else
                            {
                                logger.Trace($"Template not found: Email_{baseTemplateName}");
                            }
                        }
                        else
                        {
                            logger.Trace($"Email address not set for {toEntity.LogicalName} ({toEntity.Id})");
                        }
                    }
                    catch (Exception ex)
                    {
                        HelperMethods.LogPluginError("ActionSendNotification", ex, logger);
                    }
                }

                if (toEntity.LogicalName != Queue.EntityLogicalName && sendSMS)
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
                        logger.Trace($"Get mobile number of {toEntity.LogicalName} ({toEntity.Id})");

                        string mobileNumber = NotificationHelper.GetMobileNumber(toEntity, service);

                        if (!string.IsNullOrEmpty(mobileNumber))
                        {
                            logger.Trace($"Mobile number : {mobileNumber}");

                            // Get SMS from Template
                            logger.Trace($"Fetching Template: SMS_{baseTemplateName}");
                            smsTemplate = Template.GetByName(dataContext, "SMS_" + baseTemplateName);
                            //smsTemplate = Template.GetByName(service, "SMS_" + baseTemplateName).ToEntity<Template>();

                            if (smsTemplate != null)
                            {
                                // Map and Create Email 
                                logger.Trace("Creating Email record based on template");
                                emailEntity = NotificationHelper.GetEmailFromTemplate(smsTemplate, regardingEntity, service);

                                if (emailEntity != null)
                                {
                                    // Map and Create SMS
                                    logger.Trace("Creating SMS record based on template");
                                    smsEntity = new swa_sms();
                                    string subject = emailEntity.Subject;
                                    string message = Common.Helpers.HelperMethods.UseHtmlDecode(emailEntity.Description);

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

                                    // Code to update SMS activity with service response

                                    smsStatus = true;
                                }
                            }
                            else
                            {
                                logger.Trace($"Template not found: SMS_{baseTemplateName}");
                            }
                        }
                        else
                        {
                            logger.Trace($"Mobile number not set for {toEntity.LogicalName} ({toEntity.Id})");
                        }
                    }
                    catch (Exception ex)
                    {
                        HelperMethods.LogPluginError("ActionSendNotification", ex, logger);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperMethods.LogPluginError("ActionSendNotification", ex, logger);
            }

            // Set Output Parameters
            context.OutputParameters["EmailStatus"] = emailStatus;
            context.OutputParameters["SMSStatus"] = smsStatus;

            logger.Trace("End ActionSendNotification");
        }
    }
}
