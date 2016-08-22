using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class FormNodeTests : ProviderTestBase {
    [TestInitialize]
    public void TestInitialize() {
      PowerShell.AddScript($"Set-Location \".\\{Organization.FriendlyName}\\{EntitiesNode.NodeName}\\{EntityMetadata.LogicalName}\\{FormsNode.NodeName}\\{Form.GetAttributeValue<string>("name")}\"");
    }

    [TestMethod]
    public void HasChildren() {
      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(1, childItems.Count);
      Assert.IsTrue(childItems.All(child => child.BaseObject is ControlsNode));
    }
  }
}