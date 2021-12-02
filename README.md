# Swagger for ArcGIS Utility Network web services

An [Open API Specification/Swagger](https://github.com/OAI/OpenAPI-Specification) definition for  methods on the [ArcGIS Utility Network REST API](https://developers.arcgis.com/rest/services-reference/utility-network-service.htm)

![GetRunning](https://github.com/sspinnovations/utility-network-swagger/blob/master/UtilityNetwork_Rest_To_Client.jpg?raw=true)

## What's Here?

* Swagger/Open API definition file for trace, updatedIsConnected, getToken. 
* nSwagStudio generated C# client for trace, updatedIsConnected, getToken
* swagger-codegen samples of other generated clients (Python, C++, TypeScript-Angular, TypeScript-Node, Akka-Scala)

## Prerequisites

* Visual Studio 2015, 2017, or 2019 to compile C# sample (in /utility-network-swagger/code samples/UtilityNetworkCSharpSample_v1 (or _v2))

## Getting Started

 - Open .NET solution under code-samples\UtilityNetworkCSharpSample_v2\UNCSharpConsoleSample.sln 
 - Change variables marked as *REQUIRED* in Program.cs for your Portal web adapter, manager, username, password, and utility network feature layer name.
 - Compile, run, have fun!!
 - Fin!

## Version 2 SDKs Built With

* [Swagger-Editor](https://github.com/swagger-api/swagger-editor) - Local Visual editor for OpenAPI Spec, and Client SDK generator
* [SwaggerHub ](https://swagger.io/tools/swaggerhub/) - Local Visual editor for OpenAPI Spec, and Client SDK generator
* [nSwagStudio](https://github.com/RSuter/NSwag/wiki/NSwagStudio) - Used to generate C#, TypeScript clients
* [Swagger-codegen](https://github.com/swagger-api/swagger-codegen) - Command line client generator for Swagger APIs

## Version 1 SDKs Built With

* [Restlet Studio](https://restlet.com/modules/studio/) - Visual editor for Swagger
* [nSwagStudio](https://github.com/RSuter/NSwag/wiki/NSwagStudio) - Used to generate C# clients
* [Swagger-codegen](https://github.com/swagger-api/swagger-codegen) - Command line client generator for Swagger
* [Maven](https://maven.apache.org/) - Dependency Management (used to build swagger-codegen)