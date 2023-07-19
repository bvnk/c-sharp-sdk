
# Org.OpenAPITools.Model.CurrencyFiatDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The currency code. | [optional] 
**DepositFee** | **decimal** | The % fee to deposit the currency. | [optional] 
**Fiat** | **bool** | Is a fiat currency. | [optional] [default to true]
**Icon** | **string** | The icon of the currency. | [optional] 
**Id** | **long** | The ID of the currency. | [optional] 
**Name** | **string** | The currency name. | [optional] 
**Options** | **Object** | The currency options. | [optional] 
**PricePrecision** | **int** | The precision of decimal points for the currency. | [optional] [default to 2]
**Protocols** | **List&lt;Object&gt;** | The alternative protocols array. | [optional] 
**QuantityPrecision** | **int** | The precision of decimal points for the currency displayed. | [optional] [default to 2]
**SupportsDeposits** | **bool** | Is deposits for this currency supported. | [optional] [default to true]
**SupportsWithdrawals** | **bool** | Is withdrawals for this currency supported | [optional] [default to true]
**WithdrawalFee** | **decimal** | The % fee to withdraw this currency. | [optional] 
**WithdrawalParameters** | **List&lt;Object&gt;** | The withdrawal parameter object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

