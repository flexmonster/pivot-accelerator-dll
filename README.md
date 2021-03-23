# Sample server with Flexmonster Accelerator as a DLL
[![Flexmonster Pivot Table & Charts](https://cdn.flexmonster.com/landing.png)](http://flexmonster.com)
Website: www.flexmonster.com

## Flexmonster Pivot Table & Charts

Flexmonster Pivot is a powerful JavaScript tool for interactive web reporting. It allows you to visualize and analyze data from JSON, CSV, SQL, NoSQL, Elasticsearch, and OLAP data sources quickly and conveniently. Flexmonster is designed to integrate seamlessly with any client-side framework and can be easily embedded into your application.

This repository holds the source code for a project that demonstrates how to reference [Flexmonster Accelerator](https://www.flexmonster.com/doc/getting-started-with-accelerator-ssas/) as a DLL.

Flexmonster Accelerator is a special server-side proxy that makes big data transfer from the server to the customer's browser incredibly fast. It also greatly reduces the load on the browser memory.

The table of contents:

- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)

## Prerequisites

To run a simple application with the Accelerator as a DLL, you will need Microsoft .NET Framework 4.5.2 or higher. [Get it here](https://www.microsoft.com/en-us/download/details.aspx?id=56116) if it's not already installed on your machine.

We also use Visual Studio 2019 as an IDE. If you do not have Visual Studio installed, [download it here](https://visualstudio.microsoft.com/vs/).

## Installation

1. Download the `.zip` archive with the sample project or clone it from GitHub with the following command:

```bash
git clone https://github.com/flexmonster/pivot-accelerator-dll
```
2. Open the project in Visual Studio using the `pivot-accelerator-dll/Flexmonster Accelerator MVC.sln` file.

3. If needed, update the NuGet packages: 
    - right-click project name in `Solution Explorer` and select the `Manage NuGet Packages` item in the context menu
    - go to the `Updates` tab and choose `Select all packages`
    - click the `Update` button
  
4. Run the sample project by clicking the `IIS Express` button on the toolbar.

To see the result, open `http://localhost:55158/` in your browser.

## Usage

For details on using Flexmonster Accelerator as a DLL in your project, see the [Referencing the Accelerator as a DLL](https://www.flexmonster.com/doc/referencing-accelerator-as-a-dll/) tutorial.
