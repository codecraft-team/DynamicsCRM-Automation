using System.Linq;
using System.Reflection;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public static class EntityMetadataExtensions {
    public static void SetAttributes(this EntityMetadata entityMetadata, params AttributeMetadata[] attributes) {
      PropertyInfo attributesProperty = typeof(EntityMetadata).GetProperty("Attributes");
      attributesProperty.GetSetMethod(true).Invoke(entityMetadata, new object[] {
        attributes.ToArray()
      });
    }
  }
}