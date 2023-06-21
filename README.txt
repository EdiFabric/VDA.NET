Thank you for downloading EdiFabric's VDA examples

1. Overview
The examples are organized into different projects by product feature. All examples are provided for both .NET Framework 4.8 and .NET 6 in separate Visual Studio solutions.

2. Requirements
- Visual Studio, compatible with the supported .NET versions
- Minimum .NET Framework 4.8 or .NET 6. Downgrade to .NET Framework 4.5 is possible by changing the target framework for each project.

3. Serial Key and EdiFabric DLLs
All projects reference EdiFabric EDI Tools as NuGet packages from nuget.org. If you wish to install EdiFabric EDI Tools as DLLs, download the trial DLLs from https://sowl.co/oApEt. 

4. Setup
Rebuild the solution with Package Restore enabled. If there are any build errors, manually install the missing packages from https://www.nuget.org/packages?q=edifabric.

5. Getting started
To get started, set project EdiFabric.Examples.VDA.Read as the startup project, open ReadVDA.cs and either run it as it is or change the path to point to a local 4905 test file.

6. Examples by feature
Explore the different features of EdiFabric, such as translating from VDA file (Read) and generating VDA file (Write).

7. Validation
All trial templates in EdiFabric.Templates.Vda can be used for validation. If you need to test with a different template, please contact us.

8. VDA Templates
The trial comes with the following prebuilt template assemblies:

EdiFabric.Templates.Vda.dll - VDA 4905, 4906, 4907, 4908, 4913, 4915, 4927

EdiFabric supports all VDA versions and message types. We have an extensive library of EDI templates, howevere, if you can't find a particular transaction, please let us know. 
The following templates are available out-of-the-box:

https://support.edifabric.com/hc/en-us/articles/360000367932-VDA-Templates-4905-4906-4908-4913-4915

For an interactive view of all templates go to EdiNation (no registration is required):
https://edination.com/edi-formats.html

9. Trial use
The trial serial key is valid for 14 days, and using the product with a trial license is subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the product will begin throwing exceptions. 
To continue using the trial and the examples, you'll need to request a trial extension. 

10. Warranty
The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the
implied warranties of merchantability and/or fitness for a particular purpose.

11. Additional information

Install EdiFabric
https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric

Trial and examples
https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-and-Examples

EdiFabric tutorial
https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics

Knowledge Base
https://support.edifabric.com

Support
https://support.edifabric.com/hc/en-us/requests/new

Last updated on June 20, 2023
2023 © EdiFabric