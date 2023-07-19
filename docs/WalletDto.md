
# Org.OpenAPITools.Model.WalletDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | The crypto wallet address | [optional] 
**Alternatives** | **List&lt;Object&gt;** | The array of alternative protocol addresses. | [optional] 
**ApproxAvailable** | **string** | The approximate amount availible in the wallet. | [optional] 
**ApproxBalance** | **string** | The balance amount availible of the wallet. | [optional] 
**Available** | **float** |  | [optional] 
**Balance** | **float** | The balance of the wallet. | [optional] 
**ConvertedAvailable** | **float** | The availible converted amount | [optional] 
**Currency** | [**CurrencyDto**](CurrencyDto.md) |  | [optional] 
**CustodianWallet** | **bool** | Is a custodian wallet. | [optional] 
**DepositFee** | **float** | The fee to deposit funds in wallet. | [optional] 
**Description** | **string** | The description of the wallet. | [optional] 
**Id** | **long** | The wallet ID. | [optional] 
**IsEmoney** | **bool** | Is E Money Wallet | [optional] [default to false]
**Lookup** | **string** | Is a lookup. | [optional] 
**Protocol** | **string** | The protocol of the wallet. | [optional] 
**SupportsDeposits** | **bool** | Is able to support deposits. | [optional] [default to true]
**SupportsThirdParty** | **bool** | Is a third party wallet. | [optional] [default to false]
**SupportsWithdrawals** | **bool** | Is able to support withdrawals. | [optional] [default to true]
**WithdrawalFee** | **float** | The fee to withdraw funds from wallet. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

