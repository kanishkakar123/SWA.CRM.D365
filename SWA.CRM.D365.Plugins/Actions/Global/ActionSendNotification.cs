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
        /// Main entry point for the business logic that the plug-in is to execute.
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
            string taskOwnerName = string.Empty, resolutionRemarks = string.Empty;

            bool emailStatus = false, smsStatus = false;

            logger.Trace("Start ActionSendNotification");

            try
            {
                // Retrieve Input Parameters
                logger.Trace("Retrieving Input Parameters");
                string baseTemplateName = (string)context.InputParameters["BaseTemplateName"];
                string regardingEntityURL = (string)context.InputParameters["RegardingEntityURL"];
                EntityReference regardingEntity = new DynamicUrlParser(regardingEntityURL).ToEntityReference(service);
                string toEntityURL = (string)context.InputParameters["ToEntityURL"];
                EntityReference toEntity = new DynamicUrlParser(toEntityURL).ToEntityReference(service);
                bool sendEmail = (bool)context.InputParameters["SendEmail"];
                bool sendSMS = (bool)context.InputParameters["SendSMS"];
                EntityReference fromQueue = sendEmail ? (EntityReference)context.InputParameters["FromQueue"] : null;
                string recordURL = context.InputParameters.Contains("RecordURL") ? (string)context.InputParameters["RecordURL"] : string.Empty;

                // If email to parameter is team then send email to default queue of the team
                if (toEntity.LogicalName == Team.EntityLogicalName)
                {
                    sendEmail = false;
                    logger.Trace("Get default queue of team");
                    Queue defaultQueue = Queue.GetByTeam(dataContext, toEntity.Id);

                    if (defaultQueue != null)
                    {
                        toEntity = defaultQueue.ToEntityReference();
                        logger.Trace("Email recipient is default queue of team");
                    }
                    else
                    {
                        logger.Trace("Default queue of team is not set");
                        sendEmail = false;
                    }
                }

                // If email to parameter is account then send email to primary contact of the account
                if (toEntity.LogicalName == Account.EntityLogicalName)
                {
                    logger.Trace("Get primary contact of customer");
                    EntityReference primaryContact =  Account.GetById(dataContext, toEntity.Id).PrimaryContactId;                    

                    if (toEntity != null)
                    {
                        toEntity = primaryContact;
                        logger.Trace("Email recipient is primary contact of customer");
                    }
                    else 
                    {
                        logger.Trace("Primary Contact of customer is not set");
                        sendEmail = false;
                        sendSMS = false;
                    }
                }

                // If regarding parameter is task set email regarding as the case related to the task
                // Get task owner name to add to email body for task creation notification
                if (regardingEntity.LogicalName == Task.EntityLogicalName)
                {
                    logger.Trace("Get task record");
                    Task taskRecord = Task.GetById(dataContext, regardingEntity.Id);

                    if (taskRecord != null &&
                        taskRecord.RegardingObjectId != null &&
                        taskRecord.RegardingObjectId.LogicalName == Incident.EntityLogicalName &&
                        taskRecord.OwnerId != null)
                    {
                        taskOwnerName = taskRecord.OwnerIdName;
                        logger.Trace($"Task Owner : {taskOwnerName}");
                        regardingEntity = Incident.GetById(dataContext, taskRecord.RegardingObjectId.Id).ToEntityReference();
                    }
                }

                // Add Resolution Remarks to email body for case resolution
                if (regardingEntity.LogicalName == Incident.EntityLogicalName && baseTemplateName.EndsWith("Resolve"))
                {
                    logger.Trace("Get Incident record to check id status is resolved");
                    Incident caseRecord = Incident.GetById(dataContext, regardingEntity.Id);

                    if (caseRecord != null && caseRecord.StateCode == incident_statecode.Resolved)
                    {
                        logger.Trace("Get Incident Resolution record");
                        IncidentResolution incidentResolution = IncidentResolution.GetByCase(dataContext, regardingEntity.Id);

                        if (incidentResolution != null && !string.IsNullOrEmpty(incidentResolution.Subject))
                        {
                            logger.Trace($"Incident Resolution id : {incidentResolution.Id}");
                            resolutionRemarks = incidentResolution.Subject;                           
                        }
                    }
                }


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

                        logger.Trace($"Get email address of {toEntity.LogicalName} ({toEntity.Id})");
                        string emailAddress = NotificationHelper.GetEmailAddress(toEntity, service);

                        if (!string.IsNullOrEmpty(emailAddress))
                        {
                            logger.Trace($"Email address : {emailAddress}");

                            // Get Email from Template
                            logger.Trace($"Fetching Template: Email_{baseTemplateName}");
                            emailTemplate = Template.GetByName(dataContext, "Email_" + baseTemplateName);

                            if (emailTemplate != null)
                            {
                                // Map and Create Email 
                                logger.Trace("Creating email record based on template");
                                emailEntity = NotificationHelper.GetEmailFromTemplate(emailTemplate, regardingEntity, service);

                                if (emailEntity != null)
                                {
                                    if (!string.IsNullOrEmpty(resolutionRemarks))
                                    {
                                        emailEntity.Description = emailEntity.Description.Replace("{ResolutionRemarks}", resolutionRemarks);
                                    }

                                    if (!string.IsNullOrEmpty(taskOwnerName))
                                    {
                                        emailEntity.Description = emailEntity.Description.Replace("{TaskOwner}", taskOwnerName);
                                    }

                                    if (!string.IsNullOrEmpty(recordURL))
                                    {
                                        logger.Trace($"Record URL : {recordURL}");
                                        string orgURL = swa_configuration.GetByName(dataContext, Common.Helpers.Constants.ConfigOrganizationUrl).swa_value;
                                        recordURL = "https://" + orgURL + "/main.aspx" + recordURL.Substring(recordURL.IndexOf("?"));
                                        emailEntity.Description = emailEntity.Description.Replace("{RecordURL}", recordURL);
                                    }

                                    emailEntity = NotificationHelper.MapEmail(emailEntity, toEntity, regardingEntity, fromQueue);
                                    createEntityManipulation = new CreateEntityManipulation(emailEntity);
                                    emailId = createEntityManipulation.Create(service);
                                    logger.Trace($"Email record created : {emailId}");

                                    // Send Email
                                    logger.Trace("Sending email");
                                    sendEmailRequest = new SendEmailRequest()
                                    {
                                        EmailId = emailId,
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
                                else
                                {
                                    logger.Trace("Unable to get email from template");
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
                        logger.Trace($"Get mobile number of {toEntity.LogicalName} ({toEntity.Id})");

                        string mobileNumber = NotificationHelper.GetMobileNumber(toEntity, service);

                        if (!string.IsNullOrEmpty(mobileNumber))
                        {
                            logger.Trace($"Mobile number : {mobileNumber}");

                            // Get SMS from Template
                            logger.Trace($"Fetching Template: SMS_{baseTemplateName}");
                            smsTemplate = Template.GetByName(dataContext, "SMS_" + baseTemplateName);

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

                                    if (!string.IsNullOrEmpty(taskOwnerName))
                                    {
                                        emailEntity.Description = message = message.Replace("{TaskOwner}", taskOwnerName);
                                    }

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
                                else
                                {
                                    logger.Trace($"Unable to get email from template");
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
