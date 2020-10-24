# Body1

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**f** | **str** | Optional parameter representing the output format of the response (default is JSON). | [default to 'json']
**gdb_version** | **str** | The name of the geodatabase version. | [optional] [default to 'sde.DEFAULT']
**session_id** | **str** | Optional parameter representing the token (guid) used to lock the version. If the calling client has previously started a service session (editing) and holds an exclusive lock on the specified version, the request will fail if the sessionId is not provided. If the specified version is currently locked by any other session, the request will fail if the sessionId is not provided or does not match the sessionId which holds the exclusive lock. | [optional] [default to '']
**moment** | **str** | Optional parameter representing the session moment (the default is the version current moment). This should only be specified by the client when they do not want to use the current moment. | [optional] 
**trace_type** | **str** | The trace type. | 
**trace_locations** | **list** | ***Curently a workaround until figure out how to gen**The locations for starting and stopping points, as well as barriers. Optional parameter for subnetwork trace type, required parameter for all other trace types. | 
**trace_configuration** | **object** | The locations for starting and stopping points, as well as barriers. Optional parameter for subnetwork trace type, required parameter for all other trace types. | 
**result_types** | **list** | Optional parameter representing the types of results to return. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

