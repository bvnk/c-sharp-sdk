
# Org.OpenAPITools.Model.SummaryPaymentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | The unique identifier for the merchant payment. | [optional] 
**MerchantDisplayName** | **string** | The display name for the merchant payment. | [optional] 
**MerchantId** | **string** | The Merchant ID. You can find it on the Merchant Details page in your account. | [optional] 
**DateCreated** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 
**ExpiryDate** | **long** | The date and time, encoded into UNIX epoch timestamps | [optional] 
**QuoteExpiryDate** | **long** | The date and time, encoded into UNIX epoch timestamps | [optional] 
**AcceptanceExpiryDate** | **long** | The date and time, encoded into UNIX epoch timestamps | [optional] 
**QuoteStatus** | **string** |  | [optional] 
**Reference** | **string** | The custom payment reference ID to tie the payment to your customer. | [optional] 
**Type** | **DirectionDto** |  | [optional] 
**SubType** | **string** | The payment sub type | [optional] [default to SubTypeEnum.MerchantPayIn]
**Status** | **PaymentStatusDto** |  | [optional] 
**DisplayCurrency** | [**PayAmountsDto**](PayAmountsDto.md) |  | [optional] 
**WalletCurrency** | [**PayAmountsDto**](PayAmountsDto.md) |  | [optional] 
**PaidCurrency** | [**PayAmountsDto**](PayAmountsDto.md) |  | [optional] 
**FeeCurrency** | [**PayAmountsDto**](PayAmountsDto.md) |  | [optional] 
**DisplayRate** | [**ExchangeRateDto**](ExchangeRateDto.md) |  | [optional] 
**ExchangeRate** | [**ExchangeRateDto**](ExchangeRateDto.md) |  | [optional] 
**Address** | [**CryptoAddressDto**](CryptoAddressDto.md) |  | [optional] 
**ReturnUrl** | **string** | The URL that the customer will be redirected to if they click &#39;Back to Merchant&#39; button on the payment web page. | [optional] 
**RedirectUrl** | **string** | The URL to the payment page that you redirect your customers to. | [optional] 
**Transactions** | [**List&lt;GatewayTransactionDto&gt;**](GatewayTransactionDto.md) |  | [optional] 
**Refund** | **Object** | The payment this object is a refund of. This should reference the pay in that this refund was created for. | [optional] 
**Refunds** | **List&lt;Object&gt;** | Refunds that have been requested for this payment. This should reference the refund payout for this pay in. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

