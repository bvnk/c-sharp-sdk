
# Org.OpenAPITools.Model.MerchantDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The ID of the Merchant ID. | [optional] 
**MerchantId** | **string** | The Merchant ID as a UUID. | [optional] 
**DisplayName** | **string** | The name of the merchant displayed on the payments page. | [optional] 
**Secret** | **string** | The secret key used to validate webhooks. | [optional] 
**WebhookUrl** | **string** | The webhooks URL that webhoosk are sent to. | [optional] 
**AutoConvertInvalidPayments** | **bool** | Is set to auto convert invalid payments. | [optional] [default to true]
**DefaultExpiryMinutes** | **int** | The default number of minutes before a payment expires for this Merchant ID. | [optional] 
**WebhookVersion** | **int** | The version of webhooks sent. | [optional] 
**Wallet** | [**WalletDto**](WalletDto.md) |  | [optional] 
**EmailRecipients** | **string** | The recipients of event emails. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

