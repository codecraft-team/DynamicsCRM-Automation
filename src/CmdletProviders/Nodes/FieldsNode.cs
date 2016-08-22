using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class FieldsNode : NodeBase {
    public const string NodeName = "Fields";
    public EntityMetadataNode Parent { get; private set; }

    public FieldsNode(EntityMetadataNode parent) : base(parent.NodeContext, null, NodeName) {
      Parent = parent;
      Path = $"{parent.Path}\\{NodeName}";
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      string entityLogicalName = Parent.Name;
      IEnumerable<AttributeMetadata> attributeMetadataCollection = GetOrganizationServiceAdapter().RetrieveAttributes(entityLogicalName);
      attributeMetadataCollection = Filter(attributeMetadataCollection, attributeMetadata => attributeMetadata.LogicalName);

      return attributeMetadataCollection.Select(attributeMetadata => new AttributeMetadataNode(this, attributeMetadata));
    }
  }
}