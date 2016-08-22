using System.Collections.Generic;
using System.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class PluginAssembliesNode : NodeBase {
    public const string NodeName = "Plugins";
    public OrganizationNode Parent { get; private set; }

    public PluginAssembliesNode(OrganizationNode parent) : base(parent.NodeContext, null, NodeName) {
      Parent = parent;
      Path = $"{parent.Path}\\{Name}";
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<PluginAssembly> plugins = GetOrganizationServiceAdapter().RetrievePluginAssemblies();
      plugins = Filter(plugins, entityMetadata => entityMetadata.Name);

      return plugins.Select(pluginAssembly => new PluginAssemblyNode(this, pluginAssembly));
    }
  }
}