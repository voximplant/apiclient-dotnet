using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCurrencyRateSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetCurrencyRateSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetCurrencyRate()
        {
            // Get the current currency rate: RUR/USD.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetCurrencyRate(
                    "RUR"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}