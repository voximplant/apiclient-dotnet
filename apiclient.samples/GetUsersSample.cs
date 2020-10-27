using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetUsersSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetUsersSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetUsers()
        {
            // Get two first identities.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetUsers(
                    applicationId: 1L,
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}