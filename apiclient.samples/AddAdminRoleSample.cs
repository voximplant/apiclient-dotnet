using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddAdminRoleSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddAdminRoleSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add a new admin role with the GetAccountInfo and GetCallHistory
        * permissions.
        */
        [Fact]
        public void AddAdminRole()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddAdminRole(new AddAdminRoleRequest 
                {
                    AdminRoleName = "read_only",
                    AllowedEntries = new Argument<string>(new[] {"GetAccountInfo", "GetCallHistory"}),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}