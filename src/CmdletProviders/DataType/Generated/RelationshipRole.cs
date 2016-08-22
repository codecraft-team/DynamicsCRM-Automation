using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("relationshiprole")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class RelationshipRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "relationshiprole";
    public const int EntityTypeCode = 4500;

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

    [AttributeLogicalName("relationshiproleid")]
    public Guid? RelationshipRoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("relationshiproleid");
      }
      set
      {
        this.OnPropertyChanging("RelationshipRoleId");
        this.SetAttributeValue("relationshiproleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("RelationshipRoleId");
      }
    }

    [AttributeLogicalName("relationshiproleid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.RelationshipRoleId = new Guid?(value);
      }
    }

    [AttributeLogicalName("statecode")]
    public RelationshipRoleState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new RelationshipRoleState?((RelationshipRoleState) Enum.ToObject(typeof (RelationshipRoleState), attributeValue.Value));
        return new RelationshipRoleState?();
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber
    {
      get
      {
        return this.GetAttributeValue<long?>("versionnumber");
      }
    }

    [RelationshipSchemaName("relationship_role_customer_opportunity_roles")]
    public IEnumerable<CustomerOpportunityRole> relationship_role_customer_opportunity_roles
    {
      get
      {
        return this.GetRelatedEntities<CustomerOpportunityRole>("relationship_role_customer_opportunity_roles", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("relationship_role_customer_opportunity_roles");
        this.SetRelatedEntities<CustomerOpportunityRole>("relationship_role_customer_opportunity_roles", new EntityRole?(), value);
        this.OnPropertyChanged("relationship_role_customer_opportunity_roles");
      }
    }

    [RelationshipSchemaName("relationship_role_relationship_role_map")]
    public IEnumerable<RelationshipRoleMap> relationship_role_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntities<RelationshipRoleMap>("relationship_role_relationship_role_map", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("relationship_role_relationship_role_map");
        this.SetRelatedEntities<RelationshipRoleMap>("relationship_role_relationship_role_map", new EntityRole?(), value);
        this.OnPropertyChanged("relationship_role_relationship_role_map");
      }
    }

    [RelationshipSchemaName("RelationshipRole_AsyncOperations")]
    public IEnumerable<AsyncOperation> RelationshipRole_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("RelationshipRole_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("RelationshipRole_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("RelationshipRole_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("RelationshipRole_AsyncOperations");
      }
    }

    [RelationshipSchemaName("createdby_relationship_role")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_relationship_role
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_relationship_role", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_relationshiprole_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_relationshiprole_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_relationshiprole_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_relationshiprole_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_relationshiprole_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_relationshiprole_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_relationship_role")]
    public SystemUser modifiedby_relationship_role
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_relationship_role", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public RelationshipRole()
      : base("relationshiprole")
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
