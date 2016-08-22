using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public interface IDiscoveryServiceAdapter {
    string Url { get; }
    IEnumerable<OrganizationDetail> DiscoverOrganizations();
    bool IsDiscoverable();
  }
}