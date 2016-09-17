Function New-CrmPSDrive {
  Param (
   [Parameter(Mandatory=$True)]
   [string]$Name,
   [Parameter(Mandatory=$True)]
   [PowerShellLibrary.Crm.CmdletProviders.IDiscoveryServiceAdapter]$DiscoveryServiceAdapter,
   [Parameter(Mandatory=$True)]
   [PowerShellLibrary.Crm.CmdletProviders.IOrganizationServiceAdapter[]]$OrganizationServiceAdapters
  )

  New-PSDrive -PSProvider CRM -Name $Name -Root "" -DiscoveryServiceAdapter $DiscoveryServiceAdapter -OrganizationServiceAdapters @($OrganizationServiceAdapters) -Scope Global;
}

Function New-CrmDiscoveryServiceAdapter {
  Param (
   [Parameter(Mandatory=$True)]
   [string]$DeploymentUrl,
   [Parameter(Mandatory=$True)]
   [string]$Name,
   [Parameter(Mandatory=$True)]
   [string]$Key
  )

  return New-Object -TypeName "PowerShellLibrary.Crm.CmdletProviders.CachedDiscoveryServiceAdapter" -ArgumentList @("$DeploymentUrl/XRMServices/2011/Discovery.svc", $Name, $Key);
}

Function New-CrmOrganizationServiceAdapter {
  Param (
   [Parameter(Mandatory=$True)]
   [string]$OrganizationName,
   [Parameter(Mandatory=$True)]
   [string]$ConnectionString
  )

  return New-Object -TypeName "PowerShellLibrary.Crm.CmdletProviders.CachedOrganizationServiceAdapter" -ArgumentList @($OrganizationName, $ConnectionString);
}

Function Show-CrmContext {
  $host.ui.RawUI.WindowTitle = "CRM PSDrive";
  
  function global:prompt {
    Write-Host "[CRM " -NoNewline;
    $drive = Get-Location | % { $_.Drive } | select -First 1;
    $drivePrompt = $drive.Prompt;
    
    If ($drive -ne $null -and $drive.IsDiscoverable -eq $false) {
      Write-Host "Non-discoverable" -NoNewline -ForegroundColor Red;
    }
    ElseIf ($drivePrompt -eq $null) {
      Write-Host "Not connected" -NoNewline -ForegroundColor Red;
    }
    Else {
      Write-Host "$drivePrompt" -NoNewline -ForegroundColor Green;
    }

    $host.ui.RawUI.WindowTitle = "CRM PSDrive $drivePrompt";

    return "] PS $pwd> ";
  }
}

Function Validate-Json {
  Param (
    [Parameter(Mandatory=$True)]
    [string]$Json,
    [Parameter(Mandatory=$True)]
    [string]$JsonSchema
  )
  $newtonsoftPath = Join-Path -Path $PSScriptRoot -ChildPath 'Newtonsoft.Json.dll';
  $newtonsoftSchemaPath = Join-Path -Path $PSScriptRoot -ChildPath 'Newtonsoft.Json.Schema.dll';

  @($newtonsoftPath,$newtonsoftSchemaPath) | % { Add-Type -Path $_  };

  $schema = [Newtonsoft.Json.Schema.JSchema]::Parse($JsonSchema);
  $reader = New-Object -TypeName Newtonsoft.Json.JsonTextReader -ArgumentList @((New-Object -TypeName System.IO.StringReader -ArgumentList @($Json)));

  $validatingReader = New-Object -TypeName Newtonsoft.Json.Schema.JSchemaValidatingReader -ArgumentList @($reader);
  $validatingReader.Schema = $schema;

  $serializer = New-Object -TypeName Newtonsoft.Json.JsonSerializer;
  $serializer.Deserialize($validatingReader) | Out-Null;
}

Function Get-CrmPSDriveConfig {
  return "{0}\Connections.json" -f (Split-Path -Parent (gmo -l DynamicsCRM-Automation).Path);
}

Function Initialize-CrmPSDrive {
  Param (
   [Parameter(Mandatory=$False)]
   [string]$ConnectionsConfig = (Get-CrmPSDriveConfig),
   [Parameter(Mandatory=$false)]
   [Switch]$IgnoreUntrustedSSL
  )

  [string]$connectionsJson = Get-Content $ConnectionsConfig;
  [string]$connectionsJsonSchema = Get-Content $PSScriptRoot"\Connections.Schema.json";

  Validate-Json $connectionsJson $connectionsJsonSchema;

  If($IgnoreUntrustedSSL) {
    [System.Net.ServicePointManager]::ServerCertificateValidationCallback = { $true; };
    Write-Warning "Untrusted SSL Certificate ignored.";
  }

  $connections = $connectionsJson | ConvertFrom-Json;
  foreach($connection in $connections) {
    $discoveryAdapter = New-CrmDiscoveryServiceAdapter -DeploymentUrl $connection.DiscoveryUrl -Name $connection.UserName -Key $connection.Password;  
  
    $organizationArray = [System.Collections.ArrayList]@();
    foreach($organization in $connection.Organizations) {
      $organizationAdapter = New-CrmOrganizationServiceAdapter -OrganizationName $organization.Name -ConnectionString $organization.ConnectionString;
      $organizationArray.Add($organizationAdapter) | Out-Null;
    }

    New-CrmPSDrive -Name $connection.Name -DiscoveryServiceAdapter $discoveryAdapter -OrganizationServiceAdapters $organizationArray;
  }

  Show-CrmContext;
}