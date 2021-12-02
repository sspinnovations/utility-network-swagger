# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://t4e7j4g.restletmocks.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost**](DefaultApi.md#serverwebadaptorrestservicesutilitynetworknameutilitynetworkserverupdateisconnectedpost) | **POST** /{ServerWebAdaptor}/rest/services/{UtilityNetworkName}/UtilityNetworkServer/updateIsConnected | updateIsConnected


<a name="serverwebadaptorrestservicesutilitynetworknameutilitynetworkserverupdateisconnectedpost"></a>
# **ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost**
> UpdateIsConnectedResponse ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost (string serverWebAdaptor, string utilityNetworkName, string f, string token)

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
            var serverWebAdaptor = serverWebAdaptor_example;  // string | 
            var utilityNetworkName = utilityNetworkName_example;  // string | 
            var f = "f=json";  // string |  (default to json)
            var token = token_example;  // string | 

            try
            {
                // updateIsConnected
                UpdateIsConnectedResponse result = apiInstance.ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost(serverWebAdaptor, utilityNetworkName, f, token);
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
 **serverWebAdaptor** | **string**|  | 
 **utilityNetworkName** | **string**|  | 
 **f** | **string**|  | [default to json]
 **token** | **string**|  | 

### Return type

[**UpdateIsConnectedResponse**](UpdateIsConnectedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

