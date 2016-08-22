using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class AttributeMetadataNodeTests : ProviderTestBase {
    [TestInitialize]
    public void TestInitialize() {
      List<AttributeMetadata> unmanagedAttributes = EntityMetadata.Attributes.Where(attribute => !attribute.IsManaged.GetValueOrDefault()).ToList();
      AttributeMetadata = unmanagedAttributes.ElementAt(Random.Next(0, unmanagedAttributes.Count - 1));

      PowerShell.AddScript($"Set-Location \".\\{Organization.FriendlyName}\\{EntitiesNode.NodeName}\\{EntityMetadata.LogicalName}\\{FieldsNode.NodeName}\"");
    }

    [TestMethod]
    public void RemoveItem() {
      const string attributeNotOnTheForm = "cu_customname";
      Collection<PSObject> childItems = PowerShell.AddScript($"Remove-Item -Path {attributeNotOnTheForm};").Invoke();

      Assert.AreEqual(0, childItems.Count);
      Assert.IsFalse(EntityMetadata.Attributes.Any(a => a.LogicalName == attributeNotOnTheForm));
    }

    [TestMethod]
    public void ConflictsDisplayedAsWarning() {
      const string attributeOnFormBody = "new_customfield1";

      string expectedPathPrefix = $"\\{Organization.FriendlyName}\\Entities\\{EntityMetadata.LogicalName}\\Forms\\";
      IEnumerable<Entity> expectedDependencies = Forms.Where(form => form.GetControls().Any(control => control.GetDataFieldName() == attributeOnFormBody)).ToList();

      PowerShell.AddScript($"Remove-Item -Path {attributeOnFormBody};").Invoke();

      Assert.AreEqual(1 + expectedDependencies.Count(), PowerShell.Streams.Warning.Count);
      Assert.AreEqual($"The {attributeOnFormBody} component cannot be deleted because it is referenced by {expectedDependencies.Count()} other components.{Environment.NewLine}", PowerShell.Streams.Warning[0].Message);
      Assert.IsTrue(Enumerable.Range(0, expectedDependencies.Count() - 1).All(i => $"Dependency found under path: {expectedPathPrefix}{expectedDependencies.ElementAt(i)["name"]}" == PowerShell.Streams.Warning[i + 1].Message));
    }

    [TestMethod]
    public void WhenRemoveConflictsAttributeNotDeleted() {
      const string attributeOnFormBody = "new_customfield1";

      Collection<PSObject> childItems = PowerShell.AddScript($"Remove-Item -Path {attributeOnFormBody};").Invoke();

      Assert.AreEqual(0, childItems.Count);
      Assert.IsTrue(EntityMetadata.Attributes.Any(a => a.LogicalName == attributeOnFormBody));
    }

    [TestMethod]
    public void RemoveItemForceResolvesConflicts() {
      const string attributeOnFormBody = "new_customfield1";

      int dependencyFoundWarningCount = 4;
      int dependencyCountWarning = Forms.Count(form => form.GetControls().Any(control => control.GetDataFieldName() == attributeOnFormBody));

      Collection<PSObject> childItems = PowerShell.AddScript($"Remove-Item -Path {attributeOnFormBody} -Force;").Invoke();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(dependencyFoundWarningCount + dependencyCountWarning, PowerShell.Streams.Warning.Count);
      Assert.AreEqual(0, childItems.Count);
      Assert.IsTrue(Form.GetControls().All(a => a.GetDataFieldName() != attributeOnFormBody), "The control was not removed from the form.");
      Assert.IsFalse(EntityMetadata.Attributes.Any(a => a.LogicalName == attributeOnFormBody), "The field was not removed from entity customizations.");
    }

    [TestMethod]
    public void ManagedFieldsCannotBeDeleted() {
      AttributeMetadata managedAttribute = (from attribute in EntityMetadata.Attributes
                                            join formControl in Form.GetControls() on attribute.LogicalName equals formControl.GetDataFieldName()
                                            where attribute.IsManaged.GetValueOrDefault()
                                            select attribute).First();

      string expectedError = $"Cannot delete attribute: {managedAttribute.LogicalName} from Entity: {EntityMetadata.DisplayName.UserLocalizedLabel.Label} since the attribute is not a custom field.";

      Collection<PSObject> childItems = PowerShell.AddScript($"Remove-Item -Path {managedAttribute.LogicalName};").Invoke();

      Assert.AreEqual(0, childItems.Count);
      Assert.AreEqual(0, PowerShell.Streams.Warning.Count);
      Assert.AreEqual(1, PowerShell.Streams.Error.Count);
      Assert.AreEqual(expectedError, PowerShell.Streams.Error[0].Exception.Message);
    }
  }
}