using Microsoft.Xrm.Sdk;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public partial class SdkMessageProcessingStep {
    public string PrimaryEntityFormatted => Attributes.Contains("a1.primaryobjecttypecode") ? ((AliasedValue)Attributes["a1.primaryobjecttypecode"]).Value.ToString() : null;
    public string MessageFormatted => Attributes.Contains("a2.name") ? ((AliasedValue)Attributes["a2.name"]).Value.ToString() : null;
    public string StageFormatted => Stage != null ? ((PluginStepStage) Stage.Value).ToString() : null;
    public string StatusFormatted => StatusCode != null ? (StatusCode.Value == 1 ? "Yes" : "No") : null;
  }
}