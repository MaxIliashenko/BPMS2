# BPMS2
Experimental Blazor-powered [BPMS](https://www.interfacing.com/Rapid-Application-Development-Tools)

# Prerequisites
* [.NET 5 SDK 5.0.200 or higher](https://dotnet.microsoft.com/download/dotnet/5.0)
* DevExpress Blazor Components (installed via Nuget)
* [npm](https://www.npmjs.com/get-npm)
* Visual Studio 2019 16.9 or higher

# Building
### 1. Building JS bundle
```PowerShell
cd <solution path>\Client\JSLib
npm install
npm run build
```
### 2a. Running in Visual Studio
* restore NuGet packages
* rebuild solution
* set BPMS2.Server as startup project
* run using Kestrel (not IIS Express)

### 2b. Running in Powershell terminal
```PowerShell
cd <solution path>
dotnet restore --configfile NuGet.Config
dotnet build
dotnet run -p Server
```
and navigate to https://localhost:5001
