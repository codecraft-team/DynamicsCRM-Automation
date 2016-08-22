using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Tooling.Connector;

namespace PowerShellLibrary.Crm.CmdletProviders {

  public class DiscoveryServiceAdapter : IDiscoveryServiceAdapter {
    private readonly ClientCredentials _clientCredentials;
    private bool _isConnected;
    public string Url { get; }

    public DiscoveryServiceAdapter(string discoveryServiceUrl, string userName, string password) {
      Url = discoveryServiceUrl;
      _clientCredentials = new ClientCredentials {
        UserName = {
          UserName = userName,
          Password = password
        }
      };
    }

    public virtual IEnumerable<OrganizationDetail> DiscoverOrganizations() {
      Uri discoveryServiceUri = new Uri(Url);
      return CrmServiceClient.DiscoverOrganizations(discoveryServiceUri, null, _clientCredentials, null);
    }

    public bool IsDiscoverable() {
      try {
        HttpWebRequest request = WebRequest.Create($"{Url}?wsdl&sdkversion=8.1") as HttpWebRequest;
        request.Timeout = 4000;

        using (HttpWebResponse response = request.GetResponse() as HttpWebResponse) {
          return null != response && response.StatusCode == HttpStatusCode.OK;
        }
      }
      catch {
        return false;
      }
    }
  }
}