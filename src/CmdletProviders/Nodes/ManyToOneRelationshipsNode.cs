using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class ManyToOneRelationshipsNode : NodeBase {
    public const string NodeName = "ManyToOneRelationships";

    public EntityMetadataNode Parent { get; }

    public ManyToOneRelationshipsNode(EntityMetadataNode parent) : base(parent.NodeContext, null, NodeName) {
      IsContainer = true;
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(NodeName);
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<ManyToManyRelationshipMetadata> oneToManyRelationships = GetOrganizationServiceAdapter().RetrieveManyToManyRelationships(Parent.Name);
      oneToManyRelationships = Filter(oneToManyRelationships, relationship => relationship.SchemaName);

      return oneToManyRelationships.Select(metadata => new ManyToOneRelationshipMetadataNode(this, metadata));
    }
  }
}