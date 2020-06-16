using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelAdminUserSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DelAdminUserSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Delete the admin user.
        */
        [Fact]
        public void DelAdminUser()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DelAdminUser(new DelAdminUserRequest 
                {
                    RequiredAdminUserId = new Argument<long>(1L),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}