using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Nodes {
  public class ManyToManyRelationshipMetadataNode : NodeBase {
    public ManyToManyRelationshipsNode Parent { get; }

    public ManyToManyRelationshipMetadataNode(ManyToManyRelationshipsNode parent, RelationshipMetadataBase value) : base(parent.NodeContext, value, value.SchemaName) {
      IsContainer = false;
      Parent = parent;
      Path = $"{parent.Path}\\{value.SchemaName}";
    }

    public override void RemoveItem(object value) {
      string relationshipLogicalName = Name;
      string entityLogicalName = Parent.Parent.Name;

      GetOrganizationServiceAdapter().DeleteRelationship(entityLogicalName, relationshipLogicalName);
    }
  }
}
