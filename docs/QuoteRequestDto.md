
# Org.OpenAPITools.Model.QuoteRequestDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | The currency to convert from. | [default to "EUR"]
**To** | **string** | The currency to convert to. | [default to "USDC"]
**FromWallet** | **decimal** | The ID of the wallet converted from. | [default to 3598236M]
**UseMinimum** | **bool** | Is converting the minimum allowed amount. | [default to false]
**UseMaximum** | **bool** | Is converting the max amount of the wallet. | [default to false]
**ToWallet** | **decimal** | The ID of the wallet converted to. | [default to 3598514M]
**AmountIn** | **decimal** | The amount being converted. | [default to 10M]
**PayInMethod** | **string** | The type of method in. | [default to "wallet"]
**PayOutMethod** | **string** | The type of method out. | [default to "wallet"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

