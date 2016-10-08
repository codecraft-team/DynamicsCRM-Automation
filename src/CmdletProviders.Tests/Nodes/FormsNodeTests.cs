using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class FormsNodeTests {
    const string DriveName = "CRMLocal";
    const string OrganizationName = "crm-packaging";

    public PowerShell PowerShell { get; set; }
    public List<CrmForm> AccountForms { get; set; }

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

      EntityMetadata accountMetadata = new EntityMetadata {
        MetadataId = Guid.NewGuid(),
        LogicalName = "account",
        DisplayName = new Label(new LocalizedLabel("Account", 1033), new LocalizedLabel[0])
      };
      AccountForms = new List<CrmForm>();

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new OrganizationServiceAdapterMock {
          OrganizationFriendlyNameGet = () => OrganizationName,
          RetrieveAllEntityMetadata = () => new List<EntityMetadata> {
            accountMetadata
          },
          RetrieveFilteredFormsEntityMetadata = entityMetadata => {
            if (entityMetadata.LogicalName != "account") {
              throw new NotImplementedException();
            }
            return AccountForms;
          }
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      PowerShell.AddScript($@"Set-Location {DriveName}:\{OrganizationName}\{EntitiesNode.NodeName}\account\{FormsNode.NodeName};");
    }

    [TestMethod]
    public void FormsNodeChildrenAreCrmForms() {
      AccountForms = new List<CrmForm> {
        new CrmForm {
          Name = "Information",
          ObjectTypeCode = "account"
        },
        new CrmForm {
          Name = "Account",
          ObjectTypeCode = "account"
        }
      };
      List<CrmForm> expectedForms = AccountForms;

      Collection<CrmForm> actualForms = PowerShell.AddScript("Get-ChildItem;").Invoke<CrmForm>();

      Assert.IsFalse(PowerShell.HadErrors);
      CollectionAssert.AreEqual(expectedForms, actualForms);
    }
  }
}