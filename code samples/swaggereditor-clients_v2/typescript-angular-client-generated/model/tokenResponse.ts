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
import { TokenResponseError } from './tokenResponseError';

/**
 * Token reesponse from Portal
 */
export interface TokenResponse { 
    /**
     * The generated token.
     */
    token?: string;
    /**
     * The expiration time of the token in milliseconds since Jan. 1, 1970 (UTC).
     */
    expires?: number;
    /**
     * True if the token must always pass over ssl.
     */
    ssl?: boolean;
    error?: TokenResponseError;
}