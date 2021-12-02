/* 
 * Swagger for Utility Network
 *
 * Open API Specification (OAS/Swagger)  * **trace**, **updateIsConnected** from the [ArcGIS Utility Network](https://developers.arcgis.com/rest/services-reference/utility-network-service.htm) * **generateToken** from the [ArcGIS REST API](https://developers.arcgis.com/rest/)  Tested on ArcGIS  Enterprise 10.8.1 using OpenAPI Specification (OAC) written in [SwaggerEditor](https://github.com/swagger-api/swagger-editor)   and [SwaggerHub](https://app.swaggerhub.com/) for C# and Typescript-Angular code generation.  
 *
 * OpenAPI spec version: 3.0
 * Contact: kim.sundeen@sspinnovations.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IDefaultApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// updateIsConnected
        /// </summary>
        /// <remarks>
        /// UtilityNetworkService
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="f"></param>
        /// <param name="token"></param>
        /// <param name="serverWebAdaptor"></param>
        /// <param name="utilityNetworkName"></param>
        /// <returns>UpdateIsConnectedResponse</returns>
        UpdateIsConnectedResponse ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName);

        /// <summary>
        /// updateIsConnected
        /// </summary>
        /// <remarks>
        /// UtilityNetworkService
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="f"></param>
        /// <param name="token"></param>
        /// <param name="serverWebAdaptor"></param>
        /// <param name="utilityNetworkName"></param>
        /// <returns>ApiResponse of UpdateIsConnectedResponse</returns>
        ApiResponse<UpdateIsConnectedResponse> ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostWithHttpInfo (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// updateIsConnected
        /// </summary>
        /// <remarks>
        /// UtilityNetworkService
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="f"></param>
        /// <param name="token"></param>
        /// <param name="serverWebAdaptor"></param>
        /// <param name="utilityNetworkName"></param>
        /// <returns>Task of UpdateIsConnectedResponse</returns>
        System.Threading.Tasks.Task<UpdateIsConnectedResponse> ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostAsync (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName);

        /// <summary>
        /// updateIsConnected
        /// </summary>
        /// <remarks>
        /// UtilityNetworkService
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="f"></param>
        /// <param name="token"></param>
        /// <param name="serverWebAdaptor"></param>
        /// <param name="utilityNetworkName"></param>
        /// <returns>Task of ApiResponse (UpdateIsConnectedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UpdateIsConnectedResponse>> ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostAsyncWithHttpInfo (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class DefaultApi : IDefaultApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// </summary>
        /// <returns></returns>
        public DefaultApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// updateIsConnected UtilityNetworkService
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="f"></param>
        /// <param name="token"></param>
        /// <param name="serverWebAdaptor"></param>
        /// <param name="utilityNetworkName"></param>
        /// <returns>UpdateIsConnectedResponse</returns>
        public UpdateIsConnectedResponse ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName)
        {
             ApiResponse<UpdateIsConnectedResponse> localVarResponse = ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostWithHttpInfo(body, f, token, serverWebAdaptor, utilityNetworkName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// updateIsConnected UtilityNetworkService
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="f"></param>
        /// <param name="token"></param>
        /// <param name="serverWebAdaptor"></param>
        /// <param name="utilityNetworkName"></param>
        /// <returns>ApiResponse of UpdateIsConnectedResponse</returns>
        public ApiResponse< UpdateIsConnectedResponse > ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostWithHttpInfo (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");
            // verify the required parameter 'f' is set
            if (f == null)
                throw new ApiException(400, "Missing required parameter 'f' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");
            // verify the required parameter 'serverWebAdaptor' is set
            if (serverWebAdaptor == null)
                throw new ApiException(400, "Missing required parameter 'serverWebAdaptor' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");
            // verify the required parameter 'utilityNetworkName' is set
            if (utilityNetworkName == null)
                throw new ApiException(400, "Missing required parameter 'utilityNetworkName' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");

            var localVarPath = "/{ServerWebAdaptor}/rest/services/{UtilityNetworkName}/UtilityNetworkServer/updateIsConnected";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverWebAdaptor != null) localVarPathParams.Add("ServerWebAdaptor", this.Configuration.ApiClient.ParameterToString(serverWebAdaptor)); // path parameter
            if (utilityNetworkName != null) localVarPathParams.Add("UtilityNetworkName", this.Configuration.ApiClient.ParameterToString(utilityNetworkName)); // path parameter
            if (f != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "f", f)); // query parameter
            if (token != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "token", token)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpdateIsConnectedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UpdateIsConnectedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateIsConnectedResponse)));
        }

        /// <summary>
        /// updateIsConnected UtilityNetworkService
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="f"></param>
        /// <param name="token"></param>
        /// <param name="serverWebAdaptor"></param>
        /// <param name="utilityNetworkName"></param>
        /// <returns>Task of UpdateIsConnectedResponse</returns>
        public async System.Threading.Tasks.Task<UpdateIsConnectedResponse> ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostAsync (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName)
        {
             ApiResponse<UpdateIsConnectedResponse> localVarResponse = await ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostAsyncWithHttpInfo(body, f, token, serverWebAdaptor, utilityNetworkName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// updateIsConnected UtilityNetworkService
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="f"></param>
        /// <param name="token"></param>
        /// <param name="serverWebAdaptor"></param>
        /// <param name="utilityNetworkName"></param>
        /// <returns>Task of ApiResponse (UpdateIsConnectedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UpdateIsConnectedResponse>> ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPostAsyncWithHttpInfo (Body body, string f, string token, string serverWebAdaptor, string utilityNetworkName)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");
            // verify the required parameter 'f' is set
            if (f == null)
                throw new ApiException(400, "Missing required parameter 'f' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");
            // verify the required parameter 'serverWebAdaptor' is set
            if (serverWebAdaptor == null)
                throw new ApiException(400, "Missing required parameter 'serverWebAdaptor' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");
            // verify the required parameter 'utilityNetworkName' is set
            if (utilityNetworkName == null)
                throw new ApiException(400, "Missing required parameter 'utilityNetworkName' when calling DefaultApi->ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost");

            var localVarPath = "/{ServerWebAdaptor}/rest/services/{UtilityNetworkName}/UtilityNetworkServer/updateIsConnected";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverWebAdaptor != null) localVarPathParams.Add("ServerWebAdaptor", this.Configuration.ApiClient.ParameterToString(serverWebAdaptor)); // path parameter
            if (utilityNetworkName != null) localVarPathParams.Add("UtilityNetworkName", this.Configuration.ApiClient.ParameterToString(utilityNetworkName)); // path parameter
            if (f != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "f", f)); // query parameter
            if (token != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "token", token)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServerWebAdaptorRestServicesUtilityNetworkNameUtilityNetworkServerUpdateIsConnectedPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UpdateIsConnectedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UpdateIsConnectedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UpdateIsConnectedResponse)));
        }

    }
}
