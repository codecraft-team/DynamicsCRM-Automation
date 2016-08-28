param (
  [string]$Config,
  [string]$TargetDir
)

Function Remove-Artifact {
  param (
    [string]$Name
  )

  Remove-Item -Force -Path ("{0}{1}" -f $TargetDir,$Name) -Recurse;
}

If($Config -eq "Release") {
  Remove-Artifact "Newtonsoft.Json.xml";
  Remove-Artifact "Newtonsoft.Json.Schema.xml";
  Remove-Artifact "PowerShellLibrary.Crm.CmdletProviders.pdb";
  Remove-Artifact "CodeContracts";
  Remove-Artifact "PowerShellLibrary.Crm.CmdletProviders.dll.config";
}