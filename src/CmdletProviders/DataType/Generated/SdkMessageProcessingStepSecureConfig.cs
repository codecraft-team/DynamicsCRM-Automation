using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageprocessingstepsecureconfig")]
  public class SdkMessageProcessingStepSecureConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageprocessingstepsecureconfig";
    public const int EntityTypeCode = 4616;

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

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
    public Guid? SdkMessageProcessingStepSecureConfigId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageprocessingstepsecureconfigid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
        this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageProcessingStepSecureConfigId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigidunique")]
    public Guid? SdkMessageProcessingStepSecureConfigIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageprocessingstepsecureconfigidunique");
      }
    }

    [AttributeLogicalName("secureconfig")]
    public string SecureConfig
    {
      get
      {
        return this.GetAttributeValue<string>("secureconfig");
      }
      set
      {
        this.OnPropertyChanging("SecureConfig");
        this.SetAttributeValue("secureconfig", (object) value);
        this.OnPropertyChanged("SecureConfig");
      }
    }

    [RelationshipSchemaName("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessageprocessingstepsecureconfig")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessageprocessingstepsecureconfig", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageprocessingstepsecureconfig")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser modifiedby_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessageprocessingstepsecureconfig", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessageProcessingStepSecureConfig()
      : base("sdkmessageprocessingstepsecureconfig")
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
