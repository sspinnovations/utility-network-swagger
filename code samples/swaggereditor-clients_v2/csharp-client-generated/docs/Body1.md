# IO.Swagger.Model.Body1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**F** | **string** | Optional parameter representing the output format of the response (default is JSON). | [default to "json"]
**GdbVersion** | **string** | The name of the geodatabase version. | [optional] [default to "sde.DEFAULT"]
**SessionId** | **string** | Optional parameter representing the token (guid) used to lock the version. If the calling client has previously started a service session (editing) and holds an exclusive lock on the specified version, the request will fail if the sessionId is not provided. If the specified version is currently locked by any other session, the request will fail if the sessionId is not provided or does not match the sessionId which holds the exclusive lock. | [optional] [default to ""]
**Moment** | **string** | Optional parameter representing the session moment (the default is the version current moment). This should only be specified by the client when they do not want to use the current moment. | [optional] 
**TraceType** | **string** | The trace type. | 
**TraceLocations** | **List** | ***Curently a workaround until figure out how to gen**The locations for starting and stopping points, as well as barriers. Optional parameter for subnetwork trace type, required parameter for all other trace types. | 
**TraceConfiguration** | **Object** | The locations for starting and stopping points, as well as barriers. Optional parameter for subnetwork trace type, required parameter for all other trace types. | 
**ResultTypes** | **List** | Optional parameter representing the types of results to return. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

