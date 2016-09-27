using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class EmbeddedOrganizationDataReader {
    private const string EmbeddedResourcePrefix = "PowerShellLibrary.Crm.CmdletProviders.Tests.DataSource.";

    public OrganizationData Read(string organizationFriendlyName) {
      return new OrganizationData {
        EntityMetadatas = ReadEntities(organizationFriendlyName),
        Forms = ReadForms(organizationFriendlyName)
      };
    }

    private IEnumerable<EntityMetadata> ReadEntities(string organizationFriendlyName) {
      string entitiesFileName = $"{EmbeddedResourcePrefix}{organizationFriendlyName}.Entities.generated.json";
      return Read<List<EntityMetadata>>(entitiesFileName);
    }

    private IEnumerable<CrmForm> ReadForms(string organizationFriendlyName) {
      string entitiesFileName = $"{EmbeddedResourcePrefix}{organizationFriendlyName}.Forms.generated.json";
      return Read<List<CrmForm>>(entitiesFileName);
    }

    private TResult Read<TResult>(string resourceName) {
      using (Stream stream = typeof (ProviderTestBase).Assembly.GetManifestResourceStream(resourceName)) {
        if (null == stream) {
          throw new InvalidOperationException($"Failed to read organization data. Embedded resource with name {resourceName} not found.");
        }

        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8)) {
          string resourceContent = reader.ReadToEnd();

          JsonConverter[] customConverters = {
            new AttributeCollectionConverter(),
            new FormattedValueCollectionConverter(),
            new RelatedEntityCollectionConverter(),
            new KeyAttributeCollectionConverter()
          };

          return JsonConvert.DeserializeObject<TResult>(resourceContent, customConverters);
        }
      }
    }
  }

  public class AttributeCollectionConverter : JsonConverter {
    private static readonly Type AttributeCollectionType = typeof (AttributeCollection);

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
      throw new NotImplementedException();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
      AttributeCollection attributeCollection = existingValue as AttributeCollection ?? new AttributeCollection();

      JToken jToken = JToken.Load(reader);

      foreach (JToken keyValuePairToken in jToken) {
        string key = keyValuePairToken.Value<string>("Key");
        object value = GetValue(keyValuePairToken);

        attributeCollection[key] = value;
      }

      return attributeCollection;
    }

    private object GetValue(JToken eyValuePairToken) {
      JToken valueToken = eyValuePairToken["Value"];

      if (valueToken.Type == JTokenType.String) {
        return valueToken.Value<string>();
      }
      if (valueToken.Type == JTokenType.Integer) {
        return valueToken.Value<int>();
      }
      if (valueToken.Type == JTokenType.Guid) {
        return valueToken.Value<Guid>();
      }
      if (valueToken.Type == JTokenType.Boolean) {
        return valueToken.Value<bool>();
      }
      if (valueToken.Type == JTokenType.Date) {
        return valueToken.Value<DateTime>();
      }

      if (valueToken.Type == JTokenType.Object) {
        if (valueToken["ManagedPropertyLogicalName"] != null) {
          return new BooleanProperty(valueToken.Value<bool>("Value"), valueToken.Value<string>("ManagedPropertyLogicalName")) {
            CanBeChanged = valueToken.Value<bool>("CanBeChanged")
          };
        }

        if (valueToken["Id"] != null && valueToken["LogicalName"] != null) {
          return new EntityReference(valueToken.Value<string>("LogicalName"), Guid.Parse(valueToken.Value<string>("Id")));
        }

        bool isOptionSetValue = valueToken.Value<int>("Value") != 0;
        if (isOptionSetValue) {
          return new OptionSetValue(valueToken.Value<int>("Value"));
        }
      }

      return null;
    }

    public override bool CanConvert(Type objectType) {
      return objectType == AttributeCollectionType;
    }
  }

  public class FormattedValueCollectionConverter : JsonConverter {
    private static readonly Type FormattedValueCollectionType = typeof (FormattedValueCollection);

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
      throw new NotImplementedException();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
      FormattedValueCollection formattedValues = existingValue as FormattedValueCollection ?? new FormattedValueCollection();

      JToken jToken = JToken.Load(reader);

      foreach (JToken keyValuePairToken in jToken) {
        string key = keyValuePairToken.Value<string>("Key");
        string value = keyValuePairToken.Value<string>("Value");

        formattedValues[key] = value;
      }

      return formattedValues;
    }

    public override bool CanConvert(Type objectType) {
      return objectType == FormattedValueCollectionType;
    }
  }

  public class RelatedEntityCollectionConverter : JsonConverter {
    private static readonly Type RelatedEntityCollectionType = typeof (RelatedEntityCollection);

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
      throw new NotImplementedException();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
      RelatedEntityCollection formattedValues = existingValue as RelatedEntityCollection ?? new RelatedEntityCollection();

      JToken jToken = JToken.Load(reader);

      foreach (JToken keyValuePairToken in jToken) {
       throw new NotImplementedException();
      }

      return formattedValues;
    }

    public override bool CanConvert(Type objectType) {
      return objectType == RelatedEntityCollectionType;
    }
  }
  
  public class KeyAttributeCollectionConverter : JsonConverter {
    private static readonly Type KeyAttributeCollectionType = typeof (KeyAttributeCollection);

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
      throw new NotImplementedException();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
      KeyAttributeCollection formattedValues = existingValue as KeyAttributeCollection ?? new KeyAttributeCollection();

      JToken jToken = JToken.Load(reader);

      foreach (JToken keyValuePairToken in jToken) {
       throw new NotImplementedException();
      }

      return formattedValues;
    }

    public override bool CanConvert(Type objectType) {
      return objectType == KeyAttributeCollectionType;
    }
  }

  public class BooleanProperty : ManagedProperty<bool> {
    public BooleanProperty(bool value, string logicalName) : base(logicalName) {
      Value = value;
    }
  }
}