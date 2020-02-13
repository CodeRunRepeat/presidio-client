# IO.Swagger.Api.DatasinkApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDatasinkTemplateRequest**](DatasinkApi.md#deletedatasinktemplaterequest) | **DELETE** /templates/{projectId}/datasink/{templateId} | 
[**GetDatasinkTemplateRequest**](DatasinkApi.md#getdatasinktemplaterequest) | **GET** /templates/{projectId}/datasink/{templateId} | 
[**PostDatasinkTemplateRequest**](DatasinkApi.md#postdatasinktemplaterequest) | **POST** /templates/{projectId}/datasink/{templateId} | 
[**PutDatasinkTemplateRequest**](DatasinkApi.md#putdatasinktemplaterequest) | **PUT** /templates/{projectId}/datasink/{templateId} | 


<a name="deletedatasinktemplaterequest"></a>
# **DeleteDatasinkTemplateRequest**
> void DeleteDatasinkTemplateRequest (string projectId, string templateId)



Delete datasink template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDatasinkTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new DatasinkApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteDatasinkTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatasinkApi.DeleteDatasinkTemplateRequest: " + e.Message );
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

<a name="getdatasinktemplaterequest"></a>
# **GetDatasinkTemplateRequest**
> void GetDatasinkTemplateRequest (string projectId, string templateId)



Get datasink template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasinkTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new DatasinkApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetDatasinkTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatasinkApi.GetDatasinkTemplateRequest: " + e.Message );
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

<a name="postdatasinktemplaterequest"></a>
# **PostDatasinkTemplateRequest**
> void PostDatasinkTemplateRequest (string projectId, string templateId, DatasinkTemplate body = null)



Create datasink template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDatasinkTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new DatasinkApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new DatasinkTemplate(); // DatasinkTemplate | The request body (optional) 

            try
            {
                apiInstance.PostDatasinkTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatasinkApi.PostDatasinkTemplateRequest: " + e.Message );
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
 **body** | [**DatasinkTemplate**](DatasinkTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdatasinktemplaterequest"></a>
# **PutDatasinkTemplateRequest**
> void PutDatasinkTemplateRequest (string projectId, string templateId, DatasinkTemplate body = null)



Update datasink template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutDatasinkTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new DatasinkApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new DatasinkTemplate(); // DatasinkTemplate | The request body (optional) 

            try
            {
                apiInstance.PutDatasinkTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DatasinkApi.PutDatasinkTemplateRequest: " + e.Message );
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
 **body** | [**DatasinkTemplate**](DatasinkTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

