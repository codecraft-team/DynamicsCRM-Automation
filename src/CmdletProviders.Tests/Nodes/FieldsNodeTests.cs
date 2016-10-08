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
  public class FieldsNodeTests {
    const string DriveName = "CRMLocal";
    const string OrganizationName = "crm-packaging";

    public PowerShell PowerShell { get; set; }
    public EntityMetadata AccountMetadata { get; set; }

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

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new OrganizationServiceAdapterMock {
          OrganizationFriendlyNameGet = () => OrganizationName,
          RetrieveAllEntityMetadata = () => new List<EntityMetadata> {
            AccountMetadata
          }
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      PowerShell.AddScript($@"Set-Location {DriveName}:\{OrganizationName}\{EntitiesNode.NodeName}\account\{FieldsNode.NodeName};");
    }

    [TestMethod]
    public void FieldNodeHasAttributeMetadataChildren() {
      AttributeMetadata[] expectedAttriubtes = {
        new AttributeMetadata {
          MetadataId = Guid.NewGuid(),
          LogicalName = "name"
        },
        new AttributeMetadata {
          MetadataId = Guid.NewGuid(),
          LogicalName = "address1city"
        }
      };
      AccountMetadata.SetAttributes(expectedAttriubtes);

      Collection<AttributeMetadata> actualAttributes = PowerShell.AddScript("Get-ChildItem;").Invoke<AttributeMetadata>();

      Assert.IsFalse(PowerShell.HadErrors);
      CollectionAssert.AreEqual(expectedAttriubtes, actualAttributes);
    }
  }
}