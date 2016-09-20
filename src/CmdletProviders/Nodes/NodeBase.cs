using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Management.Automation;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public abstract class NodeBase {
    public string Name { get; protected set; }
    public bool IsContainer { get; protected set; }
    public PathSegment PathSegment { get; protected set; }
    public NodeContext NodeContext { get; internal set; }
    public object Value { get; }

    protected NodeBase(NodeContext nodeContext, object value, string name) {
      IsContainer = true;
      NodeContext = nodeContext;
      Value = value ?? this;
      Name = name;
    }

    private bool UseFilter() {
      return !string.IsNullOrEmpty(NodeContext.Filter) && PathSegment.Equals(NodeContext.CrmDrive.CurrentLocation);
    }

    protected IOrganizationServiceAdapter GetOrganizationServiceAdapter() {
      return NodeContext.GetOrganizationServiceAdapter();
    }

    protected IEnumerable<T> Filter<T>(IEnumerable<T> collection, Func<T, string> filteredMember) {
      if (UseFilter()) {
        WildcardPattern wildcardPattern = new WildcardPattern(NodeContext.Filter);
        return collection.Where(item => wildcardPattern.IsMatch(filteredMember(item)));
      }

      return collection;
    }

    public virtual IEnumerable<NodeBase> GetChildNodes() {
      throw new NotSupportedException($"The node {GetType().FullName} under the path '{PathSegment}' does not support child nodes.");
    }
    
    public virtual void RemoveItem(object value) {
      throw new NotSupportedException($"The node {GetType().FullName} under the path '{PathSegment}' does not support Remove-Item.");
    }

    public virtual string GetChildName() {
      Debug.WriteLine("The node {0} under the path '{1}' does not return the child name yet.", GetType().FullName, PathSegment);
      return null;
    }

    public void GetChildItems() {
      GetChildNodes().ForEach(childNode =>  NodeContext.WriteItemObject(new PSObject(childNode.Value), childNode.PathSegment.Path, childNode.IsContainer));
    }

    public virtual void GetChildNames(ReturnContainers returnContainers) {
      Contract.Requires<NotSupportedException>(IsContainer, "Only container nodes support GetChildNames.");

      foreach (NodeBase childNode in GetChildNodes()) {
        if (returnContainers == ReturnContainers.ReturnAllContainers || string.IsNullOrEmpty(NodeContext.Filter)) {
          NodeContext.WriteItemObject(childNode.Name, childNode.Name, IsContainer);
        }
        else {
          WildcardPattern wildcardPattern = new WildcardPattern(NodeContext.Filter);
          if (wildcardPattern.IsMatch(childNode.Name)) {
            NodeContext.WriteItemObject(childNode.Name, childNode.Name, IsContainer);
          }
        }
      }
    }

    public virtual bool HasChildItems() {
      return IsContainer;
    }
  }
}