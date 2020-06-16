using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetKeyRolesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetKeyRolesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Set roles 1, 2, 3 for the key.
        */
        [Fact]
        public void SetKeyRoles()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetKeyRoles(new SetKeyRolesRequest 
                {
                    KeyId = "ab81c76e-573e-4046-9af9-105269dfafca",
                    RoleId = new Argument<long>(1L),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}