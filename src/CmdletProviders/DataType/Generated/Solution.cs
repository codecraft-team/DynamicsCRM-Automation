using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solution")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class Solution : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solution";
    public const int EntityTypeCode = 7100;

    [AttributeLogicalName("configurationpageid")]
    public EntityReference ConfigurationPageId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("configurationpageid");
      }
      set
      {
        this.OnPropertyChanging("ConfigurationPageId");
        this.SetAttributeValue("configurationpageid", (object) value);
        this.OnPropertyChanged("ConfigurationPageId");
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

    [AttributeLogicalName("friendlyname")]
    public string FriendlyName
    {
      get
      {
        return this.GetAttributeValue<string>("friendlyname");
      }
      set
      {
        this.OnPropertyChanging("FriendlyName");
        this.SetAttributeValue("friendlyname", (object) value);
        this.OnPropertyChanged("FriendlyName");
      }
    }

    [AttributeLogicalName("installedon")]
    public DateTime? InstalledOn
    {
      get
      {
        return this.GetAttributeValue<DateTime?>("installedon");
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

    [AttributeLogicalName("isvisible")]
    public bool? IsVisible
    {
      get
      {
        return this.GetAttributeValue<bool?>("isvisible");
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
    public EntityReference OrganizationId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("organizationid");
      }
    }

    [AttributeLogicalName("parentsolutionid")]
    public EntityReference ParentSolutionId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("parentsolutionid");
      }
    }

    [AttributeLogicalName("pinpointassetid")]
    public string PinpointAssetId
    {
      get
      {
        return this.GetAttributeValue<string>("pinpointassetid");
      }
    }

    [AttributeLogicalName("pinpointpublisherid")]
    public long? PinpointPublisherId
    {
      get
      {
        return this.GetAttributeValue<long?>("pinpointpublisherid");
      }
    }

    [AttributeLogicalName("pinpointsolutiondefaultlocale")]
    public string PinpointSolutionDefaultLocale
    {
      get
      {
        return this.GetAttributeValue<string>("pinpointsolutiondefaultlocale");
      }
    }

    [AttributeLogicalName("pinpointsolutionid")]
    public long? PinpointSolutionId
    {
      get
      {
        return this.GetAttributeValue<long?>("pinpointsolutionid");
      }
    }

    [AttributeLogicalName("publisherid")]
    public EntityReference PublisherId
    {
      get
      {
        return this.GetAttributeValue<EntityReference>("publisherid");
      }
      set
      {
        this.OnPropertyChanging("PublisherId");
        this.SetAttributeValue("publisherid", (object) value);
        this.OnPropertyChanged("PublisherId");
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("solutionid");
      }
      set
      {
        this.OnPropertyChanging("SolutionId");
        this.SetAttributeValue("solutionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("SolutionId");
      }
    }

    [AttributeLogicalName("solutionid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.SolutionId = new Guid?(value);
      }
    }

    [AttributeLogicalName("solutionpackageversion")]
    public string SolutionPackageVersion
    {
      get
      {
        return this.GetAttributeValue<string>("solutionpackageversion");
      }
      set
      {
        this.OnPropertyChanging("SolutionPackageVersion");
        this.SetAttributeValue("solutionpackageversion", (object) value);
        this.OnPropertyChanged("SolutionPackageVersion");
      }
    }

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get
      {
        return this.GetAttributeValue<string>("uniquename");
      }
      set
      {
        this.OnPropertyChanging("UniqueName");
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged("UniqueName");
      }
    }

    [AttributeLogicalName("version")]
    public string Version
    {
      get
      {
        return this.GetAttributeValue<string>("version");
      }
      set
      {
        this.OnPropertyChanging("Version");
        this.SetAttributeValue("version", (object) value);
        this.OnPropertyChanged("Version");
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

    [RelationshipSchemaName("solution_parent_solution", EntityRole.Referenced)]
    public IEnumerable<Solution> Referencedsolution_parent_solution
    {
      get
      {
        return this.GetRelatedEntities<Solution>("solution_parent_solution", new EntityRole?(EntityRole.Referenced));
      }
      set
      {
        this.OnPropertyChanging("Referencedsolution_parent_solution");
        this.SetRelatedEntities<Solution>("solution_parent_solution", new EntityRole?(EntityRole.Referenced), value);
        this.OnPropertyChanged("Referencedsolution_parent_solution");
      }
    }

    [RelationshipSchemaName("solution_solutioncomponent")]
    public IEnumerable<SolutionComponent> solution_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntities<SolutionComponent>("solution_solutioncomponent", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("solution_solutioncomponent");
        this.SetRelatedEntities<SolutionComponent>("solution_solutioncomponent", new EntityRole?(), value);
        this.OnPropertyChanged("solution_solutioncomponent");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_solution_createdby")]
    public SystemUser lk_solution_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_solution_createdby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_solution_modifiedby")]
    [AttributeLogicalName("modifiedby")]
    public SystemUser lk_solution_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_solution_modifiedby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_solutionbase_createdonbehalfby")]
    [AttributeLogicalName("createdonbehalfby")]
    public SystemUser lk_solutionbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_solutionbase_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_solutionbase_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_solutionbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_solutionbase_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("publisherid")]
    [RelationshipSchemaName("publisher_solution")]
    public Publisher publisher_solution
    {
      get
      {
        return this.GetRelatedEntity<Publisher>("publisher_solution", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("publisher_solution");
        this.SetRelatedEntity<Publisher>("publisher_solution", new EntityRole?(), value);
        this.OnPropertyChanged("publisher_solution");
      }
    }

    [AttributeLogicalName("configurationpageid")]
    [RelationshipSchemaName("solution_configuration_webresource")]
    public WebResource solution_configuration_webresource
    {
      get
      {
        return this.GetRelatedEntity<WebResource>("solution_configuration_webresource", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("solution_configuration_webresource");
        this.SetRelatedEntity<WebResource>("solution_configuration_webresource", new EntityRole?(), value);
        this.OnPropertyChanged("solution_configuration_webresource");
      }
    }

    [RelationshipSchemaName("solution_parent_solution", EntityRole.Referencing)]
    [AttributeLogicalName("parentsolutionid")]
    public Solution Referencingsolution_parent_solution
    {
      get
      {
        return this.GetRelatedEntity<Solution>("solution_parent_solution", new EntityRole?(EntityRole.Referencing));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public Solution()
      : base("solution")
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
