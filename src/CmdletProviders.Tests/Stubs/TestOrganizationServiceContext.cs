using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Stubs {
  public class TestOrganizationServiceContext : OrganizationServiceContext {
    public Dictionary<string, IQueryable<Entity>> Entities { get; set; }

    public TestOrganizationServiceContext(IOrganizationService service) : base(service) {
      Entities = new Dictionary<string, IQueryable<Entity>>();
    }

    protected override IQueryable<TEntity> CreateQuery<TEntity>(IQueryProvider provider, string entityLogicalName) {
      return (IQueryable<TEntity>) Entities[entityLogicalName];
    }
  }
}