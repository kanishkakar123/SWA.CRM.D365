using Microsoft.Xrm.Sdk;
using SWA.CRM.D365.Common.Helpers;
using SWA.CRM.D365.Common.Model;
using SWA.CRM.D365.Common.Services;
using SWA.CRM.D365.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SWA.CRM.D365.Plugins
{
    public class ActionSendSMS : PluginBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionSendSMS"/> class.
        /// </summary>
        public ActionSendSMS() : base(typeof(ActionSendSMS))
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

            SMSServiceRequest smsServiceRequest;
            SMSService smsService;
            SMSServiceResponse smsServiceResponse;

            bool smsStatus = false;

            logger.Trace("Start ActionSendSMS");

            try
            {
                // Retrieve Input Parameters
                logger.Trace("Retrieving Input Parameters");
                EntityReference smsRef = (EntityReference)context.InputParameters["SMS"];

                if (smsRef != null)
                {
                    logger.Trace($"Retrieving SMS Id : {smsRef.Id}");
                    swa_sms smsRecord = swa_sms.GetById(dataContext, smsRef.Id);

                    if (smsRecord != null && smsRecord.To != null)
                    {
                        logger.Trace("Get SMS recipient");
                        IEnumerable<ActivityParty> activityPartyList = smsRecord.To;
                        ActivityParty recipientParty = activityPartyList.FirstOrDefault();                       

                        if (recipientParty != null)
                        {
                            EntityReference smsRecipient = new EntityReference(recipientParty.PartyId.LogicalName, recipientParty.PartyId.Id);
                            logger.Trace($"SMS recipient : {smsRecipient.LogicalName} ({smsRecipient.Id})");

                            logger.Trace("Get mobile number of recipient");
                            string mobileNumber = NotificationHelper.GetMobileNumber(smsRecipient, service);

                            if (!string.IsNullOrEmpty(mobileNumber) && !string.IsNullOrEmpty(smsRecord.Description))
                            {
                                // Send SMS
                                logger.Trace($"Sending SMS to {mobileNumber}");
                                //smsServiceRequest = new SMSServiceRequest()
                                //{
                                //    Message = smsRecord.Description,
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
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HelperMethods.LogPluginError("ActionSendSMS", ex, logger);
            }

            // Set Output Parameters
            context.OutputParameters["SMSStatus"] = smsStatus;

            logger.Trace("End ActionSendSMS");
        }
    }
}
