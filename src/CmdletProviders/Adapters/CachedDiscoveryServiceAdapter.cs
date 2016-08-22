using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders {

  public class CachedDiscoveryServiceAdapter : DiscoveryServiceAdapter, IDiscoveryServiceAdapter {
    private IEnumerable<OrganizationDetail> OrganizationDetails { get; set; }

    public CachedDiscoveryServiceAdapter(string discoveryServiceUrl, string userName, string password) : base(discoveryServiceUrl, userName, password) {
    }

    public override IEnumerable<OrganizationDetail> DiscoverOrganizations() {
      return OrganizationDetails ?? (OrganizationDetails = base.DiscoverOrganizations());
    }
  }
}