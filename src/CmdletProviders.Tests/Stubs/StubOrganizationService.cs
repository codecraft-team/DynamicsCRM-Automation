using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class StubOrganizationService : IOrganizationService {

    public Guid Create(Entity entity) {
      throw new NotImplementedException();
    }

    public Entity Retrieve(string entityName, Guid id, ColumnSet columnSet) {
      throw new NotImplementedException();
    }

    public void Update(Entity entity) {
      throw new NotImplementedException();
    }

    public void Delete(string entityName, Guid id) {
      throw new NotImplementedException();
    }

    public OrganizationResponse Execute(OrganizationRequest request) {
      throw new NotImplementedException();
    }

    public void Associate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities) {
      throw new NotImplementedException();
    }

    public void Disassociate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities) {
      throw new NotImplementedException();
    }

    public EntityCollection RetrieveMultiple(QueryBase query) {
      throw new NotImplementedException();
    }
  }
}