# Swagger for ArcGIS Utility Network web services

An [Open API Specification/Swagger](https://github.com/OAI/OpenAPI-Specification) definition for  methods on the [ArcGIS Utility Network REST API](https://developers.arcgis.com/rest/services-reference/utility-network-service.htm)

![GetRunning](https://github.com/sspinnovations/utility-network-swagger/blob/master/UtilityNetwork_Rest_To_Client.jpg?raw=true)

## What's Here?

* Swagger/Open API definition file for trace, updatedIsConnected, getToken. 
* nSwagStudio generated C# client for trace, updatedIsConnected, getToken
* swagger-codegen samples of other generated clients (Python, C++, TypeScript-Angular, TypeScript-Node, Akka-Scala)

## Prerequisites

* Visual Studio 2015 or 2017 to compile C# sample

## Getting Started

 - Open .NET solution under code-samples\UtilityNetworkCSharpSample\UNCSharpConsoleSample.sln 
 - Change variables marked as *REQUIRED* in Program.cs
 - Compile, run, have fun


## Built With

* [Restlet Studio](https://restlet.com/modules/studio/) - Visual editor for Swagger
* [nSwagStudio](https://github.com/RSuter/NSwag/wiki/NSwagStudio) - Used to generate C#, TypeScript clients
* [Swagger-codegen](https://github.com/swagger-api/swagger-codegen) - Command line client generator for Swagger
* [Maven](https://maven.apache.org/) - Dependency Management (used to build swagger-codegen)


