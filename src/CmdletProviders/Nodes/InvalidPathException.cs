using System;
using System.Collections.Generic;
using System.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  internal class InvalidPathException : Exception {
    public InvalidPathException(string path, IEnumerable<string> validPathCollection)
      : this(path, validPathCollection.Any() ? validPathCollection.Aggregate((p, acc) => string.Format("{0}{1}{2}", acc, Environment.NewLine, p)) : null) {
    }

    private InvalidPathException(string path, string validPathList) : base(string.Format("The specified path '{0}' is invalid. The following paths are supported: {1}", path, validPathList)) {
    }
  }
}