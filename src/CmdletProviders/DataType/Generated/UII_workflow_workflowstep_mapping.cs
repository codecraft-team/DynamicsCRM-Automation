using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("uii_workflow_workflowstep_mapping")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class UII_workflow_workflowstep_mapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "uii_workflow_workflowstep_mapping";
    public const int EntityTypeCode = 10016;

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
    public UII_workflow_workflowstep_mappingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new UII_workflow_workflowstep_mappingState?((UII_workflow_workflowstep_mappingState) Enum.ToObject(typeof (UII_workflow_workflowstep_mappingState), attributeValue.Value));
        return new UII_workflow_workflowstep_mappingState?();
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

    [AttributeLogicalName("uii_sequence")]
    public string UII_sequence
    {
      get
      {
        return this.GetAttributeValue<string>("uii_sequence");
      }
      set
      {
        this.OnPropertyChanging("UII_sequence");
        this.SetAttributeValue("uii_sequence", (object) value);
        this.OnPropertyChanged("UII_sequence");
      }
    }

    [AttributeLogicalName("uii_workflow_mappingid")]
    public EntityReference uii_workflow_mappingid
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("uii_workflow_mappingid");
      }
      set
      {
        this.OnPropertyChanging("uii_workflow_mappingid");
        this.SetAttributeValue("uii_workflow_mappingid", (object) value);
        this.OnPropertyChanged("uii_workflow_mappingid");
      }
    }

    [AttributeLogicalName("uii_workflow_workflowstep_mappingid")]
    public Guid? UII_workflow_workflowstep_mappingId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("uii_workflow_workflowstep_mappingid");
      }
      set
      {
        this.OnPropertyChanging("UII_workflow_workflowstep_mappingId");
        this.SetAttributeValue("uii_workflow_workflowstep_mappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("UII_workflow_workflowstep_mappingId");
      }
    }

    [AttributeLogicalName("uii_workflow_workflowstep_mappingid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.UII_workflow_workflowstep_mappingId = new Guid?(value);
      }
    }

    [AttributeLogicalName("uii_workflowstep_mappingid")]
    public EntityReference uii_workflowstep_mappingid
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("uii_workflowstep_mappingid");
      }
      set
      {
        this.OnPropertyChanging("uii_workflowstep_mappingid");
        this.SetAttributeValue("uii_workflowstep_mappingid", (object) value);
        this.OnPropertyChanged("uii_workflowstep_mappingid");
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

    [RelationshipSchemaName("uii_workflow_workflowstep_mapping_AsyncOperations")]
    public IEnumerable<AsyncOperation> uii_workflow_workflowstep_mapping_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("uii_workflow_workflowstep_mapping_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflow_workflowstep_mapping_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("uii_workflow_workflowstep_mapping_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflow_workflowstep_mapping_AsyncOperations");
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_uii_workflow_workflowstep_mapping")]
    public BusinessUnit business_unit_uii_workflow_workflowstep_mapping
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_uii_workflow_workflowstep_mapping", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_uii_workflow_workflowstep_mapping_createdby")]
    public SystemUser lk_uii_workflow_workflowstep_mapping_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflow_workflowstep_mapping_createdby", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_uii_workflow_workflowstep_mapping_createdonbehalfby")]
    public SystemUser lk_uii_workflow_workflowstep_mapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflow_workflowstep_mapping_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_uii_workflow_workflowstep_mapping_modifiedby")]
    public SystemUser lk_uii_workflow_workflowstep_mapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflow_workflowstep_mapping_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflow_workflowstep_mapping_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("uii_workflow_mappingid")]
    [RelationshipSchemaName("uii_workflows_mapping")]
    public UII_workflow uii_workflows_mapping
    {
      get
      {
        return this.GetRelatedEntity<UII_workflow>("uii_workflows_mapping", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflows_mapping");
        this.SetRelatedEntity<UII_workflow>("uii_workflows_mapping", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflows_mapping");
      }
    }

    [AttributeLogicalName("uii_workflowstep_mappingid")]
    [RelationshipSchemaName("uii_workflowstep_mapping")]
    public UII_workflowstep uii_workflowstep_mapping
    {
      get
      {
        return this.GetRelatedEntity<UII_workflowstep>("uii_workflowstep_mapping", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflowstep_mapping");
        this.SetRelatedEntity<UII_workflowstep>("uii_workflowstep_mapping", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflowstep_mapping");
      }
    }

    [RelationshipSchemaName("user_uii_workflow_workflowstep_mapping")]
    [AttributeLogicalName("owninguser")]
    public SystemUser user_uii_workflow_workflowstep_mapping
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("user_uii_workflow_workflowstep_mapping", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public UII_workflow_workflowstep_mapping()
      : base("uii_workflow_workflowstep_mapping")
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
