using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddUserSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddUserSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add a new user.
        */
        [Fact]
        public void AddUser()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddUser(new AddUserRequest 
                {
                    UserName = "iden1",
                    UserDisplayName = "iden1",
                    UserPassword = "1234567",
                    ApplicationId = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}