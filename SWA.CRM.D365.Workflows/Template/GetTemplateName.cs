using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using SWA.CRM.D365.Common.Helpers;
using SWA.CRM.D365.Entities.Base;
using System;
using System.Activities;

namespace SWA.CRM.D365.Workflows
{
    public class GetTemplateName : WorkFlowActivityBase
    {
        [Input("CaseType")]
        [RequiredArgument]
        [ReferenceTarget(swa_casetype.EntityLogicalName)]
        public InArgument<EntityReference> CaseType { get; set; }

        [Input("Event")]
        [RequiredArgument]
        public InArgument<string> Event { get; set; }

        [Output("BaseTemplateName")]
        public OutArgument<string> BaseTemplateName { get; set; }

        public GetTemplateName() : base(typeof(GetTemplateName))
        {
        }


        public override void ExecuteCRMWorkFlowActivity(CodeActivityContext executionContext, LocalWorkflowContext crmWorkflowContext)
        {
            ITracingService logger = crmWorkflowContext.TracingService;

            logger.Trace("Start workflow GetTemplateName");
            string baseTemplateName = string.Empty;

            try
            {
                string caseType = CaseType.Get(executionContext).Name;
                string eventName = Event.Get(executionContext);

                logger.Trace($"Case Type : {caseType}");
                logger.Trace($"Event : {eventName}");

                switch (caseType)
                {
                    case nameof(Common.Model.CaseType.Enquiry):
                        baseTemplateName = GetEnquiryTemplates(eventName);
                        break;

                    case nameof(Common.Model.CaseType.Complaint):
                        baseTemplateName = GetComplaintTemplates(eventName);
                        break;
                }

                logger.Trace($"Base Template Name : {baseTemplateName}");
                BaseTemplateName.Set(executionContext, baseTemplateName);                
            }
            catch (Exception ex)
            {
                HelperMethods.LogWorkflowError("GetTemplateName", ex, logger);
            }

            logger.Trace("End workflow GetTemplateName");
        }

        private string GetEnquiryTemplates(string eventName)
        {
            string enquiryTemplate = string.Empty;

            switch (eventName)
            {
                case "Create":
                    enquiryTemplate = Constants.CustomerEnquiryCreate;
                    break;

                case "Update":
                    enquiryTemplate = Constants.CustomerEnquiryUpdate;
                    break;

                case "Resolve":
                    enquiryTemplate = Constants.CustomerEnquiryResolve;
                    break;

                case "Assign":
                    enquiryTemplate = Constants.OwnerCaseAssignment;
                    break;

                case "TaskCreate":
                    enquiryTemplate = Constants.OwnerTaskAssignment;
                    break;
            }

            return enquiryTemplate;
        }

        private string GetComplaintTemplates(string eventName)
        {
            string complaintTemplate = string.Empty;

            switch (eventName)
            {
                case "Create":
                    complaintTemplate = Constants.CustomerComplaintCreate;
                    break;

                case "Update":
                    complaintTemplate = Constants.CustomerComplaintUpdate;
                    break;

                case "Resolve":
                    complaintTemplate = Constants.CustomerComplaintResolve;
                    break;

                case "Assign":
                    complaintTemplate = Constants.OwnerCaseAssignment;
                    break;

                case "TaskCreate":
                    complaintTemplate = Constants.OwnerTaskAssignment;
                    break;
            }

            return complaintTemplate;
        }
    }
}
