using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Metadata;
using PowerShellLibrary.Crm.CmdletProviders.Fakes;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class ControlsNodeTests {
    const string DriveName = "CRMLocal";
    const string OrganizationName = "crm-packaging";

    public PowerShell PowerShell { get; set; }
    public CrmForm AccountForm { get; set; }

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

      EntityMetadata accountMetadata = new EntityMetadata {
        MetadataId = Guid.NewGuid(),
        LogicalName = "account",
        DisplayName = new Label(new LocalizedLabel("Account", 1033), new LocalizedLabel[0])
      };
      AccountForm = new CrmForm(Guid.NewGuid()) {
        Name = "Account",
        ObjectTypeCode = "account"
      };
      List<CrmForm> accountForms = new List<CrmForm> {
        new CrmForm(Guid.NewGuid()) {
          Name = "Information",
          ObjectTypeCode = "account"
        },
        AccountForm
      };

      List<IOrganizationServiceAdapter> organizationServiceAdapters = new List<IOrganizationServiceAdapter> {
        new OrganizationServiceAdapterMock {
          OrganizationFriendlyNameGet = () => OrganizationName,
          RetrieveAllEntityMetadata = () => new List<EntityMetadata> {
            accountMetadata
          },
          RetrieveFilteredFormsEntityMetadata = entityMetadata => {
            if (entityMetadata.LogicalName != "account") {
              throw new NotImplementedException();
            }
            return accountForms;
          }
        }
      };

      PowerShell = PowerShell.Create(RunspaceMode.NewRunspace);
      PowerShell.NewDrive(DriveName, discoveryServiceAdapter, organizationServiceAdapters);

      PowerShell.AddScript($@"Set-Location {DriveName}:\{OrganizationName}\{EntitiesNode.NodeName}\account\{FormsNode.NodeName}\{AccountForm.Name}\Controls;");
    }

    [TestMethod]
    public void AccountFormHasControls() {
      const string expectedControl = "new_name";
      AccountForm.FormXml = CreateFormXml(expectedControl);

      Collection<CrmFormControl> actualControls = PowerShell.AddScript("Get-ChildItem;").Invoke<CrmFormControl>();

      Assert.IsFalse(PowerShell.HadErrors);
      Assert.AreEqual(1, actualControls.Count);
      Assert.AreEqual(expectedControl, actualControls[0].DataFieldName);
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