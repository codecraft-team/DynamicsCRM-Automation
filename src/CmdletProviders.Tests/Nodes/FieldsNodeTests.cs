using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class FieldsNodeTests : ProviderTestBase {

    [TestMethod]
    public void FieldNodeHasAttributeMetadataChildren() {
      PowerShell.AddScript($"Set-Location .\\{Organization.FriendlyName}\\{EntitiesNode.NodeName}\\{EntityMetadata.LogicalName}\\{FieldsNode.NodeName}");

      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.AreEqual(EntityMetadata.Attributes.Count(), childItems.Count);
      Assert.IsTrue(EntityMetadata.Attributes.All(field => childItems.Any(child => ((AttributeMetadata) child.BaseObject).LogicalName == field.LogicalName)));
    }
  }
}