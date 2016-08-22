using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("uii_workflowstep")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class UII_workflowstep : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "uii_workflowstep";
    public const int EntityTypeCode = 10015;

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
    public UII_workflowstepState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new UII_workflowstepState?((UII_workflowstepState) Enum.ToObject(typeof (UII_workflowstepState), attributeValue.Value));
        return new UII_workflowstepState?();
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

    [AttributeLogicalName("uii_actionid")]
    public EntityReference uii_actionid
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("uii_actionid");
      }
      set
      {
        this.OnPropertyChanging("uii_actionid");
        this.SetAttributeValue("uii_actionid", (object) value);
        this.OnPropertyChanged("uii_actionid");
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

    [AttributeLogicalName("uii_hostedapplicationworkflowstepid")]
    public EntityReference uii_hostedapplicationworkflowstepid
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("uii_hostedapplicationworkflowstepid");
      }
      set
      {
        this.OnPropertyChanging("uii_hostedapplicationworkflowstepid");
        this.SetAttributeValue("uii_hostedapplicationworkflowstepid", (object) value);
        this.OnPropertyChanged("uii_hostedapplicationworkflowstepid");
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

    [AttributeLogicalName("uii_workflowstepid")]
    public Guid? UII_workflowstepId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("uii_workflowstepid");
      }
      set
      {
        this.OnPropertyChanging("UII_workflowstepId");
        this.SetAttributeValue("uii_workflowstepid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("UII_workflowstepId");
      }
    }

    [AttributeLogicalName("uii_workflowstepid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.UII_workflowstepId = new Guid?(value);
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

    [RelationshipSchemaName("uii_workflowstep_AsyncOperations")]
    public IEnumerable<AsyncOperation> uii_workflowstep_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("uii_workflowstep_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflowstep_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("uii_workflowstep_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflowstep_AsyncOperations");
      }
    }

    [RelationshipSchemaName("uii_workflowstep_mapping")]
    public IEnumerable<UII_workflow_workflowstep_mapping> uii_workflowstep_mapping
    {
      get
      {
        return this.GetRelatedEntities<UII_workflow_workflowstep_mapping>("uii_workflowstep_mapping", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("uii_workflowstep_mapping");
        this.SetRelatedEntities<UII_workflow_workflowstep_mapping>("uii_workflowstep_mapping", new EntityRole?(), value);
        this.OnPropertyChanged("uii_workflowstep_mapping");
      }
    }

    [RelationshipSchemaName("business_unit_uii_workflowstep")]
    [AttributeLogicalName("owningbusinessunit")]
    public BusinessUnit business_unit_uii_workflowstep
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_uii_workflowstep", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_uii_workflowstep_createdby")]
    public SystemUser lk_uii_workflowstep_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflowstep_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_uii_workflowstep_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_uii_workflowstep_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflowstep_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_uii_workflowstep_modifiedby")]
    public SystemUser lk_uii_workflowstep_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflowstep_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_uii_workflowstep_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_uii_workflowstep_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_uii_workflowstep_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_uii_workflowstep")]
    public SystemUser user_uii_workflowstep
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("user_uii_workflowstep", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public UII_workflowstep()
      : base("uii_workflowstep")
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
