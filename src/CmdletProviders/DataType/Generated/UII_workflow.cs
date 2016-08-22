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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("uii_workflow")]
  public class UII_workflow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "uii_workflow";
    public const int EntityTypeCode = 10014;

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

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get
      {
        return this.GetAttributeValue<int?>("importsequencenumber");
      }
      set
      {
        this.OnPropertyChanging("ImportSequenceNumber");
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged("ImportSequenceNumber");
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

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("overriddencreatedon");
      }
      set
      {
        this.OnPropertyChanging("OverriddenCreatedOn");
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged("OverriddenCreatedOn");
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

    [AttributeLogicalName("statecode")]
    public UII_workflowState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new UII_workflowState?((UII_workflowState) Enum.ToObject(typeof (UII_workflowState), attributeValue.Value));
        return new UII_workflowState?();
      }
      set
      {
        this.OnPropertyChanging("statecode");
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged("statecode");
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue statuscode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("statuscode");
      }
      set
      {
        this.OnPropertyChanging("statuscode");
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged("statuscode");
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

    [AttributeLogicalName("uii_description")]
    public string UII_Description
    {
      get
      {
        return this.GetAttributeValue<string>("uii_description");
      }
      set
      {
        this.OnPropertyChanging("UII_Description");
        this.SetAttributeValue("uii_description", (object) value);
        this.OnPropertyChanged("UII_Description");
      }
    }

    [AttributeLogicalName("uii_isforcedworkflow")]
    public bool? UII_isForcedWorkflow
    {
      get
      {
        return this.GetAttributeValue<bool?>("uii_isforcedworkflow");
      }
      set
      {
        this.OnPropertyChanging("UII_isForcedWorkflow");
        this.SetAttributeValue("uii_isforcedworkflow", (object) value);
        this.OnPropertyChanged("UII_isForcedWorkflow");
      }
    }

    [AttributeLogicalName("uii_name")]
    public string UII_name
    {
      get
      {
        return this.GetAttributeValue<string>("uii_name");
      }
      set
      {
        this.OnPropertyChanging("UII_name");
        this.SetAttributeValue("uii_name", (object) value);
        this.OnPropertyChanged("UII_name");
      }
    }

    [AttributeLogicalName("uii_workflowid")]
    public Guid? UII_workflowId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("uii_workflowid");
      }
      set
      {
        this.OnPropertyChanging("UII_workflowId");
        this.SetAttributeValue("uii_workflowid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("UII_workflowId");
      }
    }

    [AttributeLogicalName("uii_workflowid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.UII_workflowId = new Guid?(value);
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber
    {
      get
      {
        return this.GetAttributeValue<long?>("versionnumber");
      }
    }

    [RelationshipSchemaName("uii_workflow_AsyncOperations")]
    public IEnumerable<AsyncOperation> uii_workflow_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("uii_workflow_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflow_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("uii_workflow_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflow_AsyncOperations");
      }
    }

    [RelationshipSchemaName("uii_workflows_mapping")]
    public IEnumerable<UII_workflow_workflowstep_mapping> uii_workflows_mapping
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow_workflowstep_mapping>("uii_workflows_mapping", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflows_mapping");
        this.SetRelatedEntities<UII_workflow_workflowstep_mapping>("uii_workflows_mapping", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflows_mapping");
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_uii_workflow")]
    public BusinessUnit business_unit_uii_workflow
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_uii_workflow", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_uii_workflow_createdby")]
    public SystemUser lk_uii_workflow_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflow_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_uii_workflow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflow_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_uii_workflow_modifiedby")]
    public SystemUser lk_uii_workflow_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflow_modifiedby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_uii_workflow_modifiedonbehalfby")]
    public SystemUser lk_uii_workflow_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflow_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("user_uii_workflow")]
    [AttributeLogicalName("owninguser")]
    public SystemUser user_uii_workflow
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("user_uii_workflow", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public UII_workflow()
      : base("uii_workflow")
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
