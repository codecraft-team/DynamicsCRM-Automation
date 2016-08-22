using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Client;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class AdvancedFindNode : NodeBase {
    public const string NodeName = "AdvancedFind";
    public OrganizationNode Parent { get; private set; }

    public AdvancedFindNode(OrganizationNode parent) : base(parent.NodeContext, null, NodeName) {
      IsContainer = true;
      Parent = parent;
      Path = $"{parent.Path}\\{NodeName}";
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      string entityLogicalName = Parent.Name;

      using (OrganizationServiceContext context = CreateContext()) {
        return (from entity in context.CreateQuery(entityLogicalName)
                select entity).Take(50).ToList().Select(entity => new EntityNode(this, entity));
      }
    }

    public OrganizationServiceContext CreateContext() {
      return GetOrganizationServiceAdapter().CreateContext();
    }
  }
}