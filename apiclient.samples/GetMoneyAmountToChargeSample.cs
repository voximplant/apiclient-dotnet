using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetMoneyAmountToChargeSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetMoneyAmountToChargeSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetMoneyAmountToCharge()
        {
            // Get the recommended money amount to charge in USD.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetMoneyAmountToCharge(
                    currency: "USD"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}