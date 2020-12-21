# EdiFabric examples for VDA

Go to https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-EdiFabric-Examples for the web version of this README.

## 1. Overview
The examples are organized into different projects by product feature.

## 2. Requirements
- Visual Studio, compatible with the supported .NET versions
- .NET Framework 4.5 or .NET Core 3.1. All projects target .NET Framework 4.5, however, the Target Framework from each project's properties can be changed to .NET Core 3.1.
- EdiFabric trial NuGet packages and serial number.

## 3. Download
The trial NuGet packages and the trial serial number can be downloaded from [here](https://sowl.co/oApEt). 

## 4. Install
Unzip the downloaded file in the previous step. The following folders should be available at the same level:  

edifabric-examples-edifact  
edifabric-examples-flatfile  
edifabric-examples-vda  
edifabric-examples-x12  
edifabric-trial  

Ensure that the following packages are present in folder edifabric-trial:  

EdiFabric.Core.9.8.7.5.nupkg  
EdiFabric.Framework.9.8.7.5.nupkg  
EdiFabric.Plugins.Ack.Edifact.9.8.7.5.nupkg  
EdiFabric.Plugins.Ack.X12.9.8.7.5.nupkg  
EdiFabric.Templates.Edifact.2.0.0.nupkg  
EdiFabric.Templates.Hipaa.2.0.0.nupkg  
EdiFabric.Templates.Padis.2.0.0.nupkg  
EdiFabric.Templates.Vda.2.0.0.nupkg  
EdiFabric.Templates.X12.2.0.0.nupkg  

## 5. Setup
Add folder edifabric-trial as a package source in Visual Studio:
- From the top menu in Visual Studio go to *Tools -> NuGet Package Manager -> Package Manager Settings -> Package Sources*
- Add a new package source (by clicking the green plus button), then name it "EdiFabric Trial" and browse to select the edifabric-trial folder as the Source.
- Click the Update button to apply the changes and then click OK to close the dialog.  

Rebuild the solution to install the rest of the dependencies. If there are any build errors, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.  

> NOTE: it is possible to also reference DLLs instead of NuGet packages. Change the .nupkg extension of the packages to .zip, unzip them, and extract the DLL files. 
Then uninstall the NuGet packages from each project and replace them with DLL references.  

## 6. Serial Number
All main operations, like read, write, and validate require a valid serial number. The serial number is included in the file serial.key in folder edifabric-trial. Ensure it is there and that the file is not empty.  
The serial number is used in the file License.cs in project EdiFabric.Examples.VDA.Common. Open the file and ensure that the serialKeyPath is correct.
If the serial number is invalid or the file is missing, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.  

## 7. Gettings started
To get started, set project EdiFabric.Examples.VDA.Read as the startup project, open ReadVDA.cs and either run it as it is or change the path to point to a local 4905 test file.  

## 8. Examples by feature
Explore the different features of EdiFabric, such as translating from VDA file (Read) and generating VDA file (Write).  

## 9. Validation
All trial templates in EdiFabric.Templates.Vda can be used for validation. If you need to test with a different template, please contact us.  

## 10. EDI Templates
EdiFabric supports all EDIFACT/EANCOM/IATA versions and message types. We have an extensive library of EDI templates, howevere, if you can't find a particular transaction, please let us know.   
The following templates are available out-of-the-box:  

https://support.edifabric.com/hc/en-us/articles/360000367932-VDA-Templates-4905-4906-4908-4913-4915

For an interactive view of all templates go to EdiNation's EDI Webpad (no registration is required):  

https://www.edination.com/edi-models-vda.html

## 11. Trial use
The trial assemblies are valid for 14 days and are subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the trial packages will begin throwing exceptions.   
To continue using the trial and the examples, you'll need to either request a trial extension or replace the trial packages, together with all references to the trial packages, with the full version of EdiFabric.   

## 12. Warranty
The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the implied warranties of merchantability and/or fitness for a particular purpose.  

## 13. Additional information

[EdiFabric tutorial](https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics)

[Knowledge Base](https://support.edifabric.com)

[Support](https://support.edifabric.com/hc/en-us/requests/new)

Last updated on December 16, 2020
### 2020 © EdiFabric
