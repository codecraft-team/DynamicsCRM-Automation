using System.Collections.Generic;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class EntityMetadataNode : NodeBase {
    public EntitiesNode Parent { get; }
    public FormsNode Forms { get; set; }
    public EntityMetadata EntityMetadata { get; set; }

    public EntityMetadataNode(EntitiesNode parent, EntityMetadata value) : base(parent.NodeContext, value, value.LogicalName) {
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(value.LogicalName);
      Forms = new FormsNode(this);
      EntityMetadata = value;
    }

    public override IEnumerable<NodeBase> GetChildNodes() {
      NodeBase[] nodes = {
        Forms,
        new FieldsNode(this),
        new OneToManyRelationshipsNode(this),
        new ManyToOneRelationshipsNode(this),
        new ManyToManyRelationshipsNode(this)
      };

      return Filter(nodes, nodeBase => nodeBase.Name);
    }

    public void Publish() {
      IOrganizationServiceAdapter organizationServiceAdapter = GetOrganizationServiceAdapter();
      organizationServiceAdapter.PublishEntity(EntityMetadata.LogicalName);
    }
  }
}