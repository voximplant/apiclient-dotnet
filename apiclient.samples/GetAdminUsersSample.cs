using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAdminUsersSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetAdminUsersSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetAdminUsers()
        {
            // Get two first admin users.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetAdminUsers(
                    withAccessEntries: true,
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}