# IO.Swagger.Api.FieldsApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFieldTypes**](FieldsApi.md#getfieldtypes) | **GET** /fieldTypes | 


<a name="getfieldtypes"></a>
# **GetFieldTypes**
> List<FieldTypes> GetFieldTypes ()



Get all available field types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFieldTypesExample
    {
        public void main()
        {
            var apiInstance = new FieldsApi();

            try
            {
                List&lt;FieldTypes&gt; result = apiInstance.GetFieldTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.GetFieldTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FieldTypes>**](FieldTypes.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

