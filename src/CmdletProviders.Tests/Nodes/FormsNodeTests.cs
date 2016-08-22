using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class FormsNodeTests : ProviderTestBase {
    [TestMethod]
    public void FormNodeHasSystemFormChildren() {
      PowerShell.AddScript($"Set-Location .\\{Organization.FriendlyName}\\{EntitiesNode.NodeName}\\{EntityMetadata.LogicalName}\\{FormsNode.NodeName}");

      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.AreEqual(Forms.Count(), childItems.Count);
      Assert.IsTrue(Forms.All(form => childItems.Any(child => ((Entity) child.BaseObject)["name"] == form["name"])));
    }
  }
}