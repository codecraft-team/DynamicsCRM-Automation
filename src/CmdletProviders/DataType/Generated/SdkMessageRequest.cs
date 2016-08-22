using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagerequest")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class SdkMessageRequest : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessagerequest";
    public const int EntityTypeCode = 4609;

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

    [AttributeLogicalName("primaryobjecttypecode")]
    public string PrimaryObjectTypeCode
    {
      get
      {
        return this.GetAttributeValue<string>("primaryobjecttypecode");
      }
    }

    [AttributeLogicalName("sdkmessagepairid")]
    public EntityReference SdkMessagePairId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessagepairid");
      }
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    public Guid? SdkMessageRequestId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessagerequestid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageRequestId");
        this.SetAttributeValue("sdkmessagerequestid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageRequestId");
      }
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageRequestId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessagerequestidunique")]
    public Guid? SdkMessageRequestIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessagerequestidunique");
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

    [RelationshipSchemaName("messagerequest_sdkmessagerequestfield")]
    public IEnumerable<SdkMessageRequestField> messagerequest_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("messagerequest_sdkmessagerequestfield");
        this.SetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", new EntityRole?(), value);
        this.OnPropertyChanged("messagerequest_sdkmessagerequestfield");
      }
    }

    [RelationshipSchemaName("messagerequest_sdkmessageresponse")]
    public IEnumerable<SdkMessageResponse> messagerequest_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("messagerequest_sdkmessageresponse");
        this.SetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", new EntityRole?(), value);
        this.OnPropertyChanged("messagerequest_sdkmessageresponse");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessagerequest")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessagerequest", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagerequest_createdonbehalfby")]
    public SystemUser lk_sdkmessagerequest_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessagerequest_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagerequest_modifiedonbehalfby")]
    public SystemUser lk_sdkmessagerequest_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessagerequest_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("messagepair_sdkmessagerequest")]
    [AttributeLogicalName("sdkmessagepairid")]
    public SdkMessagePair messagepair_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntity<SdkMessagePair>("messagepair_sdkmessagerequest", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessagerequest")]
    public SystemUser modifiedby_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessagerequest", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessageRequest()
      : base("sdkmessagerequest")
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
