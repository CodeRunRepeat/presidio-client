# IO.Swagger.Api.ScheduleStreamsJobApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStreamsJobTemplateRequest**](ScheduleStreamsJobApi.md#deletestreamsjobtemplaterequest) | **DELETE** /templates/{projectId}/schedule-streams-job/{templateId} | 
[**GetStreamsJobTemplateRequest**](ScheduleStreamsJobApi.md#getstreamsjobtemplaterequest) | **GET** /templates/{projectId}/schedule-streams-job/{templateId} | 
[**PostStreamsJobTemplateRequest**](ScheduleStreamsJobApi.md#poststreamsjobtemplaterequest) | **POST** /templates/{projectId}/schedule-streams-job/{templateId} | 
[**PutStreamsJobTemplateRequest**](ScheduleStreamsJobApi.md#putstreamsjobtemplaterequest) | **PUT** /templates/{projectId}/schedule-streams-job/{templateId} | 
[**ScheduleStreamsJobRequest**](ScheduleStreamsJobApi.md#schedulestreamsjobrequest) | **POST** /projects/{projectId}/schedule-streams-job | 


<a name="deletestreamsjobtemplaterequest"></a>
# **DeleteStreamsJobTemplateRequest**
> void DeleteStreamsJobTemplateRequest (string projectId, string templateId)



Delete schedule-streams-job template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStreamsJobTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleStreamsJobApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteStreamsJobTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleStreamsJobApi.DeleteStreamsJobTemplateRequest: " + e.Message );
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

<a name="getstreamsjobtemplaterequest"></a>
# **GetStreamsJobTemplateRequest**
> void GetStreamsJobTemplateRequest (string projectId, string templateId)



Get schedule-streams-job template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStreamsJobTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleStreamsJobApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetStreamsJobTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleStreamsJobApi.GetStreamsJobTemplateRequest: " + e.Message );
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

<a name="poststreamsjobtemplaterequest"></a>
# **PostStreamsJobTemplateRequest**
> void PostStreamsJobTemplateRequest (string projectId, string templateId, StreamsJobTemplate body = null)



Create schedule-streams-job template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostStreamsJobTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleStreamsJobApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new StreamsJobTemplate(); // StreamsJobTemplate | The request body (optional) 

            try
            {
                apiInstance.PostStreamsJobTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleStreamsJobApi.PostStreamsJobTemplateRequest: " + e.Message );
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
 **body** | [**StreamsJobTemplate**](StreamsJobTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstreamsjobtemplaterequest"></a>
# **PutStreamsJobTemplateRequest**
> void PutStreamsJobTemplateRequest (string projectId, string templateId, StreamsJobTemplate body = null)



Update schedule-streams-job template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutStreamsJobTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleStreamsJobApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new StreamsJobTemplate(); // StreamsJobTemplate | The request body (optional) 

            try
            {
                apiInstance.PutStreamsJobTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleStreamsJobApi.PutStreamsJobTemplateRequest: " + e.Message );
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
 **body** | [**StreamsJobTemplate**](StreamsJobTemplate.md)| The request body | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulestreamsjobrequest"></a>
# **ScheduleStreamsJobRequest**
> StreamsJobResponse ScheduleStreamsJobRequest (long? projectId, StreamsJobRequest body = null)



Schedule streams job

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ScheduleStreamsJobRequestExample
    {
        public void main()
        {
            var apiInstance = new ScheduleStreamsJobApi();
            var projectId = 789;  // long? | 
            var body = new StreamsJobRequest(); // StreamsJobRequest |  (optional) 

            try
            {
                StreamsJobResponse result = apiInstance.ScheduleStreamsJobRequest(projectId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleStreamsJobApi.ScheduleStreamsJobRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **long?**|  | 
 **body** | [**StreamsJobRequest**](StreamsJobRequest.md)|  | [optional] 

### Return type

[**StreamsJobResponse**](StreamsJobResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

