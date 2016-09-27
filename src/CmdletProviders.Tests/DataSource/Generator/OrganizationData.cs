using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class OrganizationData {
    public IEnumerable<EntityMetadata> EntityMetadatas { get; set; }

    public IEnumerable<CrmForm> Forms { get; set; }
  }
}