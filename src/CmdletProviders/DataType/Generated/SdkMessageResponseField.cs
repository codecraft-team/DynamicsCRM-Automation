using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageresponsefield")]
  public class SdkMessageResponseField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageresponsefield";
    public const int EntityTypeCode = 4611;

    [AttributeLogicalName("clrformatter")]
    public string ClrFormatter
    {
      get
      {
        return this.GetAttributeValue<string>("clrformatter");
      }
      set
      {
        this.OnPropertyChanging("ClrFormatter");
        this.SetAttributeValue("clrformatter", (object) value);
        this.OnPropertyChanged("ClrFormatter");
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

    [AttributeLogicalName("formatter")]
    public string Formatter
    {
      get
      {
        return this.GetAttributeValue<string>("formatter");
      }
      set
      {
        this.OnPropertyChanging("Formatter");
        this.SetAttributeValue("formatter", (object) value);
        this.OnPropertyChanged("Formatter");
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

    [AttributeLogicalName("parameterbindinginformation")]
    public string ParameterBindingInformation
    {
      get
      {
        return this.GetAttributeValue<string>("parameterbindinginformation");
      }
      set
      {
        this.OnPropertyChanging("ParameterBindingInformation");
        this.SetAttributeValue("parameterbindinginformation", (object) value);
        this.OnPropertyChanged("ParameterBindingInformation");
      }
    }

    [AttributeLogicalName("position")]
    public int? Position
    {
      get
      {
        return this.GetAttributeValue<int?>("position");
      }
    }

    [AttributeLogicalName("publicname")]
    public string PublicName
    {
      get
      {
        return this.GetAttributeValue<string>("publicname");
      }
      set
      {
        this.OnPropertyChanging("PublicName");
        this.SetAttributeValue("publicname", (object) value);
        this.OnPropertyChanged("PublicName");
      }
    }

    [AttributeLogicalName("sdkmessageresponsefieldid")]
    public Guid? SdkMessageResponseFieldId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageresponsefieldid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageResponseFieldId");
        this.SetAttributeValue("sdkmessageresponsefieldid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageResponseFieldId");
      }
    }

    [AttributeLogicalName("sdkmessageresponsefieldid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageResponseFieldId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessageresponsefieldidunique")]
    public Guid? SdkMessageResponseFieldIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageresponsefieldidunique");
      }
    }

    [AttributeLogicalName("sdkmessageresponseid")]
    public EntityReference SdkMessageResponseId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessageresponseid");
      }
    }

    [AttributeLogicalName("value")]
    public string Value
    {
      get
      {
        return this.GetAttributeValue<string>("value");
      }
      set
      {
        this.OnPropertyChanging("Value");
        this.SetAttributeValue("value", (object) value);
        this.OnPropertyChanged("Value");
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

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessageresponsefield")]
    public SystemUser createdby_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessageresponsefield", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageresponsefield_createdonbehalfby")]
    public SystemUser lk_sdkmessageresponsefield_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageresponsefield_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageresponsefield_modifiedonbehalfby")]
    public SystemUser lk_sdkmessageresponsefield_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageresponsefield_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("messageresponse_sdkmessageresponsefield")]
    [AttributeLogicalName("sdkmessageresponseid")]
    public SdkMessageResponse messageresponse_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageResponse>("messageresponse_sdkmessageresponsefield", new EntityRole?());
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessageresponsefield")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser modifiedby_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessageresponsefield", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessageResponseField()
      : base("sdkmessageresponsefield")
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
