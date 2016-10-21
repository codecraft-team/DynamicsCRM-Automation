using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("plugintype")]
  public partial class PluginType : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "plugintype";
    public const int EntityTypeCode = 4602;

    [AttributeLogicalName("assemblyname")]
    public string AssemblyName
    {
      get
      {
        return this.GetAttributeValue<string>("assemblyname");
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
    }

    [AttributeLogicalName("customizationlevel")]
    public int? CustomizationLevel
    {
      get
      {
        return this.GetAttributeValue<int?>("customizationlevel");
      }
    }

    [AttributeLogicalName("customworkflowactivityinfo")]
    public string CustomWorkflowActivityInfo
    {
      get
      {
        return this.GetAttributeValue<string>("customworkflowactivityinfo");
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

    [AttributeLogicalName("friendlyname")]
    public string FriendlyName
    {
      get
      {
        return this.GetAttributeValue<string>("friendlyname");
      }
      set
      {
        this.OnPropertyChanging("FriendlyName");
        this.SetAttributeValue("friendlyname", (object) value);
        this.OnPropertyChanged("FriendlyName");
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

    [AttributeLogicalName("isworkflowactivity")]
    public bool? IsWorkflowActivity
    {
      get
      {
        return this.GetAttributeValue<bool?>("isworkflowactivity");
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

    [AttributeLogicalName("pluginassemblyid")]
    public EntityReference PluginAssemblyId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("pluginassemblyid");
      }
      set
      {
        this.OnPropertyChanging("PluginAssemblyId");
        this.SetAttributeValue("pluginassemblyid", (object) value);
        this.OnPropertyChanged("PluginAssemblyId");
      }
    }

    [AttributeLogicalName("plugintypeid")]
    public Guid? PluginTypeId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("plugintypeid");
      }
      set
      {
        this.OnPropertyChanging("PluginTypeId");
        this.SetAttributeValue("plugintypeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("PluginTypeId");
      }
    }

    [AttributeLogicalName("plugintypeid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.PluginTypeId = new Guid?(value);
      }
    }

    [AttributeLogicalName("plugintypeidunique")]
    public Guid? PluginTypeIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("plugintypeidunique");
      }
    }

    [AttributeLogicalName("publickeytoken")]
    public string PublicKeyToken
    {
      get
      {
        return this.GetAttributeValue<string>("publickeytoken");
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

    [AttributeLogicalName("typename")]
    public string TypeName
    {
      get
      {
        return this.GetAttributeValue<string>("typename");
      }
      set
      {
        this.OnPropertyChanging("TypeName");
        this.SetAttributeValue("typename", (object) value);
        this.OnPropertyChanged("TypeName");
      }
    }

    [AttributeLogicalName("version")]
    public string Version
    {
      get
      {
        return this.GetAttributeValue<string>("version");
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

    [AttributeLogicalName("workflowactivitygroupname")]
    public string WorkflowActivityGroupName
    {
      get
      {
        return this.GetAttributeValue<string>("workflowactivitygroupname");
      }
      set
      {
        this.OnPropertyChanging("WorkflowActivityGroupName");
        this.SetAttributeValue("workflowactivitygroupname", (object) value);
        this.OnPropertyChanged("WorkflowActivityGroupName");
      }
    }

    [RelationshipSchemaName("plugintype_plugintypestatistic")]
    public IEnumerable<PluginTypeStatistic> plugintype_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntities<PluginTypeStatistic>("plugintype_plugintypestatistic", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("plugintype_plugintypestatistic");
        this.SetRelatedEntities<PluginTypeStatistic>("plugintype_plugintypestatistic", new EntityRole?(), value);
        this.OnPropertyChanged("plugintype_plugintypestatistic");
      }
    }

    [RelationshipSchemaName("plugintype_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> plugintype_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("plugintype_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("plugintype_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("plugintype_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("plugintype_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("plugintypeid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> plugintypeid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("plugintypeid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("plugintypeid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_plugintype")]
    public SystemUser createdby_plugintype
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_plugintype", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_plugintype_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_plugintype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_plugintype_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_plugintype_modifiedonbehalfby")]
    public SystemUser lk_plugintype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_plugintype_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("modifiedby_plugintype")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser modifiedby_plugintype
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_plugintype", new EntityRole?());
      }
    }

    [AttributeLogicalName("pluginassemblyid")]
    [RelationshipSchemaName("pluginassembly_plugintype")]
    public PluginAssembly pluginassembly_plugintype
    {
      get
      {
        return this.GetRelatedEntity<PluginAssembly>("pluginassembly_plugintype", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("pluginassembly_plugintype");
        this.SetRelatedEntity<PluginAssembly>("pluginassembly_plugintype", new EntityRole?(), value);
        this.OnPropertyChanged("pluginassembly_plugintype");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public PluginType()
      : base("plugintype")
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
