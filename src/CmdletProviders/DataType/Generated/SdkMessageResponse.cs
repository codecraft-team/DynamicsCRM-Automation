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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageresponse")]
  public class SdkMessageResponse : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageresponse";
    public const int EntityTypeCode = 4610;

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

    [AttributeLogicalName("sdkmessagerequestid")]
    public EntityReference SdkMessageRequestId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessagerequestid");
      }
    }

    [AttributeLogicalName("sdkmessageresponseid")]
    public Guid? SdkMessageResponseId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageresponseid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageResponseId");
        this.SetAttributeValue("sdkmessageresponseid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageResponseId");
      }
    }

    [AttributeLogicalName("sdkmessageresponseid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageResponseId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessageresponseidunique")]
    public Guid? SdkMessageResponseIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageresponseidunique");
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

    [RelationshipSchemaName("messageresponse_sdkmessageresponsefield")]
    public IEnumerable<SdkMessageResponseField> messageresponse_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("messageresponse_sdkmessageresponsefield");
        this.SetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", new EntityRole?(), value);
        this.OnPropertyChanged("messageresponse_sdkmessageresponsefield");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessageresponse")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessageresponse", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_sdkmessageresponse_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_sdkmessageresponse_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageresponse_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_sdkmessageresponse_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_sdkmessageresponse_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessageresponse_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("messagerequest_sdkmessageresponse")]
    [AttributeLogicalName("sdkmessagerequestid")]
    public SdkMessageRequest messagerequest_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessageresponse", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessageresponse")]
    public SystemUser modifiedby_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessageresponse", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessageResponse()
      : base("sdkmessageresponse")
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
