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
2. Build the Soluton
3. Open PowerShell as Administrator
4. Go to Solution Folder
```powershell
cd C:\Users\MyUser\source\repos\ProductsCatalog\
```
5. Run the following command
```powershell
docker-compose up
```
6. Set the Windows Forms Application as Startup Project
7. Run the Application
