# IO.Swagger.Api.ScheduleScannerCronjobApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteScannerCronJobTemplateRequest**](ScheduleScannerCronjobApi.md#deletescannercronjobtemplaterequest) | **DELETE** /templates/{projectId}/schedule-scanner-cronjob/{templateId} | 
[**GetScannerCronJobTemplateRequest**](ScheduleScannerCronjobApi.md#getscannercronjobtemplaterequest) | **GET** /templates/{projectId}/schedule-scanner-cronjob/{templateId} | 
[**PostScannerCronJobTemplateRequest**](ScheduleScannerCronjobApi.md#postscannercronjobtemplaterequest) | **POST** /templates/{projectId}/schedule-scanner-cronjob/{templateId} | 
[**PutScannerCronJobTemplateRequest**](ScheduleScannerCronjobApi.md#putscannercronjobtemplaterequest) | **PUT** /templates/{projectId}/schedule-scanner-cronjob/{templateId} | 
[**ScheduleScannerCronjobRequest**](ScheduleScannerCronjobApi.md#schedulescannercronjobrequest) | **POST** /projects/{projectId}/schedule-scanner-cronjob | 


<a name="deletescannercronjobtemplaterequest"></a>
# **DeleteScannerCronJobTemplateRequest**
> void DeleteScannerCronJobTemplateRequest (string projectId, string templateId)



Delete schedule-scanner-cronjob template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteScannerCronJobTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleScannerCronjobApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteScannerCronJobTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleScannerCronjobApi.DeleteScannerCronJobTemplateRequest: " + e.Message );
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

<a name="getscannercronjobtemplaterequest"></a>
# **GetScannerCronJobTemplateRequest**
> void GetScannerCronJobTemplateRequest (string projectId, string templateId)



Get schedule-scanner-cronjob template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetScannerCronJobTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleScannerCronjobApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetScannerCronJobTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleScannerCronjobApi.GetScannerCronJobTemplateRequest: " + e.Message );
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

<a name="postscannercronjobtemplaterequest"></a>
# **PostScannerCronJobTemplateRequest**
> void PostScannerCronJobTemplateRequest (string projectId, string templateId, ScannerCronJobTemplate body = null)



Create schedule-scanner-cronjob template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostScannerCronJobTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleScannerCronjobApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new ScannerCronJobTemplate(); // ScannerCronJobTemplate | The request body (optional) 

            try
            {
                apiInstance.PostScannerCronJobTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleScannerCronjobApi.PostScannerCronJobTemplateRequest: " + e.Message );
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
 **body** | [**ScannerCronJobTemplate**](ScannerCronJobTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putscannercronjobtemplaterequest"></a>
# **PutScannerCronJobTemplateRequest**
> void PutScannerCronJobTemplateRequest (string projectId, string templateId, ScannerCronJobTemplate body = null)



Update schedule-scanner-cronjob template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutScannerCronJobTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleScannerCronjobApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new ScannerCronJobTemplate(); // ScannerCronJobTemplate | The request body (optional) 

            try
            {
                apiInstance.PutScannerCronJobTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleScannerCronjobApi.PutScannerCronJobTemplateRequest: " + e.Message );
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
 **body** | [**ScannerCronJobTemplate**](ScannerCronJobTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulescannercronjobrequest"></a>
# **ScheduleScannerCronjobRequest**
> ScannerCronJobResponse ScheduleScannerCronjobRequest (long? projectId, ScannerCronJobRequest body = null)



Schedule scanner cron-job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ScheduleScannerCronjobRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleScannerCronjobApi();
            var projectId = 789;  // long? | 
            var body = new ScannerCronJobRequest(); // ScannerCronJobRequest | The request body (optional) 

            try
            {
                ScannerCronJobResponse result = apiInstance.ScheduleScannerCronjobRequest(projectId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleScannerCronjobApi.ScheduleScannerCronjobRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **long?**|  | 
 **body** | [**ScannerCronJobRequest**](ScannerCronJobRequest.md)| The request body | [optional] 

### Return type

[**ScannerCronJobResponse**](ScannerCronJobResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

