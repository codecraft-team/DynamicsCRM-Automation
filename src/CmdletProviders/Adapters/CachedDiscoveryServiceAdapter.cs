using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders {

  public class CachedDiscoveryServiceAdapter : DiscoveryServiceAdapter, IDiscoveryServiceAdapter {
    private IEnumerable<OrganizationDetail> OrganizationDetails { get; set; }
    private bool? _isDiscoverable;

    public CachedDiscoveryServiceAdapter(string discoveryServiceUrl, string userName, string password) : base(discoveryServiceUrl, userName, password) {
    }

    public override IEnumerable<OrganizationDetail> DiscoverOrganizations() {
      Logger.WriteDebug("CachedDiscoveryServiceAdapter.DiscoverOrganizations...");

      return OrganizationDetails ?? (OrganizationDetails = base.DiscoverOrganizations());
    }

    public override bool IsDiscoverable() {
      return _isDiscoverable ?? (_isDiscoverable = base.IsDiscoverable()).Value;
    }
  }
}