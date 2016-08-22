using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  [TestClass]
  public class CodeGeneration {
    [TestMethod, Timeout(360000)]
    [Ignore]
    public void Generate() {
      string organizationName = "Playground";
      string connectionString = "[excluded from push]";

      OrganizationDataCollector collector = new OrganizationDataCollector();
      OrganizationData organizationData = collector.Collect(new OrganizationServiceAdapter(organizationName, connectionString));

      EmbeddedOrganizationDataWriter writer = new EmbeddedOrganizationDataWriter();
      writer.Write(organizationName, organizationData);
    }
  }
}