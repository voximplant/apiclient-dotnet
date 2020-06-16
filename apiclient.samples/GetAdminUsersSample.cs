using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAdminUsersSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetAdminUsersSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get two first admin users.
        */
        [Fact]
        public void GetAdminUsers()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetAdminUsers(new GetAdminUsersRequest 
                {
                    WithAccessEntries = true,
                    Count = 2,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}