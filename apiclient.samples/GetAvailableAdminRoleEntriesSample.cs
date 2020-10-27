using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAvailableAdminRoleEntriesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetAvailableAdminRoleEntriesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetAvailableAdminRoleEntries()
        {
            // Get the all available admin role entries.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetAvailableAdminRoleEntries().Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}