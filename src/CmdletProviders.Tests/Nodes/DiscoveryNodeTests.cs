using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class DiscoveryNodeTests : ProviderTestBase {
    
    [TestMethod]
    public void RootContainerHasOrganizationDetailChildren() {
      IEnumerable<OrganizationDetail> expectedOrganizations = Organizations.ToList();

      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem").Invoke();

      Assert.IsTrue(childItems.All(childItem => childItem.BaseObject is OrganizationDetail));
      Assert.AreEqual(expectedOrganizations.Count(), childItems.Count);
      Assert.IsTrue(expectedOrganizations.All(expectedOrganization => childItems.Any(child => ((OrganizationDetail)child.BaseObject).FriendlyName == expectedOrganization.FriendlyName)));
    }

    [TestMethod]
    public void RootChildrenOrganizationDetailsFilterEndsWith() {
      string suffix = Organization.FriendlyName.Substring(Organization.FriendlyName.Length - 3);
      int expectedCount = Organizations.Count(organization => organization.FriendlyName.EndsWith(suffix));

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Filter *{suffix}").Invoke();

      Assert.AreEqual(expectedCount, childItems.Count);
      Assert.IsTrue(childItems.All(child => ((OrganizationDetail)child.BaseObject).FriendlyName.EndsWith(suffix)));
    }

    [TestMethod]
    public void RootChildrenOrganizationDetailsFilterStartsWith() {
      string prefix = Organization.FriendlyName.Substring(0, 3);
      int expectedCount = Organizations.Count(organization => organization.FriendlyName.StartsWith(prefix));

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Filter {prefix}*").Invoke();

      Assert.AreEqual(expectedCount, childItems.Count);
      Assert.IsTrue(childItems.All(child => ((OrganizationDetail)child.BaseObject).FriendlyName.StartsWith(prefix)));
    }

    [TestMethod]
    public void RootChildrenOrganizationDetailsFilterSubstring() {
      string substring = Organization.FriendlyName.Substring(0, 3);
      int expectedCount = Organizations.Count(organization => organization.FriendlyName.Contains(substring));

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Filter *{substring}*").Invoke();

      Assert.AreEqual(expectedCount, childItems.Count);
      Assert.IsTrue(childItems.All(child => ((OrganizationDetail)child.BaseObject).FriendlyName.Contains(substring)));
    }

    [TestMethod]
    public void OrganizationNodeCanBeNavigatedUsingOrganizationFriendlyName() {
      string expectedPath = $"{DriveName}:\\{Organization.FriendlyName}";

      PowerShell.AddScript($"Set-Location {Organization.FriendlyName}").Invoke();

      Assert.AreEqual(expectedPath, PowerShell.Runspace.SessionStateProxy.Path.CurrentLocation.Path);
    }

    [TestMethod]
    public void OrganizationNodeCanBeNavigatedUsingRelativePath() {
      string expectedPath = $"{DriveName}:\\{Organization.FriendlyName}";

      PowerShell.AddScript($"Set-Location .\\{Organization.FriendlyName}").Invoke();

      Assert.AreEqual(expectedPath, PowerShell.Runspace.SessionStateProxy.Path.CurrentLocation.Path);
    }

    [TestMethod]
    public void NavigatingToInvalidOrganizationCausesError() {
      string invalidOrganizationName = Guid.NewGuid().ToString();
      string expectedErrorMessage = $"Cannot find path '{DriveName}:\\{invalidOrganizationName}' because it does not exist.";

      PowerShell.AddScript($"Set-Location {invalidOrganizationName};").Invoke();
      ErrorRecord actualErrorMessage = PowerShell.Streams.Error.FirstOrDefault();

      Assert.AreEqual(1, PowerShell.Streams.Error.Count);
      Assert.IsNotNull(actualErrorMessage);
      Assert.AreEqual(expectedErrorMessage, actualErrorMessage.Exception.Message);
    }
  }
}