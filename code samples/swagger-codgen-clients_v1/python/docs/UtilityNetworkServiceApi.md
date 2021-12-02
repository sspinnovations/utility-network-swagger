# swagger_client.UtilityNetworkServiceApi

All URIs are relative to *https://t4e7j4g.restletmocks.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**portal_web_adaptor_sharing_rest_generate_token_post**](UtilityNetworkServiceApi.md#portal_web_adaptor_sharing_rest_generate_token_post) | **POST** /{PortalWebAdaptor}/sharing/rest/generateToken | generateToken
[**trace**](UtilityNetworkServiceApi.md#trace) | **POST** /{ServerWebAdaptor}/rest/services/{UtilityNetworkName}/UtilityNetworkServer/trace | trace


# **portal_web_adaptor_sharing_rest_generate_token_post**
> TokenResponse portal_web_adaptor_sharing_rest_generate_token_post(portal_web_adaptor, username, password, expiration, f, ip=ip, referer=referer)

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
portal_web_adaptor = 'portal_web_adaptor_example' # str | 
username = 'username_example' # str | 
password = 'password_example' # str | 
expiration = 8.14 # float | 
f = 'json' # str |  (default to json)
ip = 'ip_example' # str |  (optional)
referer = 'referer_example' # str |  (optional)

try:
    # generateToken
    api_response = api_instance.portal_web_adaptor_sharing_rest_generate_token_post(portal_web_adaptor, username, password, expiration, f, ip=ip, referer=referer)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UtilityNetworkServiceApi->portal_web_adaptor_sharing_rest_generate_token_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portal_web_adaptor** | **str**|  | 
 **username** | **str**|  | 
 **password** | **str**|  | 
 **expiration** | **float**|  | 
 **f** | **str**|  | [default to json]
 **ip** | **str**|  | [optional] 
 **referer** | **str**|  | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **trace**
> TraceResultsSet trace(server_web_adaptor, utility_network_name, token, f, trace_type, trace_locations, trace_configuration, gdb_version=gdb_version, session_id=session_id, moment=moment)

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
server_web_adaptor = 'server_web_adaptor_example' # str | 
utility_network_name = 'utility_network_name_example' # str | 
token = '\"Zo7BVjivecOe2IFj58REGkUcvD9RK1k1Qu8YOpRu_mkMtFA2vPSUiWk_aksOO1-WF_hxNaOOfAMWz00PvyLrgF10ghdv23tW9cr0VUBFjNrw8RnclzKuc5W2sXnu5ilS790spTGYGky4z19dCRcg-pA2oDQMndQ_IkCTE-fOsibd1kdoiK6deU8mZo14Z4A8DmRhI1vneraDt8m7HHbnwY2sfFs_p_DHOl7j521x3BjxTH303O-syc2aF1jm9aPXYtoLY3A5eTz1wVFQcGRMacLkPvHoRcfQLjq6FpRfAumIKVPumQJF_VLoKCAXvjzVbwpvGQADejej96vAmfanUQ..\"' # str | 
f = 'json' # str | Optional parameter representing the output format of the response (default is JSON). (default to json)
trace_type = '\"upstream\"' # str | The trace type.
trace_locations = '\"\\\"[{\\\\\\\"traceLocationType\\\\\\\":\\\\\\\"startingPoint\\\\\\\",\\\\\\\"globalId\\\\\\\":\\\\\\\"{7C47EFCE-4794-4589-9951-F2DEAD1E8176}\\\\\\\",\\\\\\\"percentAlong\\\\\\\":0.67932399720238645}]\\\"\"' # str | ***Curently a workaround until figure out how to gen**The locations for starting and stopping points, as well as barriers. Optional parameter for subnetwork trace type, required parameter for all other trace types.
trace_configuration = '\"{\\n   \\\"includeContainers\\\":true,\\n   \\\"includeContent\\\":false,\\n   \\\"includeStructures\\\":true,\\n   \\\"includeBarriers\\\":true,\\n   \\\"validateConsistency\\\":true,\\n   \\\"domainNetworkName\\\":\\\"ElectricDistribution\\\",\\n   \\\"tierName\\\":\\\"Medium Voltage Radial\\\",\\n   \\\"targetTierName\\\":\\\"Medium Voltage Radial\\\",\\n   \\\"subnetworkName\\\":\\\"\\\",\\n   \\\"diagramTemplateName\\\":\\\"\\\",\\n   \\\"shortestPathNetworkAttributeName\\\":\\\"\\\",\\n   \\\"filterBitsetNetworkAttributeName\\\":\\\"\\\",\\n   \\\"traversabilityScope\\\":\\\"junctionsAndEdges\\\",\\n   \\\"conditionBarriers\\\":[\\n      {\\n         \\\"name\\\":\\\"Operational Device Status\\\",\\n         \\\"type\\\":\\\"networkAttribute\\\",\\n         \\\"operator\\\":\\\"equal\\\",\\n         \\\"value\\\":1,\\n         \\\"combineUsingOr\\\":false,\\n         \\\"isSpecificValue\\\":true\\n      }\\n   ],\\n   \\\"functionBarriers\\\":[\\n\\n   ],\\n   \\\"arcadeExpressionBarrier\\\":\\\"\\\",\\n   \\\"filterBarriers\\\":[\\n\\n   ],\\n   \\\"filterFunctionBarriers\\\":[\\n\\n   ],\\n   \\\"filterScope\\\":\\\"junctionsAndEdges\\\",\\n   \\\"functions\\\":[\\n\\n   ],\\n   \\\"nearestNeighbor\\\":{\\n      \\\"count\\\":-1,\\n      \\\"costNetworkAttributeName\\\":\\\"\\\",\\n      \\\"nearestCategories\\\":[\\n\\n      ],\\n      \\\"nearestAssets\\\":[\\n\\n      ]\\n   },\\n   \\\"outputFilters\\\":[\\n\\n   ],\\n   \\\"outputConditions\\\":[\\n\\n   ],\\n   \\\"propagators\\\":[\\n\\n   ]\\n}\"' # str | The locations for starting and stopping points, as well as barriers. Optional parameter for subnetwork trace type, required parameter for all other trace types.
gdb_version = 'sde.DEFAULT' # str | The name of the geodatabase version. (optional) (default to sde.DEFAULT)
session_id = '\"\"' # str | Optional parameter representing the token (guid) used to lock the version. If the calling client has previously started a service session (editing) and holds an exclusive lock on the specified version, the request will fail if the sessionId is not provided. If the specified version is currently locked by any other session, the request will fail if the sessionId is not provided or does not match the sessionId which holds the exclusive lock. (optional) (default to "")
moment = '\"\\\"1511904463011\\\"\"' # str | Optional parameter representing the session moment (the default is the version current moment). This should only be specified by the client when they do not want to use the current moment. (optional)

try:
    # trace
    api_response = api_instance.trace(server_web_adaptor, utility_network_name, token, f, trace_type, trace_locations, trace_configuration, gdb_version=gdb_version, session_id=session_id, moment=moment)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UtilityNetworkServiceApi->trace: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **server_web_adaptor** | **str**|  | 
 **utility_network_name** | **str**|  | 
 **token** | **str**|  | 
 **f** | **str**| Optional parameter representing the output format of the response (default is JSON). | [default to json]
 **trace_type** | **str**| The trace type. | 
 **trace_locations** | **str**| ***Curently a workaround until figure out how to gen**The locations for starting and stopping points, as well as barriers. Optional parameter for subnetwork trace type, required parameter for all other trace types. | 
 **trace_configuration** | **str**| The locations for starting and stopping points, as well as barriers. Optional parameter for subnetwork trace type, required parameter for all other trace types. | 
 **gdb_version** | **str**| The name of the geodatabase version. | [optional] [default to sde.DEFAULT]
 **session_id** | **str**| Optional parameter representing the token (guid) used to lock the version. If the calling client has previously started a service session (editing) and holds an exclusive lock on the specified version, the request will fail if the sessionId is not provided. If the specified version is currently locked by any other session, the request will fail if the sessionId is not provided or does not match the sessionId which holds the exclusive lock. | [optional] [default to &quot;&quot;]
 **moment** | **str**| Optional parameter representing the session moment (the default is the version current moment). This should only be specified by the client when they do not want to use the current moment. | [optional] 

### Return type

[**TraceResultsSet**](TraceResultsSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

