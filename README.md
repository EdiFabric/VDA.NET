# EdiFabric C# .NET Examples for VDA

## 1. Overview
EdiFabric is a software development kit for .NET Framework and .NET Core, which makes it straightforward to parse, generate, validate, acknowledge, split, customize, or in other words, to programmatically manipulate EDI files. It is written in C# and is distributed as a DLL file and a NuGet package.  

It currently supports all message types for the X12, EDIFACT, HL7, and NCPDP EDI standards, the German automotive standard VDA, as well as custom formatted flat files (delimited, positional, or a mixture of both).  

> NOTE: EdiFabric does not provide any communication components (AS2 or SFTP, for example), has no dashboard or UI, and is not a full end-to-end EDI solution.
The best option to get the gist of what EdiFabric is, and can do, is to play around with the trial and examples.  

The examples are organized into different projects in two logical categories: by product feature and by message type.   

```C#
Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Vda_4905_02.txt");

List<IEdiItem> ediItems;
using (var ediReader = new VdaReader(ediStream, MessageContextFactory))
    ediItems = ediReader.ReadToEnd().ToList();
    
var transactions = ediItems.OfType<TS4905>();
```

## 2. Requirements
- Visual Studio, compatible with the supported .NET versions. [Download Visual Studio](https://visualstudio.microsoft.com/downloads/).
- Minimum .NET Framework 4.8 or .NET 6. Downgrading to .NET Framework 4.5 is possible by changing the target framework for each project.

## 3. Serial Key and EdiFabric trial DLLs
All projects reference EdiFabric EDI Tools as NuGet packages from nuget.org. If you wish to install EdiFabric EDI Tools as DLLs, download the trial DLLs from [here](https://support.edifabric.com/hc/en-us/articles/360000280532-Free-code-to-master-you-EDI-files).

## 4. Setup
Rebuild the solution with Package Restore enabled. If there are any build errors, manually install the missing packages from [here](https://www.nuget.org/packages?q=edifabric). 

## 5. Getting started
To get started, set project EdiFabric.Examples.VDA.Read as the startup project, open ReadVDA.cs and either run it as it is or change the path to point to a local 4905 test file.  

## 6. Examples by feature
Explore the different features of EdiFabric, such as translating from VDA file (Read) and generating VDA file (Write).  

## 7. VDA Validation
All trial templates in EdiFabric.Templates.Vda can be used for validation. If you need to test with a different template, please contact us.  

## 8. VDA Templates
The following templates are available out-of-the-box:  

https://support.edifabric.com/hc/en-us/articles/360000367932-VDA-Templates-4905-4906-4908-4913-4915

For an interactive view of all templates go to EdiNation (no registration is required):  

[EdiNation](https://edination.com/edi-formats.html)

## 9. Trial use
The trial serial key is valid for 14 days, and using the product with a trial license is subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the product will begin throwing exceptions. To continue using the trial and the examples, you'll need to request a trial extension.    

## 10. Warranty
*The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the implied warranties of merchantability and/or fitness for a particular purpose.*  

## 11. Additional information

[Install EdiFabric](https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric)

[Trial and Examples](https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-and-Examples)

[EdiFabric DB](https://support.edifabric.com/hc/en-us/articles/360029265372-EDI-to-DB)

[EdiFabric Tutorial](https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics)

[Knowledge Base](https://support.edifabric.com)

[Support](https://support.edifabric.com/hc/en-us/requests/new)

Last updated on June 20, 2023
### 2023 © EdiFabric
