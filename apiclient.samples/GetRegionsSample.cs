using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRegionsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetRegionsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetRegions()
        {
            // Get regions with city AACHEN.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetRegions(
                    "DE",
                    "GEOGRAPHIC",
                    cityName: "AACHEN"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}