using System;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerShellLibrary.Crm.CmdletProviders.Tests.Stubs;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  [TestClass]
  public class NewPsDriveTests {
    public PowerShell PowerShell { get; set; }

    [TestInitialize]
    public void TestInitialize() {
      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
    }

    [TestMethod, ExpectedException(typeof (PSArgumentNullException))]
    public void DiscoveryServiceAdapterRequired() {
      PowerShell.NewDrive(Guid.NewGuid().ToString("N"), null, new List<IOrganizationServiceAdapter> {
        new StubOrganizationServiceAdapter("OrganizationName")
      }).Invoke();

      Assert.Fail();
    }

    [TestMethod, ExpectedException(typeof (PSArgumentNullException))]
    public void OrganizationServiceAdapterRequired() {
      PowerShell.NewDrive(Guid.NewGuid().ToString("N"), new StubDiscoveryServiceAdapter("url"), null).Invoke();

      Assert.Fail();
    }
  }
}