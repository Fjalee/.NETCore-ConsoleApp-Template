# .NETCore-ConsoleApp-Template
My personal console app template for .NET Core

# About   
* Currently for version .NETCore 6.0   

## How to use   
* copy paste everything but `.git` folder
* update NuGet packages (if needed)
* rename solution / projects
  * in VS solution explorer:
    * rename solution
    * rename project
    * rename UnitTest project
    * rename `namespace Template` (in VS ctrl+f)
  * in Windows file explorer:
    * rename solution folder
    * rename project folder
    * rename UnitTest project folder
  * in VS solution explorer:
    * remove all projects (in VS solution explorer)
    * add existing newly renamed projects (in VS solution explorer)
* `local-appsettings.json`   
    * add `local-appsettings.json` file into the same directory as `appsettings.json`.   
    `local-appsettings.json` is for configuration that should not be pushed into repository (eg. API keys)   
