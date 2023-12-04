using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCountriesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetCountriesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetCountries()
        {
            // Get Germany.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetCountries(
                    countryCode: "DE"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}