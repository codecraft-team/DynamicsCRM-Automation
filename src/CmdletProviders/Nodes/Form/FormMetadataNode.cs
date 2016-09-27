using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Management.Automation;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Schema;
using Microsoft.Xrm.Sdk;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class FormMetadataNode : NodeBase {
    private readonly Lazy<ControlsNode> _lazyControlsNode;

    public FormsNode Parent { get; }
    public XDocument FormXml { get; private set; }
    public ControlsNode ControlsNode => _lazyControlsNode.Value;

    public FormMetadataNode(FormsNode parent, CrmForm form) : base(parent.NodeContext, form, form.GetAttributeValue<string>("name")) {
      Contract.Requires<ArgumentException>(parent.Parent.Name == form.GetAttributeValue<string>("objecttypecode"));

      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(form.Name);

      ResetFormXml();
      _lazyControlsNode = new Lazy<ControlsNode>(() => new ControlsNode(this));
    }

    public void ResetFormXml() {
      FormXml = ParseFormXml();
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      return new[] {
        ControlsNode
      };
    }

    public void RemoveControls(string attributeLogicalName) {
      try {
        ControlsNode.GetAttributeControls(attributeLogicalName).ForEach(childNode => childNode.RemoveItem(null));
        ValidateSchema();
        Update();
        
        Logger.WriteWarning($"Controls of attribute {attributeLogicalName} removed from form {Name}. To publish the changes, call the Publish function on the {Parent.Parent.EntityMetadata.LogicalName} entity.");
      }
      catch (Exception e) {
        Logger.WriteDebug(FormXml.ToString());
        Logger.WriteError(e, ErrorCategory.InvalidData, attributeLogicalName);

        ResetFormXml();
        throw;
      }
    }

    public void Update() {
      Entity formMetadata = GetFormMetadata();
      Entity updatedForm = new Entity(formMetadata.LogicalName, formMetadata.Id) {
        ["formxml"] = FormXml.ToString()
      };

      IOrganizationServiceAdapter organizationServiceAdapter = GetOrganizationServiceAdapter();
      organizationServiceAdapter.Update(updatedForm);
    }

    public void ValidateSchema() {
      XmlSchemaSet schemas = GetSchemas();
      FormXml.Validate(schemas, (sender, args) => { Logger.WriteError(args.Exception, ErrorCategory.InvalidData, null); });
    }

    private XmlSchemaSet GetSchemas() {
      XmlSchemaSet schemas = new XmlSchemaSet();
      string[] schemaFileNames = {
        //"CustomizationsSolution.xsd",
        //"fetch.xsd",
        "FormXml.xsd",
        //"isv.config.xsd",
        //"ParameterXml.xsd",
        "reports.config.xsd",
        "RibbonCore.xsd",
        "RibbonTypes.xsd",
        "RibbonWSS.xsd"
        //"SiteMap.xsd",
        //"SiteMapType.xsd",
        //"VisualizationDataDescription.xsd"
      };

      Assembly myAssembly = Assembly.GetExecutingAssembly();
      schemaFileNames.ForEach(fileName => {
        using (Stream schemaStream = myAssembly.GetManifestResourceStream($"PowerShellLibrary.Crm.CmdletProviders.Schemas.{fileName}")) {
          XmlSchema schema = XmlSchema.Read(schemaStream, null);
          schemas.Add(schema);
        }
      });

      return schemas;
    }

    private XDocument ParseFormXml() {
      CrmForm formMetadata = GetFormMetadata();

      string xml = formMetadata.FormXml;

      return XDocument.Parse(xml);
    }

    private CrmForm GetFormMetadata() {
      CrmForm formMetadata = Value as CrmForm;
      Contract.Assume(null != formMetadata, "The FormMetadataNode requires a valid form metadata entity.");
      return formMetadata;
    }
  }
}