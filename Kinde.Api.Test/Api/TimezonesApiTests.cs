/*
 * Kinde Management API
 *
 * Provides endpoints to manage your Kinde Businesses
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Kinde.Api.Client;
using Kinde.Api.Api;
// uncomment below to import models
//using Kinde.Api.Model;

namespace Kinde.Api.Test.Api
{
    /// <summary>
    ///  Class for testing TimezonesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TimezonesApiTests : IDisposable
    {
        private TimezonesApi instance;

        public TimezonesApiTests()
        {
            instance = new TimezonesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TimezonesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TimezonesApi
            //Assert.IsType<TimezonesApi>(instance);
        }

        /// <summary>
        /// Test GetTimezones
        /// </summary>
        [Fact]
        public void GetTimezonesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? timezoneKey = null;
            //string? name = null;
            //var response = instance.GetTimezones(timezoneKey, name);
            //Assert.IsType<SuccessResponse>(response);
        }
    }
}
