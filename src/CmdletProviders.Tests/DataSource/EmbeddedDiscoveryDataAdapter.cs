using System.Collections;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class EmbeddedDiscoveryDataAdapter : IDiscoveryServiceAdapter {
    public string Url { get; set; }

    private IEnumerable<OrganizationDetail> OrganizationDetails { get; }

    public EmbeddedDiscoveryDataAdapter() : this(DefaultOrganizationDetails()) {
    }

    public EmbeddedDiscoveryDataAdapter(IEnumerable<OrganizationDetail> organizationDetails) {
      OrganizationDetails = organizationDetails;
    }

    private static IEnumerable<OrganizationDetail> DefaultOrganizationDetails() {
      return new[] {
        new OrganizationDetail {
          FriendlyName = DataSourceConfiguration.Playground.OrganizationFriendlyName
        }
      };
    }

    public IEnumerable<OrganizationDetail> DiscoverOrganizations() {
      return OrganizationDetails;
    }

    public bool IsDiscoverable() {
      return true;
    }
  }
}