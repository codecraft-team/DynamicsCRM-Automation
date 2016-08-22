using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("asyncoperation")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class AsyncOperation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "asyncoperation";
    public const int EntityTypeCode = 4700;

    [AttributeLogicalName("asyncoperationid")]
    public Guid? AsyncOperationId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("asyncoperationid");
      }
      set
      {
        this.OnPropertyChanging("AsyncOperationId");
        this.SetAttributeValue("asyncoperationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("AsyncOperationId");
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.AsyncOperationId = new Guid?(value);
      }
    }

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("completedon");
      }
    }

    [AttributeLogicalName("correlationid")]
    public Guid? CorrelationId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("correlationid");
      }
      set
      {
        this.OnPropertyChanging("CorrelationId");
        this.SetAttributeValue("correlationid", (object) value);
        this.OnPropertyChanged("CorrelationId");
      }
    }

    [AttributeLogicalName("correlationupdatedtime")]
    public DateTime? CorrelationUpdatedTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("correlationupdatedtime");
      }
      set
      {
        this.OnPropertyChanging("CorrelationUpdatedTime");
        this.SetAttributeValue("correlationupdatedtime", (object) value);
        this.OnPropertyChanged("CorrelationUpdatedTime");
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

    [AttributeLogicalName("data")]
    public string Data
    {
      get
      {
        return this.GetAttributeValue<string>("data");
      }
      set
      {
        this.OnPropertyChanging("Data");
        this.SetAttributeValue("data", (object) value);
        this.OnPropertyChanged("Data");
      }
    }

    [AttributeLogicalName("dependencytoken")]
    public string DependencyToken
    {
      get
      {
        return this.GetAttributeValue<string>("dependencytoken");
      }
      set
      {
        this.OnPropertyChanging("DependencyToken");
        this.SetAttributeValue("dependencytoken", (object) value);
        this.OnPropertyChanged("DependencyToken");
      }
    }

    [AttributeLogicalName("depth")]
    public int? Depth
    {
      get
      {
        return this.GetAttributeValue<int?>("depth");
      }
      set
      {
        this.OnPropertyChanging("Depth");
        this.SetAttributeValue("depth", (object) value);
        this.OnPropertyChanged("Depth");
      }
    }

    [AttributeLogicalName("errorcode")]
    public int? ErrorCode
    {
      get
      {
        return this.GetAttributeValue<int?>("errorcode");
      }
    }

    [AttributeLogicalName("executiontimespan")]
    public double? ExecutionTimeSpan
    {
      get
      {
        return this.GetAttributeValue<double?>("executiontimespan");
      }
    }

    [AttributeLogicalName("friendlymessage")]
    public string FriendlyMessage
    {
      get
      {
        return this.GetAttributeValue<string>("friendlymessage");
      }
      set
      {
        this.OnPropertyChanging("FriendlyMessage");
        this.SetAttributeValue("friendlymessage", (object) value);
        this.OnPropertyChanged("FriendlyMessage");
      }
    }

    [AttributeLogicalName("hostid")]
    public string HostId
    {
      get
      {
        return this.GetAttributeValue<string>("hostid");
      }
      set
      {
        this.OnPropertyChanging("HostId");
        this.SetAttributeValue("hostid", (object) value);
        this.OnPropertyChanged("HostId");
      }
    }

    [AttributeLogicalName("iswaitingforevent")]
    public bool? IsWaitingForEvent
    {
      get
      {
        return this.GetAttributeValue<bool?>("iswaitingforevent");
      }
    }

    [AttributeLogicalName("message")]
    public string Message
    {
      get
      {
        return this.GetAttributeValue<string>("message");
      }
    }

    [AttributeLogicalName("messagename")]
    public string MessageName
    {
      get
      {
        return this.GetAttributeValue<string>("messagename");
      }
      set
      {
        this.OnPropertyChanging("MessageName");
        this.SetAttributeValue("messagename", (object) value);
        this.OnPropertyChanged("MessageName");
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

    [AttributeLogicalName("operationtype")]
    public OptionSetValue OperationType
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("operationtype");
      }
      set
      {
        this.OnPropertyChanging("OperationType");
        this.SetAttributeValue("operationtype", (object) value);
        this.OnPropertyChanged("OperationType");
      }
    }

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("ownerid");
      }
      set
      {
        this.OnPropertyChanging("OwnerId");
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged("OwnerId");
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("owningbusinessunit");
      }
    }

    [AttributeLogicalName("owningextensionid")]
    public EntityReference OwningExtensionId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("owningextensionid");
      }
      set
      {
        this.OnPropertyChanging("OwningExtensionId");
        this.SetAttributeValue("owningextensionid", (object) value);
        this.OnPropertyChanged("OwningExtensionId");
      }
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("owningteam");
      }
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("owninguser");
      }
    }

    [AttributeLogicalName("postponeuntil")]
    public DateTime? PostponeUntil
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("postponeuntil");
      }
      set
      {
        this.OnPropertyChanging("PostponeUntil");
        this.SetAttributeValue("postponeuntil", (object) value);
        this.OnPropertyChanged("PostponeUntil");
      }
    }

    [AttributeLogicalName("primaryentitytype")]
    public string PrimaryEntityType
    {
      get
      {
        return this.GetAttributeValue<string>("primaryentitytype");
      }
      set
      {
        this.OnPropertyChanging("PrimaryEntityType");
        this.SetAttributeValue("primaryentitytype", (object) value);
        this.OnPropertyChanged("PrimaryEntityType");
      }
    }

    [AttributeLogicalName("recurrencepattern")]
    public string RecurrencePattern
    {
      get
      {
        return this.GetAttributeValue<string>("recurrencepattern");
      }
      set
      {
        this.OnPropertyChanging("RecurrencePattern");
        this.SetAttributeValue("recurrencepattern", (object) value);
        this.OnPropertyChanged("RecurrencePattern");
      }
    }

    [AttributeLogicalName("recurrencestarttime")]
    public DateTime? RecurrenceStartTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("recurrencestarttime");
      }
      set
      {
        this.OnPropertyChanging("RecurrenceStartTime");
        this.SetAttributeValue("recurrencestarttime", (object) value);
        this.OnPropertyChanged("RecurrenceStartTime");
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("regardingobjectid");
      }
      set
      {
        this.OnPropertyChanging("RegardingObjectId");
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged("RegardingObjectId");
      }
    }

    [AttributeLogicalName("requestid")]
    public Guid? RequestId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("requestid");
      }
      set
      {
        this.OnPropertyChanging("RequestId");
        this.SetAttributeValue("requestid", (object) value);
        this.OnPropertyChanged("RequestId");
      }
    }

    [AttributeLogicalName("retrycount")]
    public int? RetryCount
    {
      get
      {
        return this.GetAttributeValue<int?>("retrycount");
      }
    }

    [AttributeLogicalName("sequence")]
    public long? Sequence
    {
      get
      {
        return this.GetAttributeValue<long?>("sequence");
      }
    }

    [AttributeLogicalName("startedon")]
    public DateTime? StartedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("startedon");
      }
    }

    [AttributeLogicalName("statecode")]
    public AsyncOperationState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new AsyncOperationState?((AsyncOperationState) Enum.ToObject(typeof (AsyncOperationState), attributeValue.Value));
        return new AsyncOperationState?();
      }
      set
      {
        this.OnPropertyChanging("StateCode");
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged("StateCode");
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("statuscode");
      }
      set
      {
        this.OnPropertyChanging("StatusCode");
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged("StatusCode");
      }
    }

    [AttributeLogicalName("subtype")]
    public int? Subtype
    {
      get
      {
        return this.GetAttributeValue<int?>("subtype");
      }
    }

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get
      {
        return this.GetAttributeValue<int?>("timezoneruleversionnumber");
      }
      set
      {
        this.OnPropertyChanging("TimeZoneRuleVersionNumber");
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged("TimeZoneRuleVersionNumber");
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get
      {
        return this.GetAttributeValue<int?>("utcconversiontimezonecode");
      }
      set
      {
        this.OnPropertyChanging("UTCConversionTimeZoneCode");
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged("UTCConversionTimeZoneCode");
      }
    }

    [AttributeLogicalName("workflowactivationid")]
    public EntityReference WorkflowActivationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("workflowactivationid");
      }
      set
      {
        this.OnPropertyChanging("WorkflowActivationId");
        this.SetAttributeValue("workflowactivationid", (object) value);
        this.OnPropertyChanged("WorkflowActivationId");
      }
    }

    [AttributeLogicalName("workflowstagename")]
    public string WorkflowStageName
    {
      get
      {
        return this.GetAttributeValue<string>("workflowstagename");
      }
    }

    [RelationshipSchemaName("lk_workflowlog_asyncoperation_childworkflow")]
    public IEnumerable<WorkflowLog> lk_workflowlog_asyncoperation_childworkflow
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperation_childworkflow", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_workflowlog_asyncoperation_childworkflow");
        this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperation_childworkflow", new EntityRole?(), value);
        this.OnPropertyChanged("lk_workflowlog_asyncoperation_childworkflow");
      }
    }

    [RelationshipSchemaName("lk_workflowlog_asyncoperations")]
    public IEnumerable<WorkflowLog> lk_workflowlog_asyncoperations
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_workflowlog_asyncoperations");
        this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperations", new EntityRole?(), value);
        this.OnPropertyChanged("lk_workflowlog_asyncoperations");
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_asyncoperation")]
    public BusinessUnit business_unit_asyncoperation
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_asyncoperation", new EntityRole?());
      }
    }

    [RelationshipSchemaName("BusinessUnit_AsyncOperations")]
    [AttributeLogicalName("regardingobjectid")]
    public BusinessUnit BusinessUnit_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("BusinessUnit_AsyncOperations");
        this.SetRelatedEntity<BusinessUnit>("BusinessUnit_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("BusinessUnit_AsyncOperations");
      }
    }

    [RelationshipSchemaName("BusinessUnitNewsArticle_AsyncOperations")]
    [AttributeLogicalName("regardingobjectid")]
    public BusinessUnitNewsArticle BusinessUnitNewsArticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("BusinessUnitNewsArticle_AsyncOperations");
        this.SetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("BusinessUnitNewsArticle_AsyncOperations");
      }
    }

    [RelationshipSchemaName("Connection_Role_AsyncOperations")]
    [AttributeLogicalName("regardingobjectid")]
    public ConnectionRole Connection_Role_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>("Connection_Role_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("Connection_Role_AsyncOperations");
        this.SetRelatedEntity<ConnectionRole>("Connection_Role_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("Connection_Role_AsyncOperations");
      }
    }

    [RelationshipSchemaName("CustomerOpportunityRole_AsyncOperations")]
    [AttributeLogicalName("regardingobjectid")]
    public CustomerOpportunityRole CustomerOpportunityRole_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("CustomerOpportunityRole_AsyncOperations");
        this.SetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("CustomerOpportunityRole_AsyncOperations");
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("IncidentResolution_AsyncOperations")]
    public IncidentResolution IncidentResolution_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<IncidentResolution>("IncidentResolution_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("IncidentResolution_AsyncOperations");
        this.SetRelatedEntity<IncidentResolution>("IncidentResolution_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("IncidentResolution_AsyncOperations");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_asyncoperation_createdby")]
    public SystemUser lk_asyncoperation_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_asyncoperation_createdby", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_asyncoperation_createdonbehalfby")]
    public SystemUser lk_asyncoperation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_asyncoperation_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_asyncoperation_modifiedby")]
    public SystemUser lk_asyncoperation_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_asyncoperation_modifiedby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_asyncoperation_modifiedonbehalfby")]
    public SystemUser lk_asyncoperation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_asyncoperation_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_asyncoperation_workflowactivationid")]
    [AttributeLogicalName("workflowactivationid")]
    public Workflow lk_asyncoperation_workflowactivationid
    {
      get
      {
        return this.GetRelatedEntity<Workflow>("lk_asyncoperation_workflowactivationid", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_asyncoperation_workflowactivationid");
        this.SetRelatedEntity<Workflow>("lk_asyncoperation_workflowactivationid", new EntityRole?(), value);
        this.OnPropertyChanged("lk_asyncoperation_workflowactivationid");
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyusd_actioncallworkflow_AsyncOperations")]
    public msdyusd_actioncallworkflow msdyusd_actioncallworkflow_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyusd_actioncallworkflow>("msdyusd_actioncallworkflow_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("msdyusd_actioncallworkflow_AsyncOperations");
        this.SetRelatedEntity<msdyusd_actioncallworkflow>("msdyusd_actioncallworkflow_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("msdyusd_actioncallworkflow_AsyncOperations");
      }
    }

    [RelationshipSchemaName("RelationshipRole_AsyncOperations")]
    [AttributeLogicalName("regardingobjectid")]
    public RelationshipRole RelationshipRole_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>("RelationshipRole_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("RelationshipRole_AsyncOperations");
        this.SetRelatedEntity<RelationshipRole>("RelationshipRole_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("RelationshipRole_AsyncOperations");
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RelationshipRoleMap_AsyncOperations")]
    public RelationshipRoleMap RelationshipRoleMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRoleMap>("RelationshipRoleMap_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("RelationshipRoleMap_AsyncOperations");
        this.SetRelatedEntity<RelationshipRoleMap>("RelationshipRoleMap_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("RelationshipRoleMap_AsyncOperations");
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Role_AsyncOperations")]
    public Role Role_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<Role>("Role_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("Role_AsyncOperations");
        this.SetRelatedEntity<Role>("Role_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("Role_AsyncOperations");
      }
    }

    [AttributeLogicalName("owningextensionid")]
    [RelationshipSchemaName("SdkMessageProcessingStep_AsyncOperations")]
    public SdkMessageProcessingStep SdkMessageProcessingStep_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageProcessingStep>("SdkMessageProcessingStep_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("SdkMessageProcessingStep_AsyncOperations");
        this.SetRelatedEntity<SdkMessageProcessingStep>("SdkMessageProcessingStep_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("SdkMessageProcessingStep_AsyncOperations");
      }
    }

    [RelationshipSchemaName("system_user_asyncoperation")]
    [AttributeLogicalName("owninguser")]
    public SystemUser system_user_asyncoperation
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("system_user_asyncoperation", new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SystemUser_AsyncOperations")]
    public SystemUser SystemUser_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("SystemUser_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("SystemUser_AsyncOperations");
        this.SetRelatedEntity<SystemUser>("SystemUser_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("SystemUser_AsyncOperations");
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("uii_workflow_AsyncOperations")]
    public UII_workflow uii_workflow_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<UII_workflow>("uii_workflow_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflow_AsyncOperations");
        this.SetRelatedEntity<UII_workflow>("uii_workflow_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflow_AsyncOperations");
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("uii_workflow_workflowstep_mapping_AsyncOperations")]
    public UII_workflow_workflowstep_mapping uii_workflow_workflowstep_mapping_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<UII_workflow_workflowstep_mapping>("uii_workflow_workflowstep_mapping_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflow_workflowstep_mapping_AsyncOperations");
        this.SetRelatedEntity<UII_workflow_workflowstep_mapping>("uii_workflow_workflowstep_mapping_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflow_workflowstep_mapping_AsyncOperations");
      }
    }

    [RelationshipSchemaName("uii_workflowstep_AsyncOperations")]
    [AttributeLogicalName("regardingobjectid")]
    public UII_workflowstep uii_workflowstep_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<UII_workflowstep>("uii_workflowstep_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflowstep_AsyncOperations");
        this.SetRelatedEntity<UII_workflowstep>("uii_workflowstep_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflowstep_AsyncOperations");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public AsyncOperation()
      : base("asyncoperation")
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
