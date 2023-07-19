/*
 * BVNK API Endpoints
 *
 * The BVNK API is designed to facilitate seamless and secure transactions including payments, channels, anddigital wallet transactions.
 *
 * The version of the OpenAPI document: 1.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing ChannelsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChannelsApiTests
    {
        private ChannelsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChannelsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChannelsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ChannelsApi
            //Assert.IsInstanceOf(typeof(ChannelsApi), instance);
        }

        
        /// <summary>
        /// Test ApiV2ChannelGet
        /// </summary>
        [Test]
        public void ApiV2ChannelGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string merchantId = null;
            //string offset = null;
            //string max = null;
            //PaymentStatusDto? sort = null;
            //string order = null;
            //var response = instance.ApiV2ChannelGet(merchantId, offset, max, sort, order);
            //Assert.IsInstanceOf(typeof(List<MerchantChannel>), response, "response is List<MerchantChannel>");
        }
        
        /// <summary>
        /// Test ApiV2ChannelPaymentGet
        /// </summary>
        [Test]
        public void ApiV2ChannelPaymentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string merchantId = null;
            //string status = null;
            //string fromDate = null;
            //string toDate = null;
            //string offset = null;
            //string max = null;
            //string order = null;
            //string q = null;
            //var response = instance.ApiV2ChannelPaymentGet(merchantId, status, fromDate, toDate, offset, max, order, q);
            //Assert.IsInstanceOf(typeof(List<MerchantChannelPayment>), response, "response is List<MerchantChannelPayment>");
        }
        
        /// <summary>
        /// Test ApiV2ChannelPaymentUuidGet
        /// </summary>
        [Test]
        public void ApiV2ChannelPaymentUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.ApiV2ChannelPaymentUuidGet(uuid);
            //Assert.IsInstanceOf(typeof(MerchantChannelPayment), response, "response is MerchantChannelPayment");
        }
        
        /// <summary>
        /// Test ApiV2ChannelPost
        /// </summary>
        [Test]
        public void ApiV2ChannelPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MerchantChannelRequest merchantChannelRequest = null;
            //var response = instance.ApiV2ChannelPost(merchantChannelRequest);
            //Assert.IsInstanceOf(typeof(MerchantChannel), response, "response is MerchantChannel");
        }
        
        /// <summary>
        /// Test ApiV2ChannelUuidGet
        /// </summary>
        [Test]
        public void ApiV2ChannelUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uuid = null;
            //var response = instance.ApiV2ChannelUuidGet(uuid);
            //Assert.IsInstanceOf(typeof(MerchantChannel), response, "response is MerchantChannel");
        }
        
    }

}
