using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using SWA.CRM.D365.Entities.Base;
using System;
using System.Linq;

namespace SWA.CRM.D365.Common.Helpers
{
    public static class NotificationHelper
    {
        public static Email GetEmailFromTemplate(Template templateEntity, Guid entityId, string entityLogicalName, IOrganizationService service)
        {
            Email emailEntity = null;

            // Retrieve email template from   
            if (templateEntity != null && entityId != Guid.Empty && !string.IsNullOrEmpty(entityLogicalName))
            {
                InstantiateTemplateRequest templateRequest = new InstantiateTemplateRequest
                {
                    TemplateId = templateEntity.TemplateId.Value,
                    ObjectId = entityId,
                    ObjectType = entityLogicalName
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

        public static Entity MapSMS(Entity smsEntity, string message, string mobileNumber, EntityReference toEntity, EntityReference regardingEntity)
        {
            smsEntity["To"] = new ActivityParty[] { new ActivityParty() { PartyId = toEntity } };
            smsEntity["swa_mobilenumber"] = mobileNumber;
            smsEntity["Description"] = message;
            smsEntity["RegardingObjectId"] = regardingEntity;
            return smsEntity;
        }

        public static string GetMobileNumber(string entityLogicalName, Guid entityId, IOrganizationService service) 
        { 
            string mobileNumber = string.Empty, fieldName = string.Empty;

            switch (entityLogicalName) 
            {
                case "contact":
                case "systemuser":
                case "lead":
                    fieldName = "mobilenumber";
                    break;
            }

            Entity entity = service.Retrieve(entityLogicalName, entityId, new Microsoft.Xrm.Sdk.Query.ColumnSet(fieldName));

            if (entity != null && entity.Contains(fieldName))
            {
                mobileNumber = entity.GetAttributeValue<string>(fieldName);
            }

            return mobileNumber;
        }
    }
}
