using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class FormsNode : NodeBase {
    public const string NodeName = "Forms";
    public EntityMetadataNode Parent { get; }

    public FormsNode(EntityMetadataNode parent) : base(parent.NodeContext, null, NodeName) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(NodeName);
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<CrmForm> forms = GetOrganizationServiceAdapter().RetrieveFilteredForms(Parent.EntityMetadata);
      return forms.Select(form => new FormMetadataNode(this, form));
    }
  }
}