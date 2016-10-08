using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Schema;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders {
  [EntityLogicalName("systemform")]
  public class CrmForm : Entity {
    public string ObjectTypeCodeFormatted => GetFormattedAttributeValue("objecttypecode");
    public string ObjectTypeCode { get  {return GetAttributeValue<string>("objecttypecode"); } set { SetAttributeValue("objecttypecode", value);} }

    public Guid FormId => GetAttributeValue<Guid>("formid");
    public string Name { get { return GetAttributeValue<string>("name"); } set { SetAttributeValue("name", value); } }
    public string Description => GetAttributeValue<string>("description");
    public string FormActivationState => GetFormattedAttributeValue("formactivationstate");
    public string Version => GetAttributeValue<string>("introducedversion");
    public string Type => GetFormattedAttributeValue("type");
    public string State => GetFormattedAttributeValue("ismanaged");
    public string FormXml { get { return GetAttributeValue<string>("formxml"); } set { SetAttributeValue("formxml", value);} }

    public CrmForm() : base("systemform") {
    }

    public CrmForm(Guid id) : base("systemform", id) {
    }

    public void ValidateSchema() {
      XDocument formDocument = XDocument.Parse(FormXml);
      XmlSchemaSet schemas = GetSchemas();
      formDocument.Validate(schemas, (sender, args) => { Logger.WriteError(args.Exception, ErrorCategory.InvalidData, null); });
    }

    public IEnumerable<CrmFormControl> GetControls() {
      XDocument formDocument = XDocument.Parse(FormXml);
      return GetControls(formDocument).Select(controlElement => new CrmFormControl(this, controlElement));
    }

    private IEnumerable<XElement> GetControls(XDocument formDocument) {
      return formDocument.Descendants(XName.Get("control"));
    }

    public void Remove(CrmFormControl control) {
      XDocument formDocument = XDocument.Parse(FormXml);

      IEnumerable<XElement> controlXElement = GetControls(formDocument).Where(c => c.GetDataFieldName() == control.DataFieldName);
      controlXElement.ForEach(c => {
        c.Remove();
        RemoveParentElement(c);
      });

      ValidateSchema();

      FormXml = formDocument.ToString();
    }

    private static void RemoveParentElement(XElement xElement) {
      if (null == xElement.Parent) {
        return;
      }

      XElement parentRow = xElement.Parent.Parent;
      xElement.Parent.Remove();
      if (null != parentRow && !parentRow.HasElements) {
        parentRow.Remove();
      }
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
  }
}