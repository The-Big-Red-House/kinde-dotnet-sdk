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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Fact]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUserRequest? createUserRequest = null;
            //var response = instance.CreateUser(createUserRequest);
            //Assert.IsType<CreateUserResponse>(response);
        }

        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Fact]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? id = null;
            //var response = instance.DeleteUser(id);
            //Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test GetUserData
        /// </summary>
        [Fact]
        public void GetUserDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetUserData(id);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Fact]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? sort = null;
            //int? pageSize = null;
            //string? userId = null;
            //string? nextToken = null;
            //string? email = null;
            //var response = instance.GetUsers(sort, pageSize, userId, nextToken, email);
            //Assert.IsType<UsersResponse>(response);
        }

        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Fact]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateUserRequest updateUserRequest = null;
            //string? id = null;
            //var response = instance.UpdateUser(updateUserRequest, id);
            //Assert.IsType<User>(response);
        }
    }
}