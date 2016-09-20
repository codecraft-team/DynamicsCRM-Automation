using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class ControlsNode : NodeBase {
    public const string NodeName = "Controls";

    public FormMetadataNode Parent { get; set; }

    public ControlsNode(FormMetadataNode parent) : base(parent.NodeContext, null, NodeName) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(Name);
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      return Parent.FormXml.Descendants(XName.Get("control")).Select(controlElement => new ControlNode(this, controlElement));
    }

    public IEnumerable<ControlNode> GetAttributeControls(string attributeLogicalName) {
      return GetChildNodes().Where(node => node is ControlNode).Cast<ControlNode>().Where(controlNode => controlNode.AttributeLogicalName == attributeLogicalName);
    }
  }
}