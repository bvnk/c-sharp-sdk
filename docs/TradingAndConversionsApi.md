# Org.OpenAPITools.Api.TradingAndConversionsApi

All URIs are relative to *https://api.sandbox.bvnk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QuoteAccept**](TradingAndConversionsApi.md#quoteaccept) | **PUT** /api/v1/quote/accept/{uuid} | Accept Quote
[**QuoteCreate**](TradingAndConversionsApi.md#quotecreate) | **POST** /api/v1/quote | Create Quote
[**QuoteList**](TradingAndConversionsApi.md#quotelist) | **GET** /api/v1/quote/{merchantId} | List Quotes
[**QuoteRead**](TradingAndConversionsApi.md#quoteread) | **GET** /api/v1/quote/{uuid} | Get Quote



## QuoteAccept

> AcceptedQuoteDto QuoteAccept (string uuid)

Accept Quote

Executes a quote.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuoteAcceptExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradingAndConversionsApi(Configuration.Default);
            var uuid = "\"5dc4e061-31c6-4b96-8c4d-0ea984aece0b\"";  // string | The quote UUID you are accepting. (default to "5dc4e061-31c6-4b96-8c4d-0ea984aece0b")

            try
            {
                // Accept Quote
                AcceptedQuoteDto result = apiInstance.QuoteAccept(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradingAndConversionsApi.QuoteAccept: " + e.Message );
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
 **uuid** | **string**| The quote UUID you are accepting. | [default to &quot;5dc4e061-31c6-4b96-8c4d-0ea984aece0b&quot;]

### Return type

[**AcceptedQuoteDto**](AcceptedQuoteDto.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## QuoteCreate

> QuoteDto QuoteCreate (bool? estimate = null, QuoteRequestDto quoteRequestDto = null)

Create Quote

Creates a quote to convert between wallets.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuoteCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradingAndConversionsApi(Configuration.Default);
            var estimate = false;  // bool? | Create estimate quote (optional)  (default to false)
            var quoteRequestDto = new QuoteRequestDto(); // QuoteRequestDto |  (optional) 

            try
            {
                // Create Quote
                QuoteDto result = apiInstance.QuoteCreate(estimate, quoteRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradingAndConversionsApi.QuoteCreate: " + e.Message );
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
 **estimate** | **bool?**| Create estimate quote | [optional] [default to false]
 **quoteRequestDto** | [**QuoteRequestDto**](QuoteRequestDto.md)|  | [optional] 

### Return type

[**QuoteDto**](QuoteDto.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## QuoteList

> List&lt;QuoteDto&gt; QuoteList (string merchantId)

List Quotes

Retrieves all quotes on a specific Merchant ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuoteListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradingAndConversionsApi(Configuration.Default);
            var merchantId = "\"0a12a214-1619-43fa-9be1-0029f6a440a0\"";  // string | Merchant ID you are retrieving quotes from. (default to "0a12a214-1619-43fa-9be1-0029f6a440a0")

            try
            {
                // List Quotes
                List<QuoteDto> result = apiInstance.QuoteList(merchantId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradingAndConversionsApi.QuoteList: " + e.Message );
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
 **merchantId** | **string**| Merchant ID you are retrieving quotes from. | [default to &quot;0a12a214-1619-43fa-9be1-0029f6a440a0&quot;]

### Return type

[**List&lt;QuoteDto&gt;**](QuoteDto.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## QuoteRead

> QuoteDto QuoteRead (string uuid)

Get Quote

Retrieves a specific quote.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuoteReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradingAndConversionsApi(Configuration.Default);
            var uuid = "\"0a12a214-1619-43fa-9be1-0029f6a440a0\"";  // string | UUID of the quote you are retrieving. (default to "0a12a214-1619-43fa-9be1-0029f6a440a0")

            try
            {
                // Get Quote
                QuoteDto result = apiInstance.QuoteRead(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TradingAndConversionsApi.QuoteRead: " + e.Message );
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
 **uuid** | **string**| UUID of the quote you are retrieving. | [default to &quot;0a12a214-1619-43fa-9be1-0029f6a440a0&quot;]

### Return type

[**QuoteDto**](QuoteDto.md)

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
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

