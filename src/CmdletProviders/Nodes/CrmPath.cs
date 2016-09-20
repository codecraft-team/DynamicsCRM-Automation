using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class CrmPath {
    private readonly Dictionary<string, NodeBase> _nodes;
    private readonly NodeContext _nodeContext;

    public IReadOnlyDictionary<string, NodeBase> Providers => new ReadOnlyDictionary<string, NodeBase>(_nodes);
    public NodeBase this[string path] => _nodes[path];
    public NodeBase CurrentNode { get; private set; }

    public CrmPath(NodeContext nodeContext) {
      Contract.Requires<ArgumentNullException>(null != nodeContext, "nodeContext");

      _nodes = new Dictionary<string, NodeBase>(new NodeKeyEqualityComparer());
      _nodeContext = nodeContext;

      CreateNodes();
    }

    private NodeBase GetNode(string path) {
      if(!NodesContainsKey(path)) {
        return new NotSupportedNode(path);
      }

      return _nodes[path];
    }

    private void CreateNodes() {
      CurrentNode = CreateRootNode();

      IEnumerable<string> paths = _nodeContext.PathSegment.GetPathDecendants();

      foreach(string currentPath in paths) {
        CurrentNode.GetChildNodes().ForEach(EnsureNodeExists);

        if(NodesContainsKey(currentPath)) {
          CurrentNode = _nodes[currentPath];
        }
      }

      SetPrompt();
    }

    private void SetPrompt() {
      SetDeploymentUrl();
      SetOrganizationUrl();
    }

    private void SetOrganizationUrl() {
      NodeBase organizationNode = Providers.Values.FirstOrDefault(node => node is OrganizationNode);
      if(null == organizationNode) {
        return;
      }

      _nodeContext.CrmDrive.SetPrompt(_nodeContext.GetOrganizationServiceAdapter().GetUrl());
    }

    private void SetDeploymentUrl() {
      NodeBase deploymentNode = Providers.Values.FirstOrDefault(node => node is DiscoveryNode);
      if(null == deploymentNode) {
        return;
      }

      string prompt = null;
      if(_nodeContext.CrmDrive.DiscoveryServiceAdapter.IsDiscoverable()) {
        prompt = _nodeContext.CrmDrive.DiscoveryServiceAdapter.Url?.Replace("/XRMServices/2011/Discovery.svc", string.Empty);
      }

      _nodeContext.CrmDrive.SetPrompt(prompt);
      _nodeContext.CrmDrive.SetDiscoverable();
    }

    private NodeBase CreateRootNode() {
      EnsureNodeExists(new DiscoveryNode(_nodeContext));
      return GetNode(PathSegment.RootPath);
    }

    private void EnsureNodeExists(NodeBase node) {
      string key = node.PathSegment.Path;

      if(!NodesContainsKey(key)) {
        _nodes.Add(key, node);
      }
      else {
        Logger.WriteVerbose($"The node for the path {key} already exists.");
      }
    }

    private bool NodesContainsKey(string key) {
      return _nodes.ContainsKey(key);
    }
  }
}