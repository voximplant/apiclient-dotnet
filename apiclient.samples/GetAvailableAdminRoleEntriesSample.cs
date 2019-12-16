using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAvailableAdminRoleEntriesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetAvailableAdminRoleEntriesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the all available admin role entries.
        */
        [Fact]
        public void GetAvailableAdminRoleEntries()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetAvailableAdminRoleEntries(new GetAvailableAdminRoleEntriesRequest 
                {
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}