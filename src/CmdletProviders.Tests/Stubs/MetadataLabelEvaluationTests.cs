using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Tooling.Connector;
using PowerShellLibrary.Crm.CmdletProviders.Extensions;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Stubs {
  [TestClass]
  public class MetadataLabelEvaluationTests {
    [TestMethod, TestCategory(TestCategories.Integrated)]
    public void RetrieveEntityMetadata() {
      string connectionString = "Url=https://crm-packaging.crm4.dynamics.com; Username=matthias.wicke@geberit.com; Password=wic365mat; authtype=Office365";
      //string connectionString = "Url=http://192.168.1.216:5555/Playground; Domain=development; Username=administrator; Password=KkvW.WzIdb!; authtype=AD";

      OrganizationServiceAdapter adapter = new OrganizationServiceAdapter("crm-packaging", connectionString);

      Predicate<EntityMetadata> hasEntityDisplayName = entityMetadata => entityMetadata.DisplayName != null && entityMetadata.DisplayName.UserLocalizedLabel != null && entityMetadata.DisplayName.UserLocalizedLabel.Label != null;
      EntityMetadata[] entities = adapter.RetrieveAllEntityMetadata().ToArray();
      EntityMetadata[] entitiesWithoutDisplayName = entities.Where(e => !hasEntityDisplayName(e)).ToArray();

      Assert.AreEqual(0, entitiesWithoutDisplayName.Length);

      //EntityMetadata entityMetadata = adapter.RetrieveEntityMetadata("account", EntityFilters.All);

      //Predicate<AttributeMetadata> hasDisplayName = attribute => attribute.DisplayName != null && attribute.DisplayName.UserLocalizedLabel.Label != null;

      ////List<AttributeMetadata> attributesWithoutLabelEntity = entityMetadata.Attributes.Where(attribute => hasDisplayName(attribute)).ToList();

      //List<AttributeMetadata> attributesMetadatas = adapter.RetrieveAttributes("account").ToList();
      //List<AttributeMetadata> attributesWithoutLabelAttribute = attributesMetadatas.Where(attribute => !hasDisplayName(attribute)).ToList();
      //IOrganizationService organizationService = new CrmServiceClient(connectionString);

      //ExecuteMultipleRequest executeMultiple = new ExecuteMultipleRequest {
      //  Requests = new OrganizationRequestCollection(),
      //  Settings = new ExecuteMultipleSettings {
      //    ContinueOnError = true,
      //    ReturnResponses = true
      //  }
      //};

      //foreach (AttributeMetadata attributeMetadata in attributesWithoutLabelAttribute) {
      //  executeMultiple.Requests.Add(new RetrieveAttributeRequest {
      //                   LogicalName = attributeMetadata.LogicalName,
      //                   EntityLogicalName = "account"
      //                 });
      //}

      //ExecuteMultipleResponse executeMultipleResponse = (ExecuteMultipleResponse) organizationService.Execute(executeMultiple);

      //AttributeMetadata[] stillWithoutLabel = executeMultipleResponse.Responses.Select(r => ((RetrieveAttributeResponse)r.Response).AttributeMetadata).Where(attributeMetadata => !hasDisplayName(attributeMetadata)).ToArray();
      //stillWithoutLabel.Select(a => a.LogicalName).ForEach(a => Console.WriteLine(a));

      //Assert.AreEqual(0, stillWithoutLabel.Length);
    }
  }
}