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
	/// Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("productpricelevel")]
	public partial class ProductPriceLevel : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the productpricelevel entity
		/// </summary>
		public partial class Fields
		{
			public const string Amount = "amount";
			public const string Amount_Base = "amount_base";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyname";
			public const string CreatedByYomiName = "createdbyyominame";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyname";
			public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
			public const string DiscountTypeId = "discounttypeid";
			public const string DiscountTypeIdName = "discounttypeidname";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string lk_productpricelevel_createdonbehalfby = "lk_productpricelevel_createdonbehalfby";
			public const string lk_productpricelevel_modifiedonbehalfby = "lk_productpricelevel_modifiedonbehalfby";
			public const string lk_productpricelevelbase_createdby = "lk_productpricelevelbase_createdby";
			public const string lk_productpricelevelbase_modifiedby = "lk_productpricelevelbase_modifiedby";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyname";
			public const string ModifiedByYomiName = "modifiedbyyominame";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
			public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string Percentage = "percentage";
			public const string price_level_product_price_levels = "price_level_product_price_levels";
			public const string PriceLevelId = "pricelevelid";
			public const string PriceLevelIdName = "pricelevelidname";
			public const string PricingMethodCode = "pricingmethodcode";
			public const string PricingMethodCodeName = "pricingmethodcodename";
			public const string ProcessId = "processid";
			public const string ProductId = "productid";
			public const string ProductIdName = "productidname";
			public const string ProductNumber = "productnumber";
			public const string ProductPriceLevelId = "productpricelevelid";
			public const string Id = "productpricelevelid";
			public const string QuantitySellingCode = "quantitysellingcode";
			public const string QuantitySellingCodeName = "quantitysellingcodename";
			public const string RoundingOptionAmount = "roundingoptionamount";
			public const string RoundingOptionAmount_Base = "roundingoptionamount_base";
			public const string RoundingOptionCode = "roundingoptioncode";
			public const string RoundingOptionCodeName = "roundingoptioncodename";
			public const string RoundingPolicyCode = "roundingpolicycode";
			public const string RoundingPolicyCodeName = "roundingpolicycodename";
			public const string StageId = "stageid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string transactioncurrency_productpricelevel = "transactioncurrency_productpricelevel";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidname";
			public const string TraversedPath = "traversedpath";
			public const string unit_of_measure_schedule_product_price_level = "unit_of_measure_schedule_product_price_level";
			public const string unit_of_measurement_product_price_levels = "unit_of_measurement_product_price_levels";
			public const string UoMId = "uomid";
			public const string UoMIdName = "uomidname";
			public const string UoMScheduleId = "uomscheduleid";
			public const string UoMScheduleIdName = "uomscheduleidname";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}
		
		
		public ProductPriceLevel(System.Guid id) : 
				base(EntityLogicalName, id)
		{
		}
		
		
		public ProductPriceLevel(string keyName, object keyValue) : 
				base(EntityLogicalName, keyName, keyValue)
		{
		}
		
		
		public ProductPriceLevel(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) : 
				base(EntityLogicalName, keyAttributes)
		{
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		
		public ProductPriceLevel() : 
				base(EntityLogicalName)
		{
		}
		
		public const string PrimaryIdAttribute = "productpricelevelid";
		
		public const string PrimaryNameAttribute = "productidname";
		
		public const string EntitySchemaName = "ProductPriceLevel";
		
		public const string EntityLogicalName = "productpricelevel";
		
		public const string EntityLogicalCollectionName = "productpricelevels";
		
		public const string EntitySetName = "productpricelevels";
		
		public const int EntityTypeCode = 1026;
		
		/// <summary>
		/// Monetary amount for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amount")]
		public Microsoft.Xrm.Sdk.Money Amount
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("amount");
			}
			
			set
			{
				this.SetAttributeValue("amount", value);
			}
		}
		
		/// <summary>
		/// Value of the Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amount_base")]
		public Microsoft.Xrm.Sdk.Money Amount_Base
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("amount_base");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the price list.
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
		/// Date and time when the price list was created.
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
		/// Shows who created the record on behalf of another user.
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
		/// Unique identifier of the discount list associated with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeid")]
		public Microsoft.Xrm.Sdk.EntityReference DiscountTypeId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("discounttypeid");
			}
			
			set
			{
				this.SetAttributeValue("discounttypeid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeidname")]
		public string DiscountTypeIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("discounttypeid"))
				{
					return this.FormattedValues["discounttypeid"];
				}
				else
				{
					return default(string);
				}
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
		/// Unique identifier of the user who last modified the price list.
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
		/// Date and time when the price list was last modified.
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
		/// Shows who last updated the record on behalf of another user.
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
		/// Unique identifier of the organization associated with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
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
		/// Percentage for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("percentage")]
		public System.Nullable<decimal> Percentage
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("percentage");
			}
			
			set
			{
				this.SetAttributeValue("percentage", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the price level associated with this price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid");
			}
			
			set
			{
				this.SetAttributeValue("pricelevelid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelidname")]
		public string PriceLevelIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("pricelevelid"))
				{
					return this.FormattedValues["pricelevelid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Pricing method applied to the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingmethodcode")]
		public virtual ProductPriceLevel_PricingMethodCode? PricingMethodCode
		{
			
			get
			{
				return ((ProductPriceLevel_PricingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "pricingmethodcode")));
			}
			
			set
			{
				this.SetAttributeValue("pricingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingmethodcodename")]
		public string PricingMethodCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("pricingmethodcode"))
				{
					return this.FormattedValues["pricingmethodcode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Contains the id of the process associated with the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			
			set
			{
				this.SetAttributeValue("processid", value);
			}
		}
		
		/// <summary>
		/// Product associated with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
		public Microsoft.Xrm.Sdk.EntityReference ProductId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("productid");
			}
			
			set
			{
				this.SetAttributeValue("productid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productidname")]
		public string ProductIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("productid"))
				{
					return this.FormattedValues["productid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// User-defined product number.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productnumber")]
		public string ProductNumber
		{
			
			get
			{
				return this.GetAttributeValue<string>("productnumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productpricelevelid")]
		public System.Nullable<System.Guid> ProductPriceLevelId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("productpricelevelid");
			}
			
			set
			{
				this.SetAttributeValue("productpricelevelid", value);
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productpricelevelid")]
		public override System.Guid Id
		{
			
			get
			{
				return base.Id;
			}
			
			set
			{
				this.ProductPriceLevelId = value;
			}
		}
		
		/// <summary>
		/// Quantity of the product that must be sold for a given price level.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitysellingcode")]
		public virtual ProductPriceLevel_QuantitySellingCode? QuantitySellingCode
		{
			
			get
			{
				return ((ProductPriceLevel_QuantitySellingCode?)(EntityOptionSetEnum.GetEnum(this, "quantitysellingcode")));
			}
			
			set
			{
				this.SetAttributeValue("quantitysellingcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitysellingcodename")]
		public string QuantitySellingCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("quantitysellingcode"))
				{
					return this.FormattedValues["quantitysellingcode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Rounding option amount for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptionamount")]
		public Microsoft.Xrm.Sdk.Money RoundingOptionAmount
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("roundingoptionamount");
			}
			
			set
			{
				this.SetAttributeValue("roundingoptionamount", value);
			}
		}
		
		/// <summary>
		/// Value of the Rounding Amount in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptionamount_base")]
		public Microsoft.Xrm.Sdk.Money RoundingOptionAmount_Base
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("roundingoptionamount_base");
			}
		}
		
		/// <summary>
		/// Option for rounding the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptioncode")]
		public virtual ProductPriceLevel_RoundingOptionCode? RoundingOptionCode
		{
			
			get
			{
				return ((ProductPriceLevel_RoundingOptionCode?)(EntityOptionSetEnum.GetEnum(this, "roundingoptioncode")));
			}
			
			set
			{
				this.SetAttributeValue("roundingoptioncode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptioncodename")]
		public string RoundingOptionCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("roundingoptioncode"))
				{
					return this.FormattedValues["roundingoptioncode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Policy for rounding the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingpolicycode")]
		public virtual ProductPriceLevel_RoundingPolicyCode? RoundingPolicyCode
		{
			
			get
			{
				return ((ProductPriceLevel_RoundingPolicyCode?)(EntityOptionSetEnum.GetEnum(this, "roundingpolicycode")));
			}
			
			set
			{
				this.SetAttributeValue("roundingpolicycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingpolicycodename")]
		public string RoundingPolicyCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("roundingpolicycode"))
				{
					return this.FormattedValues["roundingpolicycode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Contains the id of the stage where the entity is located.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			
			set
			{
				this.SetAttributeValue("stageid", value);
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
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			
			set
			{
				this.SetAttributeValue("transactioncurrencyid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyidname")]
		public string TransactionCurrencyIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("transactioncurrencyid"))
				{
					return this.FormattedValues["transactioncurrencyid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			
			set
			{
				this.SetAttributeValue("traversedpath", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the unit for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
		public Microsoft.Xrm.Sdk.EntityReference UoMId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomid");
			}
			
			set
			{
				this.SetAttributeValue("uomid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomidname")]
		public string UoMIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("uomid"))
				{
					return this.FormattedValues["uomid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier of the unit schedule for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		public Microsoft.Xrm.Sdk.EntityReference UoMScheduleId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomscheduleid");
			}
			
			set
			{
				this.SetAttributeValue("uomscheduleid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleidname")]
		public string UoMScheduleIdName
		{
			
			get
			{
				if (this.FormattedValues.Contains("uomscheduleid"))
				{
					return this.FormattedValues["uomscheduleid"];
				}
				else
				{
					return default(string);
				}
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
		/// N:1 lk_productpricelevel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_createdonbehalfby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_productpricelevel_createdonbehalfby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_productpricelevel_createdonbehalfby", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_productpricelevel_createdonbehalfby", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_productpricelevel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_modifiedonbehalfby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_productpricelevel_modifiedonbehalfby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_productpricelevel_modifiedonbehalfby", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_productpricelevel_modifiedonbehalfby", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_productpricelevelbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_createdby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_productpricelevelbase_createdby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_productpricelevelbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_productpricelevelbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_modifiedby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_productpricelevelbase_modifiedby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_productpricelevelbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 price_level_product_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_product_price_levels")]
		public SWA.CRM.D365.Entities.Base.PriceLevel price_level_product_price_levels
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.PriceLevel>("price_level_product_price_levels", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.PriceLevel>("price_level_product_price_levels", null, value);
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_productpricelevel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_productpricelevel")]
		public SWA.CRM.D365.Entities.Base.TransactionCurrency transactioncurrency_productpricelevel
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.TransactionCurrency>("transactioncurrency_productpricelevel", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.TransactionCurrency>("transactioncurrency_productpricelevel", null, value);
			}
		}
		
		/// <summary>
		/// N:1 unit_of_measure_schedule_product_price_level
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_product_price_level")]
		public SWA.CRM.D365.Entities.Base.UoMSchedule unit_of_measure_schedule_product_price_level
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.UoMSchedule>("unit_of_measure_schedule_product_price_level", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.UoMSchedule>("unit_of_measure_schedule_product_price_level", null, value);
			}
		}
		
		/// <summary>
		/// N:1 unit_of_measurement_product_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_product_price_levels")]
		public SWA.CRM.D365.Entities.Base.UoM unit_of_measurement_product_price_levels
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.UoM>("unit_of_measurement_product_price_levels", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.UoM>("unit_of_measurement_product_price_levels", null, value);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		
		public ProductPriceLevel(object anonymousType) : 
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
                        Attributes["productpricelevelid"] = base.Id;
                        break;
                    case "productpricelevelid":
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
