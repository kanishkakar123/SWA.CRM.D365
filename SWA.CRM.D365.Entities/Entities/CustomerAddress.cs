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
	/// Address and shipping information. Used to store additional addresses for an account or contact.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("customeraddress")]
	public partial class CustomerAddress : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the customeraddress entity
		/// </summary>
		public partial class Fields
		{
			public const string Account_CustomerAddress = "Account_CustomerAddress";
			public const string AddressNumber = "addressnumber";
			public const string AddressTypeCode = "addresstypecode";
			public const string AddressTypeCodeName = "addresstypecodename";
			public const string City = "city";
			public const string Composite = "composite";
			public const string Contact_CustomerAddress = "Contact_CustomerAddress";
			public const string Country = "country";
			public const string County = "county";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyname";
			public const string CreatedByYomiName = "createdbyyominame";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyname";
			public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
			public const string CustomerAddressId = "customeraddressid";
			public const string Id = "customeraddressid";
			public const string ExchangeRate = "exchangerate";
			public const string Fax = "fax";
			public const string FreightTermsCode = "freighttermscode";
			public const string FreightTermsCodeName = "freighttermscodename";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string Latitude = "latitude";
			public const string Line1 = "line1";
			public const string Line2 = "line2";
			public const string Line3 = "line3";
			public const string lk_customeraddress_createdonbehalfby = "lk_customeraddress_createdonbehalfby";
			public const string lk_customeraddress_modifiedonbehalfby = "lk_customeraddress_modifiedonbehalfby";
			public const string lk_customeraddressbase_createdby = "lk_customeraddressbase_createdby";
			public const string lk_customeraddressbase_modifiedby = "lk_customeraddressbase_modifiedby";
			public const string Longitude = "longitude";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyname";
			public const string ModifiedByYomiName = "modifiedbyyominame";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
			public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
			public const string Name = "name";
			public const string ObjectTypeCode = "objecttypecode";
			public const string ObjectTypeCodeName = "objecttypecodename";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string ParentId = "parentid";
			public const string PostalCode = "postalcode";
			public const string PostOfficeBox = "postofficebox";
			public const string PrimaryContactName = "primarycontactname";
			public const string ShippingMethodCode = "shippingmethodcode";
			public const string ShippingMethodCodeName = "shippingmethodcodename";
			public const string StateOrProvince = "stateorprovince";
			public const string Telephone1 = "telephone1";
			public const string Telephone2 = "telephone2";
			public const string Telephone3 = "telephone3";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrency_CustomerAddress = "TransactionCurrency_CustomerAddress";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidname";
			public const string UPSZone = "upszone";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string UTCOffset = "utcoffset";
			public const string VersionNumber = "versionnumber";
		}
		
		
		public CustomerAddress(System.Guid id) : 
				base(EntityLogicalName, id)
		{
		}
		
		
		public CustomerAddress(string keyName, object keyValue) : 
				base(EntityLogicalName, keyName, keyValue)
		{
		}
		
		
		public CustomerAddress(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) : 
				base(EntityLogicalName, keyAttributes)
		{
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		
		public CustomerAddress() : 
				base(EntityLogicalName)
		{
		}
		
		public const string PrimaryIdAttribute = "customeraddressid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntitySchemaName = "CustomerAddress";
		
		public const string EntityLogicalName = "customeraddress";
		
		public const string EntityLogicalCollectionName = "customeraddresses";
		
		public const string EntitySetName = "customeraddresses";
		
		public const int EntityTypeCode = 1071;
		
		/// <summary>
		/// Shows the number of the address, to indicate whether the address is the primary, secondary, or other address for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressnumber")]
		public System.Nullable<int> AddressNumber
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressnumber");
			}
			
			set
			{
				this.SetAttributeValue("addressnumber", value);
			}
		}
		
		/// <summary>
		/// Select the address type, such as primary or billing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresstypecode")]
		public virtual CustomerAddress_AddressTypeCode? AddressTypeCode
		{
			
			get
			{
				return ((CustomerAddress_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "addresstypecode")));
			}
			
			set
			{
				this.SetAttributeValue("addresstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresstypecodename")]
		public string AddressTypeCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("addresstypecode"))
				{
					return this.FormattedValues["addresstypecode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Type the city for the customer's address to help identify the location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("city")]
		public string City
		{
			
			get
			{
				return this.GetAttributeValue<string>("city");
			}
			
			set
			{
				this.SetAttributeValue("city", value);
			}
		}
		
		/// <summary>
		/// Shows the complete address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("composite")]
		public string Composite
		{
			
			get
			{
				return this.GetAttributeValue<string>("composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("country")]
		public string Country
		{
			
			get
			{
				return this.GetAttributeValue<string>("country");
			}
			
			set
			{
				this.SetAttributeValue("country", value);
			}
		}
		
		/// <summary>
		/// Type the county for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("county")]
		public string County
		{
			
			get
			{
				return this.GetAttributeValue<string>("county");
			}
			
			set
			{
				this.SetAttributeValue("county", value);
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Unique identifier of the customer address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customeraddressid")]
		public System.Nullable<System.Guid> CustomerAddressId
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("customeraddressid");
			}
			
			set
			{
				this.SetAttributeValue("customeraddressid", value);
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customeraddressid")]
		public override System.Guid Id
		{
			
			get
			{
				return base.Id;
			}
			
			set
			{
				this.CustomerAddressId = value;
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
		/// Type the fax number associated with the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			
			set
			{
				this.SetAttributeValue("fax", value);
			}
		}
		
		/// <summary>
		/// Select the freight terms to make sure shipping charges are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public virtual CustomerAddress_FreightTermsCode? FreightTermsCode
		{
			
			get
			{
				return ((CustomerAddress_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "freighttermscode")));
			}
			
			set
			{
				this.SetAttributeValue("freighttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscodename")]
		public string FreightTermsCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("freighttermscode"))
				{
					return this.FormattedValues["freighttermscode"];
				}
				else
				{
					return default(string);
				}
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
				this.SetAttributeValue("importsequencenumber", value);
			}
		}
		
		/// <summary>
		/// Type the latitude value for the customer's address, for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("latitude")]
		public System.Nullable<double> Latitude
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("latitude");
			}
			
			set
			{
				this.SetAttributeValue("latitude", value);
			}
		}
		
		/// <summary>
		/// Type the first line of the customer's address to help identify the location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line1")]
		public string Line1
		{
			
			get
			{
				return this.GetAttributeValue<string>("line1");
			}
			
			set
			{
				this.SetAttributeValue("line1", value);
			}
		}
		
		/// <summary>
		/// Type the second line of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line2")]
		public string Line2
		{
			
			get
			{
				return this.GetAttributeValue<string>("line2");
			}
			
			set
			{
				this.SetAttributeValue("line2", value);
			}
		}
		
		/// <summary>
		/// Type the third line of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line3")]
		public string Line3
		{
			
			get
			{
				return this.GetAttributeValue<string>("line3");
			}
			
			set
			{
				this.SetAttributeValue("line3", value);
			}
		}
		
		/// <summary>
		/// Type the longitude value for the customer's address, for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("longitude")]
		public System.Nullable<double> Longitude
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("longitude");
			}
			
			set
			{
				this.SetAttributeValue("longitude", value);
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
		/// Type a descriptive name for the customer's address, such as Corporate Headquarters.
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
		/// Shows the type code of the customer record to indicate whether the address belongs to a customer account or contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			
			set
			{
				this.SetAttributeValue("objecttypecode", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecodename")]
		public string ObjectTypeCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("objecttypecode"))
				{
					return this.FormattedValues["objecttypecode"];
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
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
		/// Shows the business unit that the record owner belongs to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the customer address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Choose the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentId
		{
			
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentid");
			}
			
			set
			{
				this.SetAttributeValue("parentid", value);
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postalcode")]
		public string PostalCode
		{
			
			get
			{
				return this.GetAttributeValue<string>("postalcode");
			}
			
			set
			{
				this.SetAttributeValue("postalcode", value);
			}
		}
		
		/// <summary>
		/// Type the post office box number of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postofficebox")]
		public string PostOfficeBox
		{
			
			get
			{
				return this.GetAttributeValue<string>("postofficebox");
			}
			
			set
			{
				this.SetAttributeValue("postofficebox", value);
			}
		}
		
		/// <summary>
		/// Type the name of the primary contact person for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactname")]
		public string PrimaryContactName
		{
			
			get
			{
				return this.GetAttributeValue<string>("primarycontactname");
			}
			
			set
			{
				this.SetAttributeValue("primarycontactname", value);
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public virtual CustomerAddress_ShippingMethodCode? ShippingMethodCode
		{
			
			get
			{
				return ((CustomerAddress_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			
			set
			{
				this.SetAttributeValue("shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcodename")]
		public string ShippingMethodCodeName
		{
			
			get
			{
				if (this.FormattedValues.Contains("shippingmethodcode"))
				{
					return this.FormattedValues["shippingmethodcode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Type the state or province of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stateorprovince")]
		public string StateOrProvince
		{
			
			get
			{
				return this.GetAttributeValue<string>("stateorprovince");
			}
			
			set
			{
				this.SetAttributeValue("stateorprovince", value);
			}
		}
		
		/// <summary>
		/// Type the primary phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			
			set
			{
				this.SetAttributeValue("telephone1", value);
			}
		}
		
		/// <summary>
		/// Type a second phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			
			set
			{
				this.SetAttributeValue("telephone2", value);
			}
		}
		
		/// <summary>
		/// Type a third phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			
			set
			{
				this.SetAttributeValue("telephone3", value);
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
		/// Type the UPS zone of the customer's address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("upszone")]
		public string UPSZone
		{
			
			get
			{
				return this.GetAttributeValue<string>("upszone");
			}
			
			set
			{
				this.SetAttributeValue("upszone", value);
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
		/// Select the time zone for the address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcoffset")]
		public System.Nullable<int> UTCOffset
		{
			
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcoffset");
			}
			
			set
			{
				this.SetAttributeValue("utcoffset", value);
			}
		}
		
		/// <summary>
		/// Version number of the customer address.
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
		/// N:1 Account_CustomerAddress
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_CustomerAddress")]
		public SWA.CRM.D365.Entities.Base.Account Account_CustomerAddress
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Account>("Account_CustomerAddress", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Account>("Account_CustomerAddress", null, value);
			}
		}
		
		/// <summary>
		/// N:1 Contact_CustomerAddress
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_CustomerAddress")]
		public SWA.CRM.D365.Entities.Base.Contact Contact_CustomerAddress
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.Contact>("Contact_CustomerAddress", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.Contact>("Contact_CustomerAddress", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_customeraddress_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_createdonbehalfby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_customeraddress_createdonbehalfby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_customeraddress_createdonbehalfby", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_customeraddress_createdonbehalfby", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_customeraddress_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_modifiedonbehalfby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_customeraddress_modifiedonbehalfby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_customeraddress_modifiedonbehalfby", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_customeraddress_modifiedonbehalfby", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_customeraddressbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_createdby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_customeraddressbase_createdby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_customeraddressbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_customeraddressbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_modifiedby")]
		public SWA.CRM.D365.Entities.Base.SystemUser lk_customeraddressbase_modifiedby
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.SystemUser>("lk_customeraddressbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_CustomerAddress
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_CustomerAddress")]
		public SWA.CRM.D365.Entities.Base.TransactionCurrency TransactionCurrency_CustomerAddress
		{
			
			get
			{
				return this.GetRelatedEntity<SWA.CRM.D365.Entities.Base.TransactionCurrency>("TransactionCurrency_CustomerAddress", null);
			}
			
			set
			{
				this.SetRelatedEntity<SWA.CRM.D365.Entities.Base.TransactionCurrency>("TransactionCurrency_CustomerAddress", null, value);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		
		public CustomerAddress(object anonymousType) : 
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
                        Attributes["customeraddressid"] = base.Id;
                        break;
                    case "customeraddressid":
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
