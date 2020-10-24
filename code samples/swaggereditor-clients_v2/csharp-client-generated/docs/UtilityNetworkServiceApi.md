# IO.Swagger.Api.UtilityNetworkServiceApi

All URIs are relative to *http://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PortalWebAdaptorSharingRestGenerateTokenPost**](UtilityNetworkServiceApi.md#portalwebadaptorsharingrestgeneratetokenpost) | **POST** /{PortalWebAdaptor}/sharing/rest/generateToken | generateToken
[**Trace**](UtilityNetworkServiceApi.md#trace) | **POST** /{ServerWebAdaptor}/rest/services/{UtilityNetworkName}/UtilityNetworkServer/trace | trace

<a name="portalwebadaptorsharingrestgeneratetokenpost"></a>
# **PortalWebAdaptorSharingRestGenerateTokenPost**
> TokenResponse PortalWebAdaptorSharingRestGenerateTokenPost (Body2 body, string portalWebAdaptor)

generateToken

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortalWebAdaptorSharingRestGenerateTokenPostExample
    {
        public void main()
        {
            var apiInstance = new UtilityNetworkServiceApi();
            var body = new Body2(); // Body2 | 
            var portalWebAdaptor = portalWebAdaptor_example;  // string | 

            try
            {
                // generateToken
                TokenResponse result = apiInstance.PortalWebAdaptorSharingRestGenerateTokenPost(body, portalWebAdaptor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilityNetworkServiceApi.PortalWebAdaptorSharingRestGenerateTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body2**](Body2.md)|  | 
 **portalWebAdaptor** | **string**|  | 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="trace"></a>
# **Trace**
> TraceResultsSet Trace (Body1 body, string token, string serverWebAdaptor, string utilityNetworkName)

trace

Trace

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TraceExample
    {
        public void main()
        {
            var apiInstance = new UtilityNetworkServiceApi();
            var body = new Body1(); // Body1 | 
            var token = token_example;  // string | 
            var serverWebAdaptor = serverWebAdaptor_example;  // string | 
            var utilityNetworkName = utilityNetworkName_example;  // string | 

            try
            {
                // trace
                TraceResultsSet result = apiInstance.Trace(body, token, serverWebAdaptor, utilityNetworkName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilityNetworkServiceApi.Trace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)|  | 
 **token** | **string**|  | 
 **serverWebAdaptor** | **string**|  | 
 **utilityNetworkName** | **string**|  | 

### Return type

[**TraceResultsSet**](TraceResultsSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
