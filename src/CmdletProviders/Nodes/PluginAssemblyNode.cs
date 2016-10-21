using System.Collections.Generic;
using System.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class PluginAssemblyNode : NodeBase {
    public PluginAssembliesNode Parent { get; }
    public PluginAssembly PluginAssembly { get; set; }

    public PluginAssemblyNode(PluginAssembliesNode parent, PluginAssembly value) : base(parent.NodeContext, value, value.Name) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(value.Name);
      PluginAssembly = value;
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<PluginType> pluginSteps = GetOrganizationServiceAdapter().RetrievePluginTypes(PluginAssembly.Id);
      pluginSteps = Filter(pluginSteps, entityMetadata => entityMetadata.Name);

      return pluginSteps.Select(pluginAssembly => new PluginTypeNode(this, pluginAssembly));
    }
  }
}