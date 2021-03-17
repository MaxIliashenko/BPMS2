# BPMS2
Experimental Blazor-powered [BPMS](https://www.interfacing.com/Rapid-Application-Development-Tools)

# Requiered
* [.NET 6 preview 2 or higher](https://dotnet.microsoft.com/download/dotnet/6.0)
* [Blazor UI Components by DevExpress](https://www.devexpress.com/blazor/) (installed via Nuget)
* [npm](https://www.npmjs.com/get-npm)
* [Visual Studio 2019 16.10](https://visualstudio.microsoft.com/vs/preview/) or higher

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
