using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAvailableRegulationsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetAvailableRegulationsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetAvailableRegulations()
        {
            // Search available regulation address.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetAvailableRegulations(
                    "DE",
                    "GEOGRAPHIC",
                    phoneRegionCode: "643"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}