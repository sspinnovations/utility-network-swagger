# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost**](DefaultApi.md#serverwebadaptorrestservicesutilitynetworknameutilitynetworkserverupdateisconnectedpost) | **POST** /{ServerWebAdaptor}/rest/services/{UtilityNetworkName}/UtilityNetworkServer/updateIsConnected | updateIsConnected

<a name="serverwebadaptorrestservicesutilitynetworknameutilitynetworkserverupdateisconnectedpost"></a>
# **ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost**
> UpdateIsConnectedResponse ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName)

updateIsConnected

UtilityNetworkService

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Body(); // Body | 
            var f = f_example;  // string |  (default to json)
            var token = token_example;  // string | 
            var serverWebAdaptor = serverWebAdaptor_example;  // string | 
            var utilityNetworkName = utilityNetworkName_example;  // string | 

            try
            {
                // updateIsConnected
                UpdateIsConnectedResponse result = apiInstance.ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost(body, f, token, serverWebAdaptor, utilityNetworkName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | 
 **f** | **string**|  | [default to json]
 **token** | **string**|  | 
 **serverWebAdaptor** | **string**|  | 
 **utilityNetworkName** | **string**|  | 

### Return type

[**UpdateIsConnectedResponse**](UpdateIsConnectedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
