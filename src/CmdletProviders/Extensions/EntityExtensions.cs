using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Xml.Linq;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders.Extensions {
  public static class EntityExtensions {
    public static IEnumerable<XElement> GetControls(this Entity systemForm) {
      Contract.Requires<ArgumentException>(systemForm.LogicalName == "systemform");

      string xml = systemForm.GetAttributeValue<string>("formxml");

      return XDocument.Parse(xml).Descendants(XName.Get("control"));
    }
  }
}