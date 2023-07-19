
# Org.OpenAPITools.Model.QuoteDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The ID of the quote. | [optional] 
**From** | **string** | The currency to convert from. | [optional] 
**To** | **string** | The currency to convert to. | [optional] 
**AmountIn** | **decimal** | The amount converted to. | [optional] 
**AmountDue** | **decimal** | The amount due to be converted. | [optional] 
**AmountOut** | **decimal** | The amount being converted out. | [optional] 
**Price** | **decimal** | The price quoted. | [optional] 
**QuoteStatus** | **string** | The status of the quote. | [optional] 
**PaymentStatus** | **string** | The payment status. | [optional] 
**AcceptanceExpiryDate** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 
**AcceptanceDate** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 
**PaymentExpiryDate** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 
**PaymentReceiptDate** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 
**PayInLegs** | [**List&lt;PaymentLegDto&gt;**](PaymentLegDto.md) |  | [optional] 
**PayInMethod** | [**PayInMethodDto**](PayInMethodDto.md) |  | [optional] 
**PayOutMethod** | [**PayOutMethodDto**](PayOutMethodDto.md) |  | [optional] 
**Uuid** | **string** | The UUID of the quote. | [optional] 
**PayOutInstruction** | [**PayOutInstructionDto**](PayOutInstructionDto.md) |  | [optional] 
**PayInInstruction** | [**PayInInstructionDto**](PayInInstructionDto.md) |  | [optional] 
**UsePayInMethod** | [**AccountMethodDto**](AccountMethodDto.md) |  | [optional] 
**UsePayOutMethod** | [**AccountMethodDto**](AccountMethodDto.md) |  | [optional] 
**Fee** | **decimal** | The fee for the quote. | [optional] 
**ProcessingFee** | **decimal** | The processing fee. | [optional] 
**Type** | **string** | The type of quote. | [optional] 
**NetPrice** | **decimal** | The net price fo the quote. | [optional] 
**GrossPrice** | **decimal** | The gross price of the quote. | [optional] 
**AmountInGross** | **decimal** | The price of the quote in gross. | [optional] 
**AmountInNet** | **decimal** | The price of the quote in net. | [optional] 
**Fees** | [**FeesDto**](FeesDto.md) |  | [optional] 
**DateCreated** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 
**LastUpdated** | **long** | The date and time, encoded into UNIX epoch timestamps. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

