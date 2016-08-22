using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagepair")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class SdkMessagePair : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessagepair";
    public const int EntityTypeCode = 4613;

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

    [AttributeLogicalName("endpoint")]
    public string Endpoint
    {
      get
      {
        return this.GetAttributeValue<string>("endpoint");
      }
      set
      {
        this.OnPropertyChanging("Endpoint");
        this.SetAttributeValue("endpoint", (object) value);
        this.OnPropertyChanged("Endpoint");
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

    [AttributeLogicalName("namespace")]
    public string Namespace
    {
      get
      {
        return this.GetAttributeValue<string>("namespace");
      }
      set
      {
        this.OnPropertyChanging("Namespace");
        this.SetAttributeValue("namespace", (object) value);
        this.OnPropertyChanged("Namespace");
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

    [AttributeLogicalName("sdkmessagebindinginformation")]
    public string SdkMessageBindingInformation
    {
      get
      {
        return this.GetAttributeValue<string>("sdkmessagebindinginformation");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageBindingInformation");
        this.SetAttributeValue("sdkmessagebindinginformation", (object) value);
        this.OnPropertyChanged("SdkMessageBindingInformation");
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public EntityReference SdkMessageId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessageid");
      }
    }

    [AttributeLogicalName("sdkmessagepairid")]
    public Guid? SdkMessagePairId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessagepairid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessagePairId");
        this.SetAttributeValue("sdkmessagepairid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessagePairId");
      }
    }

    [AttributeLogicalName("sdkmessagepairid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessagePairId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessagepairidunique")]
    public Guid? SdkMessagePairIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessagepairidunique");
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

    [RelationshipSchemaName("messagepair_sdkmessagerequest")]
    public IEnumerable<SdkMessageRequest> messagepair_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("messagepair_sdkmessagerequest");
        this.SetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", new EntityRole?(), value);
        this.OnPropertyChanged("messagepair_sdkmessagerequest");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessagepair")]
    public SystemUser createdby_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessagepair", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_sdkmessagepair_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_sdkmessagepair_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessagepair_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagepair_modifiedonbehalfby")]
    public SystemUser lk_sdkmessagepair_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessagepair_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("message_sdkmessagepair")]
    [AttributeLogicalName("sdkmessageid")]
    public SdkMessage message_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntity<SdkMessage>("message_sdkmessagepair", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessagepair")]
    public SystemUser modifiedby_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessagepair", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessagePair()
      : base("sdkmessagepair")
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
