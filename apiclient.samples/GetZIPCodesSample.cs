using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetZIPCodesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetZIPCodesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetZIPCodes()
        {
            // Search for zip codes in Germany.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetZIPCodes(
                    "DE",
                    count: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}