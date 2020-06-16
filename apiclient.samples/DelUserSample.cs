using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelUserSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DelUserSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Delete all the users bound to the 'myapp1' application.
        */
        [Fact]
        public void DelUser()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DelUser(new DelUserRequest 
                {
                    UserId = new Argument<long>(),
                    ApplicationName = "myapp1",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}