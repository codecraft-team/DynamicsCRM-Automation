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
  public class OneToManyRelationshipsNodeTests {
    const string DriveName = "CRMLocal";
    const string OrganizationName = "crm-packaging";

    public PowerShell PowerShell { get; set; }

    public EntityMetadata AccountMetadata { get; set; }

    public OneToManyRelationshipMetadata[] AccountRelationships { get; set; }
    public OneToManyRelationshipMetadata Relationship { get; set; }

    [TestInitialize]
    public void TestInitialize() {
      AccountRelationships = new [] {
        new OneToManyRelationshipMetadata { SchemaName = "accountcontacts" }
      };
      Relationship = AccountRelationships.First();

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
          },
          RetrieveOneToManyRelationshipsString = entityLogicalName => entityLogicalName == AccountMetadata.LogicalName ? AccountRelationships : null
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      PowerShell.AddScript($@"Set-Location {DriveName}:\{OrganizationName}\{EntitiesNode.NodeName}\account\{OneToManyRelationshipsNode.NodeName};");
    }

    [TestMethod]
    public void RelationshipNodeHasRelationshipMetadataChildren() {
      List<OneToManyRelationshipMetadata> expectedRelationships = AccountRelationships.ToList();

      Collection<OneToManyRelationshipMetadata> actualRelationships = PowerShell.AddScript("Get-ChildItem;").Invoke<OneToManyRelationshipMetadata>();

      CollectionAssert.AreEqual(expectedRelationships, actualRelationships);
    }
  }
}