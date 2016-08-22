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
      QueryExpression queryExpression = new QueryExpression();
      queryExpression.ColumnSet = new ColumnSet("name", "createdon", "modifiedon", "customizationlevel", "pluginassemblyid", "sourcetype", "path", "version", "publickeytoken", "culture", "isolationmode", "description", "modifiedby");

      FilterExpression filterExpression1 = new FilterExpression();
      queryExpression.Criteria = filterExpression1;

      filterExpression1.AddCondition("name", ConditionOperator.NotLike, (object) "CompiledWorkflow%");
      FilterExpression filterExpression2 = filterExpression1.AddFilter(LogicalOperator.Or);
      filterExpression2.AddCondition("customizationlevel", ConditionOperator.Null);
      filterExpression2.AddCondition("customizationlevel", ConditionOperator.NotEqual, (object) 0);
      filterExpression2.AddCondition("name", ConditionOperator.In, "Microsoft.Crm.ObjectModel", (object) "Microsoft.Crm.ServiceBus");

      queryExpression.EntityName = "pluginassembly";

      IOrganizationService organizationService = CreateCrmServiceClient();
      EntityCollection response = organizationService.RetrieveMultiple(queryExpression);

      return response.Entities.Select(p => p.ToEntity<PluginAssembly>());
    }

    public virtual IEnumerable<PluginType> RetrievePluginSteps(Guid assemblyId) {
      QueryExpression queryExpression = new QueryExpression("plugintype");
      queryExpression.ColumnSet = new ColumnSet("plugintypeid", "friendlyname", "createdon", "modifiedon", "customizationlevel", "assemblyname", "typename", "pluginassemblyid", "isworkflowactivity", "name", "description", "workflowactivitygroupname", "ismanaged");
      queryExpression.Criteria = new FilterExpression();
      queryExpression.Criteria.AddCondition("typename", ConditionOperator.NotLike, (object) "Compiled.Workflow%");
      FilterExpression filterExpression = queryExpression.Criteria.AddFilter(LogicalOperator.Or);
      filterExpression.AddCondition("customizationlevel", ConditionOperator.Null);
      filterExpression.AddCondition("customizationlevel", ConditionOperator.NotEqual, (object) 0);
      filterExpression.AddCondition("typename", ConditionOperator.In, (object) "Microsoft.Crm.Extensibility.InternalOperationPlugin", (object) "Microsoft.Crm.Extensibility.V3CalloutProxyPlugin", (object) "Microsoft.Crm.ServiceBus.ServiceBusPlugin");

      FilterExpression filterExpression1 = new FilterExpression();
      ConditionExpression condition = new ConditionExpression("pluginassemblyid", ConditionOperator.In);
      condition.Values.Add(assemblyId);
      filterExpression1.AddCondition(condition);
      queryExpression.AddLink("pluginassembly", "pluginassemblyid", "pluginassemblyid").LinkCriteria = filterExpression1;

      IOrganizationService organizationService = CreateCrmServiceClient();
      EntityCollection response = organizationService.RetrieveMultiple(queryExpression);

      return response.Entities.Select(p => p.ToEntity<PluginType>());
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
        return response.EntityMetadata;
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
      return RetrieveEntityMetadata(entityLogicalName, EntityFilters.Attributes).Attributes;
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

    public virtual IEnumerable<Entity> RetrieveFilteredForms(string entityLogicalName) {
      List<Entity> result = new List<Entity>();

      using (OrganizationServiceProxy organizationService = CreateOrganizationService()) {
        WhoAmIResponse whoAmIResponse = (WhoAmIResponse) organizationService.Execute(new WhoAmIRequest());

        Func<FormTypeId, IEnumerable<Entity>> retrieveForms = formTypeId => RetrieveFilteredForms(entityLogicalName, whoAmIResponse.UserId, formTypeId, organizationService);

        retrieveForms(FormTypeId.Main).ForEach(result.Add);
        retrieveForms(FormTypeId.Mobile).ForEach(result.Add);
        retrieveForms(FormTypeId.Other).ForEach(result.Add);

        return result;
      }
    }

    private IEnumerable<Entity> RetrieveFilteredForms(string entityLogicalName, Guid userId, FormTypeId formTypeId, IOrganizationService organizationService) {
      RetrieveFilteredFormsResponse filteredFormsResponse = (RetrieveFilteredFormsResponse) organizationService.Execute(new RetrieveFilteredFormsRequest {
        FormType = new OptionSetValue((int) formTypeId),
        SystemUserId = userId,
        EntityLogicalName = entityLogicalName
      });

      if (filteredFormsResponse.SystemForms.Any()) {
        QueryExpression query = new QueryExpression("systemform") {
          ColumnSet = new ColumnSet(true)
        };
        query.Criteria.AddCondition("formid", ConditionOperator.In, filteredFormsResponse.SystemForms.Select(p => p.Id).Cast<object>().ToArray());
        EntityCollection formDetails = ((RetrieveMultipleResponse) organizationService.Execute(new RetrieveMultipleRequest {
          Query = query
        })).EntityCollection;

        return formDetails.Entities;
      }

      return new Entity[0];
    }

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