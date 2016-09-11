$env:PSModulePath = "$env:PSModulePath;{0}" -f (Split-Path $PSScriptRoot -Parent);

Import-Module "DynamicsCRM-Automation";

Initialize-CrmPsDrive -IgnoreUntrustedSSL;