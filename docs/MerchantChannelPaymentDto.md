
# Org.OpenAPITools.Model.MerchantChannelPaymentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelId** | **string** | The ID of the channel. | [optional] 
**MerchantId** | **string** | The merchant ID linked to channel. | [optional] 
**MerchantDisplayName** | **string** | The display name fo the merchant. | [optional] 
**Reference** | **string** | The unique reference of the channel. | [optional] 
**DateCreated** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] [default to 0]
**LastUpdated** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] [default to 0]
**Status** | **string** | The status of the channel payment. | [optional] 
**Uuid** | **string** | The uuid fo the channel payment. | [optional] 
**Hash** | **string** | The transaction hash of the channel payment. | [optional] 
**Address** | **string** | The address of the channel. | [optional] 
**Tag** | **string** | The tag of the channel. | [optional] 
**PaidCurrency** | **string** | The currency of the payment. | [optional] 
**DisplayCurrency** | **string** | The display currency of the channel. | [optional] 
**WalletCurrency** | **string** | The currency of the wallet linked to the channel. | [optional] 
**FeeCurrency** | **string** | The currency of the fee taken. | [optional] 
**PaidAmount** | **decimal** | The amount paid to the channel. | [optional] [default to 0M]
**DisplayAmount** | **decimal** | The amount displayed of the channel payment. | [optional] [default to 0M]
**WalletAmount** | **decimal** | The amount converted to the wallet linked to the channel. | [optional] [default to 0M]
**FeeAmount** | **decimal** | The amount of the fee taken. | [optional] [default to 0M]
**ExchangeRate** | [**ExchangeRateDto**](ExchangeRateDto.md) |  | [optional] 
**DisplayRate** | [**ExchangeRateDto**](ExchangeRateDto.md) |  | [optional] 
**Risk** | [**ExchangeRateDto**](ExchangeRateDto.md) |  | [optional] 
**Sources** | **List&lt;string&gt;** | The address source of the payment. | [optional] 
**NetworkFee** | [**NetworkFeeDto**](NetworkFeeDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

