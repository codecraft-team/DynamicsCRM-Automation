using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Discovery;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class OrganizationConfigurationTest {
    [TestMethod]
    public void TestMissingOrganizationConfiguration() {
      EmbeddedDiscoveryDataAdapter discoveryServiceAdapter = new EmbeddedDiscoveryDataAdapter(new List<OrganizationDetail> {
                                                                                                new OrganizationDetail {
                                                                                                  FriendlyName = DataSourceConfiguration.Playground.OrganizationFriendlyName
                                                                                                },
                                                                                                new OrganizationDetail {
                                                                                                  FriendlyName = DataSourceConfiguration.NotConfiguredOraganization.OrganizationFriendlyName
                                                                                                }
                                                                                              });

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new EmbeddedOrganizationDataAdapter(DataSourceConfiguration.Playground)
      };

      PowerShell powerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      powerShell.NewDrive(ProviderTestBase.DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      Collection<PSObject> childItems = powerShell.AddScript("Get-ChildItem").Invoke();

      Assert.AreEqual(childItems.Count, childItems.Count);
      Assert.IsTrue(childItems[0].BaseObject is OrganizationDetail);
      Assert.AreEqual(DataSourceConfiguration.Playground.OrganizationFriendlyName, ((OrganizationDetail)childItems[0].BaseObject).FriendlyName);
    }
  }
}