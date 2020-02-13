# IO.Swagger.Api.ScanApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteScanTemplateRequest**](ScanApi.md#deletescantemplaterequest) | **DELETE** /templates/{projectId}/scan/{templateId} | 
[**GetScanTemplateRequest**](ScanApi.md#getscantemplaterequest) | **GET** /templates/{projectId}/scan/{templateId} | 
[**PostScanTemplateRequest**](ScanApi.md#postscantemplaterequest) | **POST** /templates/{projectId}/scan/{templateId} | 
[**PutScanTemplateRequest**](ScanApi.md#putscantemplaterequest) | **PUT** /templates/{projectId}/scan/{templateId} | 


<a name="deletescantemplaterequest"></a>
# **DeleteScanTemplateRequest**
> void DeleteScanTemplateRequest (string projectId, string templateId)



Delete scan template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteScanTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScanApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteScanTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanApi.DeleteScanTemplateRequest: " + e.Message );
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

<a name="getscantemplaterequest"></a>
# **GetScanTemplateRequest**
> void GetScanTemplateRequest (string projectId, string templateId)



Get scan template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetScanTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScanApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetScanTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanApi.GetScanTemplateRequest: " + e.Message );
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

<a name="postscantemplaterequest"></a>
# **PostScanTemplateRequest**
> void PostScanTemplateRequest (string projectId, string templateId, ScanTemplate body = null)



Create scan template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostScanTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScanApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new ScanTemplate(); // ScanTemplate | The request body (optional) 

            try
            {
                apiInstance.PostScanTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanApi.PostScanTemplateRequest: " + e.Message );
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
 **body** | [**ScanTemplate**](ScanTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putscantemplaterequest"></a>
# **PutScanTemplateRequest**
> void PutScanTemplateRequest (string projectId, string templateId, ScanTemplate body = null)



Update scan template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutScanTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScanApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new ScanTemplate(); // ScanTemplate | The request body (optional) 

            try
            {
                apiInstance.PutScanTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanApi.PutScanTemplateRequest: " + e.Message );
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
 **body** | [**ScanTemplate**](ScanTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

