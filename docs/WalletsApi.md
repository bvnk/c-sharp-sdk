# Org.OpenAPITools.Api.WalletsApi

All URIs are relative to *https://api.sandbox.bvnk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WalletBalanceList**](WalletsApi.md#walletbalancelist) | **GET** /api/wallet/balances | List Wallet Balances
[**WalletCreate**](WalletsApi.md#walletcreate) | **POST** /api/wallet | Create Wallet
[**WalletList**](WalletsApi.md#walletlist) | **GET** /api/wallet | List Wallets
[**WalletRead**](WalletsApi.md#walletread) | **GET** /api/wallet/{id} | Get Wallet
[**WalletTransactionReport**](WalletsApi.md#wallettransactionreport) | **GET** /api/transaction/report | Transactions Report



## WalletBalanceList

> List&lt;BalanceDto&gt; WalletBalanceList (string date = null)

List Wallet Balances

Retrieves the balances of your wallets on platform.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletBalanceListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WalletsApi(Configuration.Default);
            var date = 2020-03-17;  // string | Date at to retrieve balances. (optional) 

            try
            {
                // List Wallet Balances
                List<BalanceDto> result = apiInstance.WalletBalanceList(date);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.WalletBalanceList: " + e.Message );
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
 **date** | **string**| Date at to retrieve balances. | [optional] 

### Return type

[**List&lt;BalanceDto&gt;**](BalanceDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletCreate

> WalletDto WalletCreate (WalletRequestDto walletRequestDto = null)

Create Wallet

Creates a wallet on the BVNK platform.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WalletsApi(Configuration.Default);
            var walletRequestDto = new WalletRequestDto(); // WalletRequestDto |  (optional) 

            try
            {
                // Create Wallet
                WalletDto result = apiInstance.WalletCreate(walletRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.WalletCreate: " + e.Message );
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
 **walletRequestDto** | [**WalletRequestDto**](WalletRequestDto.md)|  | [optional] 

### Return type

[**WalletDto**](WalletDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **500** | Unexpected Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletList

> List&lt;WalletDto&gt; WalletList (int? offset = null, int? max = null)

List Wallets

Retrieves a list of wallets on your account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WalletsApi(Configuration.Default);
            var offset = 56;  // int? | Where to start fetching records. (optional) 
            var max = 10;  // int? | Maximum number of items in response. (optional)  (default to 10)

            try
            {
                // List Wallets
                List<WalletDto> result = apiInstance.WalletList(offset, max);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.WalletList: " + e.Message );
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
 **offset** | **int?**| Where to start fetching records. | [optional] 
 **max** | **int?**| Maximum number of items in response. | [optional] [default to 10]

### Return type

[**List&lt;WalletDto&gt;**](WalletDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletRead

> WalletDto WalletRead (long id)

Get Wallet

Retrieves a specific wallet.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WalletsApi(Configuration.Default);
            var id = 255861L;  // long | The ID of the wallet that you want to retrieve. (default to 255861)

            try
            {
                // Get Wallet
                WalletDto result = apiInstance.WalletRead(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.WalletRead: " + e.Message );
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
 **id** | **long**| The ID of the wallet that you want to retrieve. | [default to 255861]

### Return type

[**WalletDto**](WalletDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WalletTransactionReport

> List&lt;TransactionReportDto&gt; WalletTransactionReport (long? walletId = null, string fromDate = null, string toDate = null, string format = null, string transactionType = null)

Transactions Report

Report all transactions from wallet in specified format. Report will be generated and sent to main account email in the specified format.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WalletTransactionReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WalletsApi(Configuration.Default);
            var walletId = 255861L;  // long? | Date at to retrieve balances. (optional)  (default to 255861)
            var fromDate = "\"2022-09-17\"";  // string | Export range from date in format 'YYYY-MM-dd'. (optional)  (default to "2022-09-17")
            var toDate = "\"2023-03-17\"";  // string | Export range to date in format 'YYYY-MM-dd'. (optional)  (default to "2023-03-17")
            var format = "\"csv\"";  // string | 'json' - json format, 'csv' - csv format (optional)  (default to "csv")
            var transactionType = "transactionType_example";  // string | Transaction type code (optional) 

            try
            {
                // Transactions Report
                List<TransactionReportDto> result = apiInstance.WalletTransactionReport(walletId, fromDate, toDate, format, transactionType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.WalletTransactionReport: " + e.Message );
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
 **walletId** | **long?**| Date at to retrieve balances. | [optional] [default to 255861]
 **fromDate** | **string**| Export range from date in format &#39;YYYY-MM-dd&#39;. | [optional] [default to &quot;2022-09-17&quot;]
 **toDate** | **string**| Export range to date in format &#39;YYYY-MM-dd&#39;. | [optional] [default to &quot;2023-03-17&quot;]
 **format** | **string**| &#39;json&#39; - json format, &#39;csv&#39; - csv format | [optional] [default to &quot;csv&quot;]
 **transactionType** | **string**| Transaction type code | [optional] 

### Return type

[**List&lt;TransactionReportDto&gt;**](TransactionReportDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

