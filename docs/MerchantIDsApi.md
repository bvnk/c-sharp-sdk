# Org.OpenAPITools.Api.MerchantIDsApi

All URIs are relative to *https://api.sandbox.bvnk.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MerchantIdCreate**](MerchantIDsApi.md#merchantidcreate) | **POST** /api/v1/merchant | Create Merchant ID
[**MerchantIdList**](MerchantIDsApi.md#merchantidlist) | **GET** /api/v1/merchant | List Merchant IDs



## MerchantIdCreate

> MerchantDto MerchantIdCreate (MerchantIdCreateRequest merchantIdCreateRequest = null)

Create Merchant ID

Generate a Merchant ID for your account to process pay-ins and pay-outs through our API.  A Merchant ID is essential as it designates the account wallet where incoming pay-ins will be settled. For instance, if a Merchant ID is associated with a EUR wallet ID, any incoming USDT payment will be automatically converted to EUR and deposited in the designated EUR wallet.  Vice versa, any outgoing USDT payment will be automatically converted and withdrawn from the designated EUR wallet.  For further information, please visit https://docs.bvnk.com/docs/creating-your-first-merchant to learn more about creating your first Merchant ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MerchantIdCreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MerchantIDsApi(Configuration.Default);
            var merchantIdCreateRequest = new MerchantIdCreateRequest(); // MerchantIdCreateRequest |  (optional) 

            try
            {
                // Create Merchant ID
                MerchantDto result = apiInstance.MerchantIdCreate(merchantIdCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MerchantIDsApi.MerchantIdCreate: " + e.Message );
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
 **merchantIdCreateRequest** | [**MerchantIdCreateRequest**](MerchantIdCreateRequest.md)|  | [optional] 

### Return type

[**MerchantDto**](MerchantDto.md)

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


## MerchantIdList

> List&lt;MerchantDto&gt; MerchantIdList ()

List Merchant IDs

Retrieves merchant IDs setup on your account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MerchantIdListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.sandbox.bvnk.com";
            // Configure API key authorization: Hawk
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MerchantIDsApi(Configuration.Default);

            try
            {
                // List Merchant IDs
                List<MerchantDto> result = apiInstance.MerchantIdList();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MerchantIDsApi.MerchantIdList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;MerchantDto&gt;**](MerchantDto.md)

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

