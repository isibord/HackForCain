************************************************************************
#Cain Portal Dev Environment Readme
************************************************************************
This file would get you started on deploying the cainportal project on your machine
1. Download [Vscode](https://code.visualstudio.com/)(platform independent)/[Visual Studio 2015](https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx). You can 
also use other editors of choice like sublime but you'll need an additional plugin for your editor to provide meaningful intellisense

2. (VsCode specific) Install the c# extension for VsCode to get C# intellisense
    Go to **View -> Command Palette**. In the palette type **ext install c#**

3. Install [dot net core](https://www.microsoft.com/net/core#windows). Use the SDK if you won't be using Visual Studio 

4. Install [NodeJS](https://nodejs.org/en/) for package management. v4.4.7 would do

5. In a command shell, run  **npm install bower -g** , This would help resolve client side dependencies

6. CD to the CainPortal dir
    a. run **dotnet restore** to restore mvc needed packages
    b.  **dotnet run** should build and run the project if all dependencies were resolved currently

To view the deployed site, go to the specified localhost port in the output of dotnet run. 
To open in VisualStudioCode, Open the root directory CainPortal. In Visual Studio, open the project.json

Cheers

************************************************************************
# From ASP.NET Core's git  
************************************************************************

We've made some big updates in this release, so it’s **important** that you spend a few minutes to learn what’s new.

You've created a new ASP.NET Core project. [Learn what's new](https://go.microsoft.com/fwlink/?LinkId=518016)

## This application consists of:

*  Sample pages using ASP.NET Core MVC
*   [Bower](https://go.microsoft.com/fwlink/?LinkId=518004) for managing client-side libraries
*   Theming using [Bootstrap](https://go.microsoft.com/fwlink/?LinkID=398939)

## How to

*   [Add a Controller and View](https://go.microsoft.com/fwlink/?LinkID=398600)
*   [Add an appsetting in config and access it in app.](https://go.microsoft.com/fwlink/?LinkID=699562)
*   [Manage User Secrets using Secret Manager.](https://go.microsoft.com/fwlink/?LinkId=699315)
*   [Use logging to log a message.](https://go.microsoft.com/fwlink/?LinkId=699316)
*   [Add packages using NuGet.](https://go.microsoft.com/fwlink/?LinkId=699317)
*   [Add client packages using Bower.](https://go.microsoft.com/fwlink/?LinkId=699318)
*   [Target development, staging or production environment.](https://go.microsoft.com/fwlink/?LinkId=699319)

## Overview

*   [Conceptual overview of what is ASP.NET Core](https://go.microsoft.com/fwlink/?LinkId=518008)
*   [Fundamentals of ASP.NET Core such as Startup and middleware.](https://go.microsoft.com/fwlink/?LinkId=699320)
*   [Working with Data](https://go.microsoft.com/fwlink/?LinkId=398602)
*   [Security](https://go.microsoft.com/fwlink/?LinkId=398603)
*   [Client side development](https://go.microsoft.com/fwlink/?LinkID=699321)
*   [Develop on different platforms](https://go.microsoft.com/fwlink/?LinkID=699322)
*   [Read more on the documentation site](https://go.microsoft.com/fwlink/?LinkID=699323)

## Run & Deploy

*   [Run your app](https://go.microsoft.com/fwlink/?LinkID=517851)
*   [Run tools such as EF migrations and more](https://go.microsoft.com/fwlink/?LinkID=517853)
*   [Publish to Microsoft Azure Web Apps](https://go.microsoft.com/fwlink/?LinkID=398609)

We would love to hear your [feedback](https://go.microsoft.com/fwlink/?LinkId=518015)
