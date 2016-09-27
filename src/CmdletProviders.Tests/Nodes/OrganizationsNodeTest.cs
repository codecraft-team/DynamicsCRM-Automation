using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class OrganizationsNodeTest : ProviderTestBase {
    [TestMethod]
    public void GetOrganizationNodeChildrenTest() {
      PowerShell.AddScript($"Set-Location {Organization.FriendlyName};");

      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.AreEqual(5, childItems.Count);
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is EntitiesNode));
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is WebResourcesNode));
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is PluginAssembliesNode));
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is PluginStepsNode));
      Assert.IsTrue(childItems.Any(childItem => childItem.BaseObject is AdvancedFindNode));
    }
  }
}