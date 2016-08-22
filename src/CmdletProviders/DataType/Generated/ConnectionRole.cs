using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("connectionrole")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public class ConnectionRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "connectionrole";
    public const int EntityTypeCode = 3231;

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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("componentstate");
      }
    }

    [AttributeLogicalName("connectionroleid")]
    public Guid? ConnectionRoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("connectionroleid");
      }
      set
      {
        this.OnPropertyChanging("ConnectionRoleId");
        this.SetAttributeValue("connectionroleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("ConnectionRoleId");
      }
    }

    [AttributeLogicalName("connectionroleid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.ConnectionRoleId = new Guid?(value);
      }
    }

    [AttributeLogicalName("connectionroleidunique")]
    public Guid? ConnectionRoleIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("connectionroleidunique");
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

    [AttributeLogicalName("statecode")]
    public ConnectionRoleState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        if (attributeValue != null)
          return new ConnectionRoleState?((ConnectionRoleState) Enum.ToObject(typeof (ConnectionRoleState), attributeValue.Value));
        return new ConnectionRoleState?();
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

    [RelationshipSchemaName("Connection_Role_AsyncOperations")]
    public IEnumerable<AsyncOperation> Connection_Role_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("Connection_Role_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("Connection_Role_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("Connection_Role_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("Connection_Role_AsyncOperations");
      }
    }

    [RelationshipSchemaName("connection_role_connection_role_object_type_codes")]
    public IEnumerable<ConnectionRoleObjectTypeCode> connection_role_connection_role_object_type_codes
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRoleObjectTypeCode>("connection_role_connection_role_object_type_codes", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("connection_role_connection_role_object_type_codes");
        this.SetRelatedEntities<ConnectionRoleObjectTypeCode>("connection_role_connection_role_object_type_codes", new EntityRole?(), value);
        this.OnPropertyChanged("connection_role_connection_role_object_type_codes");
      }
    }

    [RelationshipSchemaName("connectionroleassociation_association", EntityRole.Referencing)]
    public IEnumerable<ConnectionRole> Referencingconnectionroleassociation_association
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?(EntityRole.Referencing));
      }
      set
      {
        this.OnPropertyChanging("Referencingconnectionroleassociation_association");
        this.SetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?(EntityRole.Referencing), value);
        this.OnPropertyChanged("Referencingconnectionroleassociation_association");
      }
    }

    [RelationshipSchemaName("connectionroleassociation_association", EntityRole.Referenced)]
    public IEnumerable<ConnectionRole> Referencedconnectionroleassociation_association
    {
      get
      {
        return this.GetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedconnectionroleassociation_association");
        this.SetRelatedEntities<ConnectionRole>("connectionroleassociation_association", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedconnectionroleassociation_association");
      }
    }

    [RelationshipSchemaName("createdby_connection_role")]
    [AttributeLogicalName("createdby")]
    public SystemUser createdby_connection_role
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_connection_role", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_connectionrolebase_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_connectionrolebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_connectionrolebase_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_connectionrolebase_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_connectionrolebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_connectionrolebase_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_connection_role")]
    public SystemUser modifiedby_connection_role
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_connection_role", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public ConnectionRole()
      : base("connectionrole")
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
