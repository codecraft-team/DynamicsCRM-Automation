namespace PowerShellLibrary.Crm.CmdletProviders {
  public enum PluginStepStage {
    PreValidation = 10,
    PreOperation = 20,
    PostOperation = 40,
    PostOperationDeprecated = 50,
  }
}
