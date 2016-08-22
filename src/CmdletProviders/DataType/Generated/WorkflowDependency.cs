using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("workflowdependency")]
  public class WorkflowDependency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "workflowdependency";
    public const int EntityTypeCode = 4704;

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

    [AttributeLogicalName("customentityname")]
    public string CustomEntityName
    {
      get
      {
        return this.GetAttributeValue<string>("customentityname");
      }
      set
      {
        this.OnPropertyChanging("CustomEntityName");
        this.SetAttributeValue("customentityname", (object) value);
        this.OnPropertyChanged("CustomEntityName");
      }
    }

    [AttributeLogicalName("dependentattributename")]
    public string DependentAttributeName
    {
      get
      {
        return this.GetAttributeValue<string>("dependentattributename");
      }
      set
      {
        this.OnPropertyChanging("DependentAttributeName");
        this.SetAttributeValue("dependentattributename", (object) value);
        this.OnPropertyChanged("DependentAttributeName");
      }
    }

    [AttributeLogicalName("dependententityname")]
    public string DependentEntityName
    {
      get
      {
        return this.GetAttributeValue<string>("dependententityname");
      }
      set
      {
        this.OnPropertyChanging("DependentEntityName");
        this.SetAttributeValue("dependententityname", (object) value);
        this.OnPropertyChanged("DependentEntityName");
      }
    }

    [AttributeLogicalName("entityattributes")]
    public string EntityAttributes
    {
      get
      {
        return this.GetAttributeValue<string>("entityattributes");
      }
      set
      {
        this.OnPropertyChanging("EntityAttributes");
        this.SetAttributeValue("entityattributes", (object) value);
        this.OnPropertyChanged("EntityAttributes");
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("ownerid");
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit
    {
      get
      {
        return this.GetAttributeValue<Guid?>("owningbusinessunit");
      }
    }

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser
    {
      get
      {
        return this.GetAttributeValue<Guid?>("owninguser");
      }
    }

    [AttributeLogicalName("parametername")]
    public string ParameterName
    {
      get
      {
        return this.GetAttributeValue<string>("parametername");
      }
      set
      {
        this.OnPropertyChanging("ParameterName");
        this.SetAttributeValue("parametername", (object) value);
        this.OnPropertyChanged("ParameterName");
      }
    }

    [AttributeLogicalName("parametertype")]
    public string ParameterType
    {
      get
      {
        return this.GetAttributeValue<string>("parametertype");
      }
      set
      {
        this.OnPropertyChanging("ParameterType");
        this.SetAttributeValue("parametertype", (object) value);
        this.OnPropertyChanged("ParameterType");
      }
    }

    [AttributeLogicalName("relatedattributename")]
    public string RelatedAttributeName
    {
      get
      {
        return this.GetAttributeValue<string>("relatedattributename");
      }
      set
      {
        this.OnPropertyChanging("RelatedAttributeName");
        this.SetAttributeValue("relatedattributename", (object) value);
        this.OnPropertyChanged("RelatedAttributeName");
      }
    }

    [AttributeLogicalName("relatedentityname")]
    public string RelatedEntityName
    {
      get
      {
        return this.GetAttributeValue<string>("relatedentityname");
      }
      set
      {
        this.OnPropertyChanging("RelatedEntityName");
        this.SetAttributeValue("relatedentityname", (object) value);
        this.OnPropertyChanged("RelatedEntityName");
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public EntityReference SdkMessageId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("sdkmessageid");
      }
      set
      {
        this.OnPropertyChanging("SdkMessageId");
        this.SetAttributeValue("sdkmessageid", (object) value);
        this.OnPropertyChanged("SdkMessageId");
      }
    }

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("type");
      }
      set
      {
        this.OnPropertyChanging("Type");
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged("Type");
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

    [AttributeLogicalName("workflowdependencyid")]
    public Guid? WorkflowDependencyId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("workflowdependencyid");
      }
      set
      {
        this.OnPropertyChanging("WorkflowDependencyId");
        this.SetAttributeValue("workflowdependencyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("WorkflowDependencyId");
      }
    }

    [AttributeLogicalName("workflowdependencyid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.WorkflowDependencyId = new Guid?(value);
      }
    }

    [AttributeLogicalName("workflowid")]
    public EntityReference WorkflowId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("workflowid");
      }
      set
      {
        this.OnPropertyChanging("WorkflowId");
        this.SetAttributeValue("workflowid", (object) value);
        this.OnPropertyChanged("WorkflowId");
      }
    }

    [RelationshipSchemaName("sdkmessageid_workflow_dependency")]
    [AttributeLogicalName("sdkmessageid")]
    public SdkMessage sdkmessageid_workflow_dependency
    {
      get
      {
        return this.GetRelatedEntity<SdkMessage>("sdkmessageid_workflow_dependency", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("sdkmessageid_workflow_dependency");
        this.SetRelatedEntity<SdkMessage>("sdkmessageid_workflow_dependency", new EntityRole?(), value);
        this.OnPropertyChanged("sdkmessageid_workflow_dependency");
      }
    }

    [AttributeLogicalName("workflowid")]
    [RelationshipSchemaName("workflow_dependencies")]
    public Workflow workflow_dependencies
    {
      get
      {
        return this.GetRelatedEntity<Workflow>("workflow_dependencies", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("workflow_dependencies");
        this.SetRelatedEntity<Workflow>("workflow_dependencies", new EntityRole?(), value);
        this.OnPropertyChanged("workflow_dependencies");
      }
    }

    [RelationshipSchemaName("workflow_dependency_createdby")]
    [AttributeLogicalName("createdby")]
    public SystemUser workflow_dependency_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("workflow_dependency_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("workflow_dependency_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser workflow_dependency_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("workflow_dependency_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("workflow_dependency_modifiedby")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser workflow_dependency_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("workflow_dependency_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("workflow_dependency_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser workflow_dependency_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("workflow_dependency_modifiedonbehalfby", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public WorkflowDependency()
      : base("workflowdependency")
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
