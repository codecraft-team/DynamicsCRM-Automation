param (
  [string]$TargetDir,
  [string]$TargetName,
  [string]$ProjectDir
)

Write-Host "`nRemoving Module artifacts..`n"

@("$TargetDir\$targetName.dll", "$TargetDir\$targetName.pdb") | Remove-Item -Force -Verbose;

Write-Host "`nModule artifacts removed.`n"

If (Get-Module -ListAvailable -Name PSSCriptAnalyzer) {
  $report = @("$ProjectDir\DynamicsCRM-Automation.ps1") | Invoke-ScriptAnalyzer;
  $report | Format-Table;

  If ($report.Count -gt 0) {
    $Host.SetShouldExit(1);
  }
} 
Else {
  Write-Error "Please install PSSCriptAnalyzer in order to verify script quality.";
}