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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("workflow")]
  public class Workflow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "workflow";
    public const int EntityTypeCode = 4703;

    [AttributeLogicalName("activeworkflowid")]
    public EntityReference ActiveWorkflowId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("activeworkflowid");
      }
    }

    [AttributeLogicalName("asyncautodelete")]
    public bool? AsyncAutoDelete
    {
      get
      {
        return this.GetAttributeValue<bool?>("asyncautodelete");
      }
      set
      {
        this.OnPropertyChanging("AsyncAutoDelete");
        this.SetAttributeValue("asyncautodelete", (object) value);
        this.OnPropertyChanged("AsyncAutoDelete");
      }
    }

    [AttributeLogicalName("businessprocesstype")]
    public OptionSetValue BusinessProcessType
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("businessprocesstype");
      }
      set
      {
        this.OnPropertyChanging("BusinessProcessType");
        this.SetAttributeValue("businessprocesstype", (object) value);
        this.OnPropertyChanged("BusinessProcessType");
      }
    }

    [AttributeLogicalName("category")]
    public OptionSetValue Category
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("category");
      }
      set
      {
        this.OnPropertyChanging("Category");
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged("Category");
      }
    }

    [AttributeLogicalName("clientdata")]
    public string ClientData
    {
      get
      {
        return this.GetAttributeValue<string>("clientdata");
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("createstage")]
    public OptionSetValue CreateStage
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("createstage");
      }
      set
      {
        this.OnPropertyChanging("CreateStage");
        this.SetAttributeValue("createstage", (object) value);
        this.OnPropertyChanged("CreateStage");
      }
    }

    [AttributeLogicalName("deletestage")]
    public OptionSetValue DeleteStage
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("deletestage");
      }
      set
      {
        this.OnPropertyChanging("DeleteStage");
        this.SetAttributeValue("deletestage", (object) value);
        this.OnPropertyChanged("DeleteStage");
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

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get
      {
        return this.GetAttributeValue<byte[]>("entityimage");
      }
      set
      {
        this.OnPropertyChanging("EntityImage");
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged("EntityImage");
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp
    {
      get
      {
        return this.GetAttributeValue<long?>("entityimage_timestamp");
      }
    }

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL
    {
      get
      {
        return this.GetAttributeValue<string>("entityimage_url");
      }
    }

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("entityimageid");
      }
    }

    [AttributeLogicalName("formid")]
    public Guid? FormId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("formid");
      }
      set
      {
        this.OnPropertyChanging("FormId");
        this.SetAttributeValue("formid", (object) value);
        this.OnPropertyChanged("FormId");
      }
    }

    [AttributeLogicalName("inputparameters")]
    public string InputParameters
    {
      get
      {
        return this.GetAttributeValue<string>("inputparameters");
      }
      set
      {
        this.OnPropertyChanging("InputParameters");
        this.SetAttributeValue("inputparameters", (object) value);
        this.OnPropertyChanged("InputParameters");
      }
    }

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get
      {
        return this.GetAttributeValue<string>("introducedversion");
      }
      set
      {
        this.OnPropertyChanging("IntroducedVersion");
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged("IntroducedVersion");
      }
    }

    [AttributeLogicalName("iscrmuiworkflow")]
    public bool? IsCrmUIWorkflow
    {
      get
      {
        return this.GetAttributeValue<bool?>("iscrmuiworkflow");
      }
    }

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get
      {
        return this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      }
      set
      {
        this.OnPropertyChanging("IsCustomizable");
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged("IsCustomizable");
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged
    {
      get
      {
        return this.GetAttributeValue<bool?>("ismanaged");
      }
    }

    [AttributeLogicalName("istransacted")]
    public bool? IsTransacted
    {
      get
      {
        return this.GetAttributeValue<bool?>("istransacted");
      }
      set
      {
        this.OnPropertyChanging("IsTransacted");
        this.SetAttributeValue("istransacted", (object) value);
        this.OnPropertyChanged("IsTransacted");
      }
    }

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get
      {
        return this.GetAttributeValue<int?>("languagecode");
      }
      set
      {
        this.OnPropertyChanging("LanguageCode");
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged("LanguageCode");
      }
    }

    [AttributeLogicalName("mode")]
    public OptionSetValue Mode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("mode");
      }
      set
      {
        this.OnPropertyChanging("Mode");
        this.SetAttributeValue("mode", (object) value);
        this.OnPropertyChanged("Mode");
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

    [AttributeLogicalName("ondemand")]
    public bool? OnDemand
    {
      get
      {
        return this.GetAttributeValue<bool?>("ondemand");
      }
      set
      {
        this.OnPropertyChanging("OnDemand");
        this.SetAttributeValue("ondemand", (object) value);
        this.OnPropertyChanged("OnDemand");
      }
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("overwritetime");
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

    [AttributeLogicalName("parentworkflowid")]
    public EntityReference ParentWorkflowId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("parentworkflowid");
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

    [AttributeLogicalName("primaryentity")]
    public string PrimaryEntity
    {
      get
      {
        return this.GetAttributeValue<string>("primaryentity");
      }
      set
      {
        this.OnPropertyChanging("PrimaryEntity");
        this.SetAttributeValue("primaryentity", (object) value);
        this.OnPropertyChanged("PrimaryEntity");
      }
    }

    [AttributeLogicalName("processorder")]
    public int? ProcessOrder
    {
      get
      {
        return this.GetAttributeValue<int?>("processorder");
      }
      set
      {
        this.OnPropertyChanging("ProcessOrder");
        this.SetAttributeValue("processorder", (object) value);
        this.OnPropertyChanged("ProcessOrder");
      }
    }

    [AttributeLogicalName("processroleassignment")]
    public string ProcessRoleAssignment
    {
      get
      {
        return this.GetAttributeValue<string>("processroleassignment");
      }
      set
      {
        this.OnPropertyChanging("ProcessRoleAssignment");
        this.SetAttributeValue("processroleassignment", (object) value);
        this.OnPropertyChanged("ProcessRoleAssignment");
      }
    }

    [AttributeLogicalName("rank")]
    public int? Rank
    {
      get
      {
        return this.GetAttributeValue<int?>("rank");
      }
      set
      {
        this.OnPropertyChanging("Rank");
        this.SetAttributeValue("rank", (object) value);
        this.OnPropertyChanged("Rank");
      }
    }

    [AttributeLogicalName("rendererobjecttypecode")]
    public string RendererObjectTypeCode
    {
      get
      {
        return this.GetAttributeValue<string>("rendererobjecttypecode");
      }
      set
      {
        this.OnPropertyChanging("RendererObjectTypeCode");
        this.SetAttributeValue("rendererobjecttypecode", (object) value);
        this.OnPropertyChanged("RendererObjectTypeCode");
      }
    }

    [AttributeLogicalName("runas")]
    public OptionSetValue RunAs
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("runas");
      }
      set
      {
        this.OnPropertyChanging("RunAs");
        this.SetAttributeValue("runas", (object) value);
        this.OnPropertyChanged("RunAs");
      }
    }

    [AttributeLogicalName("scope")]
    public OptionSetValue Scope
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("scope");
      }
      set
      {
        this.OnPropertyChanging("Scope");
        this.SetAttributeValue("scope", (object) value);
        this.OnPropertyChanged("Scope");
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

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("solutionid");
      }
    }

    [AttributeLogicalName("statecode")]
    public WorkflowState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new WorkflowState?((WorkflowState) Enum.ToObject(typeof (WorkflowState), attributeValue.Value));
        return new WorkflowState?();
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

    [AttributeLogicalName("subprocess")]
    public bool? Subprocess
    {
      get
      {
        return this.GetAttributeValue<bool?>("subprocess");
      }
      set
      {
        this.OnPropertyChanging("Subprocess");
        this.SetAttributeValue("subprocess", (object) value);
        this.OnPropertyChanged("Subprocess");
      }
    }

    [AttributeLogicalName("syncworkflowlogonfailure")]
    public bool? SyncWorkflowLogOnFailure
    {
      get
      {
        return this.GetAttributeValue<bool?>("syncworkflowlogonfailure");
      }
      set
      {
        this.OnPropertyChanging("SyncWorkflowLogOnFailure");
        this.SetAttributeValue("syncworkflowlogonfailure", (object) value);
        this.OnPropertyChanged("SyncWorkflowLogOnFailure");
      }
    }

    [AttributeLogicalName("triggeroncreate")]
    public bool? TriggerOnCreate
    {
      get
      {
        return this.GetAttributeValue<bool?>("triggeroncreate");
      }
      set
      {
        this.OnPropertyChanging("TriggerOnCreate");
        this.SetAttributeValue("triggeroncreate", (object) value);
        this.OnPropertyChanged("TriggerOnCreate");
      }
    }

    [AttributeLogicalName("triggerondelete")]
    public bool? TriggerOnDelete
    {
      get
      {
        return this.GetAttributeValue<bool?>("triggerondelete");
      }
      set
      {
        this.OnPropertyChanging("TriggerOnDelete");
        this.SetAttributeValue("triggerondelete", (object) value);
        this.OnPropertyChanged("TriggerOnDelete");
      }
    }

    [AttributeLogicalName("triggeronupdateattributelist")]
    public string TriggerOnUpdateAttributeList
    {
      get
      {
        return this.GetAttributeValue<string>("triggeronupdateattributelist");
      }
      set
      {
        this.OnPropertyChanging("TriggerOnUpdateAttributeList");
        this.SetAttributeValue("triggeronupdateattributelist", (object) value);
        this.OnPropertyChanged("TriggerOnUpdateAttributeList");
      }
    }

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("type");
      }
      set
      {
        this.OnPropertyChanging("Type");
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged("Type");
      }
    }

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get
      {
        return this.GetAttributeValue<string>("uniquename");
      }
      set
      {
        this.OnPropertyChanging("UniqueName");
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged("UniqueName");
      }
    }

    [AttributeLogicalName("updatestage")]
    public OptionSetValue UpdateStage
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("updatestage");
      }
      set
      {
        this.OnPropertyChanging("UpdateStage");
        this.SetAttributeValue("updatestage", (object) value);
        this.OnPropertyChanged("UpdateStage");
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

    [AttributeLogicalName("workflowid")]
    public Guid? WorkflowId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("workflowid");
      }
      set
      {
        this.OnPropertyChanging("WorkflowId");
        this.SetAttributeValue("workflowid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("WorkflowId");
      }
    }

    [AttributeLogicalName("workflowid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.WorkflowId = new Guid?(value);
      }
    }

    [AttributeLogicalName("workflowidunique")]
    public Guid? WorkflowIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("workflowidunique");
      }
    }

    [AttributeLogicalName("xaml")]
    public string Xaml
    {
      get
      {
        return this.GetAttributeValue<string>("xaml");
      }
      set
      {
        this.OnPropertyChanging("Xaml");
        this.SetAttributeValue("xaml", (object) value);
        this.OnPropertyChanged("Xaml");
      }
    }

    [RelationshipSchemaName("lk_asyncoperation_workflowactivationid")]
    public IEnumerable<AsyncOperation> lk_asyncoperation_workflowactivationid
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_workflowactivationid", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("lk_asyncoperation_workflowactivationid");
        this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_workflowactivationid", new EntityRole?(), value);
        this.OnPropertyChanged("lk_asyncoperation_workflowactivationid");
      }
    }

    [RelationshipSchemaName("workflow_active_workflow", EntityRole.Referenced)]
    public IEnumerable<Workflow> Referencedworkflow_active_workflow
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("workflow_active_workflow", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedworkflow_active_workflow");
        this.SetRelatedEntities<Workflow>("workflow_active_workflow", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedworkflow_active_workflow");
      }
    }

    [RelationshipSchemaName("workflow_dependencies")]
    public IEnumerable<WorkflowDependency> workflow_dependencies
    {
      get
      {
        return this.GetRelatedEntities<WorkflowDependency>("workflow_dependencies", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_dependencies");
        this.SetRelatedEntities<WorkflowDependency>("workflow_dependencies", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_dependencies");
      }
    }

    [RelationshipSchemaName("workflow_parent_workflow", EntityRole.Referenced)]
    public IEnumerable<Workflow> Referencedworkflow_parent_workflow
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("workflow_parent_workflow", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedworkflow_parent_workflow");
        this.SetRelatedEntities<Workflow>("workflow_parent_workflow", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedworkflow_parent_workflow");
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_workflow")]
    public BusinessUnit business_unit_workflow
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_workflow", new EntityRole?());
      }
    }

    [RelationshipSchemaName("system_user_workflow")]
    [AttributeLogicalName("owninguser")]
    public SystemUser system_user_workflow
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("system_user_workflow", new EntityRole?());
      }
    }

    [AttributeLogicalName("activeworkflowid")]
    [RelationshipSchemaName("workflow_active_workflow", EntityRole.Referencing)]
    public Workflow Referencingworkflow_active_workflow
    {
      get
      {
        return this.GetRelatedEntity<Workflow>("workflow_active_workflow", new EntityRole?(EntityRole.Referencing));
      }
    }

    [RelationshipSchemaName("workflow_createdby")]
    [AttributeLogicalName("createdby")]
    public SystemUser workflow_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("workflow_createdby", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("workflow_createdonbehalfby")]
    public SystemUser workflow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("workflow_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("workflow_modifiedby")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser workflow_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("workflow_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("workflow_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser workflow_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("workflow_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("parentworkflowid")]
    [RelationshipSchemaName("workflow_parent_workflow", EntityRole.Referencing)]
    public Workflow Referencingworkflow_parent_workflow
    {
      get
      {
        return this.GetRelatedEntity<Workflow>("workflow_parent_workflow", new EntityRole?(EntityRole.Referencing));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public Workflow()
      : base("workflow")
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
