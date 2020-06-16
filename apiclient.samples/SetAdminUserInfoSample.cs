using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetAdminUserInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetAdminUserInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Edit the admin user password.
        */
        [Fact]
        public void SetAdminUserInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetAdminUserInfo(new SetAdminUserInfoRequest 
                {
                    RequiredAdminUserId = 1,
                    NewAdminUserPassword = "7654321",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}