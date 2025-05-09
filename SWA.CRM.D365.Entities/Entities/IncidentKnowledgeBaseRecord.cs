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
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("incidentknowledgebaserecord")]
	public partial class IncidentKnowledgeBaseRecord : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the incidentknowledgebaserecord entity
		/// </summary>
		public partial class Fields
		{
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IncidentId = "incidentid";
			public const string IncidentKnowledgeBaseRecordId = "incidentknowledgebaserecordid";
			public const string Id = "incidentknowledgebaserecordid";
			public const string KnowledgeBaseRecord_Incident = "KnowledgeBaseRecord_Incident";
			public const string KnowledgeBaseRecordId = "knowledgebaserecordid";
			public const string Name = "name";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}
		
		
		public IncidentKnowledgeBaseRecord(System.Guid id) : 
				base(EntityLogicalName, id)
		{
		}
		
		
		public IncidentKnowledgeBaseRecord(string keyName, object keyValue) : 
				base(EntityLogicalName, keyName, keyValue)
		{
		}
		
		
		public IncidentKnowledgeBaseRecord(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) : 
				base(EntityLogicalName, keyAttributes)
		{
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		
		public IncidentKnowledgeBaseRecord() : 
				base(EntityLogicalName)
		{
		}
		
		public const string PrimaryIdAttribute = "incidentknowledgebaserecordid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntitySchemaName = "IncidentKnowledgeBaseRecord";
		
		public const string EntityLogicalName = "incidentknowledgebaserecord";
		
		public const string EntityLogicalCollectionName = null;
		
		public const string EntitySetName = "incidentknowledgebaserecords";
		
		public const int EntityTypeCode = 9931;
		
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incidentid")]
		public System.Nullable<System.Guid> IncidentId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("incidentid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the knowledgebase records for the incident.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incidentknowledgebaserecordid")]
		public System.Nullable<System.Guid> IncidentKnowledgeBaseRecordId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("incidentknowledgebaserecordid");
			}
			
			set
			{
				this.SetAttributeValue("incidentknowledgebaserecordid", value);
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incidentknowledgebaserecordid")]
		public override System.Guid Id
		{
			
			get
			{
				return base.Id;
			}
			
			set
			{
				this.IncidentKnowledgeBaseRecordId = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgebaserecordid")]
		public System.Nullable<System.Guid> KnowledgeBaseRecordId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("knowledgebaserecordid");
			}
		}
		
		/// <summary>
		/// name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			
			set
			{
				this.SetAttributeValue("name", value);
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
		/// N:N KnowledgeBaseRecord_Incident
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KnowledgeBaseRecord_Incident")]
		public System.Collections.Generic.IEnumerable<SWA.CRM.D365.Entities.Base.KnowledgeBaseRecord> KnowledgeBaseRecord_Incident
		{
			
			get
			{
				return this.GetRelatedEntities<SWA.CRM.D365.Entities.Base.KnowledgeBaseRecord>("KnowledgeBaseRecord_Incident", null);
			}
			
			set
			{
				this.SetRelatedEntities<SWA.CRM.D365.Entities.Base.KnowledgeBaseRecord>("KnowledgeBaseRecord_Incident", null, value);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		
		public IncidentKnowledgeBaseRecord(object anonymousType) : 
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
                        Attributes["incidentknowledgebaserecordid"] = base.Id;
                        break;
                    case "incidentknowledgebaserecordid":
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
