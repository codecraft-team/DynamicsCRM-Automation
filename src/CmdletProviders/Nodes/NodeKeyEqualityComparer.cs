using System;
using System.Collections.Generic;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class NodeKeyEqualityComparer : IEqualityComparer<string> {
    public bool Equals(string x, string y) {
      if(ReferenceEquals(x, y)) {
        return true;
      }

      if(ReferenceEquals(x, null)) {
        return false;
      }

      if(ReferenceEquals(y, null)) {
        return false;
      }

      if(x.GetType() != y.GetType()) {
        return false;
      }

      return string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
    }

    public int GetHashCode(string key) {
      string caseIndependentKey = key?.ToLower();

      return caseIndependentKey?.GetHashCode() ?? 0;
    }
  }
}