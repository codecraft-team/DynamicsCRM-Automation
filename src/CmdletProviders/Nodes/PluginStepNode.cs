namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class PluginStepNode : NodeBase {
    public PluginStepsNode Parent { get; }
    public SdkMessageProcessingStep PluginStep { get; set; }

    public PluginStepNode(PluginStepsNode parent, SdkMessageProcessingStep value) : base(parent.NodeContext, value, value.Name) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(value.Name);
      PluginStep = value;
    }
  }
}