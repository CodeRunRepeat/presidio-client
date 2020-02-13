# IO.Swagger.Api.AnonymizeApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnonymizeRequest**](AnonymizeApi.md#anonymizerequest) | **POST** /projects/{projectId}/anonymize | 
[**DeleteAnonymizeTemplateRequest**](AnonymizeApi.md#deleteanonymizetemplaterequest) | **DELETE** /templates/{projectId}/anonymize/{templateId} | 
[**GetAnonymizeTemplateRequest**](AnonymizeApi.md#getanonymizetemplaterequest) | **GET** /templates/{projectId}/anonymize/{templateId} | 
[**PostAnonymizeTemplateRequest**](AnonymizeApi.md#postanonymizetemplaterequest) | **POST** /templates/{projectId}/anonymize/{templateId} | 
[**PutAnonymizeTemplateRequest**](AnonymizeApi.md#putanonymizetemplaterequest) | **PUT** /templates/{projectId}/anonymize/{templateId} | 


<a name="anonymizerequest"></a>
# **AnonymizeRequest**
> AnonymizeResponse AnonymizeRequest (long? projectId, AnonymizeRequest body = null)



Anonymize text

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnonymizeRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeApi();
            var projectId = 789;  // long? | 
            var body = new AnonymizeRequest(); // AnonymizeRequest | The request body (optional) 

            try
            {
                AnonymizeResponse result = apiInstance.AnonymizeRequest(projectId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeApi.AnonymizeRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **long?**|  | 
 **body** | [**AnonymizeRequest**](AnonymizeRequest.md)| The request body | [optional] 

### Return type

[**AnonymizeResponse**](AnonymizeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteanonymizetemplaterequest"></a>
# **DeleteAnonymizeTemplateRequest**
> void DeleteAnonymizeTemplateRequest (string projectId, string templateId)



Delete anonymize template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAnonymizeTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteAnonymizeTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeApi.DeleteAnonymizeTemplateRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **templateId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getanonymizetemplaterequest"></a>
# **GetAnonymizeTemplateRequest**
> void GetAnonymizeTemplateRequest (string projectId, string templateId)



Get anonymize template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAnonymizeTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetAnonymizeTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeApi.GetAnonymizeTemplateRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **templateId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postanonymizetemplaterequest"></a>
# **PostAnonymizeTemplateRequest**
> void PostAnonymizeTemplateRequest (string projectId, string templateId, AnonymizeTemplate body = null)



Create anonymize template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAnonymizeTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnonymizeTemplate(); // AnonymizeTemplate | The request body (optional) 

            try
            {
                apiInstance.PostAnonymizeTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeApi.PostAnonymizeTemplateRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **templateId** | **string**|  | 
 **body** | [**AnonymizeTemplate**](AnonymizeTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putanonymizetemplaterequest"></a>
# **PutAnonymizeTemplateRequest**
> void PutAnonymizeTemplateRequest (string projectId, string templateId, AnonymizeTemplate body = null)



Update anonymize template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAnonymizeTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnonymizeTemplate(); // AnonymizeTemplate | The request body (optional) 

            try
            {
                apiInstance.PutAnonymizeTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeApi.PutAnonymizeTemplateRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **string**|  | 
 **templateId** | **string**|  | 
 **body** | [**AnonymizeTemplate**](AnonymizeTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

