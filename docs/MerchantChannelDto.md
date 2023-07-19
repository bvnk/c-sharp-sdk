
# Org.OpenAPITools.Model.MerchantChannelDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The UUID of the channel. | [optional] [default to 0]
**DateCreated** | **int** | The date and time, encoded into UNIX epoch timestamps. | [optional] [default to 0]
**LastUpdated** | **int** | The date and time, encoded into UNIX epoch timestamps. | [optional] [default to 0]
**MerchantId** | **string** | The merchant ID linked to the channel. | [optional] 
**WalletCurrency** | **string** | The wallet currency of the channel. | [optional] 
**DisplayCurrency** | **string** | The display currency of the channel. | [optional] 
**PayCurrency** | **string** | The payed currency of the channel. | [optional] 
**Address** | **string** | The address of the channel | [optional] 
**Tag** | **string** | The tag for payments | [optional] 
**Protocol** | **string** | The protocol of the channel. | [optional] 
**Reference** | **string** | The custom reference for the channel payment. | [optional] 
**Status** | **string** | The status of the channel. | [optional] 
**Uuid** | **string** | The UUID of the channel. | [optional] 
**RedirectUrl** | **string** | The redirect URL to the channel payment page. | [optional] 
**Uri** | **string** | The URI of the address for QR code | [optional] 
**Alternatives** | [**List&lt;AlternativeAddressDto&gt;**](AlternativeAddressDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

