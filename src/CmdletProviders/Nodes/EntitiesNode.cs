using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class EntitiesNode : NodeBase {
    public const string NodeName = "Entities";
    public OrganizationNode Parent { get; private set; }

    public EntitiesNode(OrganizationNode parent) : base(parent.NodeContext, null, NodeName) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(Name);
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      IEnumerable<EntityMetadata> entityMetadataCollection = GetOrganizationServiceAdapter().RetrieveAllEntityMetadata();
      entityMetadataCollection = Filter(entityMetadataCollection, entityMetadata => entityMetadata.LogicalName);

      return entityMetadataCollection.Select(entityMetadata => new EntityMetadataNode(this, entityMetadata));
    }
  }
}