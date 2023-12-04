using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ChargeAccountSample
    {
        private ITestOutputHelper Console { get; }
        
        public ChargeAccountSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void ChargeAccount()
        {
            // Charge the frozen phone number: 79993330011.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.ChargeAccount(
                    phoneNumber: "79993330011"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}