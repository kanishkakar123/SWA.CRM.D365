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
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("swa_casecategory")]
	public partial class swa_casecategory : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the swa_casecategory entity
		/// </summary>
		public partial class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyname";
			public const string CreatedByYomiName = "createdbyyominame";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyname";
			public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string lk_swa_casecategory_createdby = "lk_swa_casecategory_createdby";
			public const string lk_swa_casecategory_createdonbehalfby = "lk_swa_casecategory_createdonbehalfby";
			public const string lk_swa_casecategory_modifiedby = "lk_swa_casecategory_modifiedby";
			public const string lk_swa_casecategory_modifiedonbehalfby = "lk_swa_casecategory_modifiedonbehalfby";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyname";
			public const string ModifiedByYomiName = "modifiedbyyominame";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
			public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidname";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string StateCode = "statecode";
			public const string statecodeName = "statecodename";
			public const string StatusCode = "statuscode";
			public const string statuscodeName = "statuscodename";
			public const string swa_casecategoryId = "swa_casecategoryid";
			public const string Id = "swa_casecategoryid";
			public const string swa_casetypeid = "swa_casetypeid";
			public const string swa_casetypeidName = "swa_casetypeidname";
			public const string swa_name = "swa_name";
			public const string swa_swa_casecategory_incident_casecategoryid = "swa_swa_casecategory_incident_casecategoryid";
			public const string swa_swa_casecategory_swa_casesubcategory_casecategoryid = "swa_swa_casecategory_swa_casesubcategory_casecategoryid";
			public const string swa_swa_casetype_swa_casecategory_casetypeid = "swa_swa_casetype_swa_casecategory_casetypeid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}
		
		
		public swa_casecategory(System.Guid id) : 
				base(EntityLogicalName, id)
		{
		}
		
		
		public swa_casecategory(string keyName, object keyValue) : 
				base(EntityLogicalName, keyName, keyValue)
		{
		}
		
		
		public swa_casecategory(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) : 
				base(EntityLogicalName, keyAttributes)
		{
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		
		public swa_casecategory() : 
				base(EntityLogicalName)
		{
		}
		
		public const string PrimaryIdAttribute = "swa_casecategoryid";
		
		public const string PrimaryNameAttribute = "swa_name";
		
		public const string EntitySchemaName = "swa_casecategory";
		
		public const string EntityLogicalName = "swa_casecategory";
		
		public const string EntityLogicalCollectionName = "swa_casecategories";
		
		public const string EntitySetName = "swa_casecategories";
		
		public const int EntityTypeCode = 10113;
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyname")]
		public string CreatedByName
		{
			
			get
			{
				if (this.FormattedValues.Contains("createdby"))
				{
					return this.FormattedValues["createdby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyyominame")]
		public string CreatedByYomiName
		{
			
			get
			{
				if (this.FormattedValues.Contains("createdby"))
				{
					return this.FormattedValues["createdby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			
			set
			{
				this.SetAttributeValue("createdonbehalfby", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyname")]
		public string CreatedOnBehalfByName
		{
			
			get
			{
				if (this.FormattedValues.Contains("createdonbehalfby"))
				{
					return this.FormattedValues["createdonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyyominame")]
		public string CreatedOnBehalfByYomiName
		{
			
			get
			{
				if (this.FormattedValues.Contains("createdonbehalfby"))
				{
					return this.FormattedValues["createdonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			
			set
			{
				this.SetAttributeValue("importsequencenumber", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyname")]
		public string ModifiedByName
		{
			
			get
			{
				if (this.FormattedValues.Contains("modifiedby"))
				{
					return this.FormattedValues["modifiedby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyyominame")]
		public string ModifiedByYomiName
		{
			
			get
			{
				if (this.FormattedValues.Contains("modifiedby"))
				{
					return this.FormattedValues["modifiedby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			
			set
			{
				this.SetAttributeValue("modifiedonbehalfby", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
		public string ModifiedOnBehalfByName
		{
			
			get
			{
				if (this.FormattedValues.Contains("modifiedonbehalfby"))
				{
					return this.FormattedValues["modifiedonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
		public string ModifiedOnBehalfByYomiName
		{
			
			get
			{
				if (this.FormattedValues.Contains("modifiedonbehalfby"))
				{
					return this.FormattedValues["modifiedonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationidname")]
		public string OrganizationIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("organizationid"))
				{
					return this.FormattedValues["organizationid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			
			set
			{
				this.SetAttributeValue("overriddencreatedon", value);
			}
		}
		
		/// <summary>
		/// Status of the Case Category
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public virtual swa_casecategory_statecode? StateCode
		{
			
			get
			{
				return ((swa_casecategory_statecode?)(EntityOptionSetEnum.GetEnum(this, "statecode")));
			}
			
			set
			{
				this.SetAttributeValue("statecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecodename")]
		public string statecodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("statecode"))
				{
					return this.FormattedValues["statecode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the Case Category
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual swa_casecategory_StatusCode? StatusCode
		{
			
			get
			{
				return ((swa_casecategory_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			
			set
			{
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscodename")]
		public string statuscodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("statuscode"))
				{
					return this.FormattedValues["statuscode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("swa_casecategoryid")]
		public System.Nullable<System.Guid> swa_casecategoryId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("swa_casecategoryid");
			}
			
			set
			{
				this.SetAttributeValue("swa_casecategoryid", value);
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("swa_casecategoryid")]
		public override System.Guid Id
		{
			
			get
			{
				return base.Id;
			}
			
			set
			{
				this.swa_casecategoryId = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("swa_casetypeid")]
		public Microsoft.Xrm.Sdk.EntityReference swa_casetypeid
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("swa_casetypeid");
			}
			
			set
			{
				this.SetAttributeValue("swa_casetypeid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("swa_casetypeidname")]
		public string swa_casetypeidName
		{
			
			get
			{
				if (this.FormattedValues.Contains("swa_casetypeid"))
				{
					return this.FormattedValues["swa_casetypeid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("swa_name")]
		public string swa_name
		{
			
			get
			{
				return this.GetAttributeValue<string>("swa_name");
			}
			
			set
			{
				this.SetAttributeValue("swa_name", value);
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			
			set
			{
				this.SetAttributeValue("timezoneruleversionnumber", value);
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			
			set
			{
				this.SetAttributeValue("utcconversiontimezonecode", value);
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N swa_swa_casecategory_incident_casecategoryid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("swa_swa_casecategory_incident_casecategoryid")]
		public System.Collections.Generic.IEnumerable<SWA.CRM.D365.Entities.Base.Incident> swa_swa_casecategory_incident_casecategoryid
		{
			
			get
			{
				return this.GetRelatedEntities<SWA.CRM.D365.Entities.Base.Incident>("swa_swa_casecategory_incident_casecategoryid", null);
			}
			
			set
			{
				this.SetRelatedEntities<SWA.CRM.D365.Entities.Base.Incident>("swa_swa_casecategory_incident_casecategoryid", null, value);
			}
		}
		
		/// <summary>
		/// 1:N swa_swa_casecategory_swa_casesubcategory_casecategoryid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("swa_swa_casecategory_swa_casesubcategory_casecategoryid")]
		public System.Collections.Generic.IEnumerable<SWA.CRM.D365.Entities.Base.swa_casesubcategory> swa_swa_casecategory_swa_casesubcategory_casecategoryid
		{
			
			get
			{
				return this.GetRelatedEntities<SWA.CRM.D365.Entities.Base.swa_casesubcategory>("swa_swa_casecategory_swa_casesubcategory_casecategoryid", null);
			}
			
			set
			{
				this.SetRelatedEntities<SWA.CRM.D365.Entities.Base.swa_casesubcategory>("swa_swa_casecategory_swa_casesubcategory_casecategoryid", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_swa_casecategory_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_swa_casecategory_createdby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_swa_casecategory_createdby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_swa_casecategory_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_swa_casecategory_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_swa_casecategory_createdonbehalfby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_swa_casecategory_createdonbehalfby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_swa_casecategory_createdonbehalfby", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_swa_casecategory_createdonbehalfby", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_swa_casecategory_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_swa_casecategory_modifiedby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_swa_casecategory_modifiedby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_swa_casecategory_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_swa_casecategory_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_swa_casecategory_modifiedonbehalfby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_swa_casecategory_modifiedonbehalfby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_swa_casecategory_modifiedonbehalfby", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_swa_casecategory_modifiedonbehalfby", null, value);
			}
		}
		
		/// <summary>
		/// N:1 swa_swa_casetype_swa_casecategory_casetypeid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("swa_casetypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("swa_swa_casetype_swa_casecategory_casetypeid")]
		public SWA.CRM.D365.Entities.Base.swa_casetype swa_swa_casetype_swa_casecategory_casetypeid
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.swa_casetype>("swa_swa_casetype_swa_casecategory_casetypeid", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.swa_casetype>("swa_swa_casetype_swa_casecategory_casetypeid", null, value);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		
		public swa_casecategory(object anonymousType) : 
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
                        Attributes["swa_casecategoryid"] = base.Id;
                        break;
                    case "swa_casecategoryid":
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
