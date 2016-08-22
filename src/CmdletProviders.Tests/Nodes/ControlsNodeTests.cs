using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class ControlsNodeTests : ProviderTestBase {
    [TestInitialize]
    public void TestInitialize() {
      PowerShell.AddScript($"Set-Location \".\\{Organization.FriendlyName}\\{EntitiesNode.NodeName}\\{EntityMetadata.LogicalName}\\{FormsNode.NodeName}\\{Form["name"]}\\Controls\"");
    }

    [TestMethod]
    public void HasFormChildren() {
      IEnumerable<XElement> expectedControls = Form.GetControls().ToList();
      Predicate<Collection<PSObject>> areExpectedControlsInOutput = psObjects => {
        List<XElement> expectedControlsNotInOutput = expectedControls.Where(expectedControl => psObjects.All(child => ((ControlNode) child.BaseObject).Id != expectedControl.GetId())).ToList();
        expectedControlsNotInOutput.ForEach(c => Console.WriteLine($"Missing from output: {c.ToString()}"));
        bool result = expectedControlsNotInOutput.Any();

        return result;
      };

      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.IsTrue(childItems.All(child => child.BaseObject is ControlNode));
      Assert.AreEqual(expectedControls.Count(), childItems.Count);
      Assert.IsFalse(areExpectedControlsInOutput(childItems));
    }
  }
}