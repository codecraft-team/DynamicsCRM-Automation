using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {

  [TestClass]
  public class AdvancedFindNodeTests : ProviderTestBase {
    [TestMethod]
    public void CreatesContext() {
      const string entityLogicalName = "account";
      List<Entity> expectedEntities = OrganizationServiceContext.CreateQuery(entityLogicalName).ToList();

      PowerShell.AddScript($"Set-Location -Path .\\{Organization.FriendlyName}");
      PowerShell.AddScript("$advancedFindNode = gci -Filter AdvancedFind | select -First 1;");
      PowerShell.AddScript("$context = $advancedFindNode.CreateContext();");

      Collection<PSObject> actualEntities = PowerShell.AddScript($"$context.CreateQuery(\"{entityLogicalName}\");").Invoke();

      Assert.AreEqual(expectedEntities.Count, actualEntities.Count, "Organization {0}", Organization.FriendlyName);
      Assert.IsTrue(expectedEntities.All(expectedEntity => actualEntities.Any(actualEntity => ((Entity) actualEntity.BaseObject)["name"] == expectedEntity["name"])));
    }
  }
}