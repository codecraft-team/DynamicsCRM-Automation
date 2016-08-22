using System;
using System.Diagnostics.Contracts;
using System.Management.Automation;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public class CrmDriveInfo : PSDriveInfo {
    public readonly CrmDriveParameter DriveParameter;

    public string Prompt { get; private set; }
    public bool IsDiscoverable { get; private set; }
    public IDiscoveryServiceAdapter DiscoveryServiceAdapter => DriveParameter.DiscoveryServiceAdapter;

    public CrmDriveInfo(PSDriveInfo psDriveInfo, CrmDriveParameter driveParameter) : base(psDriveInfo) {
      Contract.Requires<ArgumentNullException>(null != psDriveInfo, "psDriveInfo");
      Contract.Requires<ArgumentNullException>(null != driveParameter, "driveParameter");

      DriveParameter = driveParameter;
    }

    public void SetPrompt(string prompt) {
      Prompt = prompt;
    }

    public void SetDiscoverable() {
      IsDiscoverable = DiscoveryServiceAdapter.IsDiscoverable();
    }
  }
}