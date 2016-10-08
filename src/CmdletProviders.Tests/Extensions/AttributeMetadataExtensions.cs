using System.Linq;
using System.Reflection;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public static class AttributeMetadataExtensions {
    public static void SetIsManaged(this AttributeMetadata attributeMetadata, bool? isManaged) {
      PropertyInfo attributesProperty = typeof(AttributeMetadata).GetProperty("IsManaged");
      attributesProperty.GetSetMethod(true).Invoke(attributeMetadata, new object[] {
        isManaged
      });
    }
  }
}