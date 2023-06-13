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
    ///  Class for testing OrganizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrganizationsApiTests : IDisposable
    {
        private OrganizationsApi instance;

        public OrganizationsApiTests()
        {
            instance = new OrganizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrganizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrganizationsApi
            //Assert.IsType<OrganizationsApi>(instance);
        }

        /// <summary>
        /// Test AddOrganizationUsers
        /// </summary>
        [Fact]
        public void AddOrganizationUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgCode = null;
            //AddOrganizationUsersRequest? addOrganizationUsersRequest = null;
            //var response = instance.AddOrganizationUsers(orgCode, addOrganizationUsersRequest);
            //Assert.IsType<AddOrganizationUsersResponse>(response);
        }

        /// <summary>
        /// Test CreateOrganization
        /// </summary>
        [Fact]
        public void CreateOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateOrganizationRequest? createOrganizationRequest = null;
            //var response = instance.CreateOrganization(createOrganizationRequest);
            //Assert.IsType<CreateOrganizationResponse>(response);
        }

        /// <summary>
        /// Test DeleteOrganizationFeatureFlagOverride
        /// </summary>
        [Fact]
        public void DeleteOrganizationFeatureFlagOverrideTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgCode = null;
            //string featureFlagKey = null;
            //var response = instance.DeleteOrganizationFeatureFlagOverride(orgCode, featureFlagKey);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test DeleteOrganizationFeatureFlagOverrides
        /// </summary>
        [Fact]
        public void DeleteOrganizationFeatureFlagOverridesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgCode = null;
            //var response = instance.DeleteOrganizationFeatureFlagOverrides(orgCode);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test GetOrganization
        /// </summary>
        [Fact]
        public void GetOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? code = null;
            //var response = instance.GetOrganization(code);
            //Assert.IsType<Organization>(response);
        }

        /// <summary>
        /// Test GetOrganizationUsers
        /// </summary>
        [Fact]
        public void GetOrganizationUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgCode = null;
            //string? sort = null;
            //int? pageSize = null;
            //string? nextToken = null;
            //string? permissions = null;
            //var response = instance.GetOrganizationUsers(orgCode, sort, pageSize, nextToken, permissions);
            //Assert.IsType<GetOrganizationsUsersResponse>(response);
        }

        /// <summary>
        /// Test GetOrganizations
        /// </summary>
        [Fact]
        public void GetOrganizationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? sort = null;
            //int? pageSize = null;
            //string? nextToken = null;
            //var response = instance.GetOrganizations(sort, pageSize, nextToken);
            //Assert.IsType<GetOrganizationsResponse>(response);
        }

        /// <summary>
        /// Test RemoveOrganizationUser
        /// </summary>
        [Fact]
        public void RemoveOrganizationUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgCode = null;
            //string userId = null;
            //var response = instance.RemoveOrganizationUser(orgCode, userId);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test UpdateOrganization
        /// </summary>
        [Fact]
        public void UpdateOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgCode = null;
            //UpdateOrganizationRequest? updateOrganizationRequest = null;
            //instance.UpdateOrganization(orgCode, updateOrganizationRequest);
        }

        /// <summary>
        /// Test UpdateOrganizationFeatureFlagOverride
        /// </summary>
        [Fact]
        public void UpdateOrganizationFeatureFlagOverrideTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgCode = null;
            //string featureFlagKey = null;
            //string value = null;
            //var response = instance.UpdateOrganizationFeatureFlagOverride(orgCode, featureFlagKey, value);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test UpdateOrganizationUsers
        /// </summary>
        [Fact]
        public void UpdateOrganizationUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgCode = null;
            //UpdateOrganizationUsersRequest? updateOrganizationUsersRequest = null;
            //var response = instance.UpdateOrganizationUsers(orgCode, updateOrganizationUsersRequest);
            //Assert.IsType<RemoveOrganizationUsersResponse>(response);
        }
    }
}
