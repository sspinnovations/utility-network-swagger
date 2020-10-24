# IO.Swagger.Model.TraceConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeContainers** | **bool?** | Optional parameter representing whether or not to include containers in the trace result (default is false). | [optional] [default to false]
**IncludeContent** | **bool?** | Optional parameter representing whether or not to include content in the trace result (default is false). | [optional] [default to false]
**IncludeStructures** | **bool?** | Optional parameter representing whether or not to include structures in the trace result (default is false). | [optional] [default to false]
**IncludeBarriers** | **bool?** | Optional parameter representing whether or not to include barrier features that stop a trace in the trace result (default is true). | [optional] [default to true]
**ValidateConsistency** | **bool?** | Optional parameter representing whether or not to validate the consistency of the trace results (default is false). | [optional] [default to false]
**IncludeIsolated** | **bool?** | Optional property specifying whether to include isolated features for an isolation trace (the default is false). | [optional] [default to false]
**IgnoreBarriersAtStartingPoints** | **bool?** | Optional property specifying whether dynamic barriers in the trace configuration are ignored for starting points. This can be useful when performing an upstream protective device trace using the discovered protective devices (barriers) as starting points to find subsequent upstream protective devices (the default is false). | [optional] [default to false]
**IncludeUpToFirstSpatialContainer** | **bool?** | Optional property representing whether to limit the containers returned in the trace result. This property depends on the includeContainers property and no-ops if includeContainers is false. If includeContainers is true and this property is true, containment associations up to, and including the first spatial container will be returned; otherwise all containment associations will be returned (the default is false). | [optional] [default to false]
**DomainNetworkName** | **string** | Specifies the name of the domain network where the trace is starting. This is required for subnetwork-based traces. | [optional] [default to ""]
**TierName** | **string** | Optional parameter that specifies the name of the tier where the trace is starting. | [optional] [default to ""]
**TargetTierName** | **string** | Optional parameter representing the name of the tier where upstream or downstream trace ends. | [optional] [default to ""]
**SubnetworkName** | **string** | Optional parameter representing the name of the subnetwork that will be traced - the starting points of the trace will be the controllers of this subnetwork . | [optional] [default to ""]
**DiagramTemplateName** | **string** | Optional parameter representing the name of the diagram template. | [optional] [default to ""]
**ShortestPathNetworkAttributeName** | **string** | Required parameter for shortest path trace ; optional otherwise. It represents the network attribute name used for determining cost when calulating the shortest path. | [optional] [default to ""]
**FilterBitsetNetworkAttributeName** | **string** | Optional parameter. Used during loops trace to only return loops with the same bit set all around the loop. Used during upstream/downstream traces to ensure that trace results include any bit that is set in the starting points for the network attribute. | [optional] [default to ""]
**TraversabilityScope** | **string** | Optional parameters representing which network element types the condition, category, or function barriers apply to (default is junctionsAndEdges). | [optional] [default to TraversabilityScopeEnum.JunctionsAndEdges]
**FilterScope** | **string** |  | [optional] [default to "junctionsAndEdges"]
**ConditionBarriers** | [**List&lt;ConditionBarrier&gt;**](ConditionBarrier.md) | Optional parameter containing an array of objects (representing network attribute conditions) that serve as barriers - default is null. If isTypeSpecificValue is true, the network attribute is being compared with a specific value ; otherwise the network attribute is being compared with another network attribute. | 
**FunctionBarriers** | [**List&lt;FunctionBarrier&gt;**](FunctionBarrier.md) | optional parameter. | 
**CategoryBarriers** | **List&lt;string&gt;** | The categories that serve as barriers (default is none) : optional parameter. | [optional] 
**FilterBarriers** | **List&lt;string&gt;** | A second pass is done over the trace results and all results after these categories are encountered are filtered (default is none) : optional parameter. | 
**FilterFunctionBarriers** | **List&lt;string&gt;** |  | 
**Functions** | **Object** | Optional parameter ; an array of objects representing functions. Each function may have an optional array of network attribute conditions. | 
**NearestNeighbor** | [**NearestNeighborParam**](NearestNeighborParam.md) |  | 
**OutputFilterCategories** | **Object** | Optional property. This is an array of objects representing categories associated with the output filter (the default is none). | [optional] 
**OutputFilters** | [**List&lt;OutputFilter&gt;**](OutputFilter.md) | Optional property representing the output filter; an array of objects (default is null). | 
**OutputConditions** | [**List&lt;TraceOutputCondition&gt;**](TraceOutputCondition.md) | Optional property specifying the type of features returned based on a network attribute or category. | 
**ArcadeExpressionBarrier** | **string** |  | [optional] [default to ""]
**Propagators** | [**List&lt;Propagator&gt;**](Propagator.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

