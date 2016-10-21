using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace PowerShellLibrary.Crm.CmdletProviders {
  [EntityLogicalName("")]
  public class Dependency : Entity {
    public OptionSetValue DependentComponentType { get { return GetAttributeValue<OptionSetValue>("dependentcomponenttype"); } set { SetAttributeValue("dependentcomponenttype", value); } }
    public Guid DependentComponentObjectId { get { return GetAttributeValue<Guid>("dependentcomponentobjectid"); } set { SetAttributeValue("dependentcomponentobjectid", value); } }
  }
}