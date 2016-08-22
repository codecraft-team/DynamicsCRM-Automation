using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class ManyToManyRelationshipsNode : NodeBase {
    public const string NodeName = "ManyToManyRelationships";

    public EntityMetadataNode Parent { get; private set; }

    public ManyToManyRelationshipsNode(EntityMetadataNode parent) : base(parent.NodeContext, null, NodeName) {
      IsContainer = true;
      Parent = parent;
      Path = $"{parent.Path}\\{NodeName}";
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<ManyToManyRelationshipMetadata> oneToManyRelationships = GetOrganizationServiceAdapter().RetrieveManyToManyRelationships(Parent.Name);
      oneToManyRelationships = Filter(oneToManyRelationships, relationship => relationship.SchemaName);

      return oneToManyRelationships.Select(metadata => new ManyToManyRelationshipMetadataNode(this, metadata));
    }
  }
}