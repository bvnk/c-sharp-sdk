
# Org.OpenAPITools.Model.GatewayTransactionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateCreated** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 
**DateConfirmed** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 
**Hash** | **string** | Transaction hash. | [optional] 
**Amount** | **decimal** | The payment amount. | [optional] 
**Risk** | **Object** |  | [optional] 
**NetworkFeeCurrency** | **string** | The currency acronym. | [optional] 
**NetworkFeeAmount** | **decimal** | The network fee amount. | [optional] 
**Sources** | **List&lt;string&gt;** | The list of source addresses, only applicable if payment in. | [optional] 
**DisplayRate** | [**ExchangeRateDto**](ExchangeRateDto.md) |  | [optional] 
**ExchangeRate** | [**ExchangeRateDto**](ExchangeRateDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

