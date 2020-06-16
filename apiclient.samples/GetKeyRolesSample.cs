using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetKeyRolesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetKeyRolesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get roles of the key.
        */
        [Fact]
        public void GetKeyRoles()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetKeyRoles(new GetKeyRolesRequest 
                {
                    KeyId = "ab81c50e-573e-4446-9af9-105269dfafca",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}