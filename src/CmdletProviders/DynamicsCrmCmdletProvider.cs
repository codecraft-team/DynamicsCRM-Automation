using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Provider;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders {
  [CmdletProvider("CRM", ProviderCapabilities.Include | ProviderCapabilities.Exclude | ProviderCapabilities.Filter)]
  public class DynamicsCrmCmdletProvider : NavigationCmdletProvider {
    public DynamicsCrmCmdletProvider() {
      Logger.RegisterProvider(this);
    }

    protected override PSDriveInfo NewDrive(PSDriveInfo drive) {
      Contract.Requires<InvalidOperationException>(null != DynamicParameters, "DynamicParameters required to create new PSDrive.");
      Contract.Requires<InvalidOperationException>(DynamicParameters is CrmDriveParameter, "DynamicParameters must be an instance of CrmDriveParameter.");
      Contract.Requires<InvalidOperationException>(null != ((CrmDriveParameter) DynamicParameters).DiscoveryServiceAdapter, "DiscoveryServiceAdapter parameter required to initialize new drive.");
      Contract.Requires<InvalidOperationException>(null != ((CrmDriveParameter) DynamicParameters).OrganizationServiceAdapters, "OrganizationServiceAdapters parameter required to initialize new drive.");

      return new CrmDriveInfo(drive, (CrmDriveParameter) DynamicParameters);
    }

    private CrmPath GetCrmPath(string path) {
      Contract.Requires<InvalidOperationException>(null != PSDriveInfo, "An instance of PSDriveInfo required to build path.");
      Contract.Requires<InvalidOperationException>(PSDriveInfo is CrmDriveInfo, "PSDriveInfo must be an instance of CrmDriveInfo.");

      NodeContext nodeContext = new NodeContext((CrmDriveInfo) PSDriveInfo) {
        Filter = Filter,
        Force = Force,
        WriteItemObject = WriteItemObject
      };
      nodeContext.SetPath(path);

      CrmPath crmPath = new CrmPath(nodeContext);
      return crmPath;
    }

    protected override object NewDriveDynamicParameters() {
      return new CrmDriveParameter();
    }

    protected override bool IsValidPath(string path) {
      bool isPathValid = GetCrmPath(path).CurrentNode.Path.Trim('\\') == path.Trim('\\');
      TraceDebug($"Path '{path}' is valid: {isPathValid}.");
      return isPathValid;
    }

    protected override bool IsItemContainer(string path) {
      bool isContainer = GetCrmPath(path).CurrentNode.IsContainer;
      TraceDebug($"Item '{path}' is container: {isContainer}.");
      return isContainer;
    }

    protected override bool ItemExists(string path) {
      bool itemExists = GetCrmPath(path).CurrentNode.Path.Trim('\\') == path.Trim('\\');
      TraceDebug($"Item '{path}' exists: {itemExists}.");
      return itemExists;
    }

    protected override string MakePath(string parent, string child) {
      List<string> pathItems = new List<string> {
        parent,
        child
      };
      string path = string.Join("\\", pathItems.Where(p => !string.IsNullOrEmpty(p)).Select(p => p.Trim('\\')));
      return $"\\{path}";
    }

    protected override void GetChildItems(string path, bool recurse) {
      TraceDebug("GetChildItems path: '{0}' recurse: {1}", path, recurse);
      GetCrmPath(path).CurrentNode.GetChildItems();
    }

    protected override void RemoveItem(string path, bool recurse) {
      TraceDebug("RemoveItem: '{0}' recurse: {1}", path, recurse);

      GetCrmPath(path).CurrentNode.RemoveItem(recurse);
    }

    protected override string GetChildName(string path) {
      string normalizedPath = NodeContext.NormalizePath(path);
      string childName = normalizedPath.Split('\\').Last();

      TraceDebug("Child name of {0} is {1}.", path, childName);

      return childName;
    }

    protected override string GetParentPath(string path, string root) {
      if (!string.IsNullOrEmpty(root) && !path.Contains(root)) {
        TraceDebug($"Parent path of {path} is [null].");
        return null;
      }

      if (!path.Contains("\\")) {
        TraceDebug($"Parent path of {path} is {root} (root).");
        return path == "\\" ? null : root;
      }

      string parentPath = path.Substring(0, path.LastIndexOf("\\", StringComparison.OrdinalIgnoreCase));

      TraceDebug($"Parent path of {path} is {(parentPath ?? "null")}.");
      return parentPath;
    }

    protected override void GetChildNames(string path, ReturnContainers returnContainers) {
      TraceDebug("GetChildNames of {0} ({1}).", path, returnContainers);

      GetCrmPath(path).CurrentNode.GetChildNames(returnContainers);
    }

    protected override bool HasChildItems(string path) {
      bool hasChildItems = GetCrmPath(path).CurrentNode.HasChildItems();
      TraceDebug("{0} {1} child items.", path, hasChildItems ? "has" : "doesn't have");
      return hasChildItems;
    }

    private void TraceDebug(string format, params object[] args) {
      string formattedMessage = string.Format(format, args);
      Logger.WriteDebug(formattedMessage);
    }
  }
}