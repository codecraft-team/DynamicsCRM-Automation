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
    private const string RootPath = "";

    public IReadOnlyDictionary<string, NodeBase> Providers => new ReadOnlyDictionary<string, NodeBase>(_nodes);
    public NodeBase this[string path] => _nodes[path];
    public NodeBase CurrentNode { get; private set; }

    public CrmPath(NodeContext nodeContext) {
      Contract.Requires<ArgumentNullException>(null != nodeContext, "nodeContext");

      _nodes = new Dictionary<string, NodeBase>();
      _nodeContext = nodeContext;

      CreateNodes();
    }

    private NodeBase GetNode(string pathSegment) {
      if (!_nodes.ContainsKey(pathSegment)) {
        return new NotSupportedNode(pathSegment);
      }

      return _nodes[pathSegment];
    }

    private void CreateNodes() {
      CurrentNode = CreateRootNode();

      string[] segments = GetPathWithoutDriveName().Split(new[] {'\\'}, StringSplitOptions.RemoveEmptyEntries);
      StringBuilder pathBuilder = new StringBuilder();
      
      foreach (string segment in segments) {
        CurrentNode.GetChildNodes().ForEach(provider => EnsureNodeExists(provider.Path, provider));

        string currentPath = pathBuilder.AppendFormat("\\{0}", segment).ToString();
        if (_nodes.ContainsKey(currentPath)) {
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
      if (null == organizationNode) {
        return;
      }

      _nodeContext.CrmDrive.SetPrompt(_nodeContext.GetOrganizationServiceAdapter().GetUrl());
    }

    private void SetDeploymentUrl() {
      NodeBase deploymentNode = Providers.Values.FirstOrDefault(node => node is DiscoveryNode);
      if (null == deploymentNode) {
        return;
      }

      string prompt = null;
      if (_nodeContext.CrmDrive.DiscoveryServiceAdapter.IsDiscoverable()) {
        prompt = _nodeContext.CrmDrive.DiscoveryServiceAdapter.Url?.Replace("/XRMServices/2011/Discovery.svc", string.Empty);
      }

      _nodeContext.CrmDrive.SetPrompt(prompt);
      _nodeContext.CrmDrive.SetDiscoverable();
    }

    private NodeBase CreateRootNode() {
      EnsureNodeExists(RootPath, new DiscoveryNode(_nodeContext));
      return GetNode(RootPath);
    }

    private void EnsureNodeExists(string key, NodeBase node) {
      if (!_nodes.ContainsKey(key)) {
        _nodes.Add(key, node);
      }
      else {
        Logger.WriteVerbose($"The node for the path {key} already exists.");
      }
    }

    private string GetPathWithoutDriveName() {
      return _nodeContext.Path.Split(new[] {':'}).Last();
    }
  }
}