ArcGISPro.HelloWorld
====================

Hello world add-in for ArcGIS Pro. Adds a (Bex!) button to the ArcGIS Pro interface.
Developed for ArcGIS Pro beta 4 - build. There is no official ArcGIS Pro .NET SDK yet,
but with these notes you can start developing. 
For more samples see https://github.com/Esri/arcgis-pro-samples-beta4

![logo](https://raw.githubusercontent.com/Esri/arcgis-pro-samples-beta4/master/arcgis-pro-samples-beta4.png)

Screenshot
========
![screenshot](/Images/screenshot.png)

Installation
========
To install without compiling:

get file releases/1.0/ArcGISPro.HelloWorld.esriAddInX

run in dos: "C:\Program Files\ArcGIS Pro\bin\RegisterAddIn.exe" ArcGISPro.HelloWorld.esriAddInX

Or double-click the file and open with C:\Program Files\ArcGIS Pro\bin\RegisterAddIn.exe

To uninstall:

run in dos: "C:\Program Files\ArcGIS Pro\bin\RegisterAddIn.exe" {BC7676B6-AC4F-4AAE-97C6-F0FF842D1C65} /u

Start ArcGIS Pro, create new project and add a map. The add-in should appear on the ribbon.


Developer notes
========

1] make new Visual Studio class project

2] set option debug -> start action -> Start external program
to 'C:\Program Files\ArcGIS Pro\bin\ArcGISPro.exe'

3] Add build targets
Open Visual Studio project file in editor and add:
```html
  <UsingTask AssemblyFile="C:\Program Files\ArcGIS Pro\bin\proapp-sdk-MSBuild.dll" TaskName="proapp_sdk_MSBuild.PackageAddIn" />
  <UsingTask AssemblyFile="C:\Program Files\ArcGIS Pro\bin\proapp-sdk-MSBuild.dll" TaskName="proapp_sdk_MSBuild.CleanAddIn" />
  <UsingTask AssemblyFile="C:\Program Files\ArcGIS Pro\bin\proapp-sdk-MSBuild.dll" TaskName="proapp_sdk_MSBuild.ConvertToRelativePath" />
  <Import Project="C:\Program Files\ArcGIS Pro\bin\Esri.ProApp.SDK.Desktop.targets" Condition="Exists('C:\Program Files\ArcGIS Pro\bin\Esri.ProApp.SDK.Desktop.targets')" />
```

4] Add XML file named 'Config.daml'
Note: the name must be 'Config.daml' not something else!

double click the daml file -> add to schemas: 
'C:\Program Files\ArcGIS Pro\bin\ArcGIS.Desktop.Framework.xsd'

Properties of daml file : set  build action to 'AddInContent'

Fill the XML file with a module, group and button (see sample)

5] add reference

C:\Program Files\ArcGIS Pro\bin\ArcGIS.Desktop.Framework.dll

Set 'copy local' property of this reference to 'false'

6] Add Module class and Button class

7] Compile and run!

On compilation, a file 'ArcGISPro.HelloWorld.esriAddInX' is generated. This is basically a zip file
with dll, images and xml file. It is registered as add-in 
using the tool RegisterAddIn.exe and a copy is placed in C:\Users\(username)\Documents\ArcGIS\AddIns\ArcGISPro1.0

The tab named 'Add-In Tab' seems to be a default tab, you can add custom tabs by editing the Config.daml file.
