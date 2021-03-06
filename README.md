# Forbid.Extensions.Microsoft.DependencyInjection

Package to support Microsoft Dependency Injection for [Forbid](https://www.nuget.org/packages/Forbid/) package.

[![.NET](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/)
![Nuget](https://img.shields.io/nuget/dt/Forbid.Extensions.Microsoft.DependencyInjection?color=blue)
[![NuGet stable version](https://badgen.net/nuget/v/Forbid.Extensions.Microsoft.DependencyInjection)](https://www.nuget.org/packages/Forbid.Extensions.Microsoft.DependencyInjection)
[![GitHub license](https://badgen.net/github/license/Revazashvili/Forbid.Extensions.Microsoft.DependencyInjection)](https://github.com/Revazashvili/Forbid.Extensions.Microsoft.DependencyInjection/blob/main/LICENSE)

## Installing
Using dotnet cli
```
dotnet add package Forbid.Extensions.Microsoft.DependencyInjection --version 1.0.0
```
or package reference
```
<PackageReference Include="Forbid.Extensions.Microsoft.DependencyInjection" Version="1.0.0" />
```

## Usage

```c#
using Forbids;

public void ConfigureServices(IServiceCollection services)
{
    services.AddForbids();  
}

Or

using Forbids;

public void ConfigureServices(IServiceCollection services)
{
    services.AddForbids(ServiceLifetime.Scoped); //default is Singleton  
}
```
