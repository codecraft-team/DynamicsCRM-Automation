using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  [TestClass]
  public class DataSourceTests {
    [TestMethod]
    public void AllOrganizationEntitiesLoaded() {
      string[] expectedEntities = DataSourceConfiguration.Playground.EntityLogicalNames;

      OrganizationData organizationData = new EmbeddedOrganizationDataReader().Read("Playground");
      EntityMetadata[] actualEntities = organizationData.EntityMetadatas.ToArray();

      Assert.AreEqual(expectedEntities.Length, actualEntities.Length);
      Assert.IsTrue(expectedEntities.All(expectedEntity => actualEntities.Any(actualEntity => expectedEntity == actualEntity.LogicalName)));
    }

    [TestMethod]
    public void AllFormsLoaded() {
      string[] expectedForms = DataSourceConfiguration.Playground.Forms;

      OrganizationData organizationData = new EmbeddedOrganizationDataReader().Read("Playground");
      Entity[] actualForms = organizationData.Forms.ToArray();

      Assert.AreEqual(4, actualForms.Length);
      Assert.IsTrue(expectedForms.All(expectedForm => actualForms.Any(actualForm => expectedForm == actualForm.LogicalName)));
    }

    [TestMethod]
    public void TestAttributeRemove() {
      string attributeLogicalName = "name";
      OrganizationData organizationData = new EmbeddedOrganizationDataReader().Read("Playground");

      EntityMetadata metadata = organizationData.EntityMetadatas.First(p => p.LogicalName == "account");
      AttributeMetadata attributeToRemove = metadata.Attributes.First(a => a.LogicalName == attributeLogicalName);

      List<AttributeMetadata> newAttributes = metadata.Attributes.ToList();
      newAttributes.Remove(attributeToRemove);

      FieldInfo attributesField = metadata.GetType().GetField("_attributes", BindingFlags.Instance | BindingFlags.NonPublic);
      attributesField.SetValue(metadata, newAttributes.ToArray());

      Assert.AreEqual(0, metadata.Attributes.Count(a => a.LogicalName == attributeLogicalName));
    }
  }
}