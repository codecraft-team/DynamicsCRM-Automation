using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders {
  public class OrganizationServiceAdapter : IOrganizationServiceAdapter {
    private readonly string _connectionString;

    public string OrganizationFriendlyName { get; private set; }

    public OrganizationServiceAdapter(string organizationFriendlyName, string connectionString) {
      Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(organizationFriendlyName), "OrganizationFriendlyName");
      Contract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(connectionString), "connectionString");

      _connectionString = connectionString;
      OrganizationFriendlyName = organizationFriendlyName;
    }

    public string GetUrl() {
      return _connectionString.Split(';').First(segment => segment.Split('=').First().Equals("Url", StringComparison.OrdinalIgnoreCase)).Split('=').Last();
    }

    public void PublishEntity(string logicalName) {
      string publisXml = $@"<importexportxml>
                             <entities>
                              <entity>{logicalName}</entity>
                             </entities>
                            </importexportxml>";

      using (OrganizationServiceProxy organizationService = CreateOrganizationService()) {
        organizationService.Execute(new PublishXmlRequest {
          ParameterXml = publisXml
        });
      }
    }

    public virtual IEnumerable<PluginAssembly> RetrievePluginAssemblies() {
      const string pluginsQuery = @"<fetch distinct=""false"" no-lock=""true"" mapping=""logical"" page=""1"" count=""250"" returntotalrecordcount=""true"">
        <entity name=""pluginassembly"">
          <attribute name=""name"" />
          <attribute name=""version"" />
          <attribute name=""culture"" />
          <attribute name=""publickeytoken"" />
          <attribute name=""isolationmode"" />
          <attribute name=""createdon"" />
          <attribute name=""modifiedon"" />
          <attribute name=""modifiedby"" />
          <attribute name=""description"" />
          <filter type=""and"">
            <condition attribute=""ishidden"" operator=""ne"" value=""1"" />
          </filter>
          <order attribute=""name"" descending=""false"" />
        </entity>
      </fetch>";

      return RetrieveMultiple<PluginAssembly>(pluginsQuery);
    }

    public virtual IEnumerable<PluginType> RetrievePluginTypes(Guid assemblyId) {
      string pluginTypesFetch = $@"<fetch distinct=""false"" no-lock=""true"" mapping=""logical"" page=""1"" count=""250"" returntotalrecordcount=""true"">
        <entity name=""plugintype"">
          <attribute name=""friendlyname"" />
          <attribute name=""typename"" />
          <attribute name=""isworkflowactivity"" />
          <attribute name=""createdon"" />
          <attribute name=""modifiedon"" />
          <attribute name=""description"" />
          <filter type=""and"">
            <condition attribute=""pluginassemblyid"" operator=""eq"" value=""{assemblyId}"" />
          </filter>
          <order attribute=""friendlyname"" descending=""false"" />
        </entity>
      </fetch>";

      return RetrieveMultiple<PluginType>(pluginTypesFetch);
    }

    public virtual IEnumerable<SdkMessageProcessingStep> RetrievePluginSteps() {
      const string pluginStepsFetch = @"<fetch distinct=""false"" no-lock=""true"" mapping=""logical"" page=""1"" count=""2500"" returntotalrecordcount=""true"">
        <entity name=""sdkmessageprocessingstep"">
          <attribute name=""statuscode"" />
          <attribute name=""name"" />
          <attribute name=""sdkmessageid"" />
          <attribute name=""eventhandler"" />
          <attribute name=""rank"" />
          <attribute name=""stage"" />
          <attribute name=""mode"" />
          <attribute name=""statecode"" />
          <attribute name=""ismanaged"" />
          <attribute name=""iscustomizable"" />
          <attribute name=""supporteddeployment"" />
          <attribute name=""description"" />
          <order attribute=""name"" descending=""false"" />
          <filter type=""and"">
            <condition attribute=""ishidden"" operator=""ne"" value=""1"" />
            <filter type=""or"">
              <condition attribute=""iscustomizable"" operator=""eq"" value=""1"" />
              <condition attribute=""ismanaged"" operator=""eq"" value=""0"" />
            </filter>
          </filter>
          <link-entity name=""sdkmessagefilter"" to=""sdkmessagefilterid"" from=""sdkmessagefilterid"" link-type=""outer"" alias=""a1"">
            <attribute name=""primaryobjecttypecode"" />
          </link-entity>
          <link-entity name=""sdkmessage"" to=""sdkmessageid"" from=""sdkmessageid"" link-type=""outer"" alias=""a2"">
            <attribute name=""name"" />
          </link-entity>
        </entity>
      </fetch>";

      return RetrieveMultiple<SdkMessageProcessingStep>(pluginStepsFetch);
    }

    private IEnumerable<TEntity> RetrieveMultiple<TEntity>(string fetchXml) where TEntity : Entity {
      IOrganizationService organizationService = CreateCrmServiceClient();
      EntityCollection response = organizationService.RetrieveMultiple(new FetchExpression(fetchXml));

      return response.Entities.Select(p => p.ToEntity<TEntity>());
    }

    private CrmServiceClient CreateCrmServiceClient() {
      Logger.WriteDebug($"{OrganizationFriendlyName} connectionString: {_connectionString}");

      return new CrmServiceClient(_connectionString);
    }

    private OrganizationServiceProxy CreateOrganizationService() {
      Contract.Ensures(Contract.Result<OrganizationServiceProxy>() != null);

      return CreateCrmServiceClient().OrganizationServiceProxy;
    }

    public virtual IEnumerable<EntityMetadata> RetrieveAllEntityMetadata() {
      using (OrganizationServiceProxy organizationService = CreateOrganizationService()) {
        RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse) organizationService.Execute(new RetrieveAllEntitiesRequest {
          EntityFilters = EntityFilters.Entity
        });
        return response.EntityMetadata.Where(e => (e.IsIntersect == null || !e.IsIntersect.Value) && (e.IsPrivate == null || !e.IsPrivate.Value) && e.LogicalName != "principalobjectaccess");
      }
    }

    public virtual EntityMetadata RetrieveEntityMetadata(string entityLogicalName, EntityFilters entityFilters) {
      using (OrganizationServiceProxy organizationService = CreateOrganizationService()) {
        RetrieveEntityResponse response = (RetrieveEntityResponse) organizationService.Execute(new RetrieveEntityRequest {
          LogicalName = entityLogicalName,
          EntityFilters = entityFilters
        });

        return response.EntityMetadata;
      }
    }

    protected virtual void RefreshEntityMetadata(string entityLogicalName, EntityFilters entityFilters) {
    }

    public virtual IEnumerable<AttributeMetadata> RetrieveAttributes(string entityLogicalName) {
      AttributeMetadata[] attributes = RetrieveEntityMetadata(entityLogicalName, EntityFilters.Attributes).Attributes;
      return attributes.Where(attribute => attribute.AttributeOf == null && attribute.LogicalName != "isprivate");
    }

    private AttributeMetadata[] RetrieveMissingLabels(AttributeMetadata[] attributes) {
      AttributeMetadata[] attributesWithoutLabel = attributes.Where(a => a.DisplayName.UserLocalizedLabel == null).ToArray();
      if (!attributesWithoutLabel.Any()) {
        return attributes;
      }

      IEnumerable<RetrieveAttributeRequest> requests = attributesWithoutLabel.Select(attributeMetadata => new RetrieveAttributeRequest {
        LogicalName = attributeMetadata.LogicalName,
        EntityLogicalName = "account"
      });

      ExecuteMultipleRequest executeMultiple = new ExecuteMultipleRequest {
        Requests = new OrganizationRequestCollection(),
        Settings = new ExecuteMultipleSettings {
          ContinueOnError = true,
          ReturnResponses = true
        }
      };
      executeMultiple.Requests.AddRange(requests);

      IOrganizationService organizationService = CreateCrmServiceClient();
      ExecuteMultipleResponse executeMultipleResponse = (ExecuteMultipleResponse)organizationService.Execute(executeMultiple);
      IEnumerable<RetrieveAttributeResponse> attributeResponses = executeMultipleResponse.Responses.Select(response => response.Response as RetrieveAttributeResponse).Where(response => null != response);

      Dictionary<Guid, AttributeMetadata> attributeMetadataDictionary = attributes.ToDictionary(a => a.MetadataId.GetValueOrDefault(), a => a);
      foreach (RetrieveAttributeResponse retrieveAttributeResponse in attributeResponses) {
        Guid attributeMetadataId = retrieveAttributeResponse.AttributeMetadata.MetadataId.GetValueOrDefault();
        attributeMetadataDictionary[attributeMetadataId].DisplayName = retrieveAttributeResponse.AttributeMetadata.DisplayName;
        attributeMetadataDictionary[attributeMetadataId].Description = retrieveAttributeResponse.AttributeMetadata.Description;
      }

      return attributes;
    }

    public IEnumerable<OneToManyRelationshipMetadata> RetrieveOneToManyRelationships(string entityLogicalName) {
      EntityMetadata entityMetadata = RetrieveEntityMetadata(entityLogicalName, EntityFilters.Relationships);

      return entityMetadata.OneToManyRelationships;
    }

    public IEnumerable<OneToManyRelationshipMetadata> RetrieveManyToOneRelationships(string entityLogicalName) {
      EntityMetadata entityMetadata = RetrieveEntityMetadata(entityLogicalName, EntityFilters.Relationships);

      return entityMetadata.ManyToOneRelationships;
    }

    public IEnumerable<ManyToManyRelationshipMetadata> RetrieveManyToManyRelationships(string entityLogicalName) {
      EntityMetadata entityMetadata = RetrieveEntityMetadata(entityLogicalName, EntityFilters.Relationships);

      return entityMetadata.ManyToManyRelationships;
    }

    public void DeleteAttribute(string entityLogicalName, string attributeLogicalName) {
      using (OrganizationServiceProxy organizationService = CreateOrganizationService()) {
        DeleteAttributeRequest deleteAttributeRequest = new DeleteAttributeRequest {
          LogicalName = attributeLogicalName,
          EntityLogicalName = entityLogicalName
        };

        organizationService.Execute(deleteAttributeRequest);
        RefreshEntityMetadata(entityLogicalName, EntityFilters.Attributes);
      }
    }

    public RetrieveDependenciesForDeleteResponse RetrieveDependencies(ComponentType componentType, Guid objectId) {
      using (OrganizationServiceProxy organizationService = CreateOrganizationService()) {
        return (RetrieveDependenciesForDeleteResponse) organizationService.Execute(new RetrieveDependenciesForDeleteRequest {
          ComponentType = (int) componentType,
          ObjectId = objectId
        });
      }
    }

    public void DeleteRelationship(string entityLogicalName, string relationshipSchemaName) {
      throw new NotImplementedException();
    }

    public virtual IEnumerable<CrmForm> RetrieveFilteredForms(EntityMetadata entityMetadata) {
      string formsFetch = $@"<fetch distinct=""true"" no-lock=""true"" mapping=""logical"" page=""1"" count=""250"" returntotalrecordcount=""true"">
        <entity name=""systemform"">
          <attribute name=""formid"" />
          <attribute name=""name"" />
          <attribute name=""formactivationstate"" />
          <attribute name=""ismanaged"" />
          <attribute name=""iscustomizable"" />
          <attribute name=""introducedversion"" />
          <attribute name=""description"" />
          <attribute name=""type"" />
          <attribute name=""formxml"" />
          <filter type=""and"">
            <condition attribute=""objecttypecode"" operator=""eq"" value=""{entityMetadata.ObjectTypeCode.GetValueOrDefault()}"" />
            <filter type=""and"">
              <condition attribute=""type"" operator=""in"">
                <value>1</value>
                <value>2</value>
                <value>4</value>
                <value>5</value>
                <value>6</value>
                <value>7</value>
                <value>11</value>
                <value>12</value>
              </condition>
            </filter>
            <filter type=""and"">
              <condition attribute=""formactivationstate"" operator=""eq"" value=""1"" />
            </filter>
          </filter>
          <order attribute=""name"" descending=""false"" />
        </entity>
      </fetch>";

      return RetrieveMultiple<CrmForm>(formsFetch);
    }

    //private IEnumerable<Entity> RetrieveFilteredForms(string entityLogicalName, Guid userId, FormTypeId formTypeId, IOrganizationService organizationService) {
    //  RetrieveFilteredFormsResponse filteredFormsResponse = (RetrieveFilteredFormsResponse) organizationService.Execute(new RetrieveFilteredFormsRequest {
    //    FormType = new OptionSetValue((int) formTypeId),
    //    SystemUserId = userId,
    //    EntityLogicalName = entityLogicalName
    //  });

    //  if (filteredFormsResponse.SystemForms.Any()) {
    //    QueryExpression query = new QueryExpression("systemform") {
    //      ColumnSet = new ColumnSet(true)
    //    };
    //    query.Criteria.AddCondition("formid", ConditionOperator.In, filteredFormsResponse.SystemForms.Select(p => p.Id).Cast<object>().ToArray());
    //    EntityCollection formDetails = ((RetrieveMultipleResponse) organizationService.Execute(new RetrieveMultipleRequest {
    //      Query = query
    //    })).EntityCollection;

    //    return formDetails.Entities;
    //  }

    //  return new Entity[0];
    //}

    public OrganizationServiceContext CreateContext() {
      return new OrganizationServiceContext(CreateOrganizationService());
    }

    public void Update(Entity entity) {
      using (OrganizationServiceProxy organizationService = CreateOrganizationService()) {
        organizationService.Update(entity);
      }
    }
  }
}