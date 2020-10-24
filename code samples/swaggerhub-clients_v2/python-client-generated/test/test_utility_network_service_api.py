# coding: utf-8

"""
    Swagger for Utility Network

    Open API Specification (OAS/Swagger)  * **trace**, **updateIsConnected** from the [ArcGIS Utility Network](https://developers.arcgis.com/rest/services-reference/utility-network-service.htm) * **generateToken** from the [ArcGIS REST API](https://developers.arcgis.com/rest/)  Tested on ArcGIS  Enterprise 10.8.1 using OpenAPI Specification (OAC) written in [SwaggerEditor](https://github.com/swagger-api/swagger-editor)   and [SwaggerHub](https://app.swaggerhub.com/) for C# and Typescript-Angular code generation.    # noqa: E501

    OpenAPI spec version: 3.0
    Contact: kim.sundeen@sspinnovations.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.utility_network_service_api import UtilityNetworkServiceApi  # noqa: E501
from swagger_client.rest import ApiException


class TestUtilityNetworkServiceApi(unittest.TestCase):
    """UtilityNetworkServiceApi unit test stubs"""

    def setUp(self):
        self.api = UtilityNetworkServiceApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_portal_web_adaptor_sharing_rest_generate_token_post(self):
        """Test case for portal_web_adaptor_sharing_rest_generate_token_post

        generateToken  # noqa: E501
        """
        pass

    def test_trace(self):
        """Test case for trace

        trace  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()