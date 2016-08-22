using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("plugintypestatistic")]
  public class PluginTypeStatistic : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "plugintypestatistic";
    public const int EntityTypeCode = 4603;

    [AttributeLogicalName("averageexecutetimeinmilliseconds")]
    public int? AverageExecuteTimeInMilliseconds
    {
      get
      {
        return this.GetAttributeValue<int?>("averageexecutetimeinmilliseconds");
      }
    }

    [AttributeLogicalName("crashcontributionpercent")]
    public int? CrashContributionPercent
    {
      get
      {
        return this.GetAttributeValue<int?>("crashcontributionpercent");
      }
    }

    [AttributeLogicalName("crashcount")]
    public int? CrashCount
    {
      get
      {
        return this.GetAttributeValue<int?>("crashcount");
      }
    }

    [AttributeLogicalName("crashpercent")]
    public int? CrashPercent
    {
      get
      {
        return this.GetAttributeValue<int?>("crashpercent");
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

    [AttributeLogicalName("executecount")]
    public int? ExecuteCount
    {
      get
      {
        return this.GetAttributeValue<int?>("executecount");
      }
    }

    [AttributeLogicalName("failurecount")]
    public int? FailureCount
    {
      get
      {
        return this.GetAttributeValue<int?>("failurecount");
      }
    }

    [AttributeLogicalName("failurepercent")]
    public int? FailurePercent
    {
      get
      {
        return this.GetAttributeValue<int?>("failurepercent");
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

    [AttributeLogicalName("plugintypeid")]
    public EntityReference PluginTypeId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("plugintypeid");
      }
    }

    [AttributeLogicalName("plugintypestatisticid")]
    public Guid? PluginTypeStatisticId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("plugintypestatisticid");
      }
    }

    [AttributeLogicalName("plugintypestatisticid")]
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

    [AttributeLogicalName("terminatecpucontributionpercent")]
    public int? TerminateCpuContributionPercent
    {
      get
      {
        return this.GetAttributeValue<int?>("terminatecpucontributionpercent");
      }
    }

    [AttributeLogicalName("terminatehandlescontributionpercent")]
    public int? TerminateHandlesContributionPercent
    {
      get
      {
        return this.GetAttributeValue<int?>("terminatehandlescontributionpercent");
      }
    }

    [AttributeLogicalName("terminatememorycontributionpercent")]
    public int? TerminateMemoryContributionPercent
    {
      get
      {
        return this.GetAttributeValue<int?>("terminatememorycontributionpercent");
      }
    }

    [AttributeLogicalName("terminateothercontributionpercent")]
    public int? TerminateOtherContributionPercent
    {
      get
      {
        return this.GetAttributeValue<int?>("terminateothercontributionpercent");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_plugintypestatistic")]
    public SystemUser createdby_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_plugintypestatistic", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_plugintypestatisticbase_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_plugintypestatisticbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_plugintypestatisticbase_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_plugintypestatisticbase_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_plugintypestatisticbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_plugintypestatisticbase_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("modifiedby_plugintypestatistic")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser modifiedby_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_plugintypestatistic", new EntityRole?());
      }
    }

    [AttributeLogicalName("plugintypeid")]
    [RelationshipSchemaName("plugintype_plugintypestatistic")]
    public PluginType plugintype_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntity<PluginType>("plugintype_plugintypestatistic", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public PluginTypeStatistic()
      : base("plugintypestatistic")
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
