using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Discovery;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class DiscoveryNodeTests {
    private const string CrmLocal = "CRMLocal";

    public PowerShell PowerShell { get; set; }
    public IDiscoveryServiceAdapter DiscoveryServiceAdapter { get; set; }

    [TestInitialize]
    public void TestInitialize() {
      const string crmPackaging = "crm-packaging";
      const string crmIntegration = "crm-integration";

      List<OrganizationDetail> organizations = new List<OrganizationDetail> {
        new OrganizationDetail {
          FriendlyName = crmPackaging
        },
        new OrganizationDetail {
          FriendlyName = crmIntegration
        }
      };

      DiscoveryServiceAdapter = new StubIDiscoveryServiceAdapter {
        DiscoverOrganizations = () => organizations,
        IsDiscoverable = () => true
      };

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new StubIOrganizationServiceAdapter {
          OrganizationFriendlyNameGet = () => crmPackaging
        },
        new StubIOrganizationServiceAdapter {
          OrganizationFriendlyNameGet = () => crmIntegration
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(CrmLocal, DiscoveryServiceAdapter, organizationServiceAdapters);
    }

    [TestMethod]
    public void RootContainerHasOrganizationDetailChildren() {
      List<OrganizationDetail> expectedOrganizations = DiscoveryServiceAdapter.DiscoverOrganizations().ToList();

      Collection<OrganizationDetail> actualOrganizations = PowerShell.AddScript($"Get-ChildItem -Path {CrmLocal}:").Invoke<OrganizationDetail>();

      CollectionAssert.AreEqual(expectedOrganizations, actualOrganizations);
    }

    [TestMethod]
    public void RootChildrenOrganizationDetailsFilterEndsWith() {
      string suffix = "integration";
      int expectedCount = DiscoveryServiceAdapter.DiscoverOrganizations().Count(organization => organization.FriendlyName.EndsWith(suffix));

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Path {CrmLocal}: -Filter *{suffix}").Invoke();

      Assert.AreEqual(expectedCount, childItems.Count);
      Assert.IsTrue(childItems.All(child => ((OrganizationDetail) child.BaseObject).FriendlyName.EndsWith(suffix)));
    }

    [TestMethod]
    public void RootChildrenOrganizationDetailsFilterStartsWith() {
      string prefix = "crm-pa";
      int expectedCount = DiscoveryServiceAdapter.DiscoverOrganizations().Count(organization => organization.FriendlyName.StartsWith(prefix));

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Path {CrmLocal}: -Filter {prefix}*").Invoke();

      Assert.AreEqual(expectedCount, childItems.Count);
      Assert.IsTrue(childItems.All(child => ((OrganizationDetail) child.BaseObject).FriendlyName.StartsWith(prefix)));
    }

    [TestMethod]
    public void RootChildrenOrganizationDetailsFilterSubstring() {
      string substring = "-pa";
      int expectedCount = DiscoveryServiceAdapter.DiscoverOrganizations().Count(organization => organization.FriendlyName.Contains(substring));

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Path {CrmLocal}: -Filter *{substring}*").Invoke();

      Assert.AreEqual(expectedCount, childItems.Count);
      Assert.IsTrue(childItems.All(child => ((OrganizationDetail) child.BaseObject).FriendlyName.Contains(substring)));
    }

    [TestMethod]
    public void OrganizationNodeCanBeNavigatedUsingOrganizationFriendlyName() {
      string expectedPath = $"{CrmLocal}:\\crm-packaging";

      PowerShell.AddScript($"Set-Location {CrmLocal}:\\crm-packaging").Invoke();

      Assert.AreEqual(expectedPath, PowerShell.Runspace.SessionStateProxy.Path.CurrentLocation.Path);
    }

    [TestMethod]
    public void OrganizationNodeCanBeNavigatedUsingRelativePath() {
      string expectedPath = $"{CrmLocal}:\\crm-integration";
      PowerShell.AddScript($"Set-Location {CrmLocal}:");

      PowerShell.AddScript($"Set-Location .\\crm-integration").Invoke();

      Assert.AreEqual(expectedPath, PowerShell.Runspace.SessionStateProxy.Path.CurrentLocation.Path);
    }

    [TestMethod]
    public void NavigatingToInvalidOrganizationCausesError() {
      string invalidOrganizationName = Guid.NewGuid().ToString();
      string expectedErrorMessage = $"The {invalidOrganizationName} was not found in the connections configuration.";

      PowerShell.AddScript($"Set-Location {CrmLocal}:\\{invalidOrganizationName};").Invoke();
      ErrorRecord actualErrorMessage = PowerShell.Streams.Error.FirstOrDefault();

      Assert.AreEqual(1, PowerShell.Streams.Error.Count);
      Assert.IsNotNull(actualErrorMessage);
      Assert.AreEqual(expectedErrorMessage, actualErrorMessage.Exception.Message);
    }
  }
}