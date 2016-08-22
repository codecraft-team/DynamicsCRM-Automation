using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyusd_actioncallworkflow")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class msdyusd_actioncallworkflow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyusd_actioncallworkflow";
    public const int EntityTypeCode = 10017;

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

    [AttributeLogicalName("msdyusd_actioncallworkflowid")]
    public Guid? msdyusd_actioncallworkflowId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("msdyusd_actioncallworkflowid");
      }
      set
      {
        this.OnPropertyChanging("msdyusd_actioncallworkflowId");
        this.SetAttributeValue("msdyusd_actioncallworkflowid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("msdyusd_actioncallworkflowId");
      }
    }

    [AttributeLogicalName("msdyusd_actioncallworkflowid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.msdyusd_actioncallworkflowId = new Guid?(value);
      }
    }

    [AttributeLogicalName("msdyusd_name")]
    public string msdyusd_name
    {
      get
      {
        return this.GetAttributeValue<string>("msdyusd_name");
      }
      set
      {
        this.OnPropertyChanging("msdyusd_name");
        this.SetAttributeValue("msdyusd_name", (object) value);
        this.OnPropertyChanged("msdyusd_name");
      }
    }

    [AttributeLogicalName("msdyusd_workflow")]
    public string msdyusd_Workflow
    {
      get
      {
        return this.GetAttributeValue<string>("msdyusd_workflow");
      }
      set
      {
        this.OnPropertyChanging("msdyusd_Workflow");
        this.SetAttributeValue("msdyusd_workflow", (object) value);
        this.OnPropertyChanged("msdyusd_Workflow");
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
    public msdyusd_actioncallworkflowState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new msdyusd_actioncallworkflowState?((msdyusd_actioncallworkflowState) Enum.ToObject(typeof (msdyusd_actioncallworkflowState), attributeValue.Value));
        return new msdyusd_actioncallworkflowState?();
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

    [RelationshipSchemaName("msdyusd_actioncallworkflow_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyusd_actioncallworkflow_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("msdyusd_actioncallworkflow_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("msdyusd_actioncallworkflow_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("msdyusd_actioncallworkflow_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("msdyusd_actioncallworkflow_AsyncOperations");
      }
    }

    [RelationshipSchemaName("business_unit_msdyusd_actioncallworkflow")]
    [AttributeLogicalName("owningbusinessunit")]
    public BusinessUnit business_unit_msdyusd_actioncallworkflow
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_msdyusd_actioncallworkflow", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyusd_actioncallworkflow_createdby")]
    public SystemUser lk_msdyusd_actioncallworkflow_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_msdyusd_actioncallworkflow_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_msdyusd_actioncallworkflow_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_msdyusd_actioncallworkflow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_msdyusd_actioncallworkflow_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyusd_actioncallworkflow_modifiedby")]
    public SystemUser lk_msdyusd_actioncallworkflow_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_msdyusd_actioncallworkflow_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_msdyusd_actioncallworkflow_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_msdyusd_actioncallworkflow_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_msdyusd_actioncallworkflow_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyusd_actioncallworkflow")]
    public SystemUser user_msdyusd_actioncallworkflow
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("user_msdyusd_actioncallworkflow", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public msdyusd_actioncallworkflow()
      : base("msdyusd_actioncallworkflow")
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
