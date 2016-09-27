namespace PowerShellLibrary.Crm.CmdletProviders {
  public partial class PluginType {
    public string IsWorkflowActivityFormatted => IsWorkflowActivity.GetValueOrDefault() ? "Yes" : "No";
    public string ModifiedOnFormatted => ModifiedOn?.ToString("yyyy.MM.dd HH:mm:ss");
  }
}