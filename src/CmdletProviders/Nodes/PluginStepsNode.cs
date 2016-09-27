using System.Collections.Generic;
using System.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class PluginStepsNode : NodeBase {
    public const string NodeName = "PluginSteps";
    public OrganizationNode Parent { get; private set; }

    public PluginStepsNode(OrganizationNode parent) : base(parent.NodeContext, null, NodeName) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(Name);
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<SdkMessageProcessingStep> plugins = GetOrganizationServiceAdapter().RetrievePluginSteps();
      plugins = Filter(plugins, messageProcessingStep => messageProcessingStep.Name);

      return plugins.Select(sdkMessageProcessingStep => new PluginStepNode(this, sdkMessageProcessingStep));
    }
  }
}