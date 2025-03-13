namespace SWA.CRM.D365.Entities.Base
{
    /// <summary>
	/// Template for an email message that contains the standard attributes of an email message.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("template")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.1.0.7629")]
    public partial class Template : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Template() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "template";

        public const int EntityTypeCode = 2010;

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
        /// Body text of the email template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("body")]
        public string Body
        {
            get
            {
                return this.GetAttributeValue<string>("body");
            }
            set
            {
                this.OnPropertyChanging("Body");
                this.SetAttributeValue("body", value);
                this.OnPropertyChanged("Body");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the email template.
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
        /// Date and time when the email template was created.
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
        /// Unique identifier of the delegate user who created the template.
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
        /// Description of the email template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get
            {
                return this.GetAttributeValue<string>("description");
            }
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("generationtypecode")]
        public System.Nullable<int> GenerationTypeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("generationtypecode");
            }
            set
            {
                this.OnPropertyChanging("GenerationTypeCode");
                this.SetAttributeValue("generationtypecode", value);
                this.OnPropertyChanged("GenerationTypeCode");
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
        /// Version in which the form is introduced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
        public string IntroducedVersion
        {
            get
            {
                return this.GetAttributeValue<string>("introducedversion");
            }
            set
            {
                this.OnPropertyChanging("IntroducedVersion");
                this.SetAttributeValue("introducedversion", value);
                this.OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
            }
            set
            {
                this.OnPropertyChanging("IsCustomizable");
                this.SetAttributeValue("iscustomizable", value);
                this.OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
            }
        }

        /// <summary>
        /// Information about whether the template is personal or is available to all users.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispersonal")]
        public System.Nullable<bool> IsPersonal
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ispersonal");
            }
            set
            {
                this.OnPropertyChanging("IsPersonal");
                this.SetAttributeValue("ispersonal", value);
                this.OnPropertyChanged("IsPersonal");
            }
        }

        /// <summary>
        /// Indicates if a template is recommended by Dynamics 365.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrecommended")]
        public System.Nullable<bool> IsRecommended
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isrecommended");
            }
        }

        /// <summary>
        /// Language of the email template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
        public System.Nullable<int> LanguageCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("languagecode");
            }
            set
            {
                this.OnPropertyChanging("LanguageCode");
                this.SetAttributeValue("languagecode", value);
                this.OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        /// MIME type of the email template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType
        {
            get
            {
                return this.GetAttributeValue<string>("mimetype");
            }
            set
            {
                this.OnPropertyChanging("MimeType");
                this.SetAttributeValue("mimetype", value);
                this.OnPropertyChanged("MimeType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the template.
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
        /// Date and time when the email template was last modified.
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
        /// Unique identifier of the delegate user who last modified the template.
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
        /// For internal use only. Shows the number of times emails that use this template have been opened.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opencount")]
        public System.Nullable<int> OpenCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("opencount");
            }
        }

        /// <summary>
        /// Shows the open rate of this template. This is based on number of opens on followed emails that use this template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrate")]
        public System.Nullable<int> OpenRate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("openrate");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the template for the email activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the template.
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
        /// Unique identifier of the team who owns the template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
        }

        /// <summary>
        /// Unique identifier of the user who owns the template.
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
        /// XML data for the body of the email template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentationxml")]
        public string PresentationXml
        {
            get
            {
                return this.GetAttributeValue<string>("presentationxml");
            }
            set
            {
                this.OnPropertyChanging("PresentationXml");
                this.SetAttributeValue("presentationxml", value);
                this.OnPropertyChanged("PresentationXml");
            }
        }

        /// <summary>
        /// For internal use only. Shows the number of times emails that use this template have received replies.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("replycount")]
        public System.Nullable<int> ReplyCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("replycount");
            }
        }

        /// <summary>
        /// Shows the reply rate for this template. This is based on number of replies received on followed emails that use this template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("replyrate")]
        public System.Nullable<int> ReplyRate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("replyrate");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
            }
        }

        /// <summary>
        /// Subject associated with the email template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get
            {
                return this.GetAttributeValue<string>("subject");
            }
            set
            {
                this.OnPropertyChanging("Subject");
                this.SetAttributeValue("subject", value);
                this.OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// XML data for the subject of the email template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectpresentationxml")]
        public string SubjectPresentationXml
        {
            get
            {
                return this.GetAttributeValue<string>("subjectpresentationxml");
            }
            set
            {
                this.OnPropertyChanging("SubjectPresentationXml");
                this.SetAttributeValue("subjectpresentationxml", value);
                this.OnPropertyChanged("SubjectPresentationXml");
            }
        }

        /// <summary>
        /// Unique identifier of the template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("templateid")]
        public System.Nullable<System.Guid> TemplateId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("templateid");
            }
            set
            {
                this.OnPropertyChanging("TemplateId");
                this.SetAttributeValue("templateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TemplateId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("templateid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.TemplateId = value;
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("templateidunique")]
        public System.Nullable<System.Guid> TemplateIdUnique
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("templateidunique");
            }
        }

        /// <summary>
        /// Type of email template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("templatetypecode")]
        public string TemplateTypeCode
        {
            get
            {
                return this.GetAttributeValue<string>("templatetypecode");
            }
            set
            {
                this.OnPropertyChanging("TemplateTypeCode");
                this.SetAttributeValue("templatetypecode", value);
                this.OnPropertyChanged("TemplateTypeCode");
            }
        }

        /// <summary>
        /// Title of the template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get
            {
                return this.GetAttributeValue<string>("title");
            }
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Shows the number of sent emails that use this template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usedcount")]
        public System.Nullable<int> UsedCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("usedcount");
            }
        }

        /// <summary>
        /// Version number of the template.
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
        /// 1:N Email_EmailTemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_EmailTemplate")]
        public System.Collections.Generic.IEnumerable<Email> Email_EmailTemplate
        {
            get
            {
                return this.GetRelatedEntities<Email>("Email_EmailTemplate", null);
            }
            set
            {
                this.OnPropertyChanging("Email_EmailTemplate");
                this.SetRelatedEntities<Email>("Email_EmailTemplate", null, value);
                this.OnPropertyChanged("Email_EmailTemplate");
            }
        }

        /// <summary>
        /// N:1 lk_templatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_createdby")]
        public SystemUser lk_templatebase_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_templatebase_createdby", null);
            }
        }

        /// <summary>
        /// N:1 lk_templatebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_createdonbehalfby")]
        public SystemUser lk_templatebase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_templatebase_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_templatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_modifiedby")]
        public SystemUser lk_templatebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_templatebase_modifiedby", null);
            }
        }

        /// <summary>
        /// N:1 lk_templatebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_modifiedonbehalfby")]
        public SystemUser lk_templatebase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_templatebase_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 system_user_email_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_email_templates")]
        public SystemUser system_user_email_templates
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("system_user_email_templates", null);
            }
        }
    }
}
