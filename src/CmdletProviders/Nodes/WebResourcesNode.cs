using System.Collections.Generic;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class WebResourcesNode : NodeBase {
    public const string NodeName = "WebResources";
    public OrganizationNode Parent { get; private set; }

    public WebResourcesNode(OrganizationNode parent) : base(parent.NodeContext, null, NodeName) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(Name);
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      return base.GetChildNodes();
    }
  }
}