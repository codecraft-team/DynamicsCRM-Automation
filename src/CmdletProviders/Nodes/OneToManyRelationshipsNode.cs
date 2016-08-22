using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class OneToManyRelationshipsNode : NodeBase {
    public const string NodeName = "OneToManyRelationships";

    public EntityMetadataNode Parent { get; private set; }

    public OneToManyRelationshipsNode(EntityMetadataNode parent) : base(parent.NodeContext, null, NodeName) {
      IsContainer = true;
      Parent = parent;
      Path = $"{parent.Path}\\{NodeName}";
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<OneToManyRelationshipMetadata> oneToManyRelationships = GetOrganizationServiceAdapter().RetrieveOneToManyRelationships(Parent.Name);
      oneToManyRelationships = Filter(oneToManyRelationships, relationship => relationship.SchemaName);

      return oneToManyRelationships.Select(metadata => new OneToManyRelationshipMetadataNode(this, metadata));
    }
  }
}