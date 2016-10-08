using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class EntityMetadataNodeTests {
    const string DriveName = "CRMLocal";
    const string OrganizationName = "crm-packaging";

    public PowerShell PowerShell { get; set; }
    public EntityMetadata AccountMetadata { get; set; }
    public EntityMetadata ContactMetadata { get; set; }

    [TestInitialize]
    public void TestInitialize() {
      IDiscoveryServiceAdapter discoveryServiceAdapter = new StubIDiscoveryServiceAdapter {
        DiscoverOrganizations = () => new List<OrganizationDetail> {
          new OrganizationDetail {
            FriendlyName = OrganizationName
          }
        },
        IsDiscoverable = () => true
      };

      AccountMetadata = new EntityMetadata {
        MetadataId = Guid.NewGuid(),
        LogicalName = "account",
        DisplayName = new Label(new LocalizedLabel("Account", 1033), new LocalizedLabel[0])
      };

      ContactMetadata = new EntityMetadata {
        MetadataId = Guid.NewGuid(),
        LogicalName = "contact",
        DisplayName = new Label(new LocalizedLabel("Contact", 1033), new LocalizedLabel[0])
      };

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new OrganizationServiceAdapterMock {
          OrganizationFriendlyNameGet = () => OrganizationName,
          RetrieveAllEntityMetadata = () => new List<EntityMetadata> {
            AccountMetadata,
            ContactMetadata,
            new EntityMetadata {
              MetadataId = Guid.NewGuid(),
              LogicalName = "opportunity",
              DisplayName = new Label(new LocalizedLabel("Opportunity", 1033), new LocalizedLabel[0])
            }
          }
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      PowerShell.AddScript($@"Set-Location {DriveName}:\{OrganizationName}\{EntitiesNode.NodeName};");
    }

    [TestMethod]
    public void RelativeAccountPathHasStaticNodesChildren() {
      PowerShell.AddScript($@"Set-Location .\{AccountMetadata.LogicalName};");

      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      AssertChildItems(childItems);
    }

    [TestMethod]
    public void RelativeContactPathHasStaticNodesChildren() {
      PowerShell.AddScript($@"Set-Location .\{ContactMetadata.LogicalName};");

      Collection<PSObject> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke();

      AssertChildItems(childItems);
    }

    [TestMethod]
    public void AbsoluteEntityMetadataPathHasStaticNodesChildren() {
      string absolutePath = $@"{DriveName}:\{OrganizationName}\{EntitiesNode.NodeName}\{AccountMetadata.LogicalName}";

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Path {absolutePath};").Invoke();

      AssertChildItems(childItems);
    }

    [TestMethod]
    public void AbsoluteContactPathHasStaticNodesChildren() {
      string absolutePath = $@"{DriveName}:\{OrganizationName}\{EntitiesNode.NodeName}\{ContactMetadata.LogicalName}";

      Collection<PSObject> childItems = PowerShell.AddScript($"Get-ChildItem -Path {absolutePath};").Invoke();

      AssertChildItems(childItems);
    }

    private void AssertChildItems(Collection<PSObject> childItems) {
      Assert.AreEqual(5, childItems.Count);
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is FormsNode));
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is FieldsNode));
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is OneToManyRelationshipsNode));
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is ManyToOneRelationshipsNode));
      Assert.AreEqual(1, childItems.Count(childItem => childItem.BaseObject is ManyToManyRelationshipsNode));
    }
  }
}