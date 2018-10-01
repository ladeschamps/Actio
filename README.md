# Actio

Curso [.NET Core Microservices | Udemy](https://www.udemy.com/share/1006lkAEcTclpUR3w=/)

## Criação da Solution

```bash
$ mkdir Actio
$ cd Actio/
$ dotnet new sln
$ mkdir src
$ mkdir scripts
$ mkdir tests
$ cd src
$ dotnet new webapi -n Actio.API
$ dotnet new webapi -n Actio.Services.Identity
$ dotnet new webapi -n Actio.Services.Activities
$ dotnet new classlib -n Actio.Common
$ dotnet add Actio.API/Actio.API.csproj reference Actio.Common/Actio.Common.csproj
$ dotnet add Actio.Services.Identity/Actio.Services.Identity.csproj reference Actio.Common/Actio.Common.csproj
$ donet Actio.Services.Activities/Actio.Services.Activities.csproj reference Actio.Common/Actio.Common.csproj
$ cd ..
$ dotnet sln add src/Actio.API/Actio.API.csproj
$ dotnet sln add src/Actio.Common/Actio.Common.csproj
$ dotnet sln add src/Actio.Services.Identity/Actio.Services.Identity.csproj
$ dotnet sln add src/Actio.API/
$ dotnet sln add src/Actio.Services.Activities/Actio.Services.Activities.csproj
$ dotnet restore
$ dotnet build
```
