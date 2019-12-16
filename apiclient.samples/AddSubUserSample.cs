using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddSubUserSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddSubUserSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Create a new subuser for account_id = 1
        */
        [Fact]
        public void AddSubUser()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddSubUser(new AddSubUserRequest 
                {
                    NewSubuserName = "test_login",
                    NewSubuserPassword = "test_pass",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}