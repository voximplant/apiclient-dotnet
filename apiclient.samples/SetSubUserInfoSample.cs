using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetSubUserInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetSubUserInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Edit the password and description for the subuser with id = 12 from
        * account_id = 1
        */
        [Fact]
        public void SetSubUserInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetSubUserInfo(new SetSubUserInfoRequest 
                {
                    SubuserId = 12,
                    OldSubuserPassword = "old_test_password",
                    NewSubuserPassword = "test_pass",
                    Description = "test_desc",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}