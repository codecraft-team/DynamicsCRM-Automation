using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessage")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class SdkMessage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessage";
    public const int EntityTypeCode = 4606;

    [AttributeLogicalName("autotransact")]
    public bool? AutoTransact
    {
      get
      {
        return this.GetAttributeValue<bool?>("autotransact");
      }
      set
      {
        this.OnPropertyChanging("AutoTransact");
        this.SetAttributeValue("autotransact", (object) value);
        this.OnPropertyChanged("AutoTransact");
      }
    }

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

    [AttributeLogicalName("categoryname")]
    public string CategoryName
    {
      get
      {
        return this.GetAttributeValue<string>("categoryname");
      }
      set
      {
        this.OnPropertyChanging("CategoryName");
        this.SetAttributeValue("categoryname", (object) value);
        this.OnPropertyChanged("CategoryName");
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

    [AttributeLogicalName("expand")]
    public bool? Expand
    {
      get
      {
        return this.GetAttributeValue<bool?>("expand");
      }
      set
      {
        this.OnPropertyChanging("Expand");
        this.SetAttributeValue("expand", (object) value);
        this.OnPropertyChanged("Expand");
      }
    }

    [AttributeLogicalName("isactive")]
    public bool? IsActive
    {
      get
      {
        return this.GetAttributeValue<bool?>("isactive");
      }
      set
      {
        this.OnPropertyChanging("IsActive");
        this.SetAttributeValue("isactive", (object) value);
        this.OnPropertyChanged("IsActive");
      }
    }

    [AttributeLogicalName("isprivate")]
    public bool? IsPrivate
    {
      get
      {
        return this.GetAttributeValue<bool?>("isprivate");
      }
      set
      {
        this.OnPropertyChanging("IsPrivate");
        this.SetAttributeValue("isprivate", (object) value);
        this.OnPropertyChanged("IsPrivate");
      }
    }

    [AttributeLogicalName("isreadonly")]
    public bool? IsReadOnly
    {
      get
      {
        return this.GetAttributeValue<bool?>("isreadonly");
      }
      set
      {
        this.OnPropertyChanging("IsReadOnly");
        this.SetAttributeValue("isreadonly", (object) value);
        this.OnPropertyChanged("IsReadOnly");
      }
    }

    [AttributeLogicalName("isvalidforexecuteasync")]
    public bool? IsValidForExecuteAsync
    {
      get
      {
        return this.GetAttributeValue<bool?>("isvalidforexecuteasync");
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

    [AttributeLogicalName("sdkmessageid")]
    public Guid? SdkMessageId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageId");
        this.SetAttributeValue("sdkmessageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SdkMessageId");
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SdkMessageId = new Guid?(value);
      }
    }

    [AttributeLogicalName("sdkmessageidunique")]
    public Guid? SdkMessageIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("sdkmessageidunique");
      }
    }

    [AttributeLogicalName("template")]
    public bool? Template
    {
      get
      {
        return this.GetAttributeValue<bool?>("template");
      }
      set
      {
        this.OnPropertyChanging("Template");
        this.SetAttributeValue("template", (object) value);
        this.OnPropertyChanged("Template");
      }
    }

    [AttributeLogicalName("throttlesettings")]
    public string ThrottleSettings
    {
      get
      {
        return this.GetAttributeValue<string>("throttlesettings");
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

    [RelationshipSchemaName("message_sdkmessagepair")]
    public IEnumerable<SdkMessagePair> message_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("message_sdkmessagepair");
        this.SetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", new EntityRole?(), value);
        this.OnPropertyChanged("message_sdkmessagepair");
      }
    }

    [RelationshipSchemaName("sdkmessageid_sdkmessagefilter")]
    public IEnumerable<SdkMessageFilter> sdkmessageid_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageid_sdkmessagefilter");
        this.SetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageid_sdkmessagefilter");
      }
    }

    [RelationshipSchemaName("sdkmessageid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> sdkmessageid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
      }
    }

    [RelationshipSchemaName("sdkmessageid_workflow_dependency")]
    public IEnumerable<WorkflowDependency> sdkmessageid_workflow_dependency
    {
      get
      {
        return this.GetRelatedEntities<WorkflowDependency>("sdkmessageid_workflow_dependency", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageid_workflow_dependency");
        this.SetRelatedEntities<WorkflowDependency>("sdkmessageid_workflow_dependency", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageid_workflow_dependency");
      }
    }

    [RelationshipSchemaName("createdby_sdkmessage")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_sdkmessage
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_sdkmessage", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessage_createdonbehalfby")]
    public SystemUser lk_sdkmessage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessage_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessage_modifiedonbehalfby")]
    public SystemUser lk_sdkmessage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_sdkmessage_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessage")]
    public SystemUser modifiedby_sdkmessage
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessage", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SdkMessage()
      : base("sdkmessage")
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
