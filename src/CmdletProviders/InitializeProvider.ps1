param(
  [string]$ConnectionsConfig
)
$env:PSModulePath = "$env:PSModulePath;{0}" -f [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot "\..\..\artifacts"));

Import-Module .\DynamicsCRM-Automation.psd1;

Initialize-CrmPSDrive -IgnoreUntrustedSSL -ConnectionsConfig $connectionsConfig;