using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class EntitiesNodeTests : ProviderTestBase {
    [TestInitialize]
    public void TestInitialize() {
      PowerShell.AddScript($"Set-Location {Organization.FriendlyName}\\{EntitiesNode.NodeName};");
    }

    [TestMethod]
    public void HasEntityMetadataChildren() {
      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.AreEqual(Entities.Count(), childItems.Count);
      Assert.IsTrue(childItems.All(childItem => childItem.BaseObject is EntityMetadata));
    }

    [TestMethod]
    public void ChildrenWithoutNavigationToPath() {
      PowerShell.AddScript("Set-Location ..\\..");
      string organizationPath = $".\\{Organization.FriendlyName}\\{EntitiesNode.NodeName}";

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem {organizationPath};").Invoke();

      Assert.AreEqual(Entities.Count(), childItems.Count);
      Assert.IsTrue(childItems.All(childItem => childItem.BaseObject is EntityMetadata));
    }

    [TestMethod]
    public void ChildrenFilterStartsWith() {
      string prefix = EntityMetadata.LogicalName.Substring(0, 3);

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Filter {prefix}*").Invoke();

      Assert.AreEqual(Entities.Count(entity => entity.LogicalName.StartsWith(prefix)), childItems.Count);
      Assert.IsTrue(childItems.All(child => child.BaseObject is EntityMetadata));
    }

    [TestMethod]
    public void ChildrenFilterEndsWith() {
      string suffix = EntityMetadata.LogicalName.Substring(EntityMetadata.LogicalName.Length - 3);

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Filter *{suffix}").Invoke();

      Assert.AreEqual(Entities.Count(entity => entity.LogicalName.EndsWith(suffix)), childItems.Count);
      Assert.IsTrue(childItems.All(child => child.BaseObject is EntityMetadata));
    }

    [TestMethod]
    public void ChildrenFilterContains() {
      string substring = EntityMetadata.LogicalName.Substring(EntityMetadata.LogicalName.Length - 5, 3);

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Filter *{substring}*").Invoke();

      Assert.AreEqual(Entities.Count(entity => entity.LogicalName.Contains(substring)), childItems.Count);
      Assert.IsTrue(childItems.All(child => child.BaseObject is EntityMetadata));
    }


    [TestMethod]
    public void TestCaseInsensitiveSetLocation() {
      PowerShell.AddScript("Set-Location ACCOUNT").Invoke();

      Assert.IsFalse(PowerShell.HadErrors);
    }
  }
}