using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class AttributeMetadataNode : NodeBase {
    public const int DependencyFoundError = -2147160033;
    public const int DynamicsCrmError = -2147220970;
    public const int CannotDeleteManagedAttributeError = -2147192823;

    public FieldsNode Parent { get; private set; }
    public AttributeMetadata AttributeMetadata { get; set; }

    public AttributeMetadataNode(FieldsNode parent, AttributeMetadata value) : base(parent.NodeContext, value, value.LogicalName) {
      IsContainer = false;
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(value.LogicalName);
      AttributeMetadata = value;
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      return new NodeBase[] {
        new AttributeDependenciesNode(this), 
      };
    }

    public override void RemoveItem(object value) {
      try {
        DeleteAttribute();
      }
      catch (FaultException<OrganizationServiceFault> e) {
        if (e.Detail?.ErrorCode == DependencyFoundError) {
          FormMetadataNode[] dependentForms = GetFormDependencies().ToArray();

          WriteRemoveItemFailed(e.Message, dependentForms);

          ForceRemoveItem(dependentForms);
        }
        else {
          Logger.WriteError(e.InnerException ?? e, ErrorCategory.InvalidOperation, Value);
        }
      }
    }

    private void WriteRemoveItemFailed(string message, FormMetadataNode[] dependentForms) {
      Logger.WriteWarning(message.Replace(" For a list of referenced components, use the RetrieveDependenciesForDeleteRequest.", Environment.NewLine));

      if (dependentForms.Any()) {
        dependentForms.ForEach(form => Logger.WriteWarning($"Dependency found under path: {form.PathSegment}"));
      }
      else {
        throw new NotSupportedException($"The attribute {Name} cannot be deleted, because it has dependencies, which cannot be resolved by the PSDrive Provider.");
      }
    }

    private void ForceRemoveItem(FormMetadataNode[] dependentForms) {
      if (!NodeContext.Force || !dependentForms.Any()) {
        return;
      }

      Logger.WriteWarning("Resolving conflicts, by removing relations to dependencies...");

      ResolveConflicts(dependentForms);
      DeleteAttribute();
    }

    private void DeleteAttribute() {
      string entityLogicalName = Parent.Parent.Name;
      IOrganizationServiceAdapter organizationServiceAdapter = GetOrganizationServiceAdapter();
      organizationServiceAdapter.DeleteAttribute(entityLogicalName, Name);

      Logger.WriteWarning($"Attribute {Name} from entity {entityLogicalName} deleted. To publish the changes, call the Publish function on the {Parent.Parent.EntityMetadata.LogicalName} entity.");
    }

    private void ResolveConflicts(FormMetadataNode[] dependentForms) {
      dependentForms.ForEach(formNode => formNode.RemoveControls(Name));
    }

    internal IEnumerable<FormMetadataNode> GetFormDependencies() {
      IEnumerable<Dependency> dependencies = GetOrganizationServiceAdapter().RetrieveDependencies(ComponentType.Attribute, ((AttributeMetadata) Value).MetadataId.GetValueOrDefault());

      List<FormMetadataNode> dependentForms = new List<FormMetadataNode>();

      Lazy<FormMetadataNode[]> lazyForms = new Lazy<FormMetadataNode[]>(() => Parent.Parent.Forms.GetChildNodes().Cast<FormMetadataNode>().ToArray());
      foreach (Dependency dependency in dependencies) {
        int dependentComponentType = dependency.DependentComponentType.Value;
        Guid dependentComponentId = dependency.DependentComponentObjectId;

        if (dependentComponentType == (int) ComponentType.SystemForm || dependentComponentType == (int) ComponentType.Form) {
          FormMetadataNode form = lazyForms.Value.First(p => ((CrmForm) p.Value).Id == dependentComponentId);
          dependentForms.Add(form);
        }
      }

      return dependentForms;
    }
  }
}