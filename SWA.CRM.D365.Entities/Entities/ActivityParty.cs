#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWA.CRM.D365.Entities.Base
{
	
	
	/// <summary>
	/// Person or group associated with an activity. An activity can have multiple activity parties.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activityparty")]
	public partial class ActivityParty : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the activityparty entity
		/// </summary>
		public partial class Fields
		{
			public const string account_activity_parties = "account_activity_parties";
			public const string ActivityId = "activityid";
			public const string ActivityPartyId = "activitypartyid";
			public const string Id = "activitypartyid";
			public const string activitypointer_activity_parties = "activitypointer_activity_parties";
			public const string AddressUsed = "addressused";
			public const string AddressUsedEmailColumnNumber = "addressusedemailcolumnnumber";
			public const string appointment_activity_parties = "appointment_activity_parties";
			public const string contact_activity_parties = "contact_activity_parties";
			public const string DoNotEmail = "donotemail";
			public const string DoNotEmailName = "donotemailname";
			public const string DoNotFax = "donotfax";
			public const string DoNotFaxName = "donotfaxname";
			public const string DoNotPhone = "donotphone";
			public const string DoNotPhoneName = "donotphonename";
			public const string DoNotPostalMail = "donotpostalmail";
			public const string DoNotPostalMailName = "donotpostalmailname";
			public const string Effort = "effort";
			public const string email_activity_parties = "email_activity_parties";
			public const string ExchangeEntryId = "exchangeentryid";
			public const string incident_activity_parties = "incident_activity_parties";
			public const string incidentresolution_activity_parties = "incidentresolution_activity_parties";
			public const string InstanceTypeCode = "instancetypecode";
			public const string InstanceTypeCodeName = "instancetypecodename";
			public const string IsPartyDeleted = "ispartydeleted";
			public const string IsPartyDeletedName = "ispartydeletedname";
			public const string letter_activity_parties = "letter_activity_parties";
			public const string OwnerId = "ownerid";
			public const string ParticipationTypeMask = "participationtypemask";
			public const string ParticipationTypeMaskName = "participationtypemaskname";
			public const string PartyId = "partyid";
			public const string PartyIdName = "partyidname";
			public const string phonecall_activity_parties = "phonecall_activity_parties";
			public const string ResourceSpecId = "resourcespecid";
			public const string ResourceSpecIdName = "resourcespecidname";
			public const string ScheduledEnd = "scheduledend";
			public const string ScheduledStart = "scheduledstart";
			public const string swa_sms_activity_parties = "swa_sms_activity_parties";
			public const string system_user_activity_parties = "system_user_activity_parties";
			public const string task_activity_parties = "task_activity_parties";
			public const string VersionNumber = "versionnumber";
		}
		
		
		public ActivityParty(System.Guid id) : 
				base(EntityLogicalName, id)
		{
		}
		
		
		public ActivityParty(string keyName, object keyValue) : 
				base(EntityLogicalName, keyName, keyValue)
		{
		}
		
		
		public ActivityParty(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) : 
				base(EntityLogicalName, keyAttributes)
		{
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		
		public ActivityParty() : 
				base(EntityLogicalName)
		{
		}
		
		public const string PrimaryIdAttribute = "activitypartyid";
		
		public const string PrimaryNameAttribute = "partyidname";
		
		public const string EntitySchemaName = "ActivityParty";
		
		public const string EntityLogicalName = "activityparty";
		
		public const string EntityLogicalCollectionName = "activityparties";
		
		public const string EntitySetName = "activityparties";
		
		public const int EntityTypeCode = 135;
		
		/// <summary>
		/// Unique identifier of the activity associated with the activity party. (A "party" is any person who is associated with an activity.)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		public Microsoft.Xrm.Sdk.EntityReference ActivityId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid");
			}
			
			set
			{
				this.SetAttributeValue("activityid", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public System.Nullable<System.Guid> ActivityPartyId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activitypartyid");
			}
			
			set
			{
				this.SetAttributeValue("activitypartyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
		public override System.Guid Id
		{
			
			get
			{
				return base.Id;
			}
			
			set
			{
				this.ActivityPartyId = value;
			}
		}
		
		/// <summary>
		/// Email address to which an email is delivered, and which is associated with the target entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressused")]
		public string AddressUsed
		{
			
			get
			{
				return this.GetAttributeValue<string>("addressused");
			}
			
			set
			{
				this.SetAttributeValue("addressused", value);
			}
		}
		
		/// <summary>
		/// Email address column number from associated party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressusedemailcolumnnumber")]
		public System.Nullable<int> AddressUsedEmailColumnNumber
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressusedemailcolumnnumber");
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending email to the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
		public System.Nullable<bool> DoNotEmail
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemailname")]
		public string DoNotEmailName
		{
			
			get
			{
				if (this.FormattedValues.Contains("donotemail"))
				{
					return this.FormattedValues["donotemail"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending faxes to the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
		public System.Nullable<bool> DoNotFax
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfaxname")]
		public string DoNotFaxName
		{
			
			get
			{
				if (this.FormattedValues.Contains("donotfax"))
				{
					return this.FormattedValues["donotfax"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Information about whether to allow phone calls to the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
		public System.Nullable<bool> DoNotPhone
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphonename")]
		public string DoNotPhoneName
		{
			
			get
			{
				if (this.FormattedValues.Contains("donotphone"))
				{
					return this.FormattedValues["donotphone"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Information about whether to allow sending postal mail to the lead.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
		public System.Nullable<bool> DoNotPostalMail
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmailname")]
		public string DoNotPostalMailName
		{
			
			get
			{
				if (this.FormattedValues.Contains("donotpostalmail"))
				{
					return this.FormattedValues["donotpostalmail"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Amount of effort used by the resource in a service appointment activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
		public System.Nullable<double> Effort
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("effort");
			}
			
			set
			{
				this.SetAttributeValue("effort", value);
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
		public string ExchangeEntryId
		{
			
			get
			{
				return this.GetAttributeValue<string>("exchangeentryid");
			}
			
			set
			{
				this.SetAttributeValue("exchangeentryid", value);
			}
		}
		
		/// <summary>
		/// Type of instance of a recurring series.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
		public virtual ActivityParty_InstanceTypeCode? InstanceTypeCode
		{
			
			get
			{
				return ((ActivityParty_InstanceTypeCode?)(EntityOptionSetEnum.GetEnum(this, "instancetypecode")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecodename")]
		public string InstanceTypeCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("instancetypecode"))
				{
					return this.FormattedValues["instancetypecode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Information about whether the underlying entity record is deleted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeleted")]
		public System.Nullable<bool> IsPartyDeleted
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ispartydeleted");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeletedname")]
		public string IsPartyDeletedName
		{
			
			get
			{
				if (this.FormattedValues.Contains("ispartydeleted"))
				{
					return this.FormattedValues["ispartydeleted"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the activity_party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
		public virtual ActivityParty_ParticipationTypeMask? ParticipationTypeMask
		{
			
			get
			{
				return ((ActivityParty_ParticipationTypeMask?)(EntityOptionSetEnum.GetEnum(this, "participationtypemask")));
			}
			
			set
			{
				this.SetAttributeValue("participationtypemask", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemaskname")]
		public string ParticipationTypeMaskName
		{
			
			get
			{
				if (this.FormattedValues.Contains("participationtypemask"))
				{
					return this.FormattedValues["participationtypemask"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier of the party associated with the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		public Microsoft.Xrm.Sdk.EntityReference PartyId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partyid");
			}
			
			set
			{
				this.SetAttributeValue("partyid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyidname")]
		public string PartyIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("partyid"))
				{
					return this.FormattedValues["partyid"];
				}
				else
				{
					return default(string);
				}
			}
			
			set
			{
				this.SetAttributeValue("partyidname", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the resource specification for the activity party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
		public Microsoft.Xrm.Sdk.EntityReference ResourceSpecId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resourcespecid");
			}
			
			set
			{
				this.SetAttributeValue("resourcespecid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecidname")]
		public string ResourceSpecIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("resourcespecid"))
				{
					return this.FormattedValues["resourcespecid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Scheduled end time of the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
		public System.Nullable<System.DateTime> ScheduledEnd
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
			}
		}
		
		/// <summary>
		/// Scheduled start time of the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
		public System.Nullable<System.DateTime> ScheduledStart
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 account_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
		public SWA.CRM.D365.Entities.Base.Account account_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Account>("account_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Account>("account_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 activitypointer_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_activity_parties")]
		public SWA.CRM.D365.Entities.Base.ActivityPointer activitypointer_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.ActivityPointer>("activitypointer_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.ActivityPointer>("activitypointer_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 appointment_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_parties")]
		public SWA.CRM.D365.Entities.Base.Appointment appointment_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Appointment>("appointment_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Appointment>("appointment_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 contact_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
		public SWA.CRM.D365.Entities.Base.Contact contact_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Contact>("contact_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Contact>("contact_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 email_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
		public SWA.CRM.D365.Entities.Base.Email email_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Email>("email_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Email>("email_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 incident_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_activity_parties")]
		public SWA.CRM.D365.Entities.Base.Incident incident_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Incident>("incident_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Incident>("incident_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 incidentresolution_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incidentresolution_activity_parties")]
		public SWA.CRM.D365.Entities.Base.IncidentResolution incidentresolution_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.IncidentResolution>("incidentresolution_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.IncidentResolution>("incidentresolution_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 letter_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_activity_parties")]
		public SWA.CRM.D365.Entities.Base.Letter letter_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Letter>("letter_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Letter>("letter_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 phonecall_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_activity_parties")]
		public SWA.CRM.D365.Entities.Base.PhoneCall phonecall_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.PhoneCall>("phonecall_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.PhoneCall>("phonecall_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 swa_sms_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("swa_sms_activity_parties")]
		public SWA.CRM.D365.Entities.Base.swa_sms swa_sms_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.swa_sms>("swa_sms_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.swa_sms>("swa_sms_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 system_user_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
		public SWA.CRM.D365.Entities.Base.SystemUser system_user_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("system_user_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("system_user_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// N:1 task_activity_parties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_activity_parties")]
		public SWA.CRM.D365.Entities.Base.Task task_activity_parties
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Task>("task_activity_parties", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Task>("task_activity_parties", null, value);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		
		public ActivityParty(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (value != null && name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["activitypartyid"] = base.Id;
                        break;
                    case "activitypartyid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}
#pragma warning restore CS1591
