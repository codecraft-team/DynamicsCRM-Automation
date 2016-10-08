using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Fakes;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {

  [TestClass]
  public class AdvancedFindNodeTests {
    const string DriveName = "CRMLocal";
    const string OrganizationName = "crm-packaging";

    public PowerShell PowerShell { get; set; }

    public OrganizationServiceContextMock OrganizationServiceContextMock { get; set; }

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

      var organizationServiceAdapter = new StubIOrganizationServiceAdapter {
        OrganizationFriendlyNameGet = () => OrganizationName
      };
      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        organizationServiceAdapter
      };

      OrganizationServiceContextMock = new OrganizationServiceContextMock(new StubIOrganizationService());
      organizationServiceAdapter.CreateContext = () => OrganizationServiceContextMock;

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive("CRMLocal", discoveryServiceAdapter, organizationServiceAdapters);
    }

    [TestMethod]
    public void CreatesContext() {
      const string entityLogicalName = "account";
      List<Entity> expectedEntities = new List<Entity> {new Entity("account", Guid.NewGuid()), new Entity("account", Guid.NewGuid()) };
      OrganizationServiceContextMock.Entities["account"] = expectedEntities.AsQueryable();

      PowerShell.AddScript($@"Set-Location -Path {DriveName}:\{OrganizationName};");
      PowerShell.AddScript("$advancedFindNode = gci -Filter AdvancedFind | select -First 1;");
      PowerShell.AddScript("$context = $advancedFindNode.CreateContext();");

      Collection<PSObject> actualEntities = PowerShell.AddScript($"$context.CreateQuery(\"{entityLogicalName}\");").Invoke();

      Assert.AreEqual(expectedEntities.Count, actualEntities.Count);
      Assert.IsTrue(expectedEntities.All(expectedEntity => actualEntities.Any(actualEntity => ((Entity) actualEntity.BaseObject).Id == expectedEntity.Id)));
    }
  }
}