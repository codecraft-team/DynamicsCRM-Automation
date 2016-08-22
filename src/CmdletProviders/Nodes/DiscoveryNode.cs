using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class DiscoveryNode : NodeBase {
    public DiscoveryNode(NodeContext nodeContext) : base(nodeContext, null, string.Empty) {
      Path = string.Empty;
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<OrganizationDetail> organizations = RetrieveOrganizations();
      organizations = Filter(organizations, organization => organization.FriendlyName);
      return organizations.Select(organization => new OrganizationNode(this, organization));
    }

    private IEnumerable<OrganizationDetail> RetrieveOrganizations() {
      return NodeContext.CrmDrive.DiscoveryServiceAdapter.DiscoverOrganizations();
    }
  }
}