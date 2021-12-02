# swagger_client.DefaultApi

All URIs are relative to *https://t4e7j4g.restletmocks.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**server_web_adaptor_rest_services_utility_network_name_utility_network_server_update_is_connected_post**](DefaultApi.md#server_web_adaptor_rest_services_utility_network_name_utility_network_server_update_is_connected_post) | **POST** /{ServerWebAdaptor}/rest/services/{UtilityNetworkName}/UtilityNetworkServer/updateIsConnected | updateIsConnected


# **server_web_adaptor_rest_services_utility_network_name_utility_network_server_update_is_connected_post**
> UpdateIsConnectedResponse server_web_adaptor_rest_services_utility_network_name_utility_network_server_update_is_connected_post(server_web_adaptor, utility_network_name, f, token)

updateIsConnected

UtilityNetworkService

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
server_web_adaptor = 'server_web_adaptor_example' # str | 
utility_network_name = 'utility_network_name_example' # str | 
f = 'json' # str |  (default to json)
token = 'token_example' # str | 

try:
    # updateIsConnected
    api_response = api_instance.server_web_adaptor_rest_services_utility_network_name_utility_network_server_update_is_connected_post(server_web_adaptor, utility_network_name, f, token)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->server_web_adaptor_rest_services_utility_network_name_utility_network_server_update_is_connected_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **server_web_adaptor** | **str**|  | 
 **utility_network_name** | **str**|  | 
 **f** | **str**|  | [default to json]
 **token** | **str**|  | 

### Return type

[**UpdateIsConnectedResponse**](UpdateIsConnectedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

