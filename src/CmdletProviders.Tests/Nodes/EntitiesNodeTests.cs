using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class EntitiesNodeTests {
    const string OrganizationName = "crm-packaging";
    const string DriveName = "CRMLocal";

    public PowerShell PowerShell { get; set; }
    public List<EntityMetadata> EntityMetadataList { get; set; }

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

      EntityMetadataList = new List<EntityMetadata> {
        new EntityMetadata {
          MetadataId = Guid.NewGuid(),
          LogicalName = "account"
        },
        new EntityMetadata {
          MetadataId = Guid.NewGuid(),
          LogicalName = "contact"
        }
      };

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new StubIOrganizationServiceAdapter {
          OrganizationFriendlyNameGet = () => OrganizationName,
          RetrieveAllEntityMetadata = () => EntityMetadataList
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      PowerShell.AddScript($"Set-Location {DriveName}:\\{OrganizationName}\\{EntitiesNode.NodeName};");
    }

    [TestMethod]
    public void HasEntityMetadataChildren() {
      List<EntityMetadata> expectedChildren = EntityMetadataList;

      Collection<EntityMetadata> childItems = PowerShell.AddScript("Get-ChildItem;").Invoke<EntityMetadata>();

      CollectionAssert.AreEqual(expectedChildren, childItems);
    }

    [TestMethod]
    public void GetChildItemUsingPath() {
      List<EntityMetadata> expectedChildren = EntityMetadataList;
      PowerShell.AddScript($"Set-Location {DriveName}:\\");

      Collection<EntityMetadata> actualChildren = PowerShell.AddScript($"Get-ChildItem -Path {OrganizationName}\\{EntitiesNode.NodeName};").Invoke<EntityMetadata>();

      CollectionAssert.AreEqual(expectedChildren, actualChildren);
    }

    [TestMethod]
    public void ChildrenFilterStartsWith() {
      const string prefix = "acc";
      List<EntityMetadata> expectedChildren = EntityMetadataList.Where(entity => entity.LogicalName.StartsWith(prefix)).ToList();

      Collection<EntityMetadata> actualChildren = PowerShell.AddScript($"Get-ChildItem -Filter {prefix}*").Invoke<EntityMetadata>();

      CollectionAssert.AreEqual(expectedChildren, actualChildren);
    }

    [TestMethod]
    public void ChildrenFilterEndsWith() {
      const string suffix = "tact";
      List<EntityMetadata> expectedChildren = EntityMetadataList.Where(entity => entity.LogicalName.EndsWith(suffix)).ToList();

      Collection<EntityMetadata> actualChildren = PowerShell.AddScript($"Get-ChildItem -Filter *{suffix}").Invoke<EntityMetadata>();

      CollectionAssert.AreEqual(expectedChildren, actualChildren);
    }

    [TestMethod]
    public void ChildrenFilterContains() {
      string substring = "ou";
      List<EntityMetadata> expectedChildren = EntityMetadataList.Where(entity => entity.LogicalName.Contains(substring)).ToList();

      Collection<EntityMetadata> actualChildren = PowerShell.AddScript($"Get-ChildItem -Filter *{substring}*").Invoke<EntityMetadata>();

      CollectionAssert.AreEqual(expectedChildren, actualChildren);
    }

    [TestMethod]
    public void TestCaseInsensitiveSetLocation() {
      PowerShell.AddScript("Set-Location ACCOUNT").Invoke();

      Assert.IsFalse(PowerShell.HadErrors);
    }

    [TestMethod]
    public void TestCasesensitiveGetLocation() {
      PowerShell.AddScript("Set-Location ACCOUNT");

      Collection<PathInfo> locations = PowerShell.AddScript("Get-Location").Invoke<PathInfo>();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(1, locations.Count);
      Assert.AreEqual($@"{DriveName}:\{OrganizationName}\Entities\account", locations[0].Path);
    }
  }
}