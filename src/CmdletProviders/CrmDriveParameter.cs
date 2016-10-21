using System;
using System.Linq;
using System.Management.Automation;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public class CrmDriveParameter {
    [Parameter(Mandatory = true)]
    public IOrganizationServiceAdapter[] OrganizationServiceAdapters { get; set; }

    [Parameter(Mandatory = true), AllowEmptyCollection]
    public IDiscoveryServiceAdapter DiscoveryServiceAdapter { get; set; }

    public IOrganizationServiceAdapter GetOrganizationServiceAdapter(string organizationFriendlyName) {
      IOrganizationServiceAdapter organizationServiceAdapter = OrganizationServiceAdapters.FirstOrDefault(adapter => string.Equals(adapter.OrganizationFriendlyName, organizationFriendlyName, StringComparison.OrdinalIgnoreCase));
      if (null == organizationServiceAdapter) {
        string message = $"The {organizationFriendlyName} was not found in the connections configuration.";
        Logger.WriteWarning(message);

        throw new PSInvalidOperationException(message);
      }

      Logger.WriteDebug($"GetOrganizationServiceAdapter: {organizationFriendlyName}");
      return organizationServiceAdapter;
    }
  }
}