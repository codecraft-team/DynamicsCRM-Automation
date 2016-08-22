using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("customeropportunityrole")]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class CustomerOpportunityRole : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "customeropportunityrole";
    public const int EntityTypeCode = 4503;

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

    [AttributeLogicalName("customerid")]
    public EntityReference CustomerId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("customerid");
      }
      set
      {
        this.OnPropertyChanging("CustomerId");
        this.SetAttributeValue("customerid", (object) value);
        this.OnPropertyChanged("CustomerId");
      }
    }

    [AttributeLogicalName("customeropportunityroleid")]
    public Guid? CustomerOpportunityRoleId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("customeropportunityroleid");
      }
      set
      {
        this.OnPropertyChanging("CustomerOpportunityRoleId");
        this.SetAttributeValue("customeropportunityroleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("CustomerOpportunityRoleId");
      }
    }

    [AttributeLogicalName("customeropportunityroleid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.CustomerOpportunityRoleId = new Guid?(value);
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

    [AttributeLogicalName("opportunityid")]
    public EntityReference OpportunityId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("opportunityid");
      }
      set
      {
        this.OnPropertyChanging("OpportunityId");
        this.SetAttributeValue("opportunityid", (object) value);
        this.OnPropertyChanged("OpportunityId");
      }
    }

    [AttributeLogicalName("opportunityroleid")]
    public EntityReference OpportunityRoleId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("opportunityroleid");
      }
      set
      {
        this.OnPropertyChanging("OpportunityRoleId");
        this.SetAttributeValue("opportunityroleid", (object) value);
        this.OnPropertyChanged("OpportunityRoleId");
      }
    }

    [AttributeLogicalName("opportunitystatecode")]
    public int? OpportunityStateCode
    {
      get
      {
        return this.GetAttributeValue<int?>("opportunitystatecode");
      }
    }

    [AttributeLogicalName("opportunitystatuscode")]
    public int? OpportunityStatusCode
    {
      get
      {
        return this.GetAttributeValue<int?>("opportunitystatuscode");
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber
    {
      get
      {
        return this.GetAttributeValue<long?>("versionnumber");
      }
    }

    [RelationshipSchemaName("CustomerOpportunityRole_AsyncOperations")]
    public IEnumerable<AsyncOperation> CustomerOpportunityRole_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>("CustomerOpportunityRole_AsyncOperations", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("CustomerOpportunityRole_AsyncOperations");
        this.SetRelatedEntities<AsyncOperation>("CustomerOpportunityRole_AsyncOperations", new EntityRole?(), value);
        this.OnPropertyChanged("CustomerOpportunityRole_AsyncOperations");
      }
    }

    [RelationshipSchemaName("business_customer_opportunity_roles")]
    [AttributeLogicalName("owningbusinessunit")]
    public BusinessUnit business_customer_opportunity_roles
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>("business_customer_opportunity_roles", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_customeropportunityrole_createdby")]
    public SystemUser lk_customeropportunityrole_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_customeropportunityrole_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_customeropportunityrole_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_customeropportunityrole_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_customeropportunityrole_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_customeropportunityrole_modifiedby")]
    public SystemUser lk_customeropportunityrole_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_customeropportunityrole_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_customeropportunityrole_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_customeropportunityrole_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_customeropportunityrole_modifiedonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("relationship_role_customer_opportunity_roles")]
    [AttributeLogicalName("opportunityroleid")]
    public RelationshipRole relationship_role_customer_opportunity_roles
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>("relationship_role_customer_opportunity_roles", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("relationship_role_customer_opportunity_roles");
        this.SetRelatedEntity<RelationshipRole>("relationship_role_customer_opportunity_roles", new EntityRole?(), value);
        this.OnPropertyChanged("relationship_role_customer_opportunity_roles");
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_customer_opportunity_roles")]
    public SystemUser user_customer_opportunity_roles
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("user_customer_opportunity_roles", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public CustomerOpportunityRole()
      : base("customeropportunityrole")
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
