using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("incidentresolution")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class IncidentResolution : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "incidentresolution";
    public const int EntityTypeCode = 4206;

    [AttributeLogicalName("activityid")]
    public Guid? ActivityId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("activityid");
      }
      set
      {
        this.OnPropertyChanging("ActivityId");
        this.SetAttributeValue("activityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("ActivityId");
      }
    }

    [AttributeLogicalName("activityid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.ActivityId = new Guid?(value);
      }
    }

    [AttributeLogicalName("activitytypecode")]
    public string ActivityTypeCode
    {
      get
      {
        return this.GetAttributeValue<string>("activitytypecode");
      }
    }

    [AttributeLogicalName("actualdurationminutes")]
    public int? ActualDurationMinutes
    {
      get
      {
        return this.GetAttributeValue<int?>("actualdurationminutes");
      }
      set
      {
        this.OnPropertyChanging("ActualDurationMinutes");
        this.SetAttributeValue("actualdurationminutes", (object) value);
        this.OnPropertyChanged("ActualDurationMinutes");
      }
    }

    [AttributeLogicalName("actualend")]
    public DateTime? ActualEnd
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("actualend");
      }
      set
      {
        this.OnPropertyChanging("ActualEnd");
        this.SetAttributeValue("actualend", (object) value);
        this.OnPropertyChanged("ActualEnd");
      }
    }

    [AttributeLogicalName("actualstart")]
    public DateTime? ActualStart
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("actualstart");
      }
      set
      {
        this.OnPropertyChanging("ActualStart");
        this.SetAttributeValue("actualstart", (object) value);
        this.OnPropertyChanged("ActualStart");
      }
    }

    [AttributeLogicalName("category")]
    public string Category
    {
      get
      {
        return this.GetAttributeValue<string>("category");
      }
      set
      {
        this.OnPropertyChanging("Category");
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged("Category");
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

    [AttributeLogicalName("createdbyexternalparty")]
    public EntityReference CreatedByExternalParty
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("createdbyexternalparty");
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

    [AttributeLogicalName("incidentid")]
    public EntityReference IncidentId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("incidentid");
      }
      set
      {
        this.OnPropertyChanging("IncidentId");
        this.SetAttributeValue("incidentid", (object) value);
        this.OnPropertyChanged("IncidentId");
      }
    }

    [AttributeLogicalName("isbilled")]
    public bool? IsBilled
    {
      get
      {
        return this.GetAttributeValue<bool?>("isbilled");
      }
      set
      {
        this.OnPropertyChanging("IsBilled");
        this.SetAttributeValue("isbilled", (object) value);
        this.OnPropertyChanged("IsBilled");
      }
    }

    [AttributeLogicalName("isregularactivity")]
    public bool? IsRegularActivity
    {
      get
      {
        return this.GetAttributeValue<bool?>("isregularactivity");
      }
    }

    [AttributeLogicalName("isworkflowcreated")]
    public bool? IsWorkflowCreated
    {
      get
      {
        return this.GetAttributeValue<bool?>("isworkflowcreated");
      }
      set
      {
        this.OnPropertyChanging("IsWorkflowCreated");
        this.SetAttributeValue("isworkflowcreated", (object) value);
        this.OnPropertyChanged("IsWorkflowCreated");
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

    [AttributeLogicalName("modifiedbyexternalparty")]
    public EntityReference ModifiedByExternalParty
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("modifiedbyexternalparty");
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

    [AttributeLogicalName("scheduleddurationminutes")]
    public int? ScheduledDurationMinutes
    {
      get
      {
        return this.GetAttributeValue<int?>("scheduleddurationminutes");
      }
    }

    [AttributeLogicalName("scheduledend")]
    public DateTime? ScheduledEnd
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("scheduledend");
      }
      set
      {
        this.OnPropertyChanging("ScheduledEnd");
        this.SetAttributeValue("scheduledend", (object) value);
        this.OnPropertyChanged("ScheduledEnd");
      }
    }

    [AttributeLogicalName("scheduledstart")]
    public DateTime? ScheduledStart
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("scheduledstart");
      }
      set
      {
        this.OnPropertyChanging("ScheduledStart");
        this.SetAttributeValue("scheduledstart", (object) value);
        this.OnPropertyChanged("ScheduledStart");
      }
    }

    [AttributeLogicalName("serviceid")]
    public EntityReference ServiceId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("serviceid");
      }
      set
      {
        this.OnPropertyChanging("ServiceId");
        this.SetAttributeValue("serviceid", (object) value);
        this.OnPropertyChanged("ServiceId");
      }
    }

    [AttributeLogicalName("statecode")]
    public IncidentResolutionState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new IncidentResolutionState?((IncidentResolutionState) Enum.ToObject(typeof (IncidentResolutionState), attributeValue.Value));
        return new IncidentResolutionState?();
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

    [AttributeLogicalName("subcategory")]
    public string Subcategory
    {
      get
      {
        return this.GetAttributeValue<string>("subcategory");
      }
      set
      {
        this.OnPropertyChanging("Subcategory");
        this.SetAttributeValue("subcategory", (object) value);
        this.OnPropertyChanged("Subcategory");
      }
    }

    [AttributeLogicalName("subject")]
    public string Subject
    {
      get
      {
        return this.GetAttributeValue<string>("subject");
      }
      set
      {
        this.OnPropertyChanging("Subject");
        this.SetAttributeValue("subject", (object) value);
        this.OnPropertyChanged("Subject");
      }
    }

    [AttributeLogicalName("timespent")]
    public int? TimeSpent
    {
      get
      {
        return this.GetAttributeValue<int?>("timespent");
      }
      set
      {
        this.OnPropertyChanging("TimeSpent");
        this.SetAttributeValue("timespent", (object) value);
        this.OnPropertyChanged("TimeSpent");
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

    [RelationshipSchemaName("IncidentResolution_AsyncOperations")]
    public IEnumerable<AsyncOperation> IncidentResolution_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("IncidentResolution_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("IncidentResolution_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("IncidentResolution_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("IncidentResolution_AsyncOperations");
      }
    }

    [RelationshipSchemaName("business_unit_incident_resolution_activities")]
    [AttributeLogicalName("owningbusinessunit")]
    public BusinessUnit business_unit_incident_resolution_activities
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_incident_resolution_activities", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_incidentresolution_createdby")]
    [AttributeLogicalName("createdby")]
    public SystemUser lk_incidentresolution_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_incidentresolution_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_incidentresolution_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_incidentresolution_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_incidentresolution_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_incidentresolution_modifiedby")]
    public SystemUser lk_incidentresolution_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_incidentresolution_modifiedby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_incidentresolution_modifiedonbehalfby")]
    public SystemUser lk_incidentresolution_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_incidentresolution_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("user_incidentresolution")]
    [AttributeLogicalName("owninguser")]
    public SystemUser user_incidentresolution
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("user_incidentresolution", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public IncidentResolution()
      : base("incidentresolution")
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
