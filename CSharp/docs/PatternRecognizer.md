# IO.Swagger.Model.PatternRecognizer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blacklist** | **List&lt;string&gt;** | A list of words that are considered PII and should always be detected e.g. [\&quot;Mr\&quot;, \&quot;Mrs\&quot;, \&quot;account\&quot;] | [optional] 
**ContextPhrases** | **List&lt;string&gt;** | A list of strings that if found in the surroundings of the entity, increase the score of the result e.g. [\&quot;name\&quot;, \&quot;address\&quot;, ] | [optional] 
**Entity** | **string** | The entity name which this recognizer can detect | [optional] 
**Language** | **string** | The supported language code, in ISO-639 format, https://en.wikipedia.org/wiki/ISO_639-1 | [optional] 
**Name** | **string** | The name of the recognizer, unique | [optional] 
**Patterns** | [**List&lt;Pattern&gt;**](Pattern.md) | List of supported patterns by this recognizer | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

