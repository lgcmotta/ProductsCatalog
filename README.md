# ProductsCatalog
Manage and export products to different file extensions.

## About
The goal was to build a web api within a microservice architecture to store data and retrieve them as JSON. 
From there client applications can convert the results to any file extension.
I've attached to this solution, an windows forms application to manage crud operations and export files to JSON and XML.

## Environment
* .NET Core 3 (preview 6)
* .NET Standard
* .NET Framework 4.7.2
* Docker for Desktop

## How To Run
1. Install Docker for Desktop (use linux containers)
2. Install .NET Core 3.0 preview 6 SDK
3. Build the Soluton
4. Open PowerShell as Administrator
5. Go to Solution Folder
```powershell
cd C:\Users\MyUser\source\repos\ProductsCatalog\
```
6. Run the following command
```powershell
docker-compose up
```
7. Set the Windows Forms Application as Startup Project
8. Run the Application
