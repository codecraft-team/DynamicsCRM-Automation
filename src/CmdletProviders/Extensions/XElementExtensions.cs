using System;
using System.Diagnostics.Contracts;
using System.Xml.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Extensions {
  public static class XElementExtensions {
    public static string GetDataFieldName(this XElement formControlElement) {
      Contract.Requires<ArgumentException>(formControlElement.Name.LocalName == "control");

      return formControlElement.Attribute(XName.Get("datafieldname"))?.Value;
    }

    public static string GetUniqueId(this XElement formControlElement) {
      Contract.Requires<ArgumentException>(formControlElement.Name.LocalName == "control");

      return formControlElement.Attribute(XName.Get("uniqueid"))?.Value;
    }

    public static string GetId(this XElement formControlElement) {
      Contract.Requires<ArgumentException>(formControlElement.Name.LocalName == "control");

      return formControlElement.Attribute(XName.Get("id"))?.Value;
    }
  }
}