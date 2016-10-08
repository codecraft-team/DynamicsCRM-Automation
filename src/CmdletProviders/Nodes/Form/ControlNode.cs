using System;
using System.Diagnostics.Contracts;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class ControlNode : NodeBase {
    public ControlsNode Parent { get; set; }

    public string AttributeLogicalName { get; set; }
    public CrmFormControl CrmFormControl { get; set; }
    public string Id { get; set; }

    public ControlNode(ControlsNode parent, CrmFormControl crmFormControl) : base(parent.NodeContext, crmFormControl, crmFormControl.Id) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(Name);

      CrmFormControl = crmFormControl;
      Id = crmFormControl.Id;
      IsContainer = false;

      AttributeLogicalName = CrmFormControl.DataFieldName;
    }

    public override void RemoveItem(object value) {
      Contract.Requires<InvalidOperationException>(null != CrmFormControl);

      CrmFormControl.Remove();

      Logger.WriteVerbose($"Control {CrmFormControl.Xml} of {AttributeLogicalName} attribute removed from {Parent.Parent.CrmForm.Name} form.");
    }
  }
}