using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class OrganizationServiceAdapterMock : StubIOrganizationServiceAdapter {

    public OrganizationServiceAdapterMock() {
      Initialize();
    }

    private void Initialize() {
      InitializeRetrieveEntityMetadata();
      InitializeDeleteAttribute();
      InitializeUpdate();
    }

    private void InitializeUpdate() {
      UpdateEntity = entity => {
        if (entity.LogicalName != "systemform") {
          throw new NotImplementedException();
        }

        IEnumerable<EntityMetadata> entities = RetrieveAllEntityMetadata();
        foreach (EntityMetadata entityMetadata in entities) {
          CrmForm form = RetrieveFilteredFormsEntityMetadata(entityMetadata).FirstOrDefault(f => f.Id == entity.Id);
          if (null != form) {
            form.FormXml = entity.ToEntity<CrmForm>().FormXml;
          }
        }
      };
    }

    private void InitializeRetrieveEntityMetadata() {
      RetrieveEntityMetadataStringEntityFilters = (entityLogicalName, filters) => RetrieveAllEntityMetadata().First(entity => entity.LogicalName == entityLogicalName);
      RetrieveAttributesString = entityLogicalName => RetrieveAllEntityMetadata().First(entity => entity.LogicalName == entityLogicalName).Attributes;
    }

    private void InitializeDeleteAttribute() {
      DeleteAttributeStringString = (entityLogicalName, attributeLogicalName) => {
        EntityMetadata entityMetadata = RetrieveEntityMetadataStringEntityFilters(entityLogicalName, EntityFilters.Attributes);
        AttributeMetadata attributeToRemove = entityMetadata.Attributes.First(a => a.LogicalName == attributeLogicalName);

        ThrowIfManaged(attributeToRemove, entityMetadata);
        ThrowIfDependencyFound(entityMetadata, attributeLogicalName);

        List<AttributeMetadata> newAttributeList = entityMetadata.Attributes.ToList();
        newAttributeList.Remove(attributeToRemove);
        entityMetadata.SetAttributes(newAttributeList.ToArray());
      };
    }

    private void ThrowIfDependencyFound(EntityMetadata entityMetadata, string attributeLogicalName) {
      IEnumerable<Entity> dependentForms = RetrieveFilteredFormsEntityMetadata(entityMetadata).Where(form => form.GetControls().Any(control => control.DataFieldName == attributeLogicalName)).ToList();
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
  }
}