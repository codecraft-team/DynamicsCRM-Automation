using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Stubs {
  public class StubOrganizationDetail {
    public string OrganizationName { get; set; }
    public OrganizationDetail Value { get; set; }
    public List<StubEntityMetadata> EntityMetadataCollection { get; set; }
  }
}