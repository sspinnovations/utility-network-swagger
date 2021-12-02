/**
 * Swagger for Utility Network
 * Open API Specification (OAS/Swagger)  * **trace**, **updateIsConnected** from the [ArcGIS Utility Network](https://developers.arcgis.com/rest/services-reference/utility-network-service.htm) * **generateToken** from the [ArcGIS REST API](https://developers.arcgis.com/rest/)  Tested on ArcGIS  Enterprise 10.8.1 using OpenAPI Specification (OAC) written in [SwaggerEditor](https://github.com/swagger-api/swagger-editor)   and [SwaggerHub](https://app.swaggerhub.com/) for C# and Typescript-Angular code generation.  
 *
 * OpenAPI spec version: 3.0
 * Contact: kim.sundeen@sspinnovations.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
import { ConditionBarrier } from './conditionBarrier';
import { FunctionBarrier } from './functionBarrier';
import { NearestNeighborParam } from './nearestNeighborParam';
import { OutputFilter } from './outputFilter';
import { Propagator } from './propagator';
import { TraceOutputCondition } from './traceOutputCondition';

export interface TraceConfiguration { 
    /**
     * Optional parameter representing whether or not to include containers in the trace result (default is false).
     */
    includeContainers?: boolean;
    /**
     * Optional parameter representing whether or not to include content in the trace result (default is false).
     */
    includeContent?: boolean;
    /**
     * Optional parameter representing whether or not to include structures in the trace result (default is false).
     */
    includeStructures?: boolean;
    /**
     * Optional parameter representing whether or not to include barrier features that stop a trace in the trace result (default is true).
     */
    includeBarriers?: boolean;
    /**
     * Optional parameter representing whether or not to validate the consistency of the trace results (default is false).
     */
    validateConsistency?: boolean;
    /**
     * Optional property specifying whether to include isolated features for an isolation trace (the default is false).
     */
    includeIsolated?: boolean;
    /**
     * Optional property specifying whether dynamic barriers in the trace configuration are ignored for starting points. This can be useful when performing an upstream protective device trace using the discovered protective devices (barriers) as starting points to find subsequent upstream protective devices (the default is false).
     */
    ignoreBarriersAtStartingPoints?: boolean;
    /**
     * Optional property representing whether to limit the containers returned in the trace result. This property depends on the includeContainers property and no-ops if includeContainers is false. If includeContainers is true and this property is true, containment associations up to, and including the first spatial container will be returned; otherwise all containment associations will be returned (the default is false).
     */
    includeUpToFirstSpatialContainer?: boolean;
    /**
     * Specifies the name of the domain network where the trace is starting. This is required for subnetwork-based traces.
     */
    domainNetworkName?: string;
    /**
     * Optional parameter that specifies the name of the tier where the trace is starting.
     */
    tierName?: string;
    /**
     * Optional parameter representing the name of the tier where upstream or downstream trace ends.
     */
    targetTierName?: string;
    /**
     * Optional parameter representing the name of the subnetwork that will be traced - the starting points of the trace will be the controllers of this subnetwork .
     */
    subnetworkName?: string;
    /**
     * Optional parameter representing the name of the diagram template.
     */
    diagramTemplateName?: string;
    /**
     * Required parameter for shortest path trace ; optional otherwise. It represents the network attribute name used for determining cost when calulating the shortest path.
     */
    shortestPathNetworkAttributeName?: string;
    /**
     * Optional parameter. Used during loops trace to only return loops with the same bit set all around the loop. Used during upstream/downstream traces to ensure that trace results include any bit that is set in the starting points for the network attribute.
     */
    filterBitsetNetworkAttributeName?: string;
    /**
     * Optional parameters representing which network element types the condition, category, or function barriers apply to (default is junctionsAndEdges).
     */
    traversabilityScope?: TraceConfiguration.TraversabilityScopeEnum;
    filterScope?: string;
    /**
     * Optional parameter containing an array of objects (representing network attribute conditions) that serve as barriers - default is null. If isTypeSpecificValue is true, the network attribute is being compared with a specific value ; otherwise the network attribute is being compared with another network attribute.
     */
    conditionBarriers: Array<ConditionBarrier>;
    /**
     * optional parameter.
     */
    functionBarriers: Array<FunctionBarrier>;
    /**
     * The categories that serve as barriers (default is none) : optional parameter.
     */
    categoryBarriers?: Array<string>;
    /**
     * A second pass is done over the trace results and all results after these categories are encountered are filtered (default is none) : optional parameter.
     */
    filterBarriers: Array<string>;
    filterFunctionBarriers: Array<string>;
    /**
     * Optional parameter ; an array of objects representing functions. Each function may have an optional array of network attribute conditions.
     */
    functions: any;
    nearestNeighbor: NearestNeighborParam;
    /**
     * Optional property. This is an array of objects representing categories associated with the output filter (the default is none).
     */
    outputFilterCategories?: any;
    /**
     * Optional property representing the output filter; an array of objects (default is null).
     */
    outputFilters: Array<OutputFilter>;
    /**
     * Optional property specifying the type of features returned based on a network attribute or category.
     */
    outputConditions: Array<TraceOutputCondition>;
    arcadeExpressionBarrier?: string;
    propagators: Array<Propagator>;
}
export namespace TraceConfiguration {
    export type TraversabilityScopeEnum = 'junctions' | 'edges' | 'junctionsAndEdges';
    export const TraversabilityScopeEnum = {
        Junctions: 'junctions' as TraversabilityScopeEnum,
        Edges: 'edges' as TraversabilityScopeEnum,
        JunctionsAndEdges: 'junctionsAndEdges' as TraversabilityScopeEnum
    };
}