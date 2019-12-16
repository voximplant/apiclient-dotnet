using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddAdminUserSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddAdminUserSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add a new admin user.
        */
        [Fact]
        public void AddAdminUser()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddAdminUser(new AddAdminUserRequest 
                {
                    NewAdminUserName = "adm1",
                    AdminUserDisplayName = "adm1",
                    NewAdminUserPassword = "1234567",
                    AdminRoleId = "1",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}