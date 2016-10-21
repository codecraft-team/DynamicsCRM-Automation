using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Management.Automation;
using Microsoft.Xrm.Sdk;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class FormMetadataNode : NodeBase {
    private readonly Lazy<ControlsNode> _lazyControlsNode;

    public FormsNode Parent { get; }
    public CrmForm CrmForm { get; }
    public ControlsNode ControlsNode => _lazyControlsNode.Value;

    public FormMetadataNode(FormsNode parent, CrmForm form) : base(parent.NodeContext, form, form.GetAttributeValue<string>("name")) {
      Contract.Requires<ArgumentException>(parent.Parent.Name == form.ObjectTypeCode);

      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(form.Name);
      CrmForm = form;

      _lazyControlsNode = new Lazy<ControlsNode>(() => new ControlsNode(this));
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      return new[] {
        ControlsNode
      };
    }

    public void RemoveControls(string attributeLogicalName) {
      try {
        ControlsNode.GetAttributeControls(attributeLogicalName).ForEach(childNode => childNode.RemoveItem(null));
        CrmForm.ValidateSchema();
        Update();
        
        Logger.WriteWarning($"Controls of attribute {attributeLogicalName} removed from form {Name}. To publish the changes, call the Publish function on the {Parent.Parent.EntityMetadata.LogicalName} entity.");
      }
      catch (Exception e) {
        Logger.WriteDebug(CrmForm.FormXml);
        Logger.WriteError(e, ErrorCategory.InvalidData, attributeLogicalName);
        throw;
      }
    }

    public void Update() {
      CrmForm updatedForm = new CrmForm(CrmForm.Id) {
        FormXml = CrmForm.FormXml
      };

      IOrganizationServiceAdapter organizationServiceAdapter = GetOrganizationServiceAdapter();
      organizationServiceAdapter.Update(updatedForm);
    }
  }
}