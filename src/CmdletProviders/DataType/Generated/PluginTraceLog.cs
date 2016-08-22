using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("plugintracelog")]
  public class PluginTraceLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "plugintracelog";
    public const int EntityTypeCode = 4619;

    [AttributeLogicalName("configuration")]
    public string Configuration
    {
      get
      {
        return this.GetAttributeValue<string>("configuration");
      }
    }

    [AttributeLogicalName("correlationid")]
    public Guid? CorrelationId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("correlationid");
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

    [AttributeLogicalName("depth")]
    public int? Depth
    {
      get
      {
        return this.GetAttributeValue<int?>("depth");
      }
    }

    [AttributeLogicalName("exceptiondetails")]
    public string ExceptionDetails
    {
      get
      {
        return this.GetAttributeValue<string>("exceptiondetails");
      }
    }

    [AttributeLogicalName("issystemcreated")]
    public bool? IsSystemCreated
    {
      get
      {
        return this.GetAttributeValue<bool?>("issystemcreated");
      }
    }

    [AttributeLogicalName("messageblock")]
    public string MessageBlock
    {
      get
      {
        return this.GetAttributeValue<string>("messageblock");
      }
    }

    [AttributeLogicalName("messagename")]
    public string MessageName
    {
      get
      {
        return this.GetAttributeValue<string>("messagename");
      }
    }

    [AttributeLogicalName("mode")]
    public OptionSetValue Mode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("mode");
      }
    }

    [AttributeLogicalName("operationtype")]
    public OptionSetValue OperationType
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("operationtype");
      }
    }

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("organizationid");
      }
    }

    [AttributeLogicalName("performanceconstructorduration")]
    public int? PerformanceConstructorDuration
    {
      get
      {
        return this.GetAttributeValue<int?>("performanceconstructorduration");
      }
    }

    [AttributeLogicalName("performanceconstructorstarttime")]
    public DateTime? PerformanceConstructorStartTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("performanceconstructorstarttime");
      }
    }

    [AttributeLogicalName("performanceexecutionduration")]
    public int? PerformanceExecutionDuration
    {
      get
      {
        return this.GetAttributeValue<int?>("performanceexecutionduration");
      }
    }

    [AttributeLogicalName("performanceexecutionstarttime")]
    public DateTime? PerformanceExecutionStartTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("performanceexecutionstarttime");
      }
    }

    [AttributeLogicalName("persistencekey")]
    public Guid? PersistenceKey
    {
      get
      {
        return this.GetAttributeValue<Guid?>("persistencekey");
      }
    }

    [AttributeLogicalName("pluginstepid")]
    public Guid? PluginStepId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("pluginstepid");
      }
    }

    [AttributeLogicalName("plugintracelogid")]
    public Guid? PluginTraceLogId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("plugintracelogid");
      }
    }

    [AttributeLogicalName("plugintracelogid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        base.Id = value;
      }
    }

    [AttributeLogicalName("primaryentity")]
    public string PrimaryEntity
    {
      get
      {
        return this.GetAttributeValue<string>("primaryentity");
      }
    }

    [AttributeLogicalName("profile")]
    public string Profile
    {
      get
      {
        return this.GetAttributeValue<string>("profile");
      }
    }

    [AttributeLogicalName("requestid")]
    public Guid? RequestId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("requestid");
      }
    }

    [AttributeLogicalName("secureconfiguration")]
    public string SecureConfiguration
    {
      get
      {
        return this.GetAttributeValue<string>("secureconfiguration");
      }
    }

    [AttributeLogicalName("typename")]
    public string TypeName
    {
      get
      {
        return this.GetAttributeValue<string>("typename");
      }
    }

    [RelationshipSchemaName("createdby_plugintracelog")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_plugintracelog
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_plugintracelog", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_plugintracelogbase_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_plugintracelogbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_plugintracelogbase_createdonbehalfby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public PluginTraceLog()
      : base("plugintracelog")
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
