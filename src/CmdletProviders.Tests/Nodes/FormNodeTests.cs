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
  public class FormNodeTests {
    const string DriveName = "CRMLocal";
    const string OrganizationName = "crm-packaging";

    public PowerShell PowerShell { get; set; }
    public CrmForm AccountForm { get; set; }

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
      AccountForm = new CrmForm(Guid.NewGuid()) {
        Name = "Account",
        ObjectTypeCode = "account"
      };
      List<CrmForm> accountForms = new List<CrmForm> {
        new CrmForm(Guid.NewGuid()) {
          Name = "Information",
          ObjectTypeCode = "account"
        },
        AccountForm
      };

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
            return accountForms;
          }
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      PowerShell.AddScript($@"Set-Location {DriveName}:\{OrganizationName}\{EntitiesNode.NodeName}\account\{FormsNode.NodeName};");
    }

    [TestMethod]
    public void AccountFormHasControlsNode() {
      PowerShell.AddScript($@"Set-Location .\{AccountForm.Name};");

      Collection<ControlsNode> actualControls = PowerShell.AddScript("Get-ChildItem;").Invoke<ControlsNode>();

      PowerShell.WriteErrorsToConsole();
      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(1, actualControls.Count);
    }
  }
}