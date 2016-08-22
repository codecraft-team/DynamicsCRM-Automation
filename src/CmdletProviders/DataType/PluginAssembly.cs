namespace PowerShellLibrary.Crm.CmdletProviders {
  public partial class PluginAssembly {
    public string ModifiedByFormatted => ModifiedBy?.Name;
    public string IsolationModeFormatted => ((AssemblyIsolationMode)(IsolationMode?.Value ?? 0)).ToString();
  }
}