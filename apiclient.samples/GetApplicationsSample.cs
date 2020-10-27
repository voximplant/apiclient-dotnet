using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetApplicationsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetApplicationsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetApplications()
        {
            // Get two applications, but skip the first one.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetApplications(
                    offset: 1L,
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}