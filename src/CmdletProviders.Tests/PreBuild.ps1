 param (
   [string]$projectPath,
   [string]$outDir
 )

$appConfigPath = "{0}App.config" -f $projectPath; 
Write-Host $appConfigPath;

$appConfig = [xml](cat $appConfigPath);
$appConfig.configuration.appSettings.add | foreach {
    $_.value = "$projectPath..\..\artifacts"
};
$appConfig.Save($appConfigPath);