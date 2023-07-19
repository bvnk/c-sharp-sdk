/*
 * BVNK API Endpoints
 *
 * The BVNK API is designed to facilitate seamless and secure transactions including payments, channels, anddigital wallet transactions.
 *
 * The version of the OpenAPI document: 1.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing Quote
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class QuoteTests
    {
        // TODO uncomment below to declare an instance variable for Quote
        //private Quote instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Quote
            //instance = new Quote();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Quote
        /// </summary>
        [Test]
        public void QuoteInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Quote
            //Assert.IsInstanceOf(typeof(Quote), instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Test]
        public void FromTest()
        {
            // TODO unit test for the property 'From'
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Test]
        public void ToTest()
        {
            // TODO unit test for the property 'To'
        }
        /// <summary>
        /// Test the property 'AmountIn'
        /// </summary>
        [Test]
        public void AmountInTest()
        {
            // TODO unit test for the property 'AmountIn'
        }
        /// <summary>
        /// Test the property 'AmountDue'
        /// </summary>
        [Test]
        public void AmountDueTest()
        {
            // TODO unit test for the property 'AmountDue'
        }
        /// <summary>
        /// Test the property 'AmountOut'
        /// </summary>
        [Test]
        public void AmountOutTest()
        {
            // TODO unit test for the property 'AmountOut'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Test]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'QuoteStatus'
        /// </summary>
        [Test]
        public void QuoteStatusTest()
        {
            // TODO unit test for the property 'QuoteStatus'
        }
        /// <summary>
        /// Test the property 'PaymentStatus'
        /// </summary>
        [Test]
        public void PaymentStatusTest()
        {
            // TODO unit test for the property 'PaymentStatus'
        }
        /// <summary>
        /// Test the property 'AcceptanceExpiryDate'
        /// </summary>
        [Test]
        public void AcceptanceExpiryDateTest()
        {
            // TODO unit test for the property 'AcceptanceExpiryDate'
        }
        /// <summary>
        /// Test the property 'AcceptanceDate'
        /// </summary>
        [Test]
        public void AcceptanceDateTest()
        {
            // TODO unit test for the property 'AcceptanceDate'
        }
        /// <summary>
        /// Test the property 'PaymentExpiryDate'
        /// </summary>
        [Test]
        public void PaymentExpiryDateTest()
        {
            // TODO unit test for the property 'PaymentExpiryDate'
        }
        /// <summary>
        /// Test the property 'PaymentReceiptDate'
        /// </summary>
        [Test]
        public void PaymentReceiptDateTest()
        {
            // TODO unit test for the property 'PaymentReceiptDate'
        }
        /// <summary>
        /// Test the property 'PayInLegs'
        /// </summary>
        [Test]
        public void PayInLegsTest()
        {
            // TODO unit test for the property 'PayInLegs'
        }
        /// <summary>
        /// Test the property 'PayInMethod'
        /// </summary>
        [Test]
        public void PayInMethodTest()
        {
            // TODO unit test for the property 'PayInMethod'
        }
        /// <summary>
        /// Test the property 'PayOutMethod'
        /// </summary>
        [Test]
        public void PayOutMethodTest()
        {
            // TODO unit test for the property 'PayOutMethod'
        }
        /// <summary>
        /// Test the property 'Uuid'
        /// </summary>
        [Test]
        public void UuidTest()
        {
            // TODO unit test for the property 'Uuid'
        }
        /// <summary>
        /// Test the property 'PayOutInstruction'
        /// </summary>
        [Test]
        public void PayOutInstructionTest()
        {
            // TODO unit test for the property 'PayOutInstruction'
        }
        /// <summary>
        /// Test the property 'PayInInstruction'
        /// </summary>
        [Test]
        public void PayInInstructionTest()
        {
            // TODO unit test for the property 'PayInInstruction'
        }
        /// <summary>
        /// Test the property 'UsePayInMethod'
        /// </summary>
        [Test]
        public void UsePayInMethodTest()
        {
            // TODO unit test for the property 'UsePayInMethod'
        }
        /// <summary>
        /// Test the property 'UsePayOutMethod'
        /// </summary>
        [Test]
        public void UsePayOutMethodTest()
        {
            // TODO unit test for the property 'UsePayOutMethod'
        }
        /// <summary>
        /// Test the property 'Fee'
        /// </summary>
        [Test]
        public void FeeTest()
        {
            // TODO unit test for the property 'Fee'
        }
        /// <summary>
        /// Test the property 'ProcessingFee'
        /// </summary>
        [Test]
        public void ProcessingFeeTest()
        {
            // TODO unit test for the property 'ProcessingFee'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'NetPrice'
        /// </summary>
        [Test]
        public void NetPriceTest()
        {
            // TODO unit test for the property 'NetPrice'
        }
        /// <summary>
        /// Test the property 'GrossPrice'
        /// </summary>
        [Test]
        public void GrossPriceTest()
        {
            // TODO unit test for the property 'GrossPrice'
        }
        /// <summary>
        /// Test the property 'AmountInGross'
        /// </summary>
        [Test]
        public void AmountInGrossTest()
        {
            // TODO unit test for the property 'AmountInGross'
        }
        /// <summary>
        /// Test the property 'AmountInNet'
        /// </summary>
        [Test]
        public void AmountInNetTest()
        {
            // TODO unit test for the property 'AmountInNet'
        }
        /// <summary>
        /// Test the property 'Fees'
        /// </summary>
        [Test]
        public void FeesTest()
        {
            // TODO unit test for the property 'Fees'
        }
        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO unit test for the property 'DateCreated'
        }
        /// <summary>
        /// Test the property 'LastUpdated'
        /// </summary>
        [Test]
        public void LastUpdatedTest()
        {
            // TODO unit test for the property 'LastUpdated'
        }

    }

}
