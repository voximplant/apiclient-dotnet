using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class RemoveKeyRolesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public RemoveKeyRolesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Remove the roles 1, 2, 3 from the key.
        */
        [Fact]
        public void RemoveKeyRoles()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.RemoveKeyRoles(new RemoveKeyRolesRequest 
                {
                    KeyId = "ab81c90e-543e-4446-9af9-105269dfafca",
                    RoleId = new Argument<long>(1L),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}