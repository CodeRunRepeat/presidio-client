# IO.Swagger.Model.DatasinkTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnalyzeDatasink** | [**List&lt;Datasink&gt;**](Datasink.md) | Datasink represents the configuration for storing the scanner output. Datasink can output both of the analyze and anonymize results and to multiple outputs Supported outputs are CloudStorage: AWS S3, Azure Blob storage, Google Storage Streams: Azure EventHub, Kafka Database: MySql, SqlLite3, MSSQL, PostgreSQL | [optional] 
**AnonymizeDatasink** | [**List&lt;Datasink&gt;**](Datasink.md) |  | [optional] 
**Description** | **string** | Template description | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

