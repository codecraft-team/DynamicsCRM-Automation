using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageprocessingstepimage")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class SdkMessageProcessingStepImage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageprocessingstepimage";
    public const int EntityTypeCode = 4615;

    [AttributeLogicalName("attributes")]
    public string Attributes1
    {
      get
      {
        return this.GetAttributeValue<string>("attributes");
      }
      set
      {
        this.OnPropertyChanging("Attributes1");
        this.SetAttributeValue("attributes", (object) value);
        this.OnPropertyChanged("Attributes1");
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

    [AttributeLogicalName("entityalias")]
    public string EntityAlias
    {
      get
      {
        return this.GetAttributeValue<string>("entityalias");
      }
      set
      {
        this.OnPropertyChanging("EntityAlias");
        this.SetAttributeValue("entityalias", (object) value);
        this.OnPropertyChanged("EntityAlias");
      }
    }

    [AttributeLogicalName("imagetype")]
    public OptionSetValue ImageType
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("imagetype");
      }
      set
      {
        this.OnPropertyChanging("ImageType");
        this.SetAttributeValue("imagetype", (object) value);
        this.OnPropertyChanged("ImageType");
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

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged
    {
      get
      {
        return this.GetAttributeValue<bool?>("ismanaged");
      }
    }

    [AttributeLogicalName("messagepropertyname")]
    public string MessagePropertyName
    {
      get
      {
        return this.GetAttributeValue<string>("messagepropertyname");
      }
      set
      {
        this.OnPropertyChanging("MessagePropertyName");
        this.SetAttributeValue("messagepropertyname", (object) value);
        this.OnPropertyChanged("MessagePropertyName");
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

    [AttributeLogicalName("relatedattributename")]
    public string RelatedAttributeName
    {
      get
      {
        return this.GetAttributeValue<string>("relatedattributename");
      }
      set
      {
        this.OnPropertyChanging("RelatedAttributeName");
        this.SetAttributeValue("relatedattributename", (object) value);
        this.OnPropertyChanged("RelatedAttributeName");
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepid")]
    public EntityReference SdkMessageProcessingStepId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessageprocessingstepid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageProcessingStepId");
        this.SetAttributeValue("sdkmessageprocessingstepid", (object) value);
        this.OnPropertyChanged("SdkMessageProcessingStepId");
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepimageid")]
    public Guid? SdkMessageProcessingStepImageId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageprocessingstepimageid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageProcessingStepImageId");
        this.SetAttributeValue("sdkmessageprocessingstepimageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageProcessingStepImageId");
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepimageid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageProcessingStepImageId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepimageidunique")]
    public Guid? SdkMessageProcessingStepImageIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageprocessingstepimageidunique");
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

    [RelationshipSchemaName("createdby_sdkmessageprocessingstepimage")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_sdkmessageprocessingstepimage
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessageprocessingstepimage", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageprocessingstepimage_createdonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstepimage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstepimage_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageprocessingstepimage_modifiedonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstepimage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageprocessingstepimage")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser modifiedby_sdkmessageprocessingstepimage
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessageprocessingstepimage", new EntityRole?());
      }
    }

    [RelationshipSchemaName("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
    [AttributeLogicalName("sdkmessageprocessingstepid")]
    public SdkMessageProcessingStep sdkmessageprocessingstepid_sdkmessageprocessingstepimage
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageProcessingStep>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
        this.SetRelatedEntity<SdkMessageProcessingStep>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessageProcessingStepImage()
      : base("sdkmessageprocessingstepimage")
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
