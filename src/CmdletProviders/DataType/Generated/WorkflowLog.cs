using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("workflowlog")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class WorkflowLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "workflowlog";
    public const int EntityTypeCode = 4706;

    [AttributeLogicalName("activityname")]
    public string ActivityName
    {
      get
      {
        return this.GetAttributeValue<string>("activityname");
      }
      set
      {
        this.OnPropertyChanging("ActivityName");
        this.SetAttributeValue("activityname", (object) value);
        this.OnPropertyChanged("ActivityName");
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    public EntityReference AsyncOperationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("asyncoperationid");
      }
      set
      {
        this.OnPropertyChanging("AsyncOperationId");
        this.SetAttributeValue("asyncoperationid", (object) value);
        this.OnPropertyChanged("AsyncOperationId");
      }
    }

    [AttributeLogicalName("childworkflowinstanceid")]
    public EntityReference ChildWorkflowInstanceId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("childworkflowinstanceid");
      }
      set
      {
        this.OnPropertyChanging("ChildWorkflowInstanceId");
        this.SetAttributeValue("childworkflowinstanceid", (object) value);
        this.OnPropertyChanged("ChildWorkflowInstanceId");
      }
    }

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("completedon");
      }
      set
      {
        this.OnPropertyChanging("CompletedOn");
        this.SetAttributeValue("completedon", (object) value);
        this.OnPropertyChanged("CompletedOn");
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

    [AttributeLogicalName("description")]
    public string Description
    {
      get
      {
        return this.GetAttributeValue<string>("description");
      }
      set
      {
        this.OnPropertyChanging("Description");
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged("Description");
      }
    }

    [AttributeLogicalName("errorcode")]
    public int? ErrorCode
    {
      get
      {
        return this.GetAttributeValue<int?>("errorcode");
      }
      set
      {
        this.OnPropertyChanging("ErrorCode");
        this.SetAttributeValue("errorcode", (object) value);
        this.OnPropertyChanged("ErrorCode");
      }
    }

    [AttributeLogicalName("interactionactivityresult")]
    public string InteractionActivityResult
    {
      get
      {
        return this.GetAttributeValue<string>("interactionactivityresult");
      }
      set
      {
        this.OnPropertyChanging("InteractionActivityResult");
        this.SetAttributeValue("interactionactivityresult", (object) value);
        this.OnPropertyChanged("InteractionActivityResult");
      }
    }

    [AttributeLogicalName("message")]
    public string Message
    {
      get
      {
        return this.GetAttributeValue<string>("message");
      }
      set
      {
        this.OnPropertyChanging("Message");
        this.SetAttributeValue("message", (object) value);
        this.OnPropertyChanged("Message");
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("ownerid");
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

    [AttributeLogicalName("stagename")]
    public string StageName
    {
      get
      {
        return this.GetAttributeValue<string>("stagename");
      }
      set
      {
        this.OnPropertyChanging("StageName");
        this.SetAttributeValue("stagename", (object) value);
        this.OnPropertyChanged("StageName");
      }
    }

    [AttributeLogicalName("status")]
    public OptionSetValue Status
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("status");
      }
      set
      {
        this.OnPropertyChanging("Status");
        this.SetAttributeValue("status", (object) value);
        this.OnPropertyChanged("Status");
      }
    }

    [AttributeLogicalName("stepname")]
    public string StepName
    {
      get
      {
        return this.GetAttributeValue<string>("stepname");
      }
      set
      {
        this.OnPropertyChanging("StepName");
        this.SetAttributeValue("stepname", (object) value);
        this.OnPropertyChanged("StepName");
      }
    }

    [AttributeLogicalName("workflowlogid")]
    public Guid? WorkflowLogId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("workflowlogid");
      }
      set
      {
        this.OnPropertyChanging("WorkflowLogId");
        this.SetAttributeValue("workflowlogid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("WorkflowLogId");
      }
    }

    [AttributeLogicalName("workflowlogid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.WorkflowLogId = new Guid?(value);
      }
    }

    [RelationshipSchemaName("business_unit_workflowlogs")]
    [AttributeLogicalName("owningbusinessunit")]
    public BusinessUnit business_unit_workflowlogs
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_workflowlogs", new EntityRole?());
      }
    }

    [AttributeLogicalName("childworkflowinstanceid")]
    [RelationshipSchemaName("lk_workflowlog_asyncoperation_childworkflow")]
    public AsyncOperation lk_workflowlog_asyncoperation_childworkflow
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperation_childworkflow", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_workflowlog_asyncoperation_childworkflow");
        this.SetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperation_childworkflow", new EntityRole?(), value);
        this.OnPropertyChanged("lk_workflowlog_asyncoperation_childworkflow");
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("lk_workflowlog_asyncoperations")]
    public AsyncOperation lk_workflowlog_asyncoperations
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_workflowlog_asyncoperations");
        this.SetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperations", new EntityRole?(), value);
        this.OnPropertyChanged("lk_workflowlog_asyncoperations");
      }
    }

    [RelationshipSchemaName("lk_workflowlog_createdby")]
    [AttributeLogicalName("createdby")]
    public SystemUser lk_workflowlog_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_workflowlog_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_workflowlog_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_workflowlog_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_workflowlog_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_workflowlog_modifiedby")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser lk_workflowlog_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_workflowlog_modifiedby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_workflowlog_modifiedonbehalfby")]
    public SystemUser lk_workflowlog_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_workflowlog_modifiedonbehalfby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public WorkflowLog()
      : base("workflowlog")
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
