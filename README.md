## Mygelb
My portfolio about Mygel Bergstresser. 
Site Url: Mygelb.com (Not live)

CMS: Umbraco 7.4.3
Web Server: IIS 10d
SQL Server: Microsoft SQLServer
IDE: Visual Studio

Localdb: mygelb.sql

# Installation of a new Umbraco Project
1. Visual Studio > File > New Project
2. Choose ASP.NET Web Application > Empty
3. Tools > NuGet Package Manager > Package Manager Console
4. Run command: Install-Package UmbracoCms
5. Build and run. Do not debug. 
> local enviroment. Localhost1337

# Setup SQL Server
1. Install SQL Server Management Studio
2. Create empty database for Umbraco installation

# Virtual host on IIS
1. Install IIS through Windows Features
2. Right click Sites > add Website
3. Application pool: DefaultAppPool
4. C:/inetpub/wwwroot/EXAMPLE
5. Hostname: EXAMPLE.dev
6. Update HOST file: 127.0.0.1 EXAMPLE.dev

# Deploy to IIS
1. Right click solution > publish
2. Physical path to EXAMPLE folder in inetpub/wwwroot
> Developing enviroment - EXAMPLE.dev

# Cloning Umbraco
1. Clone project to Documents/VS2015/Projects
2. Open MVS Solution in Visual Studio
3. Build and run. Do not debug. 
> local enviroment. Localhost1337

# Existing Database
1. Web.config : Configure DB to connect to cloned DB (Mygelb.sql)