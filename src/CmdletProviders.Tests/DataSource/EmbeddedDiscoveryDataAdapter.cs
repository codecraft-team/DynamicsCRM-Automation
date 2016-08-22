using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class EmbeddedDiscoveryDataAdapter : IDiscoveryServiceAdapter {
    public string Url { get; set; }

    public IEnumerable<OrganizationDetail> DiscoverOrganizations() {
      return new[] {
        new OrganizationDetail {
          FriendlyName = DataSourceConfiguration.Playground.OrganizationFriendlyName
        }
      };
    }

    public bool IsDiscoverable() {
      return true;
    }
  }
}