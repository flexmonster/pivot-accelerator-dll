# Sample server with Flexmonster Accelerator as a DLL
[![Flexmonster Pivot Table & Charts](https://cdn.flexmonster.com/landing.png)](https://www.flexmonster.com?r=github)
Website: [www.flexmonster.com](https://www.flexmonster.com?r=github)

## Flexmonster Pivot Table & Charts

Flexmonster Pivot is a powerful JavaScript tool for interactive web reporting. It allows you to visualize and analyze data from JSON, CSV, SQL, NoSQL, Elasticsearch, and OLAP data sources quickly and conveniently. Flexmonster is designed to integrate seamlessly with any client-side framework and can be easily embedded into your application.

This repository contains a sample project that demonstrates how to reference [Flexmonster Accelerator](https://www.flexmonster.com/doc/getting-started-with-accelerator-ssas?r=github) as a DLL.

Flexmonster Accelerator is a server-side proxy that increases data loading speeds from the server to the user’s browser. It also greatly reduces the load on the browser memory.

Table of contents:

- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Related Flexmonster docs](#related-flexmonster-docs)

## Prerequisites

- [Microsoft .NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
- [Visual Studio IDE](https://visualstudio.microsoft.com/vs/)

## Installation

1. Download a `.zip` archive with the sample project or clone it from GitHub with the following command:

```bash
git clone https://github.com/flexmonster/pivot-accelerator-dll
```
2. Open the project in Visual Studio using the `pivot-accelerator-dll/Flexmonster Accelerator MVC.sln` file.
  
3. Run the project by selecting the `IIS Express` button on the toolbar.

To see the result, open `http://localhost:55158/` in your browser.

## Related Flexmonster docs

- [Referencing the Accelerator as a DLL](https://www.flexmonster.com/doc/referencing-accelerator-as-a-dll?r=github) — learn how to use Flexmonster Accelerator as a DLL in an existing project.
