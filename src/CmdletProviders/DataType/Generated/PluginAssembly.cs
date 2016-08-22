using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("pluginassembly")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public partial class PluginAssembly : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "pluginassembly";
    public const int EntityTypeCode = 4605;

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

    [AttributeLogicalName("culture")]
    public string Culture
    {
      get
      {
        return this.GetAttributeValue<string>("culture");
      }
      set
      {
        this.OnPropertyChanging("Culture");
        this.SetAttributeValue("culture", (object) value);
        this.OnPropertyChanged("Culture");
      }
    }

    [AttributeLogicalName("customizationlevel")]
    public int? CustomizationLevel
    {
      get
      {
        return this.GetAttributeValue<int?>("customizationlevel");
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

    [AttributeLogicalName("isolationmode")]
    public OptionSetValue IsolationMode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("isolationmode");
      }
      set
      {
        this.OnPropertyChanging("IsolationMode");
        this.SetAttributeValue("isolationmode", (object) value);
        this.OnPropertyChanged("IsolationMode");
      }
    }

    [AttributeLogicalName("major")]
    public int? Major
    {
      get
      {
        return this.GetAttributeValue<int?>("major");
      }
    }

    [AttributeLogicalName("minor")]
    public int? Minor
    {
      get
      {
        return this.GetAttributeValue<int?>("minor");
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

    [AttributeLogicalName("path")]
    public string Path
    {
      get
      {
        return this.GetAttributeValue<string>("path");
      }
      set
      {
        this.OnPropertyChanging("Path");
        this.SetAttributeValue("path", (object) value);
        this.OnPropertyChanged("Path");
      }
    }

    [AttributeLogicalName("pluginassemblyid")]
    public Guid? PluginAssemblyId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("pluginassemblyid");
      }
      set
      {
        this.OnPropertyChanging("PluginAssemblyId");
        this.SetAttributeValue("pluginassemblyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("PluginAssemblyId");
      }
    }

    [AttributeLogicalName("pluginassemblyid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.PluginAssemblyId = new Guid?(value);
      }
    }

    [AttributeLogicalName("pluginassemblyidunique")]
    public Guid? PluginAssemblyIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("pluginassemblyidunique");
      }
    }

    [AttributeLogicalName("publickeytoken")]
    public string PublicKeyToken
    {
      get
      {
        return this.GetAttributeValue<string>("publickeytoken");
      }
      set
      {
        this.OnPropertyChanging("PublicKeyToken");
        this.SetAttributeValue("publickeytoken", (object) value);
        this.OnPropertyChanged("PublicKeyToken");
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

    [AttributeLogicalName("sourcehash")]
    public string SourceHash
    {
      get
      {
        return this.GetAttributeValue<string>("sourcehash");
      }
      set
      {
        this.OnPropertyChanging("SourceHash");
        this.SetAttributeValue("sourcehash", (object) value);
        this.OnPropertyChanged("SourceHash");
      }
    }

    [AttributeLogicalName("sourcetype")]
    public OptionSetValue SourceType
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("sourcetype");
      }
      set
      {
        this.OnPropertyChanging("SourceType");
        this.SetAttributeValue("sourcetype", (object) value);
        this.OnPropertyChanged("SourceType");
      }
    }

    [AttributeLogicalName("version")]
    public string Version
    {
      get
      {
        return this.GetAttributeValue<string>("version");
      }
      set
      {
        this.OnPropertyChanging("Version");
        this.SetAttributeValue("version", (object) value);
        this.OnPropertyChanged("Version");
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

    [RelationshipSchemaName("pluginassembly_plugintype")]
    public IEnumerable<PluginType> pluginassembly_plugintype
    {
      get
      {
        return this.GetRelatedEntities<PluginType>("pluginassembly_plugintype", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("pluginassembly_plugintype");
        this.SetRelatedEntities<PluginType>("pluginassembly_plugintype", new EntityRole?(), value);
        this.OnPropertyChanged("pluginassembly_plugintype");
      }
    }

    [RelationshipSchemaName("createdby_pluginassembly")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_pluginassembly
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_pluginassembly", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_pluginassembly_createdonbehalfby")]
    public SystemUser lk_pluginassembly_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_pluginassembly_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_pluginassembly_modifiedonbehalfby")]
    public SystemUser lk_pluginassembly_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_pluginassembly_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_pluginassembly")]
    public SystemUser modifiedby_pluginassembly
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_pluginassembly", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public PluginAssembly()
      : base("pluginassembly")
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
