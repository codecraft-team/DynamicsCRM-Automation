using System;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders {
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemform")]
  public class CrmForm : Entity {
    public string ObjectTypeCodeFormatted => GetFormattedAttributeValue("objecttypecode");
    public string ObjectTypeCode => GetAttributeValue<string>("objecttypecode");

    public Guid FormId => GetAttributeValue<Guid>("formid");
    public string Name => GetAttributeValue<string>("name");
    public string Description => GetAttributeValue<string>("description");
    public string FormActivationState => GetFormattedAttributeValue("formactivationstate");
    public string Version => GetAttributeValue<string>("introducedversion");
    public string Type => GetFormattedAttributeValue("type");
    public string State => GetFormattedAttributeValue("ismanaged");

    public string FormXml => GetAttributeValue<string>("formxml");
  }
}