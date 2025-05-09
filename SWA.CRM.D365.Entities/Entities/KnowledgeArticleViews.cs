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
	public enum KnowledgeArticleViewsState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// No of times an article is viewed per day
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("knowledgearticleviews")]
	public partial class KnowledgeArticleViews : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		
		public KnowledgeArticleViews() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "knowledgearticleviews";
		
		public const string EntitySchemaName = "KnowledgeArticleViews";
		
		public const string PrimaryIdAttribute = "knowledgearticleviewsid";
		
		public const string PrimaryNameAttribute = "knowledgearticleidname";
		
		public const string EntityLogicalCollectionName = "knowledgearticleviews";
		
		public const string EntitySetName = "knowledgearticleviews";
		
		public const int EntityTypeCode = 9955;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
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
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Choose the Knowledge Article.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleid")]
		public Microsoft.Xrm.Sdk.EntityReference KnowledgeArticleId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("knowledgearticleid");
			}
			
			set
			{
				this.OnPropertyChanging("KnowledgeArticleId");
				this.SetAttributeValue("knowledgearticleid", value);
				this.OnPropertyChanged("KnowledgeArticleId");
			}
		}
		
		/// <summary>
		/// Number of Knowledge Article Views visited per day
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleview")]
		public System.Nullable<int> KnowledgeArticleView
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("knowledgearticleview");
			}
			
			set
			{
				this.OnPropertyChanging("KnowledgeArticleView");
				this.SetAttributeValue("knowledgearticleview", value);
				this.OnPropertyChanged("KnowledgeArticleView");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Knowledge Article Views
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleviewsid")]
		public System.Nullable<System.Guid> KnowledgeArticleViewsId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("knowledgearticleviewsid");
			}
			
			set
			{
				this.OnPropertyChanging("KnowledgeArticleViewsId");
				this.SetAttributeValue("knowledgearticleviewsid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("KnowledgeArticleViewsId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleviewsid")]
		public override System.Guid Id
		{
			
			get
			{
				return base.Id;
			}
			
			set
			{
				this.KnowledgeArticleViewsId = value;
			}
		}
		
		/// <summary>
		/// Shows where the knowledge was used
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("location")]
		public virtual KnowledgeArticleViews_Location? Location
		{
			
			get
			{
				return ((KnowledgeArticleViews_Location?)(EntityOptionSetEnum.GetEnum(this, "location")));
			}
			
			set
			{
				this.OnPropertyChanging("Location");
				this.SetAttributeValue("location", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("Location");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
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
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the knowledge article views.
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
		/// Unique identifier of the business unit that owns the knowledge article views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public System.Nullable<System.Guid> OwningBusinessUnit
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the knowledge article views.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public System.Nullable<System.Guid> OwningUser
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Knowledge Article Views
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<SWA.CRM.D365.Entities.Base.KnowledgeArticleViewsState> StateCode
		{
			
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((SWA.CRM.D365.Entities.Base.KnowledgeArticleViewsState)(System.Enum.ToObject(typeof(SWA.CRM.D365.Entities.Base.KnowledgeArticleViewsState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Knowledge Article Views
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual KnowledgeArticleViews_StatusCode? StatusCode
		{
			
			get
			{
				return ((KnowledgeArticleViews_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("StatusCode");
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
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
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
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// 
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
		/// Information about the Day
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("viewdate")]
		public System.Nullable<System.DateTime> ViewDate
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("viewdate");
			}
			
			set
			{
				this.OnPropertyChanging("ViewDate");
				this.SetAttributeValue("viewdate", value);
				this.OnPropertyChanged("ViewDate");
			}
		}
		
		/// <summary>
		/// N:1 knowledgearticle_views
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("knowledgearticle_views")]
		public SWA.CRM.D365.Entities.Base.KnowledgeArticle knowledgearticle_views
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.KnowledgeArticle>("knowledgearticle_views", null);
			}
			
			set
			{
				this.OnPropertyChanging("knowledgearticle_views");
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.KnowledgeArticle>("knowledgearticle_views", null, value);
				this.OnPropertyChanged("knowledgearticle_views");
			}
		}
		
		/// <summary>
		/// N:1 lk_knowledgearticleviews_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_knowledgearticleviews_createdby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_knowledgearticleviews_createdby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_knowledgearticleviews_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_knowledgearticleviews_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_knowledgearticleviews_createdonbehalfby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_knowledgearticleviews_createdonbehalfby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_knowledgearticleviews_createdonbehalfby", null);
			}
			
			set
			{
				this.OnPropertyChanging("lk_knowledgearticleviews_createdonbehalfby");
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_knowledgearticleviews_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_knowledgearticleviews_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_knowledgearticleviews_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_knowledgearticleviews_modifiedby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_knowledgearticleviews_modifiedby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_knowledgearticleviews_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_knowledgearticleviews_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_knowledgearticleviews_modifiedonbehalfby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_knowledgearticleviews_modifiedonbehalfby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_knowledgearticleviews_modifiedonbehalfby", null);
			}
			
			set
			{
				this.OnPropertyChanging("lk_knowledgearticleviews_modifiedonbehalfby");
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_knowledgearticleviews_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_knowledgearticleviews_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_knowledgearticleviews
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_knowledgearticleviews")]
		public SWA.CRM.D365.Entities.Base.TransactionCurrency transactioncurrency_knowledgearticleviews
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.TransactionCurrency>("transactioncurrency_knowledgearticleviews", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		
		public KnowledgeArticleViews(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["knowledgearticleviewsid"] = base.Id;
                        break;
                    case "knowledgearticleviewsid":
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