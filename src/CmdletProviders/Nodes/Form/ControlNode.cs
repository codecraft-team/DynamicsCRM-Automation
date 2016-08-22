using System;
using System.Diagnostics.Contracts;
using System.Xml.Linq;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class ControlNode : NodeBase {
    public ControlsNode Parent { get; set; }

    public string AttributeLogicalName { get; set; }
    public XElement ControlElement { get; set; }
    public string Id { get; set; }

    public ControlNode(ControlsNode parent, XElement controlElement) : base(parent.NodeContext, null, controlElement.Attribute(XName.Get("id")).Value) {
      Parent = parent;
      Path = $"{parent.Path}\\{Name}";
      ControlElement = controlElement;
      Id = ControlElement.GetId();
      IsContainer = false;

      AttributeLogicalName = ControlElement.Attribute(XName.Get("datafieldname"))?.Value;
    }

    public override void RemoveItem(object value) {
      Contract.Requires<InvalidOperationException>(null != ControlElement && ControlElement.Name.LocalName == "control", "The control node value must be a valid control XElement.");

      ControlElement.Remove();
      if (null != ControlElement.Parent) {
        XElement parentRow = ControlElement.Parent.Parent;
        ControlElement.Parent.Remove();
        if (null != parentRow && !parentRow.HasElements) {
          parentRow.Remove();
        }
      }

      Parent.Parent.ValidateSchema();

      Logger.WriteVerbose($"Control {ControlElement} of {AttributeLogicalName} attribute removed from {Parent.Parent.Name} form.");
    }
  }
}