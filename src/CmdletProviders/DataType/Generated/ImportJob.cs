using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("importjob")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class ImportJob : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "importjob";
    public const int EntityTypeCode = 9107;

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("completedon");
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

    [AttributeLogicalName("importjobid")]
    public Guid? ImportJobId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("importjobid");
      }
      set
      {
        this.OnPropertyChanging("ImportJobId");
        this.SetAttributeValue("importjobid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("ImportJobId");
      }
    }

    [AttributeLogicalName("importjobid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.ImportJobId = new Guid?(value);
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("organizationid");
      }
    }

    [AttributeLogicalName("progress")]
    public double? Progress
    {
      get
      {
        return this.GetAttributeValue<double?>("progress");
      }
      set
      {
        this.OnPropertyChanging("Progress");
        this.SetAttributeValue("progress", (object) value);
        this.OnPropertyChanged("Progress");
      }
    }

    [AttributeLogicalName("solutionname")]
    public string SolutionName
    {
      get
      {
        return this.GetAttributeValue<string>("solutionname");
      }
      set
      {
        this.OnPropertyChanging("SolutionName");
        this.SetAttributeValue("solutionname", (object) value);
        this.OnPropertyChanged("SolutionName");
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

    [RelationshipSchemaName("lk_importjobbase_createdby")]
    [AttributeLogicalName("createdby")]
    public SystemUser lk_importjobbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_importjobbase_createdby", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_importjobbase_createdonbehalfby")]
    public SystemUser lk_importjobbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_importjobbase_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_importjobbase_modifiedby")]
    public SystemUser lk_importjobbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_importjobbase_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_importjobbase_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_importjobbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_importjobbase_modifiedonbehalfby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public ImportJob()
      : base("importjob")
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
