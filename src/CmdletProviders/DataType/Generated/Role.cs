using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("role")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class Role : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "role";
    public const int EntityTypeCode = 1036;

    [AttributeLogicalName("businessunitid")]
    public EntityReference BusinessUnitId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("businessunitid");
      }
      set
      {
        this.OnPropertyChanging("BusinessUnitId");
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged("BusinessUnitId");
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
    public Guid? OrganizationId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("organizationid");
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("overwritetime");
      }
    }

    [AttributeLogicalName("parentroleid")]
    public EntityReference ParentRoleId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("parentroleid");
      }
    }

    [AttributeLogicalName("parentrootroleid")]
    public EntityReference ParentRootRoleId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("parentrootroleid");
      }
    }

    [AttributeLogicalName("roleid")]
    public Guid? RoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roleid");
      }
      set
      {
        this.OnPropertyChanging("RoleId");
        this.SetAttributeValue("roleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("RoleId");
      }
    }

    [AttributeLogicalName("roleid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.RoleId = new Guid?(value);
      }
    }

    [AttributeLogicalName("roleidunique")]
    public Guid? RoleIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("roleidunique");
      }
    }

    [AttributeLogicalName("roletemplateid")]
    public EntityReference RoleTemplateId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("roletemplateid");
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

    [RelationshipSchemaName("Role_AsyncOperations")]
    public IEnumerable<AsyncOperation> Role_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("Role_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("Role_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("Role_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("Role_AsyncOperations");
      }
    }

    [RelationshipSchemaName("role_parent_role", EntityRole.Referenced)]
    public IEnumerable<Role> Referencedrole_parent_role
    {
      get
      {
        return this.GetRelatedEntities<Role>("role_parent_role", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedrole_parent_role");
        this.SetRelatedEntities<Role>("role_parent_role", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedrole_parent_role");
      }
    }

    [RelationshipSchemaName("role_parent_root_role", EntityRole.Referenced)]
    public IEnumerable<Role> Referencedrole_parent_root_role
    {
      get
      {
        return this.GetRelatedEntities<Role>("role_parent_root_role", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedrole_parent_root_role");
        this.SetRelatedEntities<Role>("role_parent_root_role", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedrole_parent_root_role");
      }
    }

    [RelationshipSchemaName("systemuserroles_association")]
    public IEnumerable<SystemUser> systemuserroles_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>("systemuserroles_association", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("systemuserroles_association");
        this.SetRelatedEntities<SystemUser>("systemuserroles_association", new EntityRole?(), value);
        this.OnPropertyChanged("systemuserroles_association");
      }
    }

    [RelationshipSchemaName("business_unit_roles")]
    [AttributeLogicalName("businessunitid")]
    public BusinessUnit business_unit_roles
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_unit_roles", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("business_unit_roles");
        this.SetRelatedEntity<BusinessUnit>("business_unit_roles", new EntityRole?(), value);
        this.OnPropertyChanged("business_unit_roles");
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_role_createdonbehalfby")]
    public SystemUser lk_role_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_role_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_role_modifiedonbehalfby")]
    public SystemUser lk_role_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_role_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_rolebase_createdby")]
    [AttributeLogicalName("createdby")]
    public SystemUser lk_rolebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_rolebase_createdby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_rolebase_modifiedby")]
    public SystemUser lk_rolebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_rolebase_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("role_parent_role", EntityRole.Referencing)]
    [AttributeLogicalName("parentroleid")]
    public Role Referencingrole_parent_role
    {
      get
      {
        return this.GetRelatedEntity<Role>("role_parent_role", new EntityRole?(EntityRole.Referencing));
      }
    }

    [AttributeLogicalName("parentrootroleid")]
    [RelationshipSchemaName("role_parent_root_role", EntityRole.Referencing)]
    public Role Referencingrole_parent_root_role
    {
      get
      {
        return this.GetRelatedEntity<Role>("role_parent_root_role", new EntityRole?(EntityRole.Referencing));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public Role()
      : base("role")
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
