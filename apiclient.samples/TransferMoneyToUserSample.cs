using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class TransferMoneyToUserSample
    {
        private ITestOutputHelper Console { get; }
        
        public TransferMoneyToUserSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void TransferMoneyToUser()
        {
            // Transfer 5.67 $ to the user 1 and transfer 5.67 $ to the user 2 too.
            // The account spends 2*5.67= 11.34 $ in total.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.TransferMoneyToUser(
                    5.67m,
                    userId: "1;2",
                    currency: "USD"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}