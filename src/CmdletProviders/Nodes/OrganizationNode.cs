using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class OrganizationNode : NodeBase {
    public DiscoveryNode Parent { get; set; }
    public OrganizationDetail Organization { get; set; } 

    public OrganizationNode(DiscoveryNode parent, OrganizationDetail organization) : base(parent.NodeContext, organization, GetPathName(organization)) {
      Parent = parent;
      Organization = organization;
      PathSegment = parent.PathSegment + new PathSegment(GetPathName(organization));
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<NodeBase> childNodes = new NodeBase[] {
        new EntitiesNode(this),
        new WebResourcesNode(this),
        new PluginAssembliesNode(this),
        new AdvancedFindNode(this)
      };

      return Filter(childNodes, nodeBase => nodeBase.Name);
    }

    public static string GetPathName(OrganizationDetail organizationDetail) {
      return organizationDetail.FriendlyName;
    }
  }
}