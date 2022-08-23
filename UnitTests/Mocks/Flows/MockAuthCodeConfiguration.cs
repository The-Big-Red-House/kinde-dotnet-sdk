﻿using Kinde.Authorization.Models.Configuration;

namespace UnitTests.Mocks.Flows
{
    internal class MockAuthCodeConfiguration : AuthorizationCodeConfiguration
    {
        public MockAuthCodeConfiguration() : base("123", "123", "123", "1111111111111111")
        {

        }
    }
}
