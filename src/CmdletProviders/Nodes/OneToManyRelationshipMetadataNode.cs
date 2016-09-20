using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class OneToManyRelationshipMetadataNode : NodeBase {
    public OneToManyRelationshipsNode Parent { get; }

    public OneToManyRelationshipMetadataNode(OneToManyRelationshipsNode parent, RelationshipMetadataBase value) : base(parent.NodeContext, value, value.SchemaName) {
      IsContainer = false;
      Parent = parent;
      PathSegment = parent.PathSegment + new PathSegment(value.SchemaName);
    }

    public override void RemoveItem(object value) {
      string relationshipLogicalName = Name;
      string entityLogicalName = Parent.Parent.Name;

      GetOrganizationServiceAdapter().DeleteRelationship(entityLogicalName, relationshipLogicalName);
    }
  }
}
