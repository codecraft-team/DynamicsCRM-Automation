using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class OrganizationDataCollector {
    public OrganizationData Collect(IOrganizationServiceAdapter organizationServiceAdapter) {

      List<EntityMetadata> entities = new List<EntityMetadata>();
      List<CrmForm> forms = new List<CrmForm>();
      string[] supportedEntities = new[] {
        "account",
        "contact"
      };

      List<EntityMetadata> retrieveAllEntityMetadata = organizationServiceAdapter.RetrieveAllEntityMetadata().ToList().Where(p => supportedEntities.Contains(p.LogicalName)).ToList();
      Console.WriteLine($"{retrieveAllEntityMetadata.Count} entities found.");
      int index = 0;
      Stopwatch stopwatch = Stopwatch.StartNew();

      foreach (EntityMetadata leanMetadata in retrieveAllEntityMetadata) {
        EntityMetadata entireEntityMetadata = organizationServiceAdapter.RetrieveEntityMetadata(leanMetadata.LogicalName, EntityFilters.All);
        Console.WriteLine($"{index++}/{retrieveAllEntityMetadata.Count} elapsed seconds {stopwatch.Elapsed.TotalSeconds:##.###}: {entireEntityMetadata.LogicalName}");

        IEnumerable<CrmForm> filteredForms = organizationServiceAdapter.RetrieveFilteredForms(leanMetadata);
        filteredForms.ToList().ForEach(forms.Add);

        entities.Add(entireEntityMetadata);
      }

      return new OrganizationData {
        EntityMetadatas = entities,
        Forms = forms
      };
    }
  }
}