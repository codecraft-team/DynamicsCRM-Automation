param (
  [string]$TargetDir,
  [string]$TargetName,
  [string]$ProjectDir
)

Write-Host "`nRemoving Module artifacts..`n"

@("$TargetDir\$targetName.dll", "$TargetDir\$targetName.pdb") | Remove-Item -Force -Verbose;

Write-Host "`nModule artifacts removed.`n"

If (Get-Module -ListAvailable -Name PSSCriptAnalyzer) {
  $scripts = @("$($ProjectDir)DynamicsCRM-Automation.ps1");
  
  Try {
    $scripts | % { Write-Host ("Analyzing script: {0}" -f $_) };
    $report = $scripts | Invoke-ScriptAnalyzer -Severity Error;
    $report | Format-Table;
  }
  Catch {
    $ErrorMessage = $_.Exception.Message
    $FailedItem = $_.Exception.ItemName
    Write-Error "Failed to analyze scripts. Failed on $FailedItem. The error message was $ErrorMessage"
  }

  If ($report.Count -gt 0) {
    $Host.SetShouldExit(1);
  }
} 
Else {
  Write-Host "Please install PSSCriptAnalyzer in order to verify script quality.";
  $Host.SetShouldExit(1);
}