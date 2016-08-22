using System.Linq;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class EntityNode : NodeBase {
    public AdvancedFindNode Parent { get; private set; }

    public EntityNode(AdvancedFindNode parent, Entity value) : base(parent.NodeContext, value, GetPrimaryAttribute(value)) {
      IsContainer = false;
      Parent = parent;
      Path = $"{parent.Path}\\{Name}";
    }

    private static string GetPrimaryAttribute(Entity entity) {
      return (string) entity.KeyAttributes.First().Value;
    }
  }
}