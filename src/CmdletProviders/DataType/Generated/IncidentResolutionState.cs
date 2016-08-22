using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  public enum IncidentResolutionState
  {
    [EnumMember] Open,
    [EnumMember] Completed,
    [EnumMember] Canceled,
  }
}
