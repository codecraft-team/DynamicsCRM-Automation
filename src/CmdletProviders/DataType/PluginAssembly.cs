namespace PowerShellLibrary.Crm.CmdletProviders {
  public partial class PluginAssembly {
    public string ModifiedByFormatted => ModifiedBy?.Name;
    public string ModifiedOnFormatted => ModifiedOn?.ToString("yyyy.MM.dd HH:mm:ss");
    public string IsolationModeFormatted => ((PluginAssemblyIsolationMode)(IsolationMode?.Value ?? 0)).ToString();
  }
}