using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solutioncomponent")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class SolutionComponent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solutioncomponent";
    public const int EntityTypeCode = 7103;

    [AttributeLogicalName("componenttype")]
    public OptionSetValue ComponentType
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("componenttype");
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

    [AttributeLogicalName("ismetadata")]
    public bool? IsMetadata
    {
      get
      {
        return this.GetAttributeValue<bool?>("ismetadata");
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

    [AttributeLogicalName("objectid")]
    public Guid? ObjectId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("objectid");
      }
    }

    [AttributeLogicalName("rootcomponentbehavior")]
    public OptionSetValue RootComponentBehavior
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("rootcomponentbehavior");
      }
    }

    [AttributeLogicalName("rootsolutioncomponentid")]
    public Guid? RootSolutionComponentId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("rootsolutioncomponentid");
      }
    }

    [AttributeLogicalName("solutioncomponentid")]
    public Guid? SolutionComponentId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("solutioncomponentid");
      }
    }

    [AttributeLogicalName("solutioncomponentid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        base.Id = value;
      }
    }

    [AttributeLogicalName("solutionid")]
    public EntityReference SolutionId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("solutionid");
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

    [RelationshipSchemaName("solutioncomponent_parent_solutioncomponent", EntityRole.Referenced)]
    public IEnumerable<SolutionComponent> Referencedsolutioncomponent_parent_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntities<SolutionComponent>("solutioncomponent_parent_solutioncomponent", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedsolutioncomponent_parent_solutioncomponent");
        this.SetRelatedEntities<SolutionComponent>("solutioncomponent_parent_solutioncomponent", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedsolutioncomponent_parent_solutioncomponent");
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentbase_createdonbehalfby")]
    public SystemUser lk_solutioncomponentbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_solutioncomponentbase_createdonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentbase_modifiedonbehalfby")]
    public SystemUser lk_solutioncomponentbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_solutioncomponentbase_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("solutionid")]
    [RelationshipSchemaName("solution_solutioncomponent")]
    public Solution solution_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntity<Solution>("solution_solutioncomponent", new EntityRole?());
      }
    }

    [AttributeLogicalName("rootsolutioncomponentid")]
    [RelationshipSchemaName("solutioncomponent_parent_solutioncomponent", EntityRole.Referencing)]
    public SolutionComponent Referencingsolutioncomponent_parent_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntity<SolutionComponent>("solutioncomponent_parent_solutioncomponent", new EntityRole?(EntityRole.Referencing));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public SolutionComponent()
      : base("solutioncomponent")
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
