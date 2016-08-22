using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageprocessingstep")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class SdkMessageProcessingStep : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageprocessingstep";
    public const int EntityTypeCode = 4608;

    [AttributeLogicalName("asyncautodelete")]
    public bool? AsyncAutoDelete
    {
      get
      {
        return this.GetAttributeValue<bool?>("asyncautodelete");
      }
      set
      {
        this.OnPropertyChanging("AsyncAutoDelete");
        this.SetAttributeValue("asyncautodelete", (object) value);
        this.OnPropertyChanged("AsyncAutoDelete");
      }
    }

    [AttributeLogicalName("canusereadonlyconnection")]
    public bool? CanUseReadOnlyConnection
    {
      get
      {
        return this.GetAttributeValue<bool?>("canusereadonlyconnection");
      }
      set
      {
        this.OnPropertyChanging("CanUseReadOnlyConnection");
        this.SetAttributeValue("canusereadonlyconnection", (object) value);
        this.OnPropertyChanged("CanUseReadOnlyConnection");
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

    [AttributeLogicalName("configuration")]
    public string Configuration
    {
      get
      {
        return this.GetAttributeValue<string>("configuration");
      }
      set
      {
        this.OnPropertyChanging("Configuration");
        this.SetAttributeValue("configuration", (object) value);
        this.OnPropertyChanged("Configuration");
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

    [AttributeLogicalName("eventhandler")]
    public EntityReference EventHandler
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("eventhandler");
      }
      set
      {
        this.OnPropertyChanging("EventHandler");
        this.SetAttributeValue("eventhandler", (object) value);
        this.OnPropertyChanged("EventHandler");
      }
    }

    [AttributeLogicalName("filteringattributes")]
    public string FilteringAttributes
    {
      get
      {
        return this.GetAttributeValue<string>("filteringattributes");
      }
      set
      {
        this.OnPropertyChanging("FilteringAttributes");
        this.SetAttributeValue("filteringattributes", (object) value);
        this.OnPropertyChanged("FilteringAttributes");
      }
    }

    [AttributeLogicalName("impersonatinguserid")]
    public EntityReference ImpersonatingUserId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("impersonatinguserid");
      }
      set
      {
        this.OnPropertyChanging("ImpersonatingUserId");
        this.SetAttributeValue("impersonatinguserid", (object) value);
        this.OnPropertyChanged("ImpersonatingUserId");
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

    [AttributeLogicalName("invocationsource")]
    [Obsolete]
    public OptionSetValue InvocationSource
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("invocationsource");
      }
      set
      {
        this.OnPropertyChanging("InvocationSource");
        this.SetAttributeValue("invocationsource", (object) value);
        this.OnPropertyChanged("InvocationSource");
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

    [AttributeLogicalName("mode")]
    public OptionSetValue Mode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("mode");
      }
      set
      {
        this.OnPropertyChanging("Mode");
        this.SetAttributeValue("mode", (object) value);
        this.OnPropertyChanged("Mode");
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

    [AttributeLogicalName("plugintypeid")]
    [Obsolete]
    public EntityReference PluginTypeId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("plugintypeid");
      }
      set
      {
        this.OnPropertyChanging("PluginTypeId");
        this.SetAttributeValue("plugintypeid", (object) value);
        this.OnPropertyChanged("PluginTypeId");
      }
    }

    [AttributeLogicalName("rank")]
    public int? Rank
    {
      get
      {
        return this.GetAttributeValue<int?>("rank");
      }
      set
      {
        this.OnPropertyChanging("Rank");
        this.SetAttributeValue("rank", (object) value);
        this.OnPropertyChanged("Rank");
      }
    }

    [AttributeLogicalName("sdkmessagefilterid")]
    public EntityReference SdkMessageFilterId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessagefilterid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageFilterId");
        this.SetAttributeValue("sdkmessagefilterid", (object) value);
        this.OnPropertyChanged("SdkMessageFilterId");
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public EntityReference SdkMessageId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessageid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageId");
        this.SetAttributeValue("sdkmessageid", (object) value);
        this.OnPropertyChanged("SdkMessageId");
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepid")]
    public Guid? SdkMessageProcessingStepId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageprocessingstepid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageProcessingStepId");
        this.SetAttributeValue("sdkmessageprocessingstepid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageProcessingStepId");
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageProcessingStepId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepidunique")]
    public Guid? SdkMessageProcessingStepIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageprocessingstepidunique");
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
    public EntityReference SdkMessageProcessingStepSecureConfigId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessageprocessingstepsecureconfigid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
        this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", (object) value);
        this.OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
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

    [AttributeLogicalName("stage")]
    public OptionSetValue Stage
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("stage");
      }
      set
      {
        this.OnPropertyChanging("Stage");
        this.SetAttributeValue("stage", (object) value);
        this.OnPropertyChanged("Stage");
      }
    }

    [AttributeLogicalName("statecode")]
    public SdkMessageProcessingStepState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new SdkMessageProcessingStepState?((SdkMessageProcessingStepState) Enum.ToObject(typeof (SdkMessageProcessingStepState), attributeValue.Value));
        return new SdkMessageProcessingStepState?();
      }
      set
      {
        this.OnPropertyChanging("StateCode");
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged("StateCode");
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("statuscode");
      }
      set
      {
        this.OnPropertyChanging("StatusCode");
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged("StatusCode");
      }
    }

    [AttributeLogicalName("supporteddeployment")]
    public OptionSetValue SupportedDeployment
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("supporteddeployment");
      }
      set
      {
        this.OnPropertyChanging("SupportedDeployment");
        this.SetAttributeValue("supporteddeployment", (object) value);
        this.OnPropertyChanged("SupportedDeployment");
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

    [RelationshipSchemaName("SdkMessageProcessingStep_AsyncOperations")]
    public IEnumerable<AsyncOperation> SdkMessageProcessingStep_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("SdkMessageProcessingStep_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("SdkMessageProcessingStep_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("SdkMessageProcessingStep_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("SdkMessageProcessingStep_AsyncOperations");
      }
    }

    [RelationshipSchemaName("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
    public IEnumerable<SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
        this.SetRelatedEntities<SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessageprocessingstep")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessageprocessingstep", new EntityRole?());
      }
    }

    [RelationshipSchemaName("impersonatinguserid_sdkmessageprocessingstep")]
    [AttributeLogicalName("impersonatinguserid")]
    public SystemUser impersonatinguserid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("impersonatinguserid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("impersonatinguserid_sdkmessageprocessingstep");
        this.SetRelatedEntity<SystemUser>("impersonatinguserid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("impersonatinguserid_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("lk_sdkmessageprocessingstep_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstep_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstep_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstep_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstep_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageprocessingstep")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser modifiedby_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessageprocessingstep", new EntityRole?());
      }
    }

    [AttributeLogicalName("eventhandler")]
    [RelationshipSchemaName("plugintype_sdkmessageprocessingstep")]
    public PluginType plugintype_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<PluginType>("plugintype_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("plugintype_sdkmessageprocessingstep");
        this.SetRelatedEntity<PluginType>("plugintype_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("plugintype_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("plugintypeid_sdkmessageprocessingstep")]
    [AttributeLogicalName("plugintypeid")]
    public PluginType plugintypeid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<PluginType>("plugintypeid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
        this.SetRelatedEntity<PluginType>("plugintypeid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("sdkmessagefilterid_sdkmessageprocessingstep")]
    [AttributeLogicalName("sdkmessagefilterid")]
    public SdkMessageFilter sdkmessagefilterid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
        this.SetRelatedEntity<SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("sdkmessageid_sdkmessageprocessingstep")]
    [AttributeLogicalName("sdkmessageid")]
    public SdkMessage sdkmessageid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
        this.SetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
    [RelationshipSchemaName("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
    public SdkMessageProcessingStepSecureConfig sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
        this.SetRelatedEntity<SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
      }
    }

    [AttributeLogicalName("eventhandler")]
    [RelationshipSchemaName("serviceendpoint_sdkmessageprocessingstep")]
    public ServiceEndpoint serviceendpoint_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<ServiceEndpoint>("serviceendpoint_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("serviceendpoint_sdkmessageprocessingstep");
        this.SetRelatedEntity<ServiceEndpoint>("serviceendpoint_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("serviceendpoint_sdkmessageprocessingstep");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessageProcessingStep()
      : base("sdkmessageprocessingstep")
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
