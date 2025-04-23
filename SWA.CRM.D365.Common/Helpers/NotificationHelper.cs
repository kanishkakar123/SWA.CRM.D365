using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using SWA.CRM.D365.Entities.Base;
using System.Collections;
using System.Linq;

namespace SWA.CRM.D365.Common.Helpers
{
    public static class NotificationHelper
    {
        public static Email GetEmailFromTemplate(Template templateEntity, EntityReference entityReference, IOrganizationService service)
        {
            Email emailEntity = null;

            // Retrieve email template from   
            if (templateEntity != null && entityReference != null)
            {
                InstantiateTemplateRequest templateRequest = new InstantiateTemplateRequest
                {
                    TemplateId = templateEntity.TemplateId.Value,
                    ObjectId = entityReference.Id,
                    ObjectType = entityReference.LogicalName
                };

                InstantiateTemplateResponse templateResponse = (InstantiateTemplateResponse)service.Execute(templateRequest);

                if (templateResponse != null && templateResponse.EntityCollection.Entities.Any())
                {
                    emailEntity = (Email)templateResponse.EntityCollection.Entities.FirstOrDefault();
                }
            }

            return emailEntity;
        }

        public static Email MapEmail(Email emailEntity, EntityReference toEntity, EntityReference regardingEntity, EntityReference systemUserEntity)
        {
            emailEntity.To = new ActivityParty[] { new ActivityParty() { PartyId = toEntity } };
            emailEntity.From = new ActivityParty[] { new ActivityParty() { PartyId = systemUserEntity } };
            emailEntity.Description = emailEntity.Description;
            emailEntity.RegardingObjectId = regardingEntity;
            emailEntity.DirectionCode = true;
            return emailEntity;
        }

        public static swa_sms MapSMS(swa_sms sms, string subject, string message, EntityReference toEntity, EntityReference regardingEntity)
        {
            sms.To = new ActivityParty[] { new ActivityParty() { PartyId = toEntity } };
            sms.Subject = subject;
            sms.Description = message;
            sms.RegardingObjectId = regardingEntity;
            return sms;
        }

        public static string GetEmailAddress(EntityReference entityReference, IOrganizationService service)
        {
            string emailAddress = string.Empty, fieldName = string.Empty;

            switch (entityReference.LogicalName)
            {
                case Contact.EntityLogicalName:
                    fieldName = Contact.Fields.EMailAddress1;
                    break;
                case SystemUser.EntityLogicalName:
                    fieldName = SystemUser.Fields.InternalEMailAddress;
                    break;
                case Entities.Base.Queue.EntityLogicalName:
                    fieldName = Entities.Base.Queue.Fields.EMailAddress;
                    break;
            }

            Entity entity = service.Retrieve(entityReference.LogicalName, entityReference.Id, new Microsoft.Xrm.Sdk.Query.ColumnSet(fieldName));

            if (entity != null && entity.Contains(fieldName))
            {
                emailAddress = entity.GetAttributeValue<string>(fieldName);
            }

            return emailAddress;
        }

        public static string GetMobileNumber(EntityReference entityReference, IOrganizationService service) 
        { 
            string mobileNumber = string.Empty, fieldName = string.Empty;

            switch (entityReference.LogicalName) 
            {
                case Contact.EntityLogicalName:
                    fieldName = Contact.Fields.MobilePhone;
                    break;
                case SystemUser.EntityLogicalName:
                    fieldName = SystemUser.Fields.MobilePhone;
                    break;
            }

            Entity entity = service.Retrieve(entityReference.LogicalName, entityReference.Id, new Microsoft.Xrm.Sdk.Query.ColumnSet(fieldName));

            if (entity != null && entity.Contains(fieldName))
            {
                mobileNumber = entity.GetAttributeValue<string>(fieldName);
            }

            return mobileNumber;
        }
    }
}
