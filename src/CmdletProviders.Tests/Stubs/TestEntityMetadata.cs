using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Stubs {
  public class TestEntityMetadata {
    public EntityMetadata Value { get; set; }
    public List<Entity> Forms { get; set; }
  }
}