using System.Collections.Generic;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class PluginTypeNode : NodeBase {
    public PluginAssemblyNode Parent { get; }

    public PluginTypeNode(PluginAssemblyNode parent, PluginType value) : base(parent.NodeContext, value, value.TypeName) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(value.TypeName);
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      NodeBase[] nodes = {
      };

      return Filter(nodes, nodeBase => nodeBase.Name);
    }
  }
}