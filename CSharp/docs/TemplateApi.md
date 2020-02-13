# IO.Swagger.Api.TemplateApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAnalyzeTemplateRequest**](TemplateApi.md#deleteanalyzetemplaterequest) | **DELETE** /templates/{projectId}/analyze/{templateId} | 
[**DeleteAnonymizeImageTemplateRequest**](TemplateApi.md#deleteanonymizeimagetemplaterequest) | **DELETE** /templates/{projectId}/anonymize-image/{templateId} | 
[**DeleteAnonymizeTemplateRequest**](TemplateApi.md#deleteanonymizetemplaterequest) | **DELETE** /templates/{projectId}/anonymize/{templateId} | 
[**DeleteDatasinkTemplateRequest**](TemplateApi.md#deletedatasinktemplaterequest) | **DELETE** /templates/{projectId}/datasink/{templateId} | 
[**DeleteScanTemplateRequest**](TemplateApi.md#deletescantemplaterequest) | **DELETE** /templates/{projectId}/scan/{templateId} | 
[**DeleteScannerCronJobTemplateRequest**](TemplateApi.md#deletescannercronjobtemplaterequest) | **DELETE** /templates/{projectId}/schedule-scanner-cronjob/{templateId} | 
[**DeleteStreamTemplateRequest**](TemplateApi.md#deletestreamtemplaterequest) | **DELETE** /templates/{projectId}/stream/{templateId} | 
[**DeleteStreamsJobTemplateRequest**](TemplateApi.md#deletestreamsjobtemplaterequest) | **DELETE** /templates/{projectId}/schedule-streams-job/{templateId} | 
[**GetAnalyzeTemplateRequest**](TemplateApi.md#getanalyzetemplaterequest) | **GET** /templates/{projectId}/analyze/{templateId} | 
[**GetAnonymizeImageTemplateRequest**](TemplateApi.md#getanonymizeimagetemplaterequest) | **GET** /templates/{projectId}/anonymize-image/{templateId} | 
[**GetAnonymizeTemplateRequest**](TemplateApi.md#getanonymizetemplaterequest) | **GET** /templates/{projectId}/anonymize/{templateId} | 
[**GetDatasinkTemplateRequest**](TemplateApi.md#getdatasinktemplaterequest) | **GET** /templates/{projectId}/datasink/{templateId} | 
[**GetScanTemplateRequest**](TemplateApi.md#getscantemplaterequest) | **GET** /templates/{projectId}/scan/{templateId} | 
[**GetScannerCronJobTemplateRequest**](TemplateApi.md#getscannercronjobtemplaterequest) | **GET** /templates/{projectId}/schedule-scanner-cronjob/{templateId} | 
[**GetStreamTemplateRequest**](TemplateApi.md#getstreamtemplaterequest) | **GET** /templates/{projectId}/stream/{templateId} | 
[**GetStreamsJobTemplateRequest**](TemplateApi.md#getstreamsjobtemplaterequest) | **GET** /templates/{projectId}/schedule-streams-job/{templateId} | 
[**PostAnalyzeTemplateRequest**](TemplateApi.md#postanalyzetemplaterequest) | **POST** /templates/{projectId}/analyze/{templateId} | 
[**PostAnonymizeImageTemplateRequest**](TemplateApi.md#postanonymizeimagetemplaterequest) | **POST** /templates/{projectId}/anonymize-image/{templateId} | 
[**PostAnonymizeTemplateRequest**](TemplateApi.md#postanonymizetemplaterequest) | **POST** /templates/{projectId}/anonymize/{templateId} | 
[**PostDatasinkTemplateRequest**](TemplateApi.md#postdatasinktemplaterequest) | **POST** /templates/{projectId}/datasink/{templateId} | 
[**PostScanTemplateRequest**](TemplateApi.md#postscantemplaterequest) | **POST** /templates/{projectId}/scan/{templateId} | 
[**PostScannerCronJobTemplateRequest**](TemplateApi.md#postscannercronjobtemplaterequest) | **POST** /templates/{projectId}/schedule-scanner-cronjob/{templateId} | 
[**PostStreamTemplateRequest**](TemplateApi.md#poststreamtemplaterequest) | **POST** /templates/{projectId}/stream/{templateId} | 
[**PostStreamsJobTemplateRequest**](TemplateApi.md#poststreamsjobtemplaterequest) | **POST** /templates/{projectId}/schedule-streams-job/{templateId} | 
[**PutAnalyzeTemplateRequest**](TemplateApi.md#putanalyzetemplaterequest) | **PUT** /templates/{projectId}/analyze/{templateId} | 
[**PutAnonymizeImageTemplateRequest**](TemplateApi.md#putanonymizeimagetemplaterequest) | **PUT** /templates/{projectId}/anonymize-image/{templateId} | 
[**PutAnonymizeTemplateRequest**](TemplateApi.md#putanonymizetemplaterequest) | **PUT** /templates/{projectId}/anonymize/{templateId} | 
[**PutDatasinkTemplateRequest**](TemplateApi.md#putdatasinktemplaterequest) | **PUT** /templates/{projectId}/datasink/{templateId} | 
[**PutScanTemplateRequest**](TemplateApi.md#putscantemplaterequest) | **PUT** /templates/{projectId}/scan/{templateId} | 
[**PutScannerCronJobTemplateRequest**](TemplateApi.md#putscannercronjobtemplaterequest) | **PUT** /templates/{projectId}/schedule-scanner-cronjob/{templateId} | 
[**PutStreamTemplateRequest**](TemplateApi.md#putstreamtemplaterequest) | **PUT** /templates/{projectId}/stream/{templateId} | 
[**PutStreamsJobTemplateRequest**](TemplateApi.md#putstreamsjobtemplaterequest) | **PUT** /templates/{projectId}/schedule-streams-job/{templateId} | 


<a name="deleteanalyzetemplaterequest"></a>
# **DeleteAnalyzeTemplateRequest**
> void DeleteAnalyzeTemplateRequest (string projectId, string templateId)



Delete analyze template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAnalyzeTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteAnalyzeTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteAnalyzeTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteAnonymizeImageTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteAnonymizeImageTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteAnonymizeTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteAnonymizeTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteDatasinkTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteDatasinkTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteScanTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteScanTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteScannerCronJobTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteScannerCronJobTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteStreamTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteStreamTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteStreamsJobTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.DeleteStreamsJobTemplateRequest: " + e.Message );
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

<a name="getanalyzetemplaterequest"></a>
# **GetAnalyzeTemplateRequest**
> void GetAnalyzeTemplateRequest (string projectId, string templateId)



Get analyze template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAnalyzeTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetAnalyzeTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetAnalyzeTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetAnonymizeImageTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetAnonymizeImageTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetAnonymizeTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetAnonymizeTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetDatasinkTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetDatasinkTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetScanTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetScanTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetScannerCronJobTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetScannerCronJobTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetStreamTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetStreamTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetStreamsJobTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.GetStreamsJobTemplateRequest: " + e.Message );
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

<a name="postanalyzetemplaterequest"></a>
# **PostAnalyzeTemplateRequest**
> void PostAnalyzeTemplateRequest (string projectId, string templateId, AnalyzeTemplate body = null)



Create analyze template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAnalyzeTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnalyzeTemplate(); // AnalyzeTemplate | The request body (optional) 

            try
            {
                apiInstance.PostAnalyzeTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PostAnalyzeTemplateRequest: " + e.Message );
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
 **body** | [**AnalyzeTemplate**](AnalyzeTemplate.md)| The request body | [optional] 

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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnonymizeImageTemplate(); // AnonymizeImageTemplate | The request body (optional) 

            try
            {
                apiInstance.PostAnonymizeImageTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PostAnonymizeImageTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnonymizeTemplate(); // AnonymizeTemplate | The request body (optional) 

            try
            {
                apiInstance.PostAnonymizeTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PostAnonymizeTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new DatasinkTemplate(); // DatasinkTemplate | The request body (optional) 

            try
            {
                apiInstance.PostDatasinkTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PostDatasinkTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new ScanTemplate(); // ScanTemplate | The request body (optional) 

            try
            {
                apiInstance.PostScanTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PostScanTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new ScannerCronJobTemplate(); // ScannerCronJobTemplate | The request body (optional) 

            try
            {
                apiInstance.PostScannerCronJobTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PostScannerCronJobTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new StreamTemplate(); // StreamTemplate | The request body (optional) 

            try
            {
                apiInstance.PostStreamTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PostStreamTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new StreamsJobTemplate(); // StreamsJobTemplate | The request body (optional) 

            try
            {
                apiInstance.PostStreamsJobTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PostStreamsJobTemplateRequest: " + e.Message );
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

<a name="putanalyzetemplaterequest"></a>
# **PutAnalyzeTemplateRequest**
> void PutAnalyzeTemplateRequest (string projectId, string templateId, AnalyzeTemplate body = null)



Update analyze template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAnalyzeTemplateRequestExample
    {
        public void main()
        {
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnalyzeTemplate(); // AnalyzeTemplate | The request body (optional) 

            try
            {
                apiInstance.PutAnalyzeTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PutAnalyzeTemplateRequest: " + e.Message );
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
 **body** | [**AnalyzeTemplate**](AnalyzeTemplate.md)| The request body | [optional] 

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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnonymizeImageTemplate(); // AnonymizeImageTemplate | The request body (optional) 

            try
            {
                apiInstance.PutAnonymizeImageTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PutAnonymizeImageTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnonymizeTemplate(); // AnonymizeTemplate | The request body (optional) 

            try
            {
                apiInstance.PutAnonymizeTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PutAnonymizeTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new DatasinkTemplate(); // DatasinkTemplate | The request body (optional) 

            try
            {
                apiInstance.PutDatasinkTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PutDatasinkTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new ScanTemplate(); // ScanTemplate | The request body (optional) 

            try
            {
                apiInstance.PutScanTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PutScanTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new ScannerCronJobTemplate(); // ScannerCronJobTemplate | The request body (optional) 

            try
            {
                apiInstance.PutScannerCronJobTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PutScannerCronJobTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new StreamTemplate(); // StreamTemplate | The request body (optional) 

            try
            {
                apiInstance.PutStreamTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PutStreamTemplateRequest: " + e.Message );
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
            var apiInstance = new TemplateApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new StreamsJobTemplate(); // StreamsJobTemplate | The request body (optional) 

            try
            {
                apiInstance.PutStreamsJobTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateApi.PutStreamsJobTemplateRequest: " + e.Message );
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

