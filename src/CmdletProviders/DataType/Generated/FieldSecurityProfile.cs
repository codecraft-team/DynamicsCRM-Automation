using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("fieldsecurityprofile")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class FieldSecurityProfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "fieldsecurityprofile";
    public const int EntityTypeCode = 1200;

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

    [AttributeLogicalName("fieldsecurityprofileid")]
    public Guid? FieldSecurityProfileId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("fieldsecurityprofileid");
      }
      set
      {
        this.OnPropertyChanging("FieldSecurityProfileId");
        this.SetAttributeValue("fieldsecurityprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("FieldSecurityProfileId");
      }
    }

    [AttributeLogicalName("fieldsecurityprofileid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.FieldSecurityProfileId = new Guid?(value);
      }
    }

    [AttributeLogicalName("fieldsecurityprofileidunique")]
    public Guid? FieldSecurityProfileIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("fieldsecurityprofileidunique");
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("overwritetime");
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber
    {
      get
      {
        return this.GetAttributeValue<long?>("versionnumber");
      }
    }

    [RelationshipSchemaName("systemuserprofiles_association")]
    public IEnumerable<SystemUser> systemuserprofiles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("systemuserprofiles_association", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("systemuserprofiles_association");
        this.SetRelatedEntities<SystemUser>("systemuserprofiles_association", new EntityRole?(), value);
        this.OnPropertyChanged("systemuserprofiles_association");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_fieldsecurityprofile_createdby")]
    public SystemUser lk_fieldsecurityprofile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_fieldsecurityprofile_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_fieldsecurityprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedby")]
    public SystemUser lk_fieldsecurityprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_modifiedby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_fieldsecurityprofile_modifiedonbehalfby")]
    public SystemUser lk_fieldsecurityprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_modifiedonbehalfby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public FieldSecurityProfile()
      : base("fieldsecurityprofile")
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
