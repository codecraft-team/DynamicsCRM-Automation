> **WARNING: Please note, that the project setup is still in progress. Expected release date: Monday, 5th September 2016.**

# PowerShell Library for Microsoft Dynamics CRM

<a href="https://github.com/ostools/DynamicsCRM-Automation"><img src="logo.png" align="left" vspace="4"></a>

**DynamicsCRM-Automation** is a PowerShell library for Microsoft Dynamics CRM project related tasks automation. 
The library targets different areas of a Dynamics CRM Project life cycle, e.g. consulting, development, support or maintenance.

[![Feedback Build](https://ci.appveyor.com/api/projects/status/h5ew281tw33s3jti?svg=true&passingText=Feedback%20Build%20-%20OK&failingText=Feedback%20Build%20-%20Fails&pendingText=Feedback%20Build%20-%20Pending)](https://ci.appveyor.com/project/JozsefHorvath/dynamicscrm-automation)
[![PowerShell Gallery Release](https://ci.appveyor.com/api/projects/status/p9avq7ngyhiao7qp?svg=true&passingText=PowerShell%20Gallery%20Release%20-%20OK&failingText=PowerShell%20Gallery%20Release%20-%20Fails&pendingText=PowerShell%20Gallery%20Release%20-%20Pending)](https://ci.appveyor.com/project/JozsefHorvath/dynamicscrm-automation-ndmcj)

<br/>

## Resources

* [Wiki](https://github.com/ostools/dynamicscrm-automation/wiki)
* [Examples](https://github.com/ostools/dynamicscrm-automation/wiki/CmdletReference.md)
  * [Development Automation](https://github.com/ostools/dynamicscrm-automation/wiki/CmdletReference.md)
  * [Staging Automation](https://github.com/ostools/dynamicscrm-automation/wiki/CmdletReference.md)
  * [Quality Assurance Automation](https://github.com/ostools/dynamicscrm-automation/wiki/CmdletReference.md)
  * [Maintenance Automation](https://github.com/ostools/dynamicscrm-automation/wiki/CmdletReference.md)
* [Cmdlet Reference](https://github.com/ostools/dynamicscrm-automation/wiki/CmdletReference.md)
* [Cmdlet Provider Reference](https://github.com/ostools/dynamicscrm-automation/wiki/CmdletReference.md)

## Installation

The following command  will download the module from the PowerShell marketplace.

```powershell
Install-Module DynamicsCRM-Automation
```

When you already installed the module, you can initialize the CRM PSDrives by execution the following cmdlet:

```powershell
Initialize-CrmPsDrive -IgnoreUntrustedSSL;
```

You can also download the latest release using this [link](http://latestrelease).

## Examples

This should be a short block with 2-3 examples.

## Release Notes

This should be the latest version info only.