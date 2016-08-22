using System.IO;
using Newtonsoft.Json;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class EmbeddedOrganizationDataWriter {
    //TODO: Relative Path (consider PowerShell environment).
    public const string TargetDir = @"R:\Source\jhorvath\PowerShellLibrary\Main\Source\DynamicsCRM\Provider\Provider.Tests\DataSource";

    public string Url { get; set; }

    public void Write(string organizationFriendlyName, OrganizationData organizationData) {
      string targetEntitiesFileName = $@"{TargetDir}\{organizationFriendlyName}.Entities.generated.{GetTargetFileExtension()}";
      Write(targetEntitiesFileName, organizationData.EntityMetadatas);

      string targetFormsFileName = $@"{TargetDir}\{organizationFriendlyName}.Forms.generated.{GetTargetFileExtension()}";
      Write(targetFormsFileName, organizationData.Forms);
    }

    private void Write(string targetFileName, object data) {
      string serializedData = Serialize(data);
      File.WriteAllText(targetFileName, serializedData);
    }

    protected virtual string Serialize(object data) {
      return JsonConvert.SerializeObject(data, Formatting.Indented);
    }

    protected virtual string GetTargetFileExtension() {
      return "json";
    }
  }
}