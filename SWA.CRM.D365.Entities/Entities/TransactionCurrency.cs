namespace SWA.CRM.D365.Entities.Base
{
    /// <summary>
	/// Currency in which a financial transaction is carried out.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("transactioncurrency")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.1.0.7629")]
    public partial class TransactionCurrency : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TransactionCurrency() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "transactioncurrency";

        public const int EntityTypeCode = 9105;

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
        /// Unique identifier of the user who created the transaction currency.
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
        /// Date and time when the transaction currency was created.
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
        /// Unique identifier of the delegate user who created the transactioncurrency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }

        /// <summary>
        /// Name of the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyname")]
        public string CurrencyName
        {
            get
            {
                return this.GetAttributeValue<string>("currencyname");
            }
            set
            {
                this.OnPropertyChanging("CurrencyName");
                this.SetAttributeValue("currencyname", value);
                this.OnPropertyChanged("CurrencyName");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used for currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyprecision")]
        public System.Nullable<int> CurrencyPrecision
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currencyprecision");
            }
            set
            {
                this.OnPropertyChanging("CurrencyPrecision");
                this.SetAttributeValue("currencyprecision", value);
                this.OnPropertyChanged("CurrencyPrecision");
            }
        }

        /// <summary>
        /// Symbol for the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencysymbol")]
        public string CurrencySymbol
        {
            get
            {
                return this.GetAttributeValue<string>("currencysymbol");
            }
            set
            {
                this.OnPropertyChanging("CurrencySymbol");
                this.SetAttributeValue("currencysymbol", value);
                this.OnPropertyChanged("CurrencySymbol");
            }
        }

        /// <summary>
        /// The default image for the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get
            {
                return this.GetAttributeValue<byte[]>("entityimage");
            }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get
            {
                return this.GetAttributeValue<string>("entityimage_url");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
            }
        }

        /// <summary>
        /// Exchange rate between the transaction currency and the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
            set
            {
                this.OnPropertyChanging("ExchangeRate");
                this.SetAttributeValue("exchangerate", value);
                this.OnPropertyChanged("ExchangeRate");
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
        /// ISO currency code for the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isocurrencycode")]
        public string ISOCurrencyCode
        {
            get
            {
                return this.GetAttributeValue<string>("isocurrencycode");
            }
            set
            {
                this.OnPropertyChanging("ISOCurrencyCode");
                this.SetAttributeValue("isocurrencycode", value);
                this.OnPropertyChanged("ISOCurrencyCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the transaction currency.
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
        /// Date and time when the transaction currency was last modified.
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
        /// Unique identifier of the delegate user who last modified the transactioncurrency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
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
        /// Reason for the status of the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
            }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Unique identifier of the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public System.Nullable<System.Guid> TransactionCurrencyId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("transactioncurrencyid");
            }
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.TransactionCurrencyId = value;
            }
        }

        /// <summary>
        /// Version number of the transaction currency.
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
        /// 1:N transactioncurrency_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_account")]
        public System.Collections.Generic.IEnumerable<Account> transactioncurrency_account
        {
            get
            {
                return this.GetRelatedEntities<Account>("transactioncurrency_account", null);
            }
            set
            {
                this.OnPropertyChanging("transactioncurrency_account");
                this.SetRelatedEntities<Account>("transactioncurrency_account", null, value);
                this.OnPropertyChanged("transactioncurrency_account");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_contact")]
        public System.Collections.Generic.IEnumerable<Contact> transactioncurrency_contact
        {
            get
            {
                return this.GetRelatedEntities<Contact>("transactioncurrency_contact", null);
            }
            set
            {
                this.OnPropertyChanging("transactioncurrency_contact");
                this.SetRelatedEntities<Contact>("transactioncurrency_contact", null, value);
                this.OnPropertyChanged("transactioncurrency_contact");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_pricelevel
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_pricelevel")]
        public System.Collections.Generic.IEnumerable<PriceLevel> transactioncurrency_pricelevel
        {
            get
            {
                return this.GetRelatedEntities<PriceLevel>("transactioncurrency_pricelevel", null);
            }
            set
            {
                this.OnPropertyChanging("transactioncurrency_pricelevel");
                this.SetRelatedEntities<PriceLevel>("transactioncurrency_pricelevel", null, value);
                this.OnPropertyChanged("transactioncurrency_pricelevel");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_product")]
        public System.Collections.Generic.IEnumerable<Product> transactioncurrency_product
        {
            get
            {
                return this.GetRelatedEntities<Product>("transactioncurrency_product", null);
            }
            set
            {
                this.OnPropertyChanging("transactioncurrency_product");
                this.SetRelatedEntities<Product>("transactioncurrency_product", null, value);
                this.OnPropertyChanged("transactioncurrency_product");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SystemUser")]
        public System.Collections.Generic.IEnumerable<SystemUser> TransactionCurrency_SystemUser
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("TransactionCurrency_SystemUser", null);
            }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SystemUser");
                this.SetRelatedEntities<SystemUser>("TransactionCurrency_SystemUser", null, value);
                this.OnPropertyChanged("TransactionCurrency_SystemUser");
            }
        }

        /// <summary>
        /// N:1 lk_transactioncurrency_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_createdonbehalfby")]
        public SystemUser lk_transactioncurrency_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_transactioncurrency_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_transactioncurrency_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_modifiedonbehalfby")]
        public SystemUser lk_transactioncurrency_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_transactioncurrency_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_transactioncurrencybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_createdby")]
        public SystemUser lk_transactioncurrencybase_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_transactioncurrencybase_createdby", null);
            }
        }

        /// <summary>
        /// N:1 lk_transactioncurrencybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_modifiedby")]
        public SystemUser lk_transactioncurrencybase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_transactioncurrencybase_modifiedby", null);
            }
        }
    }
}
