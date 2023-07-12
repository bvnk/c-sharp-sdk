# Org.OpenAPITools.Api.CurrenciesApi

All URIs are relative to *https://api.sandbox.bvnk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCurrenciesCrypto**](CurrenciesApi.md#listcurrenciescrypto) | **GET** /api/currency/crypto | List Crypto Currencies
[**ListCurrenciesDeposit**](CurrenciesApi.md#listcurrenciesdeposit) | **GET** /api/currency/deposit | List Wallet Currencies
[**ListCurrenciesFiat**](CurrenciesApi.md#listcurrenciesfiat) | **GET** /api/currency/fiat | List Fiat Currencies



## ListCurrenciesCrypto

> List&lt;CurrencyDto&gt; ListCurrenciesCrypto (decimal? offset = null, decimal? max = null, bool? allowDeposits = null)

List Crypto Currencies

Retrieves a list of all cryptocurrencies available on the BVNK platform. This list represents cryptocurrencies that end users can select whilst making a payment.  For sandbox, only Ethereum (ETH) is fully functional.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCurrenciesCryptoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            var apiInstance = new CurrenciesApi(Configuration.Default);
            var offset = 0MD;  // decimal? | Where to start fetching records. (optional)  (default to 0M)
            var max = 200MD;  // decimal? | Maximum number of items in response. (optional)  (default to 200M)
            var allowDeposits = false;  // bool? | Only list currencies that allow deposits. (optional)  (default to false)

            try
            {
                // List Crypto Currencies
                List<CurrencyDto> result = apiInstance.ListCurrenciesCrypto(offset, max, allowDeposits);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CurrenciesApi.ListCurrenciesCrypto: " + e.Message );
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
 **offset** | **decimal?**| Where to start fetching records. | [optional] [default to 0M]
 **max** | **decimal?**| Maximum number of items in response. | [optional] [default to 200M]
 **allowDeposits** | **bool?**| Only list currencies that allow deposits. | [optional] [default to false]

### Return type

[**List&lt;CurrencyDto&gt;**](CurrencyDto.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCurrenciesDeposit

> List&lt;CurrencyDto&gt; ListCurrenciesDeposit (decimal? offset = null, decimal? max = null)

List Wallet Currencies

These are the currencies that can be used to create a new wallet.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCurrenciesDepositExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            var apiInstance = new CurrenciesApi(Configuration.Default);
            var offset = 0MD;  // decimal? | Where to start fetching records. (optional)  (default to 0M)
            var max = 200MD;  // decimal? | Maximum number of items in response. (optional)  (default to 200M)

            try
            {
                // List Wallet Currencies
                List<CurrencyDto> result = apiInstance.ListCurrenciesDeposit(offset, max);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CurrenciesApi.ListCurrenciesDeposit: " + e.Message );
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
 **offset** | **decimal?**| Where to start fetching records. | [optional] [default to 0M]
 **max** | **decimal?**| Maximum number of items in response. | [optional] [default to 200M]

### Return type

[**List&lt;CurrencyDto&gt;**](CurrencyDto.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCurrenciesFiat

> List&lt;CurrencyFiatDto&gt; ListCurrenciesFiat (decimal? offset = null, decimal? max = null)

List Fiat Currencies

Retrieves a list of all display fiat currencies available on BVNK's Crypto Payments API. This list refers to currencies merchants can display on a payment page to an end user. It does not represent the list of currencies that can be held on the platform in wallets.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCurrenciesFiatExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            var apiInstance = new CurrenciesApi(Configuration.Default);
            var offset = 0MD;  // decimal? | Where to start fetching records. (optional)  (default to 0M)
            var max = 200MD;  // decimal? | Maximum number of items in response. (optional)  (default to 200M)

            try
            {
                // List Fiat Currencies
                List<CurrencyFiatDto> result = apiInstance.ListCurrenciesFiat(offset, max);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CurrenciesApi.ListCurrenciesFiat: " + e.Message );
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
 **offset** | **decimal?**| Where to start fetching records. | [optional] [default to 0M]
 **max** | **decimal?**| Maximum number of items in response. | [optional] [default to 200M]

### Return type

[**List&lt;CurrencyFiatDto&gt;**](CurrencyFiatDto.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

