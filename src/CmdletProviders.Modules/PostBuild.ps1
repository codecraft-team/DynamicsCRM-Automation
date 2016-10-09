param (
  [string]$TargetDir,
  [string]$TargetName,
  [string]$ProjectDir
)

Write-Host "`nRemoving Module artifacts..`n"

@("$TargetDir\$targetName.dll", "$TargetDir\$targetName.pdb") | Remove-Item -Force -Verbose;

Write-Host "`nModule artifacts removed.`n"

If (Get-Module -ListAvailable -Name PSSCriptAnalyzer) {
  $hasError = $false;

  Try {
    $script = "$($ProjectDir)DynamicsCRM-Automation.ps1";
    Write-Host "Analyzing script: $($script)";
    $report = Invoke-ScriptAnalyzer -Severity Error -Path $script;
    $report | Format-Table;
    $hasError = $report.Count -gt 0;
  }
  Catch {
    Write-Host "Failed to analyze scripts.";
  }

  If ($hasError) {
    Write-Host "The PSScriptAnalyzer found one or more errors, i.e. quality gate not passed.";
    $Host.SetShouldExit(1);
  }
} 
Else {
  Write-Host "Please install PSSCriptAnalyzer in order to verify script quality.";
  $Host.SetShouldExit(1);
}