using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {

  public class ProviderTestBase {
    public const string DriveName = "CRMLocal";
    protected readonly Random Random = new Random(DateTime.Now.Millisecond);
    private IDiscoveryServiceAdapter _discoveryServiceAdapter;
    private List<IOrganizationServiceAdapter> _organizationServiceAdapters;
    private IOrganizationServiceAdapter _organizationServiceAdapter;

    public PowerShell PowerShell { get; set; }

    public IEnumerable<OrganizationDetail> Organizations { get; private set; }
    public OrganizationDetail Organization { get; private set; }
    public IEnumerable<EntityMetadata> Entities { get; set; }
    public EntityMetadata EntityMetadata { get; private set; }
    public AttributeMetadata AttributeMetadata { get; set; }
    public IEnumerable<Entity> Forms { get; set; }
    public Entity Form { get; set; }

    public OrganizationServiceContext OrganizationServiceContext { get; set; }
    
    [TestInitialize]
    public void TestInitializeBase() {
      _discoveryServiceAdapter = new EmbeddedDiscoveryDataAdapter();
      _organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new EmbeddedOrganizationDataAdapter(DataSourceConfiguration.Playground)
      };

      InitializeRandomDataModel();

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, _discoveryServiceAdapter, _organizationServiceAdapters);
    }

    [TestCleanup]
    public void TestCleanupBase() {
      WriteCurrentDataModelToConsole();

      StreamToConsole("Error", PowerShell.Streams.Error.Select(ToTraceString));
      StreamToConsole("Warning", PowerShell.Streams.Warning.Select(warning => warning.Message));
      StreamToConsole("Debug", PowerShell.Streams.Debug.Select(debug => debug.Message));
      StreamToConsole("Verbose", PowerShell.Streams.Verbose.Select(verbose => verbose.Message));
      StreamToConsole("Progress", PowerShell.Streams.Progress.Select(progress => progress.Activity));

      PowerShell.Dispose();
    }

    private string ToTraceString(ErrorRecord error) {
      StringBuilder trace = new StringBuilder();
      trace.AppendLine($"Exception Message: {error?.Exception?.Message ?? "null"}");
      trace.AppendLine($"Exception Stacktrace: {error?.Exception?.StackTrace ?? "null"}");
      trace.AppendLine($"ErrorDetails Message: {error?.ErrorDetails?.Message ?? "null"}");
      return trace.ToString();
    }

    private void InitializeRandomDataModel() {
      Organizations = _discoveryServiceAdapter.DiscoverOrganizations().ToList();

      SetOrganization(Organizations.ElementAt(Random.Next(0, Organizations.Count() - 1)).FriendlyName);
      SetEntityMetadata(Entities.ElementAt(Random.Next(0, Entities.Count())).LogicalName);
      SetForm(Forms.ElementAt(Random.Next(0, Forms.Count())).GetAttributeValue<string>("name"));

      OrganizationServiceContext = _organizationServiceAdapter.CreateContext();
    }

    protected void SetTestData(string organizationFriendlyName, string entityLogicalName, string attributeLogicalName, string formName) {
      SetOrganization(organizationFriendlyName);
      SetEntityMetadata(entityLogicalName);
      SetForm(formName);
    }

    protected void SetOrganization(string organizationFriendlyName) {
      Organization = Organizations.Single(p => p.FriendlyName == organizationFriendlyName);

      _organizationServiceAdapter = _organizationServiceAdapters.Single(o => o.OrganizationFriendlyName == Organization.FriendlyName);
      Entities = _organizationServiceAdapter.RetrieveAllEntityMetadata().ToList();

      EntityMetadata = null;
      AttributeMetadata = null;
      Forms = null;
      Form = null;
    }

    protected void SetEntityMetadata(string logicalName) {
      EntityMetadata = Entities.Single(p => p.LogicalName == logicalName);
      Forms = _organizationServiceAdapter.RetrieveFilteredForms(EntityMetadata.LogicalName).ToList();

      AttributeMetadata = null;
      Form = null;
    }

    protected void SetForm(string formName) {
      Form = Forms.Single(p => p.GetAttributeValue<string>("name") == formName);
    }

    private void WriteCurrentDataModelToConsole() {
      Console.WriteLine($"Organization: {Organization?.FriendlyName}");
      Console.WriteLine($"EntityMetadata: {EntityMetadata?.LogicalName}");
      Console.WriteLine($"AttributeMetadata: {AttributeMetadata?.LogicalName}");
      Console.WriteLine($"Form: {Form?["name"]}");
    }

    private void StreamToConsole(string streamName, IEnumerable<string> messages) {
      Console.WriteLine($"{streamName} Stream: ");
      messages.ForEach(Console.WriteLine);
    }
  }
}