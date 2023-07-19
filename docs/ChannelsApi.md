# Org.OpenAPITools.Api.ChannelsApi

All URIs are relative to *https://api.sandbox.bvnk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChannelCreate**](ChannelsApi.md#channelcreate) | **POST** /api/v2/channel | Create Channel
[**ChannelList**](ChannelsApi.md#channellist) | **GET** /api/v2/channel | List Channels
[**ChannelPaymentList**](ChannelsApi.md#channelpaymentlist) | **GET** /api/v2/channel/payment | List Channel Payments
[**ChannelPaymentRead**](ChannelsApi.md#channelpaymentread) | **GET** /api/v2/channel/payment/{uuid} | Get Channel Payment
[**ChannelRead**](ChannelsApi.md#channelread) | **GET** /api/v2/channel/{uuid} | Get Channel



## ChannelCreate

> MerchantChannelDto ChannelCreate (MerchantChannelRequestDto merchantChannelRequestDto = null)

Create Channel

Creates a channel that your end users can openly send payments to.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChannelCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var merchantChannelRequestDto = new MerchantChannelRequestDto(); // MerchantChannelRequestDto |  (optional) 

            try
            {
                // Create Channel
                MerchantChannelDto result = apiInstance.ChannelCreate(merchantChannelRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelCreate: " + e.Message );
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
 **merchantChannelRequestDto** | [**MerchantChannelRequestDto**](MerchantChannelRequestDto.md)|  | [optional] 

### Return type

[**MerchantChannelDto**](MerchantChannelDto.md)

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


## ChannelList

> List&lt;MerchantChannelDto&gt; ChannelList (string merchantId, string offset = null, string max = null, PaymentStatusDto? sort = null, string order = null)

List Channels

Retrieves all channels related to a Merchant ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChannelListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var merchantId = "\"c02153ae-8ac8-4222-80e8-b2b2af85bd78\"";  // string | The merchant ID that the channels belong to (default to "c02153ae-8ac8-4222-80e8-b2b2af85bd78")
            var offset = 0;  // string | Where to start fetching records. (optional) 
            var max = 10;  // string | Maximum number of items in response. (optional) 
            var sort = (PaymentStatusDto) "PENDING";  // PaymentStatusDto? | The attribute used to sort the data (optional) 
            var order = "asc";  // string | Ordering direction (optional) 

            try
            {
                // List Channels
                List<MerchantChannelDto> result = apiInstance.ChannelList(merchantId, offset, max, sort, order);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelList: " + e.Message );
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
 **merchantId** | **string**| The merchant ID that the channels belong to | [default to &quot;c02153ae-8ac8-4222-80e8-b2b2af85bd78&quot;]
 **offset** | **string**| Where to start fetching records. | [optional] 
 **max** | **string**| Maximum number of items in response. | [optional] 
 **sort** | **PaymentStatusDto?**| The attribute used to sort the data | [optional] 
 **order** | **string**| Ordering direction | [optional] 

### Return type

[**List&lt;MerchantChannelDto&gt;**](MerchantChannelDto.md)

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


## ChannelPaymentList

> List&lt;MerchantChannelPaymentDto&gt; ChannelPaymentList (string merchantId, string status = null, string fromDate = null, string toDate = null, string offset = null, string max = null, string order = null, string q = null)

List Channel Payments

Retrieves a list of payments to a channel on a specific Merchant ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChannelPaymentListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var merchantId = "\"c02153ae-8ac8-4222-80e8-b2b2af85bd78\"";  // string | The Merchant ID (default to "c02153ae-8ac8-4222-80e8-b2b2af85bd78")
            var status = COMPLETE;  // string |  (optional) 
            var fromDate = 2023-03-05;  // string | From which date to start searching. (optional) 
            var toDate = 2023-05-03;  // string | At which date to stop searching. (optional) 
            var offset = 0;  // string | Where to start fetching records. (optional) 
            var max = 10;  // string | Maximum number of items in response. (optional) 
            var order = asc;  // string | Ordering direction (optional) 
            var q = "q_example";  // string | Can be UUID of the payment, reference, channel UUID, transaction hash, or wallet code. (optional) 

            try
            {
                // List Channel Payments
                List<MerchantChannelPaymentDto> result = apiInstance.ChannelPaymentList(merchantId, status, fromDate, toDate, offset, max, order, q);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelPaymentList: " + e.Message );
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
 **merchantId** | **string**| The Merchant ID | [default to &quot;c02153ae-8ac8-4222-80e8-b2b2af85bd78&quot;]
 **status** | **string**|  | [optional] 
 **fromDate** | **string**| From which date to start searching. | [optional] 
 **toDate** | **string**| At which date to stop searching. | [optional] 
 **offset** | **string**| Where to start fetching records. | [optional] 
 **max** | **string**| Maximum number of items in response. | [optional] 
 **order** | **string**| Ordering direction | [optional] 
 **q** | **string**| Can be UUID of the payment, reference, channel UUID, transaction hash, or wallet code. | [optional] 

### Return type

[**List&lt;MerchantChannelPaymentDto&gt;**](MerchantChannelPaymentDto.md)

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


## ChannelPaymentRead

> MerchantChannelPaymentDto ChannelPaymentRead (string uuid)

Get Channel Payment

Retrieves a specific payment made into a channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChannelPaymentReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var uuid = "\"c0dc9c14-0312-4a6b-a1a3-a6dcebdcc8a4\"";  // string | The UUID of the payment you are querying. (default to "c0dc9c14-0312-4a6b-a1a3-a6dcebdcc8a4")

            try
            {
                // Get Channel Payment
                MerchantChannelPaymentDto result = apiInstance.ChannelPaymentRead(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelPaymentRead: " + e.Message );
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
 **uuid** | **string**| The UUID of the payment you are querying. | [default to &quot;c0dc9c14-0312-4a6b-a1a3-a6dcebdcc8a4&quot;]

### Return type

[**MerchantChannelPaymentDto**](MerchantChannelPaymentDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 200 |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ChannelRead

> MerchantChannelDto ChannelRead (string uuid)

Get Channel

Retrieves a specific channel by UUID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChannelReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChannelsApi(Configuration.Default);
            var uuid = "\"9d1f67f2-a647-404b-9b02-247c77be81d0\"";  // string | The UUID of the channel you are querying (default to "9d1f67f2-a647-404b-9b02-247c77be81d0")

            try
            {
                // Get Channel
                MerchantChannelDto result = apiInstance.ChannelRead(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelRead: " + e.Message );
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
 **uuid** | **string**| The UUID of the channel you are querying | [default to &quot;9d1f67f2-a647-404b-9b02-247c77be81d0&quot;]

### Return type

[**MerchantChannelDto**](MerchantChannelDto.md)

### Authorization

[Hawk](../README.md#Hawk)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

