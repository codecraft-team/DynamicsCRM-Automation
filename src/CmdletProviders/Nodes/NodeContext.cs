using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class NodeContext {
    public CrmDriveInfo CrmDrive { get; private set; }
    public PathSegment PathSegment { get; private set; }

    public WriteItemObjectDelegate WriteItemObject { get; set; }
    public string Filter { get; set; }
    public bool Force { get; set; }

    public NodeContext(CrmDriveInfo driveInfo) {
      Contract.Requires<ArgumentNullException>(null != driveInfo, "driveInfo");

      CrmDrive = driveInfo;
    }

    public void SetPath(PathSegment pathSegment) {
      PathSegment = pathSegment;
    }

    public IOrganizationServiceAdapter GetOrganizationServiceAdapter() {
      string organizationFriendlyName = PathSegment.Segments.First();

      return CrmDrive.DriveParameter.GetOrganizationServiceAdapter(organizationFriendlyName);
    }
  }
}