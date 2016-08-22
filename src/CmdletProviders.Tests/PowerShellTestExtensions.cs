using System;
using System.Collections.Generic;
using System.Configuration;
using System.Management.Automation;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public static class PowerShellTestExtensions {
    public static PowerShell NewDrive(this PowerShell powerShell, string driveName, IDiscoveryServiceAdapter discoveryServiceAdapter, List<IOrganizationServiceAdapter> organizationServiceAdapters) {
      powerShell.AddScript($@"
        param (
          [PowerShellLibrary.Crm.CmdletProviders.IDiscoveryServiceAdapter]$discoveryServiceAdapter,
          [PowerShellLibrary.Crm.CmdletProviders.IOrganizationServiceAdapter[]]$organizationServiceAdapters
        )
        $env:PSModulePath = ""$env:PSModulePath;{ConfigurationManager.AppSettings["TestedModuleDirectory"]}"";
        Import-Module DynamicsCRM-PSLibrary;
        $driveInfo = New-PSDrive -PSProvider CRM -Name {driveName} -Root """" -DiscoveryServiceAdapter $discoveryServiceAdapter -OrganizationServiceAdapters $organizationServiceAdapters;
        sl CRMLocal:;");
      powerShell.AddParameter("discoveryServiceAdapter", new PSObject(discoveryServiceAdapter));
      powerShell.AddParameter("organizationServiceAdapters", new PSObject(organizationServiceAdapters?.ToArray()));

      return powerShell;
    }

    public static void WriteErrorsToConsole(this PowerShell powerShell) {
      powerShell.Streams.Error.ForEach(error => Console.WriteLine($"{error.Exception.Message} {error.ScriptStackTrace}"));
    }
  }
}