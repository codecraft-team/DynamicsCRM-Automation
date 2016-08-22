using System.Collections.Generic;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class PluginStepNode : NodeBase {
    public PluginAssemblyNode Parent { get; }

    public PluginStepNode(PluginAssemblyNode parent, PluginType value) : base(parent.NodeContext, value, value.Name) {
      Parent = parent;
      Path = $"{parent.Path}\\{value.Name}";
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      NodeBase[] nodes = {
      };

      return Filter(nodes, nodeBase => nodeBase.Name);
    }
  }
}