# What's New in .NET 7

.NET 7 builds on the foundation established by .NET 6, which includes a unified set of base libraries, runtime, and SDK, a simplified development experience, and higher developer productivity. Major areas of focus for .NET 7 include improved support for cloud native scenarios, tools to make it easier to upgrade legacy projects, and simplifying the developer experience by making it easier to work with containers.

* Resource: <https://devblogs.microsoft.com/dotnet/announcing-net-7-preview-1/>

## Download .NET 7

Download and install latest version of .NET 7.

|Latest Version|Download|
|--------------|--------|
|7.0.100-preview.3|<https://dotnet.microsoft.com/en-us/download/dotnet/7.0>|

## Create a Console Application in Visual Studio 2022 Preview

Create a new project

![picture 1](images/470356d86aea87bdde1fa692c683ac139b4b0d8e852d54772861b7067bd3b498.png)  

Configure your new project

![picture 2](images/edf226708a313ba1519451152d61a91f3e6da3b98ff47ed6d8a825b0cc334d76.png)  

Select .NET 7.0 (Preview) and click Create

![picture 3](images/df806324abaff2d3e2d325c43f7e29cda15da138c0c9c1c9d3a74e42fee4a8b6.png)  

Program.cs looks the same as .NET 6.0

![picture 4](images/4829c4ae194e6b606ff84da738a1e59e13b234f0f99660d0c5e4015b76cfe703.png)  

But the .csproj hast a new TargetFramework

![picture 5](images/28ae4f02f17d793ea696664fbe01853a87d2c4138f313af480133567ee9da47c.png)  

## Available TargetFrameworks

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <!--Available TargetFramework values
    net7.0
    net7.0-android
    net7.0-ios
    net7.0-maccatalyst
    net7.0-macos
    net7.0-tvos
    net7.0-windows-->
    <TargetFramework>net7.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
```

## StringSyntaxAttribute

This new attribute allows you to specify what kind of data a string represents, for example Regex, JSON, or a DateTime. This will be use to expand syntax highlighting and colorization.

Before

![picture 11](images/c6ef9e3187e024adfd3a37943ee0b9cee2c7feb479c418e584da503cf545d5f3.png)  

After

![picture 10](images/4625bf3ba0630af44a20b1c72796a82060305ef63abfd386687acb44c84dadfb.png)  

* Resource <https://github.com/dotnet/runtime/issues/62505>

## 


## Complete Code

* [<https://github.com/payini/WhatsNewInDotNet7>](https://github.com/payini/What-s-New-in-.NET-7)

## Resources

|Resource                       |Url                                                     |
|-------------------------------|--------------------------------------------------------|
|.NET 7 Downloads               |<https://dotnet.microsoft.com/en-us/download/dotnet/7.0>|
|ASP.NET Core Roadmap for .NET 7|<https://github.com/dotnet/aspnetcore/issues/39504>     |
|Announcing .NET 7 Preview 1|<https://devblogs.microsoft.com/dotnet/announcing-net-7-preview-1/>|
|Announcing .NET 7 Preview 2 – The New, ‘New’ Experience|<https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-2/>|
|Announcing .NET 7 Preview 2|<https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-3/>|
|StringSyntaxAttribute|<https://github.com/dotnet/runtime/issues/62505>|
|||
|||
|||