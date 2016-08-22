using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("relationshiprolemap")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class RelationshipRoleMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "relationshiprolemap";
    public const int EntityTypeCode = 4501;

    [AttributeLogicalName("associateobjecttypecode")]
    public string AssociateObjectTypeCode
    {
      get
      {
        return this.GetAttributeValue<string>("associateobjecttypecode");
      }
      set
      {
        this.OnPropertyChanging("AssociateObjectTypeCode");
        this.SetAttributeValue("associateobjecttypecode", (object) value);
        this.OnPropertyChanged("AssociateObjectTypeCode");
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

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("organizationid");
      }
    }

    [AttributeLogicalName("primaryobjecttypecode")]
    public string PrimaryObjectTypeCode
    {
      get
      {
        return this.GetAttributeValue<string>("primaryobjecttypecode");
      }
      set
      {
        this.OnPropertyChanging("PrimaryObjectTypeCode");
        this.SetAttributeValue("primaryobjecttypecode", (object) value);
        this.OnPropertyChanged("PrimaryObjectTypeCode");
      }
    }

    [AttributeLogicalName("relationshiproleid")]
    public EntityReference RelationshipRoleId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("relationshiproleid");
      }
      set
      {
        this.OnPropertyChanging("RelationshipRoleId");
        this.SetAttributeValue("relationshiproleid", (object) value);
        this.OnPropertyChanged("RelationshipRoleId");
      }
    }

    [AttributeLogicalName("relationshiprolemapid")]
    public Guid? RelationshipRoleMapId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("relationshiprolemapid");
      }
      set
      {
        this.OnPropertyChanging("RelationshipRoleMapId");
        this.SetAttributeValue("relationshiprolemapid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("RelationshipRoleMapId");
      }
    }

    [AttributeLogicalName("relationshiprolemapid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.RelationshipRoleMapId = new Guid?(value);
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

    [RelationshipSchemaName("RelationshipRoleMap_AsyncOperations")]
    public IEnumerable<AsyncOperation> RelationshipRoleMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("RelationshipRoleMap_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("RelationshipRoleMap_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("RelationshipRoleMap_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("RelationshipRoleMap_AsyncOperations");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_relationship_role_map")]
    public SystemUser createdby_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_relationship_role_map", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_relationshiprolemap_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_relationshiprolemap_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_relationshiprolemap_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_relationshiprolemap_modifiedonbehalfby")]
    public SystemUser lk_relationshiprolemap_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_relationshiprolemap_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_relationship_role_map")]
    public SystemUser modifiedby_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_relationship_role_map", new EntityRole?());
      }
    }

    [AttributeLogicalName("relationshiproleid")]
    [RelationshipSchemaName("relationship_role_relationship_role_map")]
    public RelationshipRole relationship_role_relationship_role_map
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>("relationship_role_relationship_role_map", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("relationship_role_relationship_role_map");
        this.SetRelatedEntity<RelationshipRole>("relationship_role_relationship_role_map", new EntityRole?(), value);
        this.OnPropertyChanged("relationship_role_relationship_role_map");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public RelationshipRoleMap()
      : base("relationshiprolemap")
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
