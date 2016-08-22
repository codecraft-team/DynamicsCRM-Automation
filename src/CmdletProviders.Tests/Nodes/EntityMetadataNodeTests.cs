using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class EntityMetadataNodeTests : ProviderTestBase {

    [TestInitialize]
    public void TestInitialize() {
      PowerShell.AddScript($"Set-Location .\\{Organization.FriendlyName}\\{EntitiesNode.NodeName}\\{EntityMetadata.LogicalName}");
    }

    [TestMethod]
    public void EntityMetadataHasStaticNodesChildren() {
      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.AreEqual(5, childItems.Count);
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is FormsNode));
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is FieldsNode));
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is OneToManyRelationshipsNode));
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is ManyToOneRelationshipsNode));
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is ManyToManyRelationshipsNode));
    }
  }
}