using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class OneToManyRelationshipsNodeTests : ProviderTestBase {
    public OneToManyRelationshipMetadata[] Relationships { get; set; }
    public OneToManyRelationshipMetadata Relationship { get; set; }
    public string RelationshipSchemaName { get; set; }

    [TestInitialize]
    public void TestInitialize() {
      Relationships = EntityMetadata.OneToManyRelationships;
      Relationship = Relationships.ElementAt(Random.Next(0, Relationships.Count()));
      RelationshipSchemaName = Relationship.SchemaName;

      PowerShell.AddScript($"Set-Location .\\{Organization.FriendlyName}\\{EntitiesNode.NodeName}\\{EntityMetadata.LogicalName}\\{OneToManyRelationshipsNode.NodeName}");
    }

    [TestMethod]
    public void RelationshipNodeHasRelationshipMetadataChildren() {
      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      Assert.AreEqual(Relationships.Count(), childItems.Count);
      Assert.IsTrue(Relationships.All(field => childItems.Any(child => ((OneToManyRelationshipMetadata) child.BaseObject).SchemaName == field.SchemaName)));
    }
  }
}