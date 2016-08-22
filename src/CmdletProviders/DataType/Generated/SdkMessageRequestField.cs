using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagerequestfield")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class SdkMessageRequestField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessagerequestfield";
    public const int EntityTypeCode = 4614;

    [AttributeLogicalName("clrparser")]
    public string ClrParser
    {
      get
      {
        return this.GetAttributeValue<string>("clrparser");
      }
      set
      {
        this.OnPropertyChanging("ClrParser");
        this.SetAttributeValue("clrparser", (object) value);
        this.OnPropertyChanged("ClrParser");
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

    [AttributeLogicalName("fieldmask")]
    public int? FieldMask
    {
      get
      {
        return this.GetAttributeValue<int?>("fieldmask");
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

    [AttributeLogicalName("optional")]
    public bool? Optional
    {
      get
      {
        return this.GetAttributeValue<bool?>("optional");
      }
      set
      {
        this.OnPropertyChanging("Optional");
        this.SetAttributeValue("optional", (object) value);
        this.OnPropertyChanged("Optional");
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

    [AttributeLogicalName("parser")]
    public string Parser
    {
      get
      {
        return this.GetAttributeValue<string>("parser");
      }
      set
      {
        this.OnPropertyChanging("Parser");
        this.SetAttributeValue("parser", (object) value);
        this.OnPropertyChanged("Parser");
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

    [AttributeLogicalName("sdkmessagerequestfieldid")]
    public Guid? SdkMessageRequestFieldId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessagerequestfieldid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageRequestFieldId");
        this.SetAttributeValue("sdkmessagerequestfieldid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageRequestFieldId");
      }
    }

    [AttributeLogicalName("sdkmessagerequestfieldid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageRequestFieldId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessagerequestfieldidunique")]
    public Guid? SdkMessageRequestFieldIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessagerequestfieldidunique");
      }
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    public EntityReference SdkMessageRequestId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessagerequestid");
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

    [RelationshipSchemaName("createdby_sdkmessagerequestfield")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessagerequestfield", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagerequestfield_createdonbehalfby")]
    public SystemUser lk_sdkmessagerequestfield_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessagerequestfield_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_sdkmessagerequestfield_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_sdkmessagerequestfield_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessagerequestfield_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    [RelationshipSchemaName("messagerequest_sdkmessagerequestfield")]
    public SdkMessageRequest messagerequest_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessagerequestfield", new EntityRole?());
      }
    }

    [RelationshipSchemaName("modifiedby_sdkmessagerequestfield")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser modifiedby_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessagerequestfield", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessageRequestField()
      : base("sdkmessagerequestfield")
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
