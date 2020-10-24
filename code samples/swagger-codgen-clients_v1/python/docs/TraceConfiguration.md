# TraceConfiguration

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**include_containers** | **bool** | Optional parameter representing whether or not to include containers in the trace result (default is false). | [optional] [default to False]
**include_content** | **bool** | Optional parameter representing whether or not to include content in the trace result (default is false). | [optional] [default to False]
**include_structures** | **bool** | Optional parameter representing whether or not to include structures in the trace result (default is false). | [optional] [default to False]
**include_barriers** | **bool** | Optional parameter representing whether or not to include barrier features that stop a trace in the trace result (default is true). | [optional] [default to True]
**validate_consistency** | **bool** | Optional parameter representing whether or not to validate the consistency of the trace results (default is false). | [optional] [default to False]
**domain_network_name** | **str** | Optional parameter that specifies the name of the domain network where the trace is starting. | [optional] [default to 'REPLACE_WITH_EMPTY_STRING']
**tier_name** | **str** | Optional parameter that specifies the name of the tier where the trace is starting. | [optional] [default to 'REPLACE_WITH_EMPTY_STRING']
**target_tier_name** | **str** | Optional parameter representing the name of the tier where upstream or downstream trace ends. | [optional] [default to 'REPLACE_WITH_EMPTY_STRING']
**subnetwork_name** | **str** | Optional parameter representing the name of the subnetwork that will be traced - the starting points of the trace will be the controllers of this subnetwork . | [optional] [default to 'REPLACE_WITH_EMPTY_STRING']
**diagram_template_name** | **str** | Optional parameter representing the name of the diagram template. | [optional] [default to 'REPLACE_WITH_EMPTY_STRING']
**shortest_path_network_attribute_name** | **str** | Required parameter for shortest path trace ; optional otherwise. It represents the network attribute name used for determining cost when calulating the shortest path. | [optional] [default to 'REPLACE_WITH_EMPTY_STRING']
**filter_bitset_network_attribute_name** | **str** | Optional parameter. Used during loops trace to only return loops with the same bit set all around the loop. Used during upstream/downstream traces to ensure that trace results include any bit that is set in the starting points for the network attribute. | [optional] [default to 'REPLACE_WITH_EMPTY_STRING']
**traversability_scope** | **str** | Optional parameters representing which network element types the condition, category, or function barriers apply to (default is junctionsAndEdges). | [optional] [default to 'junctionsAndEdges']
**condition_barriers** | [**list[ConditionBarrier]**](ConditionBarrier.md) | Optional parameter containing an array of objects (representing network attribute conditions) that serve as barriers - default is null. If isTypeSpecificValue is true, the network attribute is being compared with a specific value ; otherwise the network attribute is being compared with another network attribute. | 
**category_barriers** | **list[str]** | The categories that serve as barriers (default is none) : optional parameter. | [optional] 
**function_barriers** | [**list[FunctionBarrier]**](FunctionBarrier.md) | optional parameter. | 
**arcade_expression_barrier** | **str** |  | [optional] [default to '""']
**filter_barriers** | **list[str]** | A second pass is done over the trace results and all results after these categories are encountered are filtered (default is none) : optional parameter. | 
**filter_function_barriers** | **list[str]** |  | 
**filter_scope** | **str** |  | [optional] [default to 'junctionsAndEdges']
**functions** | **object** | Optional parameter ; an array of objects representing functions. Each function may have an optional array of network attribute conditions. | 
**nearest_neighbor** | [**NearestNeighborParam**](NearestNeighborParam.md) |  | 
**output_filters** | [**list[TraceOutputCondition]**](TraceOutputCondition.md) |  | 
**output_conditions** | [**list[OutputFilter]**](OutputFilter.md) | The categories associated with the output filter (default is none) ; optional parameter. | 
**propagators** | [**list[Propagator]**](Propagator.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


