using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public class CachedOrganizationServiceAdapter : OrganizationServiceAdapter, IOrganizationServiceAdapter {
    private IEnumerable<EntityMetadata> _allEntityMetadataCache;
    private readonly Dictionary<string, IEnumerable<AttributeMetadata>> _attributeMetadataCache = new Dictionary<string, IEnumerable<AttributeMetadata>>();
    private readonly Dictionary<string, Dictionary<EntityFilters, EntityMetadata>> _retrieveEntityMetadataCache = new Dictionary<string, Dictionary<EntityFilters, EntityMetadata>>();
    private readonly Dictionary<string, IEnumerable<Entity>> _filteredFormsCache = new Dictionary<string, IEnumerable<Entity>>();

    private IEnumerable<PluginAssembly> _pluginAssemblies;
    private readonly Dictionary<Guid, IEnumerable<PluginType>> _pluginTypes = new Dictionary<Guid, IEnumerable<PluginType>>();

    public CachedOrganizationServiceAdapter(string organizationFriendlyName, string connectionString) : base(organizationFriendlyName, connectionString) {
    }

    public override IEnumerable<EntityMetadata> RetrieveAllEntityMetadata() {
      return _allEntityMetadataCache ?? (_allEntityMetadataCache = base.RetrieveAllEntityMetadata());
    }

    public override IEnumerable<AttributeMetadata> RetrieveAttributes(string entityLogicalName) {
      if (!_attributeMetadataCache.ContainsKey(entityLogicalName)) {
        _attributeMetadataCache.Add(entityLogicalName, base.RetrieveAttributes(entityLogicalName));
      }

      return _attributeMetadataCache[entityLogicalName];
    }

    public override EntityMetadata RetrieveEntityMetadata(string entityLogicalName, EntityFilters entityFilters) {
      if (!_retrieveEntityMetadataCache.ContainsKey(entityLogicalName)) {
        _retrieveEntityMetadataCache.Add(entityLogicalName, new Dictionary<EntityFilters, EntityMetadata>());
      }

      if (!_retrieveEntityMetadataCache[entityLogicalName].ContainsKey(entityFilters)) {
        _retrieveEntityMetadataCache[entityLogicalName].Add(entityFilters, base.RetrieveEntityMetadata(entityLogicalName, entityFilters));
      }

      return _retrieveEntityMetadataCache[entityLogicalName][entityFilters];
    }

    protected override void RefreshEntityMetadata(string entityLogicalName, EntityFilters entityFilters) {
      if (_retrieveEntityMetadataCache.ContainsKey(entityLogicalName) && _retrieveEntityMetadataCache[entityLogicalName].ContainsKey(entityFilters)) {
        _retrieveEntityMetadataCache[entityLogicalName].Remove(entityFilters);
      }
    }

    public override IEnumerable<Entity> RetrieveFilteredForms(string entityLogicalName) {
      if (!_filteredFormsCache.ContainsKey(entityLogicalName)) {
        _filteredFormsCache.Add(entityLogicalName, base.RetrieveFilteredForms(entityLogicalName));
      }

      return _filteredFormsCache[entityLogicalName];
    }

    public override IEnumerable<PluginAssembly> RetrievePluginAssemblies() {
      return _pluginAssemblies ?? (_pluginAssemblies = base.RetrievePluginAssemblies());
    }

    public override IEnumerable<PluginType> RetrievePluginSteps(Guid assemblyId) {
      if (!_pluginTypes.ContainsKey(assemblyId)) {
        _pluginTypes.Add(assemblyId, base.RetrievePluginSteps(assemblyId));
      }

      return _pluginTypes[assemblyId];
    }
  }
}