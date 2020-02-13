# IO.Swagger.Api.StreamApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStreamTemplateRequest**](StreamApi.md#deletestreamtemplaterequest) | **DELETE** /templates/{projectId}/stream/{templateId} | 
[**GetStreamTemplateRequest**](StreamApi.md#getstreamtemplaterequest) | **GET** /templates/{projectId}/stream/{templateId} | 
[**PostStreamTemplateRequest**](StreamApi.md#poststreamtemplaterequest) | **POST** /templates/{projectId}/stream/{templateId} | 
[**PutStreamTemplateRequest**](StreamApi.md#putstreamtemplaterequest) | **PUT** /templates/{projectId}/stream/{templateId} | 


<a name="deletestreamtemplaterequest"></a>
# **DeleteStreamTemplateRequest**
> void DeleteStreamTemplateRequest (string projectId, string templateId)



Delete stream template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStreamTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new StreamApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteStreamTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamApi.DeleteStreamTemplateRequest: " + e.Message );
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

<a name="getstreamtemplaterequest"></a>
# **GetStreamTemplateRequest**
> void GetStreamTemplateRequest (string projectId, string templateId)



Get stream template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStreamTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new StreamApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetStreamTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamApi.GetStreamTemplateRequest: " + e.Message );
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

<a name="poststreamtemplaterequest"></a>
# **PostStreamTemplateRequest**
> void PostStreamTemplateRequest (string projectId, string templateId, StreamTemplate body = null)



Create stream template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostStreamTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new StreamApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new StreamTemplate(); // StreamTemplate | The request body (optional) 

            try
            {
                apiInstance.PostStreamTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamApi.PostStreamTemplateRequest: " + e.Message );
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
 **body** | [**StreamTemplate**](StreamTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstreamtemplaterequest"></a>
# **PutStreamTemplateRequest**
> void PutStreamTemplateRequest (string projectId, string templateId, StreamTemplate body = null)



Update stream template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutStreamTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new StreamApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new StreamTemplate(); // StreamTemplate | The request body (optional) 

            try
            {
                apiInstance.PutStreamTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamApi.PutStreamTemplateRequest: " + e.Message );
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
 **body** | [**StreamTemplate**](StreamTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

