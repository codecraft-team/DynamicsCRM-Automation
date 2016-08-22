using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class NodeContext {
    public CrmDriveInfo CrmDrive { get; private set; }
    public string Path { get; private set; }
    public WriteItemObjectDelegate WriteItemObject { get; set; }
    public string Filter { get; set; }
    public bool Force { get; set; }

    public NodeContext(CrmDriveInfo driveInfo) {
      Contract.Requires<ArgumentNullException>(null != driveInfo, "driveInfo");

      CrmDrive = driveInfo;
    }

    public void SetPath(string path) {
      Path = NormalizePath(path);
    }

    public static string NormalizePath(string path) {
      path = path.Replace('/', '\\');
      path = !string.IsNullOrEmpty(path) && !path.StartsWith("\\") ? "\\" + path : path;

      return path;
    }

    public IOrganizationServiceAdapter GetOrganizationServiceAdapter() {
      string organizationFriendlyName = Path.Split(new[] {
        '\\'
      }, StringSplitOptions.RemoveEmptyEntries).First();

      IOrganizationServiceAdapter adapter = CrmDrive.DriveParameter.GetOrganizationServiceAdapter(organizationFriendlyName);
      return adapter;
    }
  }
}