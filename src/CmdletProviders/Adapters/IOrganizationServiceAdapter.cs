using System;
using System.Collections.Generic;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public interface IOrganizationServiceAdapter {
    string OrganizationFriendlyName { get; }
    IEnumerable<EntityMetadata> RetrieveAllEntityMetadata();
    EntityMetadata RetrieveEntityMetadata(string entityLogicalName, EntityFilters attributes);
    IEnumerable<AttributeMetadata> RetrieveAttributes(string entityLogicalName);
    IEnumerable<OneToManyRelationshipMetadata> RetrieveOneToManyRelationships(string entityLogicalName);
    IEnumerable<OneToManyRelationshipMetadata> RetrieveManyToOneRelationships(string entityLogicalName);
    IEnumerable<ManyToManyRelationshipMetadata> RetrieveManyToManyRelationships(string entityLogicalName);
    IEnumerable<Entity> RetrieveFilteredForms(string entityLogicalName);
    void DeleteAttribute(string entityLogicalName, string attributeLogicalName);
    void DeleteRelationship(string entityLogicalName, string relationshipSchemaName);
    RetrieveDependenciesForDeleteResponse RetrieveDependencies(ComponentType componentType, Guid objectId);
    OrganizationServiceContext CreateContext();
    void Update(Entity entity);
    string GetUrl();
    void PublishEntity(string logicalName);
    IEnumerable<PluginAssembly> RetrievePluginAssemblies();
    IEnumerable<PluginType> RetrievePluginSteps(Guid assemblyId);
  }
}