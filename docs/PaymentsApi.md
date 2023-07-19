# Org.OpenAPITools.Api.PaymentsApi

All URIs are relative to *https://api.sandbox.bvnk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PaymentCreate**](PaymentsApi.md#paymentcreate) | **POST** /api/v1/pay/summary | Create payment
[**PaymentList**](PaymentsApi.md#paymentlist) | **GET** /api/v1/pay/summary | List Payments
[**PaymentOutValidate**](PaymentsApi.md#paymentoutvalidate) | **PUT** /api/v1/pay/validate | Validate Address
[**PaymentRead**](PaymentsApi.md#paymentread) | **GET** /api/v1/pay/{uuid}/summary | Get Payment



## PaymentCreate

> SummaryPaymentDto PaymentCreate (PayRequestDto payRequestDto)

Create payment

Creates a payment, either type IN or type OUT.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PaymentsApi(Configuration.Default);
            var payRequestDto = new PayRequestDto(); // PayRequestDto | 

            try
            {
                // Create payment
                SummaryPaymentDto result = apiInstance.PaymentCreate(payRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentCreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payRequestDto** | [**PayRequestDto**](PayRequestDto.md)|  | 

### Return type

[**SummaryPaymentDto**](SummaryPaymentDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PaymentList

> List&lt;SummaryPaymentDto&gt; PaymentList (string merchantId, string customerReference = null, string paymentExternalId = null, string fromDate = null, string toDate = null, decimal? offset = null, decimal? max = null, PaymentStatusDto? status = null, string order = null)

List Payments

Retrieves a list of payments on a specific Merchant ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PaymentsApi(Configuration.Default);
            var merchantId = "\"5C8D8D78-366A-4AFB-B658-A64CE543C5DB\"";  // string | The merchant ID as a UUID. (default to "5C8D8D78-366A-4AFB-B658-A64CE543C5DB")
            var customerReference = REF123;  // string | The customer reference. (optional) 
            var paymentExternalId = 5C8D8D78-366A-4AFB-B658-A64CE543C5DB;  // string | The merchant payment uuid. (optional) 
            var fromDate = 2023-03-30;  // string | The start date. (optional) 
            var toDate = 2023-03-30;  // string | The end date. (optional) 
            var offset = 0;  // decimal? | Where to start fetching records. (optional) 
            var max = 20;  // decimal? | Maximum number of items in response. (optional) 
            var status = (PaymentStatusDto) "PENDING";  // PaymentStatusDto? |  (optional) 
            var order = asc;  // string | Ordering direction. (optional) 

            try
            {
                // List Payments
                List<SummaryPaymentDto> result = apiInstance.PaymentList(merchantId, customerReference, paymentExternalId, fromDate, toDate, offset, max, status, order);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantId** | **string**| The merchant ID as a UUID. | [default to &quot;5C8D8D78-366A-4AFB-B658-A64CE543C5DB&quot;]
 **customerReference** | **string**| The customer reference. | [optional] 
 **paymentExternalId** | **string**| The merchant payment uuid. | [optional] 
 **fromDate** | **string**| The start date. | [optional] 
 **toDate** | **string**| The end date. | [optional] 
 **offset** | **decimal?**| Where to start fetching records. | [optional] 
 **max** | **decimal?**| Maximum number of items in response. | [optional] 
 **status** | **PaymentStatusDto?**|  | [optional] 
 **order** | **string**| Ordering direction. | [optional] 

### Return type

[**List&lt;SummaryPaymentDto&gt;**](SummaryPaymentDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PaymentOutValidate

> void PaymentOutValidate (PayOutDetailDto payOutDetailDto)

Validate Address

Validates that a crypto address is correct.  Use this endpoint to validate that an address exists, is correctly formatted, and includes all the required data. This endpoint can help prevent your end users losing funds when submitting a payout.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentOutValidateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            var apiInstance = new PaymentsApi(Configuration.Default);
            var payOutDetailDto = new PayOutDetailDto(); // PayOutDetailDto | 

            try
            {
                // Validate Address
                apiInstance.PaymentOutValidate(payOutDetailDto);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentOutValidate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payOutDetailDto** | [**PayOutDetailDto**](PayOutDetailDto.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PaymentRead

> SummaryPaymentDto PaymentRead (string uuid)

Get Payment

Retrieves details of a specific payment using the UUID of the payment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PaymentReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PaymentsApi(Configuration.Default);
            var uuid = "\"5C8D8D78-366A-4AFB-B658-A64CE543C5DB\"";  // string | The payment UUID. (default to "5C8D8D78-366A-4AFB-B658-A64CE543C5DB")

            try
            {
                // Get Payment
                SummaryPaymentDto result = apiInstance.PaymentRead(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PaymentsApi.PaymentRead: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The payment UUID. | [default to &quot;5C8D8D78-366A-4AFB-B658-A64CE543C5DB&quot;]

### Return type

[**SummaryPaymentDto**](SummaryPaymentDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

