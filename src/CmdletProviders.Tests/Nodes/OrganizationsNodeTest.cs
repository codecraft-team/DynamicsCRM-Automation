using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Discovery;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class OrganizationsNodeTest {
    private const string CrmPackaging = "crm-packaging";

    public PowerShell PowerShell { get; set; }

    [TestInitialize]
    public void TestInitialize() {
      IDiscoveryServiceAdapter discoveryServiceAdapter = new StubIDiscoveryServiceAdapter {
        DiscoverOrganizations = () => new List<OrganizationDetail> {
          new OrganizationDetail {
            FriendlyName = CrmPackaging
          }
        },
        IsDiscoverable = () => true
      };

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new StubIOrganizationServiceAdapter {
          OrganizationFriendlyNameGet = () => CrmPackaging
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive("CRMLocal", discoveryServiceAdapter, organizationServiceAdapters);
      PowerShell.AddScript("Set-Location CrmLocal:");
    }

    [TestMethod]
    public void GetOrganizationNodeChildrenTest() {
      PowerShell.AddScript($"Set-Location {CrmPackaging};");

      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.AreEqual(5, childItems.Count);
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is EntitiesNode));
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is WebResourcesNode));
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is PluginAssembliesNode));
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is PluginStepsNode));
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is AdvancedFindNode));
    }

    [TestMethod]
    public void OrganizationsAreSortedByFriendlyName() {
      Collection<OrganizationDetail> result = PowerShell.AddScript("Get-ChildItem").Invoke<OrganizationDetail>();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(1, result.Count);
      Assert.AreEqual(CrmPackaging, result[0].FriendlyName);
    }
  }
}