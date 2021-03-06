/**
 * Swagger for Utility Network
 * Open API Specification (OAS/Swagger)  * **trace**, **updateIsConnected** from the [ArcGIS Utility Network]( https://developers.arcgis.com/rest/services-reference/utility-network-service.htm) * **generateToken** from the [ArcGIS REST API](https://developers.arcgis.com/rest/)  Tested on ArcGIS  Enterprise 10.6.1 using [NSwagStudio](https://github.com/RSuter/NSwag/wiki/NSwagStudio) C# code gen . 
 *
 * OpenAPI spec version: 0.13
 * Contact: 
 *
 * NOTE: This class is auto generated by the swagger code generator 2.4.0-SNAPSHOT.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */



#include "TokenResponse.h"

namespace io {
namespace swagger {
namespace client {
namespace model {

TokenResponse::TokenResponse()
{
    m_Token = utility::conversions::to_string_t("");
    m_TokenIsSet = false;
    m_Expires = 0.0;
    m_ExpiresIsSet = false;
    m_Ssl = false;
    m_SslIsSet = false;
    m_ErrorIsSet = false;
}

TokenResponse::~TokenResponse()
{
}

void TokenResponse::validate()
{
    // TODO: implement validation
}

web::json::value TokenResponse::toJson() const
{
    web::json::value val = web::json::value::object();

    if(m_TokenIsSet)
    {
        val[utility::conversions::to_string_t("token")] = ModelBase::toJson(m_Token);
    }
    if(m_ExpiresIsSet)
    {
        val[utility::conversions::to_string_t("expires")] = ModelBase::toJson(m_Expires);
    }
    if(m_SslIsSet)
    {
        val[utility::conversions::to_string_t("ssl")] = ModelBase::toJson(m_Ssl);
    }
    if(m_ErrorIsSet)
    {
        val[utility::conversions::to_string_t("error")] = ModelBase::toJson(m_Error);
    }

    return val;
}

void TokenResponse::fromJson(web::json::value& val)
{
    if(val.has_field(utility::conversions::to_string_t("token")))
    {
        setToken(ModelBase::stringFromJson(val[utility::conversions::to_string_t("token")]));
    }
    if(val.has_field(utility::conversions::to_string_t("expires")))
    {
        setExpires(ModelBase::doubleFromJson(val[utility::conversions::to_string_t("expires")]));
    }
    if(val.has_field(utility::conversions::to_string_t("ssl")))
    {
        setSsl(ModelBase::boolFromJson(val[utility::conversions::to_string_t("ssl")]));
    }
    if(val.has_field(utility::conversions::to_string_t("error")))
    {
        if(!val[utility::conversions::to_string_t("error")].is_null())
        {
            std::shared_ptr<TokenResponse_error> newItem(new TokenResponse_error());
            newItem->fromJson(val[utility::conversions::to_string_t("error")]);
            setError( newItem );
        }
    }
}

void TokenResponse::toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix) const
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(m_TokenIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("token"), m_Token));
        
    }
    if(m_ExpiresIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("expires"), m_Expires));
    }
    if(m_SslIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("ssl"), m_Ssl));
    }
    if(m_ErrorIsSet)
    {
        if (m_Error.get())
        {
            m_Error->toMultipart(multipart, utility::conversions::to_string_t("error."));
        }
        
    }
}

void TokenResponse::fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix)
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(multipart->hasContent(utility::conversions::to_string_t("token")))
    {
        setToken(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("token"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("expires")))
    {
        setExpires(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("expires"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("ssl")))
    {
        setSsl(ModelBase::boolFromHttpContent(multipart->getContent(utility::conversions::to_string_t("ssl"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("error")))
    {
        if(multipart->hasContent(utility::conversions::to_string_t("error")))
        {
            std::shared_ptr<TokenResponse_error> newItem(new TokenResponse_error());
            newItem->fromMultiPart(multipart, utility::conversions::to_string_t("error."));
            setError( newItem );
        }
    }
}

utility::string_t TokenResponse::getToken() const
{
    return m_Token;
}


void TokenResponse::setToken(utility::string_t value)
{
    m_Token = value;
    m_TokenIsSet = true;
}
bool TokenResponse::tokenIsSet() const
{
    return m_TokenIsSet;
}

void TokenResponse::unsetToken()
{
    m_TokenIsSet = false;
}

double TokenResponse::getExpires() const
{
    return m_Expires;
}


void TokenResponse::setExpires(double value)
{
    m_Expires = value;
    m_ExpiresIsSet = true;
}
bool TokenResponse::expiresIsSet() const
{
    return m_ExpiresIsSet;
}

void TokenResponse::unsetExpires()
{
    m_ExpiresIsSet = false;
}

bool TokenResponse::isSsl() const
{
    return m_Ssl;
}


void TokenResponse::setSsl(bool value)
{
    m_Ssl = value;
    m_SslIsSet = true;
}
bool TokenResponse::sslIsSet() const
{
    return m_SslIsSet;
}

void TokenResponse::unsetSsl()
{
    m_SslIsSet = false;
}

std::shared_ptr<TokenResponse_error> TokenResponse::getError() const
{
    return m_Error;
}


void TokenResponse::setError(std::shared_ptr<TokenResponse_error> value)
{
    m_Error = value;
    m_ErrorIsSet = true;
}
bool TokenResponse::errorIsSet() const
{
    return m_ErrorIsSet;
}

void TokenResponse::unsetError()
{
    m_ErrorIsSet = false;
}

}
}
}
}

