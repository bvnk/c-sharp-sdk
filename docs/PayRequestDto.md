
# Org.OpenAPITools.Model.PayRequestDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantId** | **string** | Your Merchant ID. You can find it on the Merchant Details page in your account. | [default to "5C8D8D78-366A-4AFB-B658-A64CE543C5DB"]
**Amount** | **decimal** | The payment amount. | [default to 223.05M]
**ExpiryMinutes** | **int** | The time period after which payment expires. | [optional] [default to 20]
**Currency** | **string** | The currency acronym. | [default to "EUR"]
**ReturnUrl** | **string** | The URL that the customer will be redirected to if they click &#39;Back to Merchant&#39; button on the payment web page. | [optional] [default to "https://my-shop.com/payment-complete?ref=xyz"]
**Reference** | **string** | The custom payment reference ID to tie the payment to your customer. | [default to "myUniqueRef333"]
**Type** | **DirectionDto** |  | 
**PayInDetails** | [**PayInDetailDto**](PayInDetailDto.md) |  | [optional] 
**PayOutDetails** | [**PayOutDetailDto**](PayOutDetailDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

