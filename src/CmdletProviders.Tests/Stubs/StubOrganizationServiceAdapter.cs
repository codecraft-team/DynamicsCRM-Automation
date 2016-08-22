using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Stubs {
  public class StubOrganizationServiceAdapter : IOrganizationServiceAdapter {
    public string OrganizationFriendlyName { get; }
    public List<EntityMetadata> EntityMetadataDetail { get; set; }
    public Dictionary<string, List<Entity>> Forms { get; set; }
    public Dictionary<string, List<AttributeMetadata>> Fields { get; set; }
    public Dictionary<string, List<OneToManyRelationshipMetadata>> ManyToOneRelationships { get; set; }
    public Dictionary<string, List<OneToManyRelationshipMetadata>> OneToManyRelationships { get; set; }
    public Dictionary<string, List<ManyToManyRelationshipMetadata>> ManyToManyRelationships { get; set; }
    public Dictionary<string, List<Entity>> Entities { get; set; }

    public StubOrganizationServiceAdapter(string organizationFriendlyName) {
      OrganizationFriendlyName = organizationFriendlyName;
      EntityMetadataDetail = new List<EntityMetadata>();
      Forms = new Dictionary<string, List<Entity>>();
    }

    public IOrganizationService CreateOrganizationService(OrganizationDetail organizationDetail) {
      return new StubOrganizationService();
    }

    public void Initialize(OrganizationDetail organizationDetail) {
      //Prevent Mock behavior, implement stub property.
      //Contract.Requires<InvalidOperationException>(string.Equals(OrganizationFriendlyName, organizationDetail.FriendlyName));
    }

    public IEnumerable<EntityMetadata> RetrieveAllEntityMetadata() {
      return EntityMetadataDetail;
    }

    public EntityMetadata RetrieveEntityMetadata(string entityLogicalName, EntityFilters attributes) {
      throw new NotImplementedException();
    }

    public IEnumerable<AttributeMetadata> RetrieveAttributes(string entityLogicalName) {
      return Fields[entityLogicalName];
    }

    public IEnumerable<OneToManyRelationshipMetadata> RetrieveManyToOneRelationships(string entityLogicalName) {
      return ManyToOneRelationships[entityLogicalName];
    }

    public IEnumerable<ManyToManyRelationshipMetadata> RetrieveManyToManyRelationships(string entityLogicalName) {
      return ManyToManyRelationships[entityLogicalName];
    }

    public IEnumerable<OneToManyRelationshipMetadata> RetrieveOneToManyRelationships(string entityLogicalName) {
      return OneToManyRelationships[entityLogicalName];
    }

    public void DeleteAttribute(string entityLogicalName, string attributeLogicalName) {
      //TODO: Implement dependency exists exception mock. 
      //IEnumerable<Entity> entityForms = Forms[OrganizationFriendlyName].Where(entity => (string)entity["name"] == entityLogicalName);
      //Regex controlRegex = new Regex($".*<control.*datafieldname=\"{attributeLogicalName}\"\\s+");
      //bool existsOnForm = entityForms.Any(form => controlRegex.IsMatch((string)form["formxml"]));

      //if (existsOnForm) {
      //  throw new FaultException<OrganizationServiceFault>(new OrganizationServiceFault {
      //    ErrorCode = AttributeMetadataNode.DependencyFoundError
      //  });
      //}
      Fields[entityLogicalName].Remove(Fields[entityLogicalName].First(a => a.LogicalName == attributeLogicalName));
    }

    public void DeleteRelationship(string entityLogicalName, string relationshipSchemaName) {
      throw new NotImplementedException();
    }

    public RetrieveDependenciesForDeleteResponse RetrieveDependencies(ComponentType componentType, Guid objectId) {
      throw new NotImplementedException();
    }

    public OrganizationServiceContext CreateContext() {
      return new StubOrganizationServiceContext(new StubOrganizationService()) {
        Entities = Entities.ToDictionary(e => e.Key, e => e.Value.AsQueryable())
      };
    }

    public void Update(Entity entity) {
      throw new NotImplementedException();
    }

    public string GetUrl() {
      return null;
    }

    public void PublishEntity(string logicalName) {
      throw new NotImplementedException();
    }

    public IEnumerable<PluginAssembly> RetrievePluginAssemblies() {
      throw new NotImplementedException();
    }

    public IEnumerable<PluginType> RetrievePluginSteps(Guid assemblyId) {
      throw new NotImplementedException();
    }

    public IEnumerable<Entity> RetrieveFilteredForms(string entityLogicalName) {
      return Forms[entityLogicalName];
    }
  }

  public class DeploymentModel {
    public OrganizationModel Organizations { get; set; }
  }

  public class OrganizationModel {
    public IEnumerable<EntityMetadataModel> EntityMetadataModels { get; set; }
  }

  public class EntityMetadataModel {
    public IEnumerable<FormModel> FormModels { get; set; }
    public IEnumerable<AttributeMetadataModel> FieldModels { get; set; }
    public IEnumerable<OneToManyRelationshipModel> OneToManyRelationshipModels { get; set; }
    public IEnumerable<ManyToOneRelationshipModel> ManyToOneRelationshipModels { get; set; }
    public IEnumerable<ManyToManyRelationshipModel> ManyToManyRelationshipModel { get; set; }
  }

  public class FormModel {
    public IEnumerable<ControlModel> ControlModels { get; set; }
  }

  public class AttributeMetadataModel {

  }

  public class ControlModel {

  }

  public class OneToManyRelationshipModel {

  }

  public class ManyToManyRelationshipModel {

  }

  public class ManyToOneRelationshipModel {

  }
}