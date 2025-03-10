using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSubscriptionPriceSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetSubscriptionPriceSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetSubscriptionPrice()
        {
            // Get the all subscription template prices.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetSubscriptionPrice().Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}