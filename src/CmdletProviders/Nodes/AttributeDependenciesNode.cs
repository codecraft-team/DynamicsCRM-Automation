using System.Collections.Generic;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class AttributeDependenciesNode : NodeBase {
    public const string NodeName = "Dependencies";
    public AttributeMetadataNode Parent { get; set; }

    public AttributeDependenciesNode(AttributeMetadataNode parent) : base(parent.NodeContext, null, NodeName) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(NodeName);
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<FormMetadataNode> formDependencies = Parent.GetFormDependencies();
      IEnumerable<FormMetadataNode> machingDependencies = Filter(formDependencies, entity => entity.Name);

      return machingDependencies;
    }
  }
}