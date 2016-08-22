using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("serviceendpoint")]
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public class ServiceEndpoint : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "serviceendpoint";
    public const int EntityTypeCode = 4618;

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("componentstate");
      }
    }

    [AttributeLogicalName("connectionmode")]
    public OptionSetValue ConnectionMode
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("connectionmode");
      }
      set
      {
        this.OnPropertyChanging("ConnectionMode");
        this.SetAttributeValue("connectionmode", (object) value);
        this.OnPropertyChanged("ConnectionMode");
      }
    }

    [AttributeLogicalName("contract")]
    public OptionSetValue Contract
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("contract");
      }
      set
      {
        this.OnPropertyChanging("Contract");
        this.SetAttributeValue("contract", (object) value);
        this.OnPropertyChanged("Contract");
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

    [AttributeLogicalName("path")]
    public string Path
    {
      get
      {
        return this.GetAttributeValue<string>("path");
      }
      set
      {
        this.OnPropertyChanging("Path");
        this.SetAttributeValue("path", (object) value);
        this.OnPropertyChanged("Path");
      }
    }

    [AttributeLogicalName("serviceendpointid")]
    public Guid? ServiceEndpointId
    {
      get
      {
        return this.GetAttributeValue<Guid?>("serviceendpointid");
      }
      set
      {
        this.OnPropertyChanging("ServiceEndpointId");
        this.SetAttributeValue("serviceendpointid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged("ServiceEndpointId");
      }
    }

    [AttributeLogicalName("serviceendpointid")]
    public override Guid Id
    {
      get
      {
        return base.Id;
      }
      set
      {
        this.ServiceEndpointId = new Guid?(value);
      }
    }

    [AttributeLogicalName("serviceendpointidunique")]
    public Guid? ServiceEndpointIdUnique
    {
      get
      {
        return this.GetAttributeValue<Guid?>("serviceendpointidunique");
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

    [AttributeLogicalName("solutionnamespace")]
    public string SolutionNamespace
    {
      get
      {
        return this.GetAttributeValue<string>("solutionnamespace");
      }
      set
      {
        this.OnPropertyChanging("SolutionNamespace");
        this.SetAttributeValue("solutionnamespace", (object) value);
        this.OnPropertyChanged("SolutionNamespace");
      }
    }

    [AttributeLogicalName("userclaim")]
    public OptionSetValue UserClaim
    {
      get
      {
        return this.GetAttributeValue<OptionSetValue>("userclaim");
      }
      set
      {
        this.OnPropertyChanging("UserClaim");
        this.SetAttributeValue("userclaim", (object) value);
        this.OnPropertyChanged("UserClaim");
      }
    }

    [RelationshipSchemaName("serviceendpoint_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> serviceendpoint_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>("serviceendpoint_sdkmessageprocessingstep", new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging("serviceendpoint_sdkmessageprocessingstep");
        this.SetRelatedEntities<SdkMessageProcessingStep>("serviceendpoint_sdkmessageprocessingstep", new EntityRole?(), value);
        this.OnPropertyChanged("serviceendpoint_sdkmessageprocessingstep");
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_serviceendpoint")]
    public SystemUser createdby_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("createdby_serviceendpoint", new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_serviceendpointbase_createdonbehalfby")]
    public SystemUser lk_serviceendpointbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_serviceendpointbase_createdonbehalfby", new EntityRole?());
      }
    }

    [RelationshipSchemaName("lk_serviceendpointbase_modifiedonbehalfby")]
    [AttributeLogicalName("modifiedonbehalfby")]
    public SystemUser lk_serviceendpointbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("lk_serviceendpointbase_modifiedonbehalfby", new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_serviceendpoint")]
    public SystemUser modifiedby_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>("modifiedby_serviceendpoint", new EntityRole?());
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    public ServiceEndpoint()
      : base("serviceendpoint")
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
