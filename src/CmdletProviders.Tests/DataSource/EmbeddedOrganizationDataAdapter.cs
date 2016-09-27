using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Xml.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;
using PowerShellLibrary.Crm.CmdletProviders.Tests.Stubs;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class EmbeddedOrganizationDataAdapter : IOrganizationServiceAdapter {
    private readonly Lazy<OrganizationData> _lazyOrganizationData;
    private OrganizationData OrganizationData => _lazyOrganizationData.Value;

    public string OrganizationFriendlyName { get; }

    public EmbeddedOrganizationDataAdapter(DataSourceConfiguration dataSourceConfiguration) {
      OrganizationFriendlyName = dataSourceConfiguration.OrganizationFriendlyName;

      _lazyOrganizationData = new Lazy<OrganizationData>(() => {
        EmbeddedOrganizationDataReader reader = new EmbeddedOrganizationDataReader();
        OrganizationData organizationData = reader.Read(OrganizationFriendlyName);
        return organizationData;
      }, true);
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

    public IEnumerable<PluginType> RetrievePluginTypes(Guid assemblyId) {
      throw new NotImplementedException();
    }

    public IEnumerable<SdkMessageProcessingStep> RetrievePluginSteps() {
      throw new NotImplementedException();
    }

    public IEnumerable<EntityMetadata> RetrieveAllEntityMetadata() {
      return OrganizationData.EntityMetadatas;
    }

    public EntityMetadata RetrieveEntityMetadata(string entityLogicalName, EntityFilters attributes) {
      return OrganizationData.EntityMetadatas.First(entityMetadata => entityMetadata.LogicalName == entityLogicalName);
    }

    public IEnumerable<AttributeMetadata> RetrieveAttributes(string entityLogicalName) {
      return RetrieveEntityMetadata(entityLogicalName, EntityFilters.Attributes).Attributes;
    }

    public IEnumerable<OneToManyRelationshipMetadata> RetrieveOneToManyRelationships(string entityLogicalName) {
      return RetrieveEntityMetadata(entityLogicalName, EntityFilters.Relationships).OneToManyRelationships;
    }

    public IEnumerable<OneToManyRelationshipMetadata> RetrieveManyToOneRelationships(string entityLogicalName) {
      return RetrieveEntityMetadata(entityLogicalName, EntityFilters.Relationships).ManyToOneRelationships;
    }

    public IEnumerable<ManyToManyRelationshipMetadata> RetrieveManyToManyRelationships(string entityLogicalName) {
      return RetrieveEntityMetadata(entityLogicalName, EntityFilters.Relationships).ManyToManyRelationships;
    }

    public IEnumerable<CrmForm> RetrieveFilteredForms(EntityMetadata entityMetadata) {
      return OrganizationData.Forms.Where(form => form.ObjectTypeCode == entityMetadata.LogicalName);
    }

    public void DeleteAttribute(string entityLogicalName, string attributeLogicalName) {
      EntityMetadata entityMetadata = RetrieveEntityMetadata(entityLogicalName, EntityFilters.Attributes);
      AttributeMetadata attributeToRemove = entityMetadata.Attributes.First(a => a.LogicalName == attributeLogicalName);

      ThrowIfManaged(attributeToRemove, entityMetadata);
      ThrowIfDependencyFound(entityMetadata, attributeLogicalName);

      List<AttributeMetadata> newAttributeList = entityMetadata.Attributes.ToList();
      newAttributeList.Remove(attributeToRemove);

      FieldInfo attributesField = entityMetadata.GetType().GetField("_attributes", BindingFlags.Instance | BindingFlags.NonPublic);
      attributesField.SetValue(entityMetadata, newAttributeList.ToArray());
    }

    private void ThrowIfDependencyFound(EntityMetadata entityMetadata, string attributeLogicalName) {
      IEnumerable<Entity> dependentForms = RetrieveFilteredForms(entityMetadata).Where(form => form.GetControls().Any(control => control.GetDataFieldName() == attributeLogicalName)).ToList();
      if (dependentForms.Any()) {
        FaultReason reason = new FaultReason($"The {attributeLogicalName} component cannot be deleted because it is referenced by {dependentForms.Count()} other components. For a list of referenced components, use the RetrieveDependenciesForDeleteRequest.");
        OrganizationServiceFault detail = new OrganizationServiceFault {
          ErrorCode = AttributeMetadataNode.DependencyFoundError
        };

        throw new FaultException<OrganizationServiceFault>(detail, reason);
      }
    }

    private static void ThrowIfManaged(AttributeMetadata attributeToRemove, EntityMetadata entityMetadata) {
      if (attributeToRemove.IsManaged.GetValueOrDefault()) {
        string message = $"Cannot delete attribute: {attributeToRemove.LogicalName} from Entity: {entityMetadata.DisplayName.UserLocalizedLabel.Label} since the attribute is not a custom field.";
        OrganizationServiceFault innerFault = new OrganizationServiceFault {
          ErrorCode = AttributeMetadataNode.CannotDeleteManagedAttributeError,
          Message = message
        };

        OrganizationServiceFault fault = new OrganizationServiceFault {
          ErrorCode = AttributeMetadataNode.DynamicsCrmError,
          InnerFault = innerFault,
          Message = "Microsoft Dynamics CRM has experienced an error. Reference number for administrators or support: #C37E6B13."
        };

        throw new FaultException<OrganizationServiceFault>(fault, new FaultReason(message));
      }
    }

    public void DeleteRelationship(string entityLogicalName, string relationshipSchemaName) {
      EntityMetadata entityMetadata = RetrieveEntityMetadata(entityLogicalName, EntityFilters.Attributes);
      string fieldName = null;
      object fieldValue = null;

      OneToManyRelationshipMetadata relationship = entityMetadata.OneToManyRelationships.FirstOrDefault(r => r.SchemaName == relationshipSchemaName);
      if (null != relationship) {
        List<OneToManyRelationshipMetadata> relationships = entityMetadata.OneToManyRelationships.ToList();
        relationships.Remove(relationship);

        fieldName = "_oneToManyRelationships";
        fieldValue = relationships.ToArray();
      }

      OneToManyRelationshipMetadata manyToOneRelationship = entityMetadata.ManyToOneRelationships.FirstOrDefault(r => r.SchemaName == relationshipSchemaName);
      if (null != manyToOneRelationship) {
        List<OneToManyRelationshipMetadata> relationships = entityMetadata.ManyToOneRelationships.ToList();
        relationships.Remove(manyToOneRelationship);

        fieldName = "_manyToOneRelationships";
        fieldValue = relationships.ToArray();
      }

      ManyToManyRelationshipMetadata manyToManyRelationship = entityMetadata.ManyToManyRelationships.FirstOrDefault(r => r.SchemaName == relationshipSchemaName);
      if (null != manyToManyRelationship) {
        List<ManyToManyRelationshipMetadata> relationships = entityMetadata.ManyToManyRelationships.ToList();
        relationships.Remove(manyToManyRelationship);

        fieldName = "_manyToOneRelationships";
        fieldValue = relationships.ToArray();
      }

      Contract.Assume(null != fieldName, "Assuming to always have a non null relationship field name.");

      FieldInfo relationshipMetadataField = entityMetadata.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
      Contract.Assume(null != relationshipMetadataField, "Assuming to find one non public instance member of entity metadata.");

      relationshipMetadataField.SetValue(entityMetadata, fieldValue);
    }

    public RetrieveDependenciesForDeleteResponse RetrieveDependencies(ComponentType componentType, Guid objectId) {
      if (componentType == ComponentType.Attribute) {
        IEnumerable<EntityMetadata> entities = RetrieveAllEntityMetadata().ToList();
        EntityMetadata entityOfAttribute = entities.Single(entity => entity.Attributes.Any(aMetadata => aMetadata.MetadataId == objectId));
        IEnumerable<Entity> forms = RetrieveFilteredForms(entityOfAttribute);
        AttributeMetadata attribute = entityOfAttribute.Attributes.First(a => a.MetadataId == objectId);

        List<Entity> dependencies = new List<Entity>();

        foreach (Entity form in forms) {
          bool isAttributeOnForm = IsAttributeOnForm(attribute.LogicalName, form);

          if (isAttributeOnForm) {
            if (form.LogicalName != "systemform") {
              throw new NotImplementedException($"The dependentcomponenttype is not set properly, when using non-systemform forms.");
            }

            dependencies.Add(new Entity {
              ["name"] = form.GetAttributeValue<string>("name"),
              ["dependentcomponentobjectid"] = form.Id,
              ["dependentcomponenttype"] = new OptionSetValue((int) ComponentType.SystemForm)
            });
          }
        }

        RetrieveDependenciesForDeleteResponse response = new RetrieveDependenciesForDeleteResponse {
          ["EntityCollection"] = new EntityCollection(dependencies)
        };
        return response;
      }

      throw new NotImplementedException();
    }

    private bool IsAttributeOnForm(string attributeLogicalName, Entity form) {
      return GetFormControls(form).Any(controlElement => controlElement.Attribute(XName.Get("datafieldname"))?.Value == attributeLogicalName);
    }

    private IEnumerable<XElement> GetFormControls(Entity form) {
      return form.GetControls();
    }

    public OrganizationServiceContext CreateContext() {
      StubOrganizationServiceContext context = new StubOrganizationServiceContext(new StubOrganizationService());

      context.Entities.Add("account", new[] {
        new Entity("account", Guid.NewGuid()) {
          ["name"] = "Account 1"
        },
        new Entity("account", Guid.NewGuid()) {
          ["name"] = "Account 2"
        },
        new Entity("account", Guid.NewGuid()) {
          ["name"] = "Account 3"
        }
      }.AsQueryable());

      context.Entities.Add("contact", new[] {
        new Entity("contact", Guid.NewGuid()) {
          ["name"] = "Contact 1"
        },
        new Entity("contact", Guid.NewGuid()) {
          ["name"] = "Contact 2"
        }
      }.AsQueryable());

      return context;
    }

    public void Update(Entity entity) {
      if (entity.LogicalName == "systemform") {
        Entity previousEntity = OrganizationData.Forms.First(form => form.Id == entity.Id);
        entity.Attributes.ForEach(attribute => { previousEntity[attribute.Key] = attribute.Value; });
      }
      else {
        throw new NotImplementedException($"The update of {entity.LogicalName} entity not implemented.");
      }
    }
  }
}