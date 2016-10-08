using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class AttributeMetadataNodeTests {
    const string DriveName = "CRMLocal";
    const string OrganizationName = "crm-packaging";

    public PowerShell PowerShell { get; set; }

    public EntityMetadata AccountMetadata { get; set; }
    public List<CrmForm> AccountForms { get; set; }
    public Dictionary<Guid, List<Dependency>> AttriubteDependencies { get; set; }

    [TestInitialize]
    public void TestInitialize() {
      IDiscoveryServiceAdapter discoveryServiceAdapter = new StubIDiscoveryServiceAdapter {
        DiscoverOrganizations = () => new List<OrganizationDetail> {
          new OrganizationDetail {
            FriendlyName = OrganizationName
          }
        },
        IsDiscoverable = () => true
      };

      AccountMetadata = new EntityMetadata {
        MetadataId = Guid.NewGuid(),
        LogicalName = "account",
        DisplayName = new Label(new LocalizedLabel("Account", 1033), new LocalizedLabel[0])
      };
      AccountForms = new List<CrmForm>();
      AttriubteDependencies = new Dictionary<Guid, List<Dependency>>();

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new OrganizationServiceAdapterMock {
          OrganizationFriendlyNameGet = () => OrganizationName,
          RetrieveAllEntityMetadata = () => new List<EntityMetadata> {
            AccountMetadata
          },
          RetrieveDependenciesComponentTypeGuid = (componentType, componentId) => componentType == ComponentType.Attribute ? AttriubteDependencies[componentId] : null,
          RetrieveFilteredFormsEntityMetadata = entityMetadata => {
            if (entityMetadata.LogicalName != "account") {
              throw new NotImplementedException();
            }
            return AccountForms;
          }
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      PowerShell.AddScript($@"Set-Location {DriveName}:\{OrganizationName}\{EntitiesNode.NodeName}\account\{FieldsNode.NodeName};");
    }

    [TestMethod]
    public void RemoveItemRemovesAttributeWithoutDependency() {
      const string attributeToRemove = "new_name";
      string[] dependentForms = new string[0];
      Arrange(attributeToRemove, dependentForms);

      Collection<PSObject> childItems = PowerShell.AddScript($"Remove-Item -Path {attributeToRemove};").Invoke();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(0, childItems.Count);
      Assert.IsFalse(AccountMetadata.Attributes.Any(a => a.LogicalName == attributeToRemove));
    }

    [TestMethod]
    public void RemoveItemConflictsDisplayedAsWarning() {
      const string attributeToRemove = "new_field1";
      string[] dependentForms = {
        "Information"
      };
      Arrange(attributeToRemove, dependentForms);

      PowerShell.AddScript($"Remove-Item -Path {attributeToRemove};").Invoke();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(2, PowerShell.Streams.Warning.Count, "Expecting 1 general warning for remove not possible, and 1 warning for the form dependency.");
      Assert.AreEqual($"The {attributeToRemove} component cannot be deleted because it is referenced by 1 other components.{Environment.NewLine}", PowerShell.Streams.Warning[0].Message);
      Assert.AreEqual($@"Dependency found under path: \{OrganizationName}\Entities\account\Forms\{dependentForms[0]}", PowerShell.Streams.Warning[1].Message);
    }

    [TestMethod]
    public void WhenRemoveConflictsAttributeNotDeleted() {
      const string attributeOnFormBody = "new_customfield1";
      string[] dependentForms = {
        "Information"
      };
      Arrange(attributeOnFormBody, dependentForms);

      Collection<PSObject> childItems = PowerShell.AddScript($"Remove-Item -Path {attributeOnFormBody};").Invoke();

      Assert.AreEqual(0, childItems.Count);
      Assert.IsTrue(AccountMetadata.Attributes.Any(a => a.LogicalName == attributeOnFormBody));
    }

    [TestMethod]
    public void RemoveItemForceResolvesConflicts() {
      const string attributeToRemove = "new_customfield1";
      string[] dependentForms = {
        "Information"
      };
      Arrange(attributeToRemove, dependentForms);

      int dependencyFoundWarningCount = 4;
      int dependencyCountWarning = dependentForms.Length;

      Collection<PSObject> childItems = PowerShell.AddScript($"Remove-Item -Path {attributeToRemove} -Force;").Invoke();
      
      PowerShell.WriteErrorsToConsole();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(dependencyFoundWarningCount + dependencyCountWarning, PowerShell.Streams.Warning.Count);
      Assert.AreEqual(0, childItems.Count);
      Assert.IsTrue(AccountForms.First(f => f.Name == dependentForms[0]).GetControls().All(a => a.DataFieldName != attributeToRemove), "The control was not removed from the form.");
      Assert.IsFalse(AccountMetadata.Attributes.Any(a => a.LogicalName == attributeToRemove), "The field was not removed from entity customizations.");
    }

    [TestMethod]
    public void ManagedFieldsCannotBeDeleted() {
      AttributeMetadata managedAttribute = Arrange("name");
      managedAttribute.SetIsManaged(true);
      string expectedError = $"Cannot delete attribute: {managedAttribute.LogicalName} from Entity: {AccountMetadata.DisplayName.UserLocalizedLabel.Label} since the attribute is not a custom field.";

      Collection<PSObject> childItems = PowerShell.AddScript($"Remove-Item -Path {managedAttribute.LogicalName};").Invoke();

      Assert.AreEqual(0, childItems.Count);
      Assert.AreEqual(0, PowerShell.Streams.Warning.Count);
      Assert.AreEqual(1, PowerShell.Streams.Error.Count);
      Assert.AreEqual(expectedError, PowerShell.Streams.Error[0].Exception.Message);
    }

    private AttributeMetadata Arrange(string attributeLogicalName, params string[] dependentFormNames) {
      AttributeMetadata attriubteToRemove = new AttributeMetadata {
        MetadataId = Guid.NewGuid(),
        LogicalName = attributeLogicalName
      };
      AccountMetadata.SetAttributes(attriubteToRemove);

      if (!dependentFormNames.Any()) {
        return attriubteToRemove;
      }

      foreach (string dependentFormName in dependentFormNames) {
        CrmForm form = new CrmForm(Guid.NewGuid()) {
          Name = dependentFormName,
          Id = Guid.NewGuid(),
          ObjectTypeCode = AccountMetadata.LogicalName,
          FormXml = CreateFormXml(attriubteToRemove.LogicalName)
        };
        AccountForms.Add(form);

        AttriubteDependencies.Add(attriubteToRemove.MetadataId.GetValueOrDefault(), new List<Dependency> {
          new Dependency {
            DependentComponentObjectId = form.Id,
            DependentComponentType = new OptionSetValue((int) ComponentType.SystemForm)
          }
        });
      }

      return attriubteToRemove;
    }

    private static string CreateFormXml(string attributeLogicalName) {
      return $@"<form showImage="" true"">
        <ancestor id=""{{8448b78f-8f42-454e-8e2a-f8196b0419af}}"" />
        <hiddencontrols>
          <data id="" address1_addressid"" datafieldname="" address1_addressid"" classid=""{{5546E6CD-394C-4bee-94A8-4425E17EF6C6}}"" />
          <data id="" address2_addressid"" datafieldname="" address2_addressid"" classid=""{{5546E6CD-394C-4bee-94A8-4425E17EF6C6}}"" />
        </hiddencontrols>
        <tabs>
          <tab name="" SUMMARY_TAB"" id=""{{3b0b63a9-d379-689a-0ec3-e71eb4c6a841}}"" IsUserDefined=""0"" showlabel="" true"" expanded="" true"" locklevel=""0"">
            <labels>
              <label description="" Summary"" languagecode=""1033"" />
            </labels>
            <columns>
              <column width=""100%"">
                <sections>
                  <section name=""ACCOUNT_INFORMATION"" showlabel="" true"" showbar="" false"" id=""{{0eb92e6c-bcb8-0d52-a188-d81543ddb7cd}}"" IsUserDefined=""0"" layout="" varwidth"" columns=""1"" labelwidth=""115"" celllabelposition=""Left"">
                    <labels>
                      <label description=""ACCOUNT INFORMATION"" languagecode=""1033"" />
                    </labels>
                    <rows>
                      <row>
                        <cell id=""{{b0e82a7e-5683-d90c-308a-0d779377ea8a}}"" showlabel=""true"">
                          <labels>
                            <label description=""Account Name"" languagecode=""1033"" />
                          </labels>
                          <control id=""{attributeLogicalName}"" classid=""{{4273EDBD-AC1D-40d3-9FB2-095C621B552D}}"" datafieldname=""{attributeLogicalName}"" disabled=""false"" />
                        </cell>
                      </row>
                    </rows>
                  </section>
                </sections>
              </column>
            </columns>
          </tab>
        </tabs>
        <controlDescriptions />
        <DisplayConditions FallbackForm=""true"" Order=""2"">
          <Everyone />
        </DisplayConditions>
      </form>";
    }
  }
}