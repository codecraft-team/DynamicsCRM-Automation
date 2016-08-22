using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace PowerShellLibrary.Crm.CmdletProviders
{
  [GeneratedCode("CrmSvcUtil", "7.1.0001.3108")]
  [DataContract]
  public enum AsyncOperationState
  {
    [EnumMember] Ready,
    [EnumMember] Suspended,
    [EnumMember] Locked,
    [EnumMember] Completed,
  }
}
