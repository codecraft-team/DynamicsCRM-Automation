namespace PowerShellLibrary.Crm.CmdletProviders.Tests {
  public class DataSourceConfiguration {
    public string OrganizationFriendlyName { get; private set; }

    public string[] EntityLogicalNames { get; private set; }

    public string[] Forms { get; private set; }

    public static readonly DataSourceConfiguration Playground = new DataSourceConfiguration {
      OrganizationFriendlyName = "Playground",
      EntityLogicalNames = new[] {
        "account",
        "contact"
      },
      Forms = new[] {
        "systemform"
      }
    };

    public static readonly DataSourceConfiguration NotConfiguredOraganization = new DataSourceConfiguration {
      OrganizationFriendlyName = "NotConfiguredOraganization",
      EntityLogicalNames = new[] {
        "account",
        "contact"
      },
      Forms = new[] {
        "systemform"
      }
    };
  }
}