# IO.Swagger.Api.AnonymizeImageApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnonymizeImageRequest**](AnonymizeImageApi.md#anonymizeimagerequest) | **POST** /projects/{projectId}/anonymize-image | 
[**DeleteAnonymizeImageTemplateRequest**](AnonymizeImageApi.md#deleteanonymizeimagetemplaterequest) | **DELETE** /templates/{projectId}/anonymize-image/{templateId} | 
[**GetAnonymizeImageTemplateRequest**](AnonymizeImageApi.md#getanonymizeimagetemplaterequest) | **GET** /templates/{projectId}/anonymize-image/{templateId} | 
[**PostAnonymizeImageTemplateRequest**](AnonymizeImageApi.md#postanonymizeimagetemplaterequest) | **POST** /templates/{projectId}/anonymize-image/{templateId} | 
[**PutAnonymizeImageTemplateRequest**](AnonymizeImageApi.md#putanonymizeimagetemplaterequest) | **PUT** /templates/{projectId}/anonymize-image/{templateId} | 


<a name="anonymizeimagerequest"></a>
# **AnonymizeImageRequest**
> AnonymizeImageResponse AnonymizeImageRequest (long? projectId, AnonymizeImageRequest body = null)



Anonymize image

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnonymizeImageRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeImageApi();
            var projectId = 789;  // long? | 
            var body = new AnonymizeImageRequest(); // AnonymizeImageRequest | The request body (optional) 

            try
            {
                AnonymizeImageResponse result = apiInstance.AnonymizeImageRequest(projectId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeImageApi.AnonymizeImageRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **long?**|  | 
 **body** | [**AnonymizeImageRequest**](AnonymizeImageRequest.md)| The request body | [optional] 

### Return type

[**AnonymizeImageResponse**](AnonymizeImageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteanonymizeimagetemplaterequest"></a>
# **DeleteAnonymizeImageTemplateRequest**
> void DeleteAnonymizeImageTemplateRequest (string projectId, string templateId)



Delete anonymize-image template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAnonymizeImageTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeImageApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteAnonymizeImageTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeImageApi.DeleteAnonymizeImageTemplateRequest: " + e.Message );
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

<a name="getanonymizeimagetemplaterequest"></a>
# **GetAnonymizeImageTemplateRequest**
> void GetAnonymizeImageTemplateRequest (string projectId, string templateId)



Get anonymize-image template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAnonymizeImageTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeImageApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetAnonymizeImageTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeImageApi.GetAnonymizeImageTemplateRequest: " + e.Message );
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

<a name="postanonymizeimagetemplaterequest"></a>
# **PostAnonymizeImageTemplateRequest**
> void PostAnonymizeImageTemplateRequest (string projectId, string templateId, AnonymizeImageTemplate body = null)



Create anonymize-image template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAnonymizeImageTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeImageApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnonymizeImageTemplate(); // AnonymizeImageTemplate | The request body (optional) 

            try
            {
                apiInstance.PostAnonymizeImageTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeImageApi.PostAnonymizeImageTemplateRequest: " + e.Message );
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
 **body** | [**AnonymizeImageTemplate**](AnonymizeImageTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putanonymizeimagetemplaterequest"></a>
# **PutAnonymizeImageTemplateRequest**
> void PutAnonymizeImageTemplateRequest (string projectId, string templateId, AnonymizeImageTemplate body = null)



Update anonymize-image template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAnonymizeImageTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new AnonymizeImageApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnonymizeImageTemplate(); // AnonymizeImageTemplate | The request body (optional) 

            try
            {
                apiInstance.PutAnonymizeImageTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnonymizeImageApi.PutAnonymizeImageTemplateRequest: " + e.Message );
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
 **body** | [**AnonymizeImageTemplate**](AnonymizeImageTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

