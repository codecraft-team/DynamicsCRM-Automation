using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagefilter")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class SdkMessageFilter : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessagefilter";
    public const int EntityTypeCode = 4607;

    [AttributeLogicalName("availability")]
    public int? Availability
    {
      get
      {
        return this.GetAttributeValue<int?>("availability");
      }
      set
      {
        this.OnPropertyChanging("Availability");
        this.SetAttributeValue("availability", (object) value);
        this.OnPropertyChanged("Availability");
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

    [AttributeLogicalName("iscustomprocessingstepallowed")]
    public bool? IsCustomProcessingStepAllowed
    {
      get
      {
        return this.GetAttributeValue<bool?>("iscustomprocessingstepallowed");
      }
      set
      {
        this.OnPropertyChanging("IsCustomProcessingStepAllowed");
        this.SetAttributeValue("iscustomprocessingstepallowed", (object) value);
        this.OnPropertyChanged("IsCustomProcessingStepAllowed");
      }
    }

    [AttributeLogicalName("isvisible")]
    public bool? IsVisible
    {
      get
      {
        return this.GetAttributeValue<bool?>("isvisible");
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("organizationid");
      }
    }

    [AttributeLogicalName("primaryobjecttypecode")]
    public string PrimaryObjectTypeCode
    {
      get
      {
        return this.GetAttributeValue<string>("primaryobjecttypecode");
      }
    }

    [AttributeLogicalName("sdkmessagefilterid")]
    public Guid? SdkMessageFilterId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessagefilterid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageFilterId");
        this.SetAttributeValue("sdkmessagefilterid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageFilterId");
      }
    }

    [AttributeLogicalName("sdkmessagefilterid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageFilterId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessagefilteridunique")]
    public Guid? SdkMessageFilterIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessagefilteridunique");
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

    [AttributeLogicalName("secondaryobjecttypecode")]
    public string SecondaryObjectTypeCode
    {
      get
      {
        return this.GetAttributeValue<string>("secondaryobjecttypecode");
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

    [AttributeLogicalName("workflowsdkstepenabled")]
    public bool? WorkflowSdkStepEnabled
    {
      get
      {
        return this.GetAttributeValue<bool?>("workflowsdkstepenabled");
      }
    }

    [RelationshipSchemaName("sdkmessagefilterid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> sdkmessagefilterid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessagefilter")]
    public SystemUser createdby_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessagefilter", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagefilter_createdonbehalfby")]
    public SystemUser lk_sdkmessagefilter_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessagefilter_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_sdkmessagefilter_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_sdkmessagefilter_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessagefilter_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessagefilter")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser modifiedby_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessagefilter", new EntityRole?());
      }
    }

    [RelationshipSchemaName("sdkmessageid_sdkmessagefilter")]
    [AttributeLogicalName("sdkmessageid")]
    public SdkMessage sdkmessageid_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessagefilter", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageid_sdkmessagefilter");
        this.SetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessagefilter", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageid_sdkmessagefilter");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessageFilter()
      : base("sdkmessagefilter")
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
