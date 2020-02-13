# IO.Swagger.Api.AnalyzeApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnalyzeRequest**](AnalyzeApi.md#analyzerequest) | **POST** /projects/{projectId}/analyze | 
[**DeleteAnalyzeTemplateRequest**](AnalyzeApi.md#deleteanalyzetemplaterequest) | **DELETE** /templates/{projectId}/analyze/{templateId} | 
[**GetAllRecognizersRequest**](AnalyzeApi.md#getallrecognizersrequest) | **GET** /analyzer/recognizers/ | 
[**GetAnalyzeTemplateRequest**](AnalyzeApi.md#getanalyzetemplaterequest) | **GET** /templates/{projectId}/analyze/{templateId} | 
[**GetRecognizerRequest**](AnalyzeApi.md#getrecognizerrequest) | **GET** /analyzer/recognizers/{id} | 
[**InsertRecognizerRequest**](AnalyzeApi.md#insertrecognizerrequest) | **POST** /analyzer/recognizers/{id} | 
[**PostAnalyzeTemplateRequest**](AnalyzeApi.md#postanalyzetemplaterequest) | **POST** /templates/{projectId}/analyze/{templateId} | 
[**PutAnalyzeTemplateRequest**](AnalyzeApi.md#putanalyzetemplaterequest) | **PUT** /templates/{projectId}/analyze/{templateId} | 


<a name="analyzerequest"></a>
# **AnalyzeRequest**
> List<AnalyzeResult> AnalyzeRequest (long? projectId, AnalyzeRequest body = null)



Analyze text

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AnalyzeRequestExample
    {
        public void main()
        {
            var apiInstance = new AnalyzeApi();
            var projectId = 789;  // long? | 
            var body = new AnalyzeRequest(); // AnalyzeRequest | The request body (optional) 

            try
            {
                List&lt;AnalyzeResult&gt; result = apiInstance.AnalyzeRequest(projectId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.AnalyzeRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **long?**|  | 
 **body** | [**AnalyzeRequest**](AnalyzeRequest.md)| The request body | [optional] 

### Return type

[**List<AnalyzeResult>**](AnalyzeResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var apiInstance = new AnalyzeApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.DeleteAnalyzeTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.DeleteAnalyzeTemplateRequest: " + e.Message );
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

<a name="getallrecognizersrequest"></a>
# **GetAllRecognizersRequest**
> List<RecognizersGetResponse> GetAllRecognizersRequest ()



Get all recognizers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllRecognizersRequestExample
    {
        public void main()
        {
            var apiInstance = new AnalyzeApi();

            try
            {
                List&lt;RecognizersGetResponse&gt; result = apiInstance.GetAllRecognizersRequest();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.GetAllRecognizersRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RecognizersGetResponse>**](RecognizersGetResponse.md)

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
            var apiInstance = new AnalyzeApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 

            try
            {
                apiInstance.GetAnalyzeTemplateRequest(projectId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.GetAnalyzeTemplateRequest: " + e.Message );
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

<a name="getrecognizerrequest"></a>
# **GetRecognizerRequest**
> RecognizersGetResponse GetRecognizerRequest (string id)



Get an existing recognizer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRecognizerRequestExample
    {
        public void main()
        {
            var apiInstance = new AnalyzeApi();
            var id = id_example;  // string | Recognizer name

            try
            {
                RecognizersGetResponse result = apiInstance.GetRecognizerRequest(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.GetRecognizerRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Recognizer name | 

### Return type

[**RecognizersGetResponse**](RecognizersGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="insertrecognizerrequest"></a>
# **InsertRecognizerRequest**
> void InsertRecognizerRequest (string id, RecognizerInsertOrUpdateRequest body = null)



Insert a new recognizer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InsertRecognizerRequestExample
    {
        public void main()
        {
            var apiInstance = new AnalyzeApi();
            var id = id_example;  // string | Recognizer name
            var body = new RecognizerInsertOrUpdateRequest(); // RecognizerInsertOrUpdateRequest | Recognizer properties (optional) 

            try
            {
                apiInstance.InsertRecognizerRequest(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.InsertRecognizerRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Recognizer name | 
 **body** | [**RecognizerInsertOrUpdateRequest**](RecognizerInsertOrUpdateRequest.md)| Recognizer properties | [optional] 

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
            var apiInstance = new AnalyzeApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnalyzeTemplate(); // AnalyzeTemplate | The request body (optional) 

            try
            {
                apiInstance.PostAnalyzeTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.PostAnalyzeTemplateRequest: " + e.Message );
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
            var apiInstance = new AnalyzeApi();
            var projectId = projectId_example;  // string | 
            var templateId = templateId_example;  // string | 
            var body = new AnalyzeTemplate(); // AnalyzeTemplate | The request body (optional) 

            try
            {
                apiInstance.PutAnalyzeTemplateRequest(projectId, templateId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeApi.PutAnalyzeTemplateRequest: " + e.Message );
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

