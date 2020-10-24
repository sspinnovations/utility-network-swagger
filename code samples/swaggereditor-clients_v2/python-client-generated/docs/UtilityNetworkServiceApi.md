# swagger_client.UtilityNetworkServiceApi

All URIs are relative to *http://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**portal_web_adaptor_sharing_rest_generate_token_post**](UtilityNetworkServiceApi.md#portal_web_adaptor_sharing_rest_generate_token_post) | **POST** /{PortalWebAdaptor}/sharing/rest/generateToken | generateToken
[**trace**](UtilityNetworkServiceApi.md#trace) | **POST** /{ServerWebAdaptor}/rest/services/{UtilityNetworkName}/UtilityNetworkServer/trace | trace

# **portal_web_adaptor_sharing_rest_generate_token_post**
> TokenResponse portal_web_adaptor_sharing_rest_generate_token_post(body, portal_web_adaptor)

generateToken

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UtilityNetworkServiceApi()
body = swagger_client.Body2() # Body2 | 
portal_web_adaptor = 'portal_web_adaptor_example' # str | 

try:
    # generateToken
    api_response = api_instance.portal_web_adaptor_sharing_rest_generate_token_post(body, portal_web_adaptor)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UtilityNetworkServiceApi->portal_web_adaptor_sharing_rest_generate_token_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body2**](Body2.md)|  | 
 **portal_web_adaptor** | **str**|  | 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **trace**
> TraceResultsSet trace(body, token, server_web_adaptor, utility_network_name)

trace

Trace

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UtilityNetworkServiceApi()
body = swagger_client.Body1() # Body1 | 
token = 'token_example' # str | 
server_web_adaptor = 'server_web_adaptor_example' # str | 
utility_network_name = 'utility_network_name_example' # str | 

try:
    # trace
    api_response = api_instance.trace(body, token, server_web_adaptor, utility_network_name)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UtilityNetworkServiceApi->trace: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)|  | 
 **token** | **str**|  | 
 **server_web_adaptor** | **str**|  | 
 **utility_network_name** | **str**|  | 

### Return type

[**TraceResultsSet**](TraceResultsSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

