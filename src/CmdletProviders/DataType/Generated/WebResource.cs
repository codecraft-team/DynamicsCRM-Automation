using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("webresource")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class WebResource : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "webresource";
    public const int EntityTypeCode = 9333;

    [AttributeLogicalName("canbedeleted")]
    public BooleanManagedProperty CanBeDeleted
    {
      get
      {
        return this.GetAttributeValue<BooleanManagedProperty>("canbedeleted");
      }
      set
      {
        this.OnPropertyChanging("CanBeDeleted");
        this.SetAttributeValue("canbedeleted", (object) value);
        this.OnPropertyChanged("CanBeDeleted");
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("componentstate");
      }
    }

    [AttributeLogicalName("content")]
    public string Content
    {
      get
      {
        return this.GetAttributeValue<string>("content");
      }
      set
      {
        this.OnPropertyChanging("Content");
        this.SetAttributeValue("content", (object) value);
        this.OnPropertyChanged("Content");
      }
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("createdby");
      }
    }

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("createdon");
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("createdonbehalfby");
      }
    }

    [AttributeLogicalName("description")]
    public string Description
    {
      get
      {
        return this.GetAttributeValue<string>("description");
      }
      set
      {
        this.OnPropertyChanging("Description");
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged("Description");
      }
    }

    [AttributeLogicalName("displayname")]
    public string DisplayName
    {
      get
      {
        return this.GetAttributeValue<string>("displayname");
      }
      set
      {
        this.OnPropertyChanging("DisplayName");
        this.SetAttributeValue("displayname", (object) value);
        this.OnPropertyChanged("DisplayName");
      }
    }

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get
      {
        return this.GetAttributeValue<string>("introducedversion");
      }
      set
      {
        this.OnPropertyChanging("IntroducedVersion");
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged("IntroducedVersion");
      }
    }

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get
      {
        return this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      }
      set
      {
        this.OnPropertyChanging("IsCustomizable");
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged("IsCustomizable");
      }
    }

    [AttributeLogicalName("isenabledformobileclient")]
    public bool? IsEnabledForMobileClient
    {
      get
      {
        return this.GetAttributeValue<bool?>("isenabledformobileclient");
      }
      set
      {
        this.OnPropertyChanging("IsEnabledForMobileClient");
        this.SetAttributeValue("isenabledformobileclient", (object) value);
        this.OnPropertyChanged("IsEnabledForMobileClient");
      }
    }

    [AttributeLogicalName("ishidden")]
    public BooleanManagedProperty IsHidden
    {
      get
      {
        return this.GetAttributeValue<BooleanManagedProperty>("ishidden");
      }
      set
      {
        this.OnPropertyChanging("IsHidden");
        this.SetAttributeValue("ishidden", (object) value);
        this.OnPropertyChanged("IsHidden");
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged
    {
      get
      {
        return this.GetAttributeValue<bool?>("ismanaged");
      }
    }

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get
      {
        return this.GetAttributeValue<int?>("languagecode");
      }
      set
      {
        this.OnPropertyChanging("LanguageCode");
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged("LanguageCode");
      }
    }

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("modifiedby");
      }
    }

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("modifiedon");
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
      }
    }

    [AttributeLogicalName("name")]
    public string Name
    {
      get
      {
        return this.GetAttributeValue<string>("name");
      }
      set
      {
        this.OnPropertyChanging("Name");
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged("Name");
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("organizationid");
      }
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("overwritetime");
      }
    }

    [AttributeLogicalName("silverlightversion")]
    public string SilverlightVersion
    {
      get
      {
        return this.GetAttributeValue<string>("silverlightversion");
      }
      set
      {
        this.OnPropertyChanging("SilverlightVersion");
        this.SetAttributeValue("silverlightversion", (object) value);
        this.OnPropertyChanged("SilverlightVersion");
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("solutionid");
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber
    {
      get
      {
        return this.GetAttributeValue<long?>("versionnumber");
      }
    }

    [AttributeLogicalName("webresourceid")]
    public Guid? WebResourceId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("webresourceid");
      }
      set
      {
        this.OnPropertyChanging("WebResourceId");
        this.SetAttributeValue("webresourceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("WebResourceId");
      }
    }

    [AttributeLogicalName("webresourceid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.WebResourceId = new Guid?(value);
      }
    }

    [AttributeLogicalName("webresourceidunique")]
    public Guid? WebResourceIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("webresourceidunique");
      }
    }

    [AttributeLogicalName("webresourcetype")]
    public OptionSetValue WebResourceType
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("webresourcetype");
      }
      set
      {
        this.OnPropertyChanging("WebResourceType");
        this.SetAttributeValue("webresourcetype", (object) value);
        this.OnPropertyChanged("WebResourceType");
      }
    }

    [RelationshipSchemaName("solution_configuration_webresource")]
    public IEnumerable<Solution> solution_configuration_webresource
    {
      get
      {
        return this.GetRelatedEntities<Solution>("solution_configuration_webresource", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("solution_configuration_webresource");
        this.SetRelatedEntities<Solution>("solution_configuration_webresource", new EntityRole?(), value);
        this.OnPropertyChanged("solution_configuration_webresource");
      }
    }

    [RelationshipSchemaName("lk_webresourcebase_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_webresourcebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_webresourcebase_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_webresourcebase_modifiedonbehalfby")]
    public SystemUser lk_webresourcebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_webresourcebase_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("webresource_createdby")]
    public SystemUser webresource_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("webresource_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("webresource_modifiedby")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser webresource_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("webresource_modifiedby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public WebResource()
      : base("webresource")
    {
    }

    private void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnPropertyChanging(string propertyName)
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, new PropertyChangingEventArgs(propertyName));
    }
  }
}
