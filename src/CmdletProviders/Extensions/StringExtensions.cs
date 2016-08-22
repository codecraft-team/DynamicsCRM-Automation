using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Security;

namespace PowerShellLibrary.Crm.CmdletProviders.Extensions {
  public static class StringExtensions {
    public static string ToUnsecure(this SecureString secureString) {
      Contract.Requires<ArgumentNullException>(null != secureString);

      IntPtr unmanagedString = IntPtr.Zero;
      try {
        unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
        return Marshal.PtrToStringUni(unmanagedString);
      }
      finally {
        Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
      }
    }
  }
}